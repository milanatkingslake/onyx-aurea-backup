<%@LANGUAGE="VBSCRIPT" CODEPAGE="65001"%>
<%
option explicit
' Copyright Aptean 2017. All rights reserved.
response.CharSet = "utf-8"
response.buffer = false
on error resume next
session.abandon
err.clear
on error goto 0
Server.ScriptTimeOut = 20000
%>
<!--#include file="adovbs.inc"-->
<%

'Variable Declarations
dim blnPagePosted
dim gstrDBConnection, gstrOptOutText, gstrOptOutURL, gstrTimageURL, gintSiteID,gstrSMTPServer
dim gintRecipientCount
dim gArrayRecipientSampling(2)
dim objWarnings
dim strPostAction
dim i
dim gBlnSystemOptOut

'Warning Object contains warnings and errors that may occur.
set objWarnings = New warningObj

call LoadGlobalVariables(gstrDBConnection, gstrOptOutText, gstrOptOutURL, gstrTimageURL, gintSiteID,gstrSMTPServer)
if objWarnings.blnWarningsExist then
    call stopPageExecution()
end if
if len(trim(gstrOptOutURL)) = 0 then
    gBlnSystemOptOut = false
else
    gBlnSystemOptOut = true
end if

'Determine if Page is executing first time or being posted
if trim(request("PAGE_POSTED")) <> "" then
    blnPagePosted = True
else
    blnPagePosted = False
end if

if not blnPagePosted then
    call validateRequiredValues ("CLIENT_FORM")
    'Failure halts page execution
    if objWarnings.blnWarningsExist then
        call stopPageExecution()
    end if
    GetQueue
    'Failure halts page execution
    if objWarnings.blnWarningsExist then
        call stopPageExecution()
    end if
    call validateAndRetrieveQueue(gArrayRecipientSampling,gintRecipientCount)
    'Failure halts page execution
    if objWarnings.blnWarningsExist then
        call stopPageExecution()
    end if
    'Show Client Form with no validation warnings
    call startPageHTML()
    call clientForm()
    call endPageHTML()
else 'blnPagePosted = true
'   if Posted
'   Possible Cases: PREVIEW, PREVIEW_EMAIL, or SEND_MASS_EMAIL
    strPostAction = ucase(trim(request("POST_ACTION")))

    select case ucase(strPostAction)
        case "PREVIEW"
            call validateRequiredValues ("PREVIEW")
            'Failure displays error message.
            'This Action happens in a new window to preview the entire posting HTML
            if objWarnings.blnWarningsExist then
                call stopPageExecution()
            else
                response.write " - <a href=""#"" onClick=""window.close();"">Close Preview</a> - " & "<p>" & request("HTMLMessage")
            end if


        case "EMAIL_PREVIEW"
            call validateRequiredValues ("EMAIL_PREVIEW")
            if not objWarnings.blnWarningsExist then
                call doEmailPreview()
            end if
            call validateAndRetrieveQueue(gArrayRecipientSampling,gintRecipientCount)
            call startPageHTML()
            call clientForm()
            call endPageHTML()

        case "SEND_MASS_EMAIL"
            call validateRequiredValues ("SEMD_MASS_EMAIL")
            if not objWarnings.blnWarningsExist then
                call startPageHTML()
                call doMassEmail()
                call endPageHTML
            else
                call validateAndRetrieveQueue(gArrayRecipientSampling,gintRecipientCount)
                call startPageHTML()
                call clientForm()
                call endPageHTML
            end if
    end select
end if 'BlnPagePosted = true
set objWarnings = nothing
'END PAGE EXECUTION


'************************************************************************************************
'***********************SUB ROUTINES*************************************************************
'************************************************************************************************
private sub validateRequiredValues(byVal pFormToValidate)

    Select case ucase(pFormToValidate)
        case "CLIENT_FORM"
            if trim(request("gMailBatchID")) = "" then
                objWarnings.addWarning("No Mail Batch ID was passed into Client Form.")
            end if
        case "PREVIEW"
            if trim(request("HTMLMessage")) = "" then
                objWarnings.addWarning("No HTML Source was available to preview.")
            end if
        case "EMAIL_PREVIEW"
            if trim(request("HTMLMessage")) = "" then
                objWarnings.addWarning("No HTML Source was available to preview.")
            end if
            if trim(request("from")) = "" then
                objWarnings.addWarning("No 'From' address was designated.")
            else
                if not isValidFromEmail(trim(request("from"))) then
                    objWarnings.addWarning("Warning: From address is not in an acceptable format.")
                end if
            end if
            if trim(request("PreviewRecipients")) = "" then
                objWarnings.addWarning("No one was designated to be sent an email preview.")
            end if
        case "SEMD_MASS_EMAIL"
            if trim(request("gMailBatchID")) = "" then
                objWarnings.addWarning("The Mail Batch ID was lost. Please select bulk action in OEP again.")
            end if
            if trim(request("from")) = "" then
                objWarnings.addWarning("No 'From' address was designated.")
            else
                if not isValidFromEmail(trim(request("from"))) then
                    objWarnings.addWarning("From address is not in an acceptable format.")
                end if
            end if
            if not validateIDs(request("viewedTrackingID")) then
                objWarnings.addWarning("The 'Viewed Email' Tracking ID was invalid or empty.")
            end if
            if not validateIDs(request("viewedActionID")) then
                objWarnings.addWarning("The 'Viewed Email' Action ID was invalid or empty.")
            end if
            if gBlnSystemOptOut then
                if (not validateIDs(request("optoutTrackingID"))) or (trim(request("optOutTrackingId")) = "0") then
                    objWarnings.addWarning("The 'Opt Out' Tracking ID was invalid or empty.")
                end if
                if (not validateIDs(request("optOutActionID"))) or (trim(request("optOutActionID")) = "0") then
                    objWarnings.addWarning("The 'Opt Out' Action ID was invalid or empty.")
                end if
            end if
            if trim(request("HTMLMessage")) = "" then
                objWarnings.addWarning("No HTML Source was submitted.")
            end if
            if trim(request("OptOutText")) = "" then
                objWarnings.addWarning("No Opt-Out text was included.")
            end if
    end Select


end sub

private function validateIDs(pValidate)
    if trim(pValidate) = "" or not isnumeric(pValidate) then
        validateIDs = false
    else
        validateIDs = true
    end if
end function

Function isValidEmail(pEmail)
  dim regEx

  if isNull(pEmail) then
    isValidEmail = false
    exit function
  end if

  isValidEmail = True
  set regEx = New RegExp
  regEx.IgnoreCase = False
  regEx.Pattern = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
  isValidEmail = regEx.Test(pEmail)

End Function

Function isValidFromEmail(pEmail)
  dim regExPure
  dim regExFriendly

  if isNull(pEmail) then
    isValidFromEmail = false
    exit function
  end if

  isValidFromEmail = True
  set regExPure = New RegExp
  set regExFriendly = New RegExp

  regExPure.IgnoreCase = False
  regExFriendly.IgnoreCase = False

  regExPure.Pattern = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
  regExFriendly.Pattern = "^[a-zA-Z][\W\s\w][^<]*\s<[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]>$"
  if regExPure.Test(pEmail) or regExFriendly.Test(pEmail) then
    isValidFromEmail = true
  else
    isValidFromEmail = false
  end if

End Function

private sub stopPageExecution()
    call startPageHTML()
    for i = 0 to ubound(objWarnings.strWarnings)
        response.write "<span class=""Warning"">" & objWarnings.strWarnings(i) & "</span>"
    next
    call endPageHTML()
    set objWarnings = nothing
    response.end
end sub

private sub GetQueue()
    dim objConn
    dim objCmd
    dim strResults
    dim intReturnValue

    call connect(objConn)
    Set objCmd = Server.CreateObject("ADODB.Command")
    objCmd.CommandType = adCmdStoredProc
    objCmd.ActiveConnection = objConn
    objCmd.CommandText = "SDpcdEmailBatchExecute"
    objCmd.CommandTimeout = 120

    objCmd.Parameters.Append objCmd.CreateParameter("RETURN_VALUE", adInteger, adParamReturnValue)
    objCmd.Parameters.Append objCmd.CreateParameter("mass_email_batch_id", adGUID, adParamInput)

    objCmd("mass_email_batch_id") = "{" & trim(request("gMailBatchID")) & "}"

    objCmd.Execute

    'Output and Return values:
    intReturnValue = objCmd("RETURN_VALUE")

    if intReturnValue < 0 then
        objWarnings.addWarning("Unable to create queue for this Email Batch.")
    end if
end sub

private sub validateAndRetrieveQueue(byRef pArray, byRef pCount)
    dim objConn
    dim objCmd
    dim objRs
    dim strResults
    dim intReturnValue

    call connect(objConn)
    Set objCmd = Server.CreateObject("ADODB.Command")
    objCmd.CommandType = adCmdStoredProc
    objCmd.ActiveConnection = objConn
    objCmd.CommandText = "SDpcgValidateEmailQueue"
    objCmd.CommandTimeout = 120

    objCmd.Parameters.Append objCmd.CreateParameter("RETURN_VALUE", adInteger, adParamReturnValue)
    objCmd.Parameters.Append objCmd.CreateParameter("site_id", adInteger, adParamInput)
    objCmd.Parameters.Append objCmd.CreateParameter("mass_email_batch_id", adGUID, adParamInput)

    objCmd("site_id") = gintSiteID
    objCmd("mass_email_batch_id") = "{" & trim(request("gMailBatchID")) & "}"

    set objRs = objCmd.Execute 'or set recordset = objCmd.Execute

    'Output and Return values:
    intReturnValue = objCmd("RETURN_VALUE")


    if intReturnValue < 0 then
        pCount = 0
        objWarnings.addWarning("No records matched the batch Email ID passed into Client Form")
    else

        'Load, at most, first three names in list.
        if not objRs.eof then
                pCount = objRS("batchCount")
        else
                pCount = 0
        end if
        for i = 0 to uBound(pArray)
            if not objRs.eof then
                pArray(i) = objRs("first_name") & " " & objRs("last_name")
                objRs.movenext
            else
                pArray(i) = ""
            end if
        next

        objRs.close
    end if


    'Clean up:
    set objRs = nothing
    set objCmd.ActiveConnection = nothing
    set objCmd= nothing

    call disconnect(objConn)
end sub

sub doEmailPreview()
    on error resume next
    dim objMsg

    Set objMsg = Server.CreateObject("CDO.Message")
	objMsg.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/sendusing") = 1
	objMsg.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpserver") = gstrSMTPServer
	objMsg.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25
	objMsg.Configuration.Fields.Update

    objMsg.From = trim(request("from"))
    objMsg.Subject = trim(request("subject"))
    'objMsg.BodyFormat = 0
    'objMsg.MailFormat = 0
    objMsg.To = ""
    objMsg.Cc = ""
    objMsg.Bcc = trim(request("PreviewRecipients"))
	objMsg.AutoGenerateTextBody=false
    objMsg.HTMLBody = trim(request("HTMLMessage"))
	objMsg.HTMLBodyPart.Charset = "UTF-8"
    objMsg.HTMLBodyPart.ContentTransferEncoding = "quoted-printable"
    objMsg.Send
    set objMsg = nothing
    objWarnings.addWarning("Email Preview process complete.")
    if err.number <> 0 then
        objWarnings.addWarning ("An error occured when attempting to send Email Preview: " & err.description)
        err.clear
    end if


end sub

class warningObj

    public strWarnings()
    public blnWarningsExist

	Private Sub Class_Initialize
        blnWarningsExist = false
	End Sub

    public sub addWarning(pstrWarning)
        if blnWarningsExist then
            redim preserve strWarnings(ubound(strWarnings)+1)
            strWarnings(ubound(strWarnings)) = pstrWarning
        else
            redim strWarnings(0)
            strWarnings(0) = pstrWarning
            blnWarningsExist = true
        end if
    end sub
    public sub clearWarnings
        Erase strWarnings
        blnWarningsExist = false
    end sub

end class


private sub LoadGlobalVariables (byRef pstrDBConnection, byRef pstrOptOutText, byRef pstrOptOutURL, byRef pstrTimageURL, byRef pintSiteID,byref pstrSMTPServer)
    dim xmlConfig
    dim objErr

    pstrDBConnection = ""
    pstrOptOutText = ""
    pstrOptOutURL = ""
    pstrTimageURL = ""
    pstrSMTPServer = ""

    set xmlConfig = Server.CreateObject("Msxml2.DomDocument")
    xmlConfig.async="false"
    xmlConfig.setProperty "ServerHTTPRequest", true
    xmlConfig.load(Server.MapPath("AcceleratorClient.config"))

    Set objErr = xmlConfig.parseError
    If objErr.errorCode <>  0 Then
        objWarnings.addWarning("An error occured when loading the Configuration File. Reason: " & objErr.reason)
    else
        pstrDBConnection =  xmlConfig.getElementsByTagName("DatabaseConnectionString").item(0).text
        pstrOptOutText =  xmlConfig.getElementsByTagName("OptOutText").item(0).text
        pstrOptOutURL = xmlConfig.getElementsByTagName("OptOutURL").item(0).text
        pstrTimageURL = xmlConfig.getElementsByTagName("TimageURL").item(0).text
        pintSiteId = xmlConfig.getElementsByTagName("iSiteID").item(0).text
        pstrSMTPServer = xmlConfig.getElementsByTagName("SMTPServer").item(0).text
    End If
    set objErr = nothing
    set xmlConfig = nothing
end sub

private Sub connect(ByRef pcnnConnection)
	' Local variables
	Dim strConnectionString
	Dim strSQL

	' Create and open the connection
	Set pcnnConnection = Server.CreateObject("ADODB.Connection")
	pcnnConnection.Open gstrDBConnection

	' Set connection options
    strSQL = "SET NOCOUNT ON SET ANSI_NULLS ON SET ANSI_PADDING OFF SET ANSI_WARNINGS OFF SET QUOTED_IDENTIFIER OFF SET ANSI_NULL_DFLT_ON OFF SET CONCAT_NULL_YIELDS_NULL OFF SET IMPLICIT_TRANSACTIONS OFF"
    pcnnConnection.Execute strSQL, , adExecuteNoRecords

End Sub

private Sub disconnect(ByRef pcnnConnection)

	' Close out and kill the connection
	pcnnConnection.close
	Set pcnnConnection = Nothing

End Sub


private sub doMassEmail()
    dim strFrom, strSubject, strHTMLMessage, strOptOutText
    dim intViewedTrackingID, intViewedActionID, intOptOutTrackingID, intOptOutActionID, guidMailBatchID
    dim objCmd_Recipients
    dim objCmd_EmailData
    dim objCmd_UpdateQueue
    dim objCmd_ProcessedEmail
    dim objConn_Recipients
    dim objConn_EmailData
    dim objConn_UpdateQueue
    dim objConn_ProcessedEmail
    dim objRs_Recipients
    dim strEmailAddress, strFirstName, strLastName, strCompany, strViewEncoded, strOptOutEncoded
    dim objMsg
    dim strFinalMessage
    dim intRecipientCount
    dim intStatusStep,intStatusLength
    dim intLoopCount
    dim intSentCount

    strFrom = trim(request("from"))
    strSubject = trim(request("subject"))
    strHTMLMessage = trim(request("HTMLMessage"))
    intViewedTrackingID = trim(request("viewedTrackingID"))
    intViewedActionID = trim(request("viewedActionID"))
    if gBlnSystemOptOut then
        intOptOutTrackingID = trim(request("optOutTrackingID"))
        intOptOutActionID = trim(request("optOutActionID"))
    else
        intOptOutTrackingId = 0
        intOptOutActionId = 0
    end if
    strOptOutText = trim(request("optOutText"))
    guidMailBatchID = "{" & trim(request("gMailBatchID")) & "}"

    'Status Bar Setup
    intRecipientCount = clng(request("totalRecipients"))
    intStatusLength = 100 'total length of bar
    if intRecipientCount < intStatusLength then 'if less recipients than length of bar, we'll be MOD by 0. Step by each individual if less
        intStatusLength = intRecipientCount
    end if
    intStatusStep = intRecipientCount\intStatusLength 'Update Status bar each integer step of this calculation
    intLoopCount = 0 'counter for MODULAR math

    'REMOVE </body> tag and all HTML right of </body>. We will be appending Encrypted data tracking at the end of the email
    if instr(strHTMLMessage,"</body>") then
        strHTMLMessage = left(strHTMLMessage,instr(strHTMLMessage,"</body>")-1)
    end if
    if instr(strHTMLMessage,"</BODY>") then
       strHTMLMessage = left(strHTMLMessage,instr(strHTMLMessage,"</BODY>")-1)
    end if

    'connect to Database
    call connect(objConn_Recipients)
    call connect(objConn_EmailData)
    call connect(objConn_UpdateQueue)

    'CREATE LIST OF RECIPIENTS FROM QUEUE TABLE.
    'POPULATE objRS_Recipients
    Set objCmd_Recipients = Server.CreateObject("ADODB.Command")
    objCmd_Recipients.CommandType = adCmdStoredProc
    objCmd_Recipients.ActiveConnection = objConn_Recipients
    objCmd_Recipients.CommandText = "SDpcgGetEmailQueue"
    objCmd_Recipients.CommandTimeout = 120

    objCmd_Recipients.Parameters.Append objCmd_Recipients.CreateParameter("site_id", adInteger, adParamInput)
    objCmd_Recipients.Parameters.Append objCmd_Recipients.CreateParameter("mass_email_batch_id", adGUID, adParamInput)

    objCmd_Recipients("site_id") = gintSiteID
    objCmd_Recipients("mass_email_batch_id") = guidMailBatchID

    set objRs_Recipients = objCmd_Recipients.Execute

    if objRS_Recipients.eof or objRS_Recipients.bof then
        response.write "<span class=""warning"">There were no recipients to send to.</span>"
        call disconnect(objConn_Recipients)
        set objCmd_Recipients.ActiveConnection = nothing
        set objCmd_Recipients= nothing
        exit sub
    end if

    'CREATE COMMAND OBJECT THAT WILL BE CALLING DB AND ENCRYPTING AND RETRIEVING DATA
    Set objCmd_EmailData = Server.CreateObject("ADODB.Command")
    objCmd_EmailData.CommandType = adCmdStoredProc
    objCmd_EmailData.ActiveConnection = objConn_EmailData
    objCmd_EmailData.CommandText = "SDpcgEncryptEmailData"
    objCmd_EmailData.CommandTimeout = 120

    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("site_id", adInteger, adParamInput)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("individual_id", adGUID, adParamInput)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("view_tracking_code_did", adInteger, adParamInput)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("view_milestone_action_did", adInteger, adParamInput)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("opt_out_tracking_code_did", adInteger, adParamInput)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("opt_out_milestone_action_did", adInteger, adParamInput)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("view_encoded", adVarChar, adParamOutput, 100)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("optout_encoded", adVarWChar, adParamOutput, 100)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("email_address", adVarWChar, adParamOutput, 255)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("first_name", adVarWChar, adParamOutput, 255)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("last_name", adVarWChar, adParamOutput, 255)
    objCmd_EmailData.Parameters.Append objCmd_EmailData.CreateParameter("company_name", adVarWChar, adParamOutput, 255)

    objCmd_EmailData("site_id") = gIntSiteID
    objCmd_EmailData("view_tracking_code_did") = intViewedTrackingID
    objCmd_EmailData("view_milestone_action_did") = intViewedActionID
    objCmd_EmailData("opt_out_tracking_code_did") = intOptOutTrackingID
    objCmd_EmailData("opt_out_milestone_action_did") = intOptOutActionID


    'CREATE COMMAND OBJECT THAT WILL BE SETTING mass_email_queue TiSent Value = 1
    Set objCmd_UpdateQueue = Server.CreateObject("ADODB.Command")
    objCmd_UpdateQueue.CommandType = adCmdStoredProc
    objCmd_UpdateQueue.ActiveConnection = objConn_UpdateQueue
    objCmd_UpdateQueue.CommandText = "SDpcuSentEmail"
    objCmd_UpdateQueue.CommandTimeout = 120

    objCmd_UpdateQueue.Parameters.Append objCmd_UpdateQueue.CreateParameter("mass_email_batch_id", adGUID, adParamInput)
    objCmd_UpdateQueue.Parameters.Append objCmd_UpdateQueue.CreateParameter("tracking_code_did", adInteger, adParamInput)
    objCmd_UpdateQueue.Parameters.Append objCmd_UpdateQueue.CreateParameter("individual_id", adGUID, adParamInput)

    objCmd_UpdateQueue("mass_email_batch_id") = guidMailBatchID
    objCmd_UpdateQueue("tracking_code_did") = intViewedTrackingID

    'Start page and set status bar bookends
    response.write "<span class=""title"">Sending Mass Emails...</span>" & _
    "<p>0%"
    for i = 0 to (intRecipientCount\intStatusStep)-15
        response.write "&nbsp;"
    next
    response.write "100%" & _
    "<br><span style=""background-color:#306A9A;"">"
    'LOOP THROUGH objRS_Recipients and Send Mail to Each
    intSentCount = 0
    while not objRs_Recipients.eof

        objCmd_EmailData("individual_id") = objRS_Recipients("individual_id").value
        objCmd_EmailData.Execute

        'Output and Return values:
        strViewEncoded = objCmd_EmailData("view_encoded")
        strOptOutEncoded = objCmd_EmailData("optout_encoded")
        strEmailAddress = objCmd_EmailData("email_address")
        strFirstName = objCmd_EmailData("first_name")
        strLastName = objCmd_EmailData("last_name")
        strCompany = objCmd_EmailData("company_name")

        'PARSE HTML FOR EACH INDIVIDUAL
        'MERGE FIRSTNAME, LASTNAME and COMPANY if EXIST
        strFinalMessage = strHTMLMessage
        if not isNull(strFirstName) then strFinalMessage = replace(strFinalMessage,"<@FIRSTNAME@>",strFirstName)
        if not isNull(strLastName) then  strFinalMessage = replace(strFinalMessage,"<@LASTNAME@>",strLastName)
        if not isNull(strCompany) then strFinalMessage = replace(strFinalMessage,"<@COMPANY@>",strCompany)
        if not isNull(objRS_Recipients("individual_id")) then strFinalMessage = replace(strFinalMessage,"<@ID@>",objRS_Recipients("individual_id").value)
        'ADD Encoded data to end of HTML
        strFinalMessage = strFinalMessage & "<br><img src=""" & gstrTimageURL & strViewEncoded & ".png"" width=""10"" height=""10"" alt=""Thank you""><Br>"
        if gBlnSystemOptOut then
            strFinalMessage = strFinalMessage & "<a href=""" & gstrOptOutURL &"?en=" & strOptOutEncoded & """>" & strOptOutText &"</a><br></body></html>"
        else
            strFinalMessage = strFinalMessage & strOptOutText & "<br></body></html>"
        end if
        'SEND EMAIL
        if isValidEmail(strEmailAddress) then
            Set objMsg = Server.CreateObject("CDO.Message")
            objMsg.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/sendusing") = 1
            objMsg.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpserver") = gstrSMTPServer
            objMsg.Configuration.Fields.Item("http://schemas.microsoft.com/cdo/configuration/smtpserverport") = 25
            objMsg.Configuration.Fields.Update
            objMsg.From = strFrom
            objMsg.Subject = strSubject
            objMsg.To = strEmailAddress
            objMsg.Cc = ""
            objMsg.Bcc = ""
            objMsg.AutoGenerateTextBody=false
            objMsg.HTMLBody = strFinalMessage
            objMsg.HTMLBodyPart.Charset = "UTF-8"
            objMsg.HTMLBodyPart.ContentTransferEncoding = "quoted-printable"
            objMsg.Send

            set objMsg = nothing
            intSentCount = intSentCount + 1

            'MARK AS DONE
            objCmd_UpdateQueue("individual_id") = objRS_Recipients("individual_id").value
            objCmd_UpdateQueue.Execute
        end if
        strFinalMessage = ""

        'STATUS BAR
        if (intLoopCount mod intStatusStep) = 0 then
            response.write "&nbsp;"
        end if
        intLoopCount = intLoopCount + 1

        objRs_Recipients.movenext
    wend 'Recipients LOOP
    response.write "</span><p><span class=""subtitle"">" & intSentCount & " emails were sent. Updating history..."

    if intRecipientCount > intSentCount then
        response.write "<br><span class=""Warning"">" & intRecipientCount - intSentCount & " recipient(s) had an invalid or empty email address in the database. Query table mass_email_invalid_records to retrieve those individuals.</span>"
    end if

    'Clean Up Database Objects
    set objCmd_UpdateQueue.ActiveConnection = nothing
    set objCmd_UpdateQueue= nothing

    set objCmd_EmailData.ActiveConnection = nothing
    set objCmd_EmailData= nothing

    objRs_Recipients.close
    set objRs_Recipients = nothing

    set objCmd_Recipients.ActiveConnection = nothing
    set objCmd_Recipients= nothing

    call disconnect(objConn_Recipients)
    call disconnect(objConn_EmailData)
    call disconnect(objConn_UpdateQueue)


    call connect(objConn_ProcessedEmail)

    Set objCmd_ProcessedEmail = Server.CreateObject("ADODB.Command")
    objCmd_ProcessedEmail.CommandType = adCmdStoredProc
    objCmd_ProcessedEmail.ActiveConnection = objConn_ProcessedEmail 'or other valid connection object
    objCmd_ProcessedEmail.CommandText = "SDpcdProcessedEmail"
    objCmd_ProcessedEmail.CommandTimeout = 120

    objCmd_ProcessedEmail.Parameters.Append objCmd_ProcessedEmail.CreateParameter("mass_email_batch_id", adGUID, adParamInput)

    objCmd_ProcessedEmail("mass_email_batch_id") = guidMailBatchID

    objCmd_ProcessedEmail.Execute

    'Clean up:
    set objCmd_ProcessedEmail.ActiveConnection = nothing
    set objCmd_ProcessedEmail= nothing
    call disconnect(objConn_ProcessedEmail)

    response.write "<p>Process Complete.<p><a href=""javascript:window.close();"">Close Window</a></span>"

end sub


private sub startPageHTML()
%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Client</title>
    <style type="text/css">
    <!--
    BODY
    {
    FONT-SIZE: 10px;
    MARGIN: 0pt 0pt 0pt 0pt;
    FONT-FAMILY: arial;
    BACKGROUND-COLOR: #f3f3f3;
    }
    td
    {
    FONT-SIZE: 10px;
    FONT-FAMILY: arial;
    }
    TABLE.bordered {
	/*border-top: 1px #306A9A solid;
	border-right: 1px #306A9A solid;
	border-left: 1px #306A9A solid;
   	border-bottom: 1px #306A9A solid;*/
    }
    .mainBody
    {
    MARGIN: 10pt 10pt 10pt 10pt;
    }
    .Title
    {
    font-weight: bold;
    FONT-SIZE: 15px;
    }
    .subTitle
    {
    font-weight: bold;
    FONT-SIZE: 13px;
    }
    .WhiteTitle
    {
    font-weight: bold;
    FONT-SIZE: 15px;
    color:#FFFFFF;
    }
    .Warning {
    FONT-SIZE: 9pt;
    color: #8F2F2F;
    font-weight:bold;
    }
    .FormElement {
	font-family : Arial,;
	font-size: 10px;
    width:100%;
    }
    -->
    </style>
    <script language="JavaScript1.1" type="text/javascript">
    <!--
        function submitPreview() {
            document.forms[0].target = "_blank";
            document.forms[0].POST_ACTION.value = "PREVIEW"
            document.forms[0].submit();
            document.forms[0].POST_ACTION.value = "SEND_MASS_EMAIL";
	    document.forms[0].target = "_self";
        }
        function submitEmailPreview() {
            document.forms[0].target = "_self";
            document.forms[0].POST_ACTION.value = "EMAIL_PREVIEW"
            document.forms[0].submit();
        }

    //-->
    </script>
    </head>

    <body leftmargin="0" topmargin="0" rightmargin="0" bottommargin="0" marginwidth="0" marginheight="0">
    <!--Begin Header-->
    <Table width="100%" cellspacing=0 cellpadding=0 border=0>
        <tr style="width:100%; height:35px;">
           <!-- <td width="168"><img src="images/HeaderTopLeft.png" width="168" height="63" alt=""></td>
            <td width="100%" background="images/headerTopMiddle.png">
			<span class="WhiteTitle">Onyx Email Accelerator
			</span>
			</td>
            <td><img src="images/headerTopRight.png" width="32" height="63" alt=""></td>-->
			<td style="width:100%; height:35px; background-color:#438fbc; padding-left:5px; font-weight:bold; color:white; font-size:12pt; font-family:Arial;">Onyx Email Accelerator</td>
        </tr>
    </table>
    <!--End Header-->
    <div class="mainBody">
<%
end sub

private sub endPageHTML()
    %>
    </div>
    </body>
    </html>
    <%
end sub

sub clientForm ()
    dim i

    if objWarnings.blnWarningsExist then
        for i = 0 to ubound(objWarnings.strWarnings)
            response.write "<span class=""Warning"">" & objWarnings.strWarnings(i) & "</span><br>"
        next
        objWarnings.clearWarnings
    end if
%>

<form name="onyxmets" method="post" action="client.asp">
<input type="hidden" name="PAGE_POSTED" value="TRUE">
<input type="hidden" name="POST_ACTION" value="SEND_MASS_EMAIL">
<input type="hidden" name="gMailBatchID" value="<%=trim(request("gMailBatchID"))%>">
<input type="hidden" name="totalRecipients" value="<%=gintRecipientCount%>">
<table cellpadding="5" cellspacing="0" width="700" bgColor="#f3f3f3" class="bordered">

<tr>
<td valign="top" style="width:100%;font-size:8pt;"><strong>To:</strong></td>
    </tr>
    <tr>
<td valign="top">
<%
for i = 0 to ubound(gArrayRecipientSampling)
    response.write gArrayRecipientSampling(i) & ";"
next
response.write "...." & cstr(gintRecipientCount) & " total recipients"

%>
</td>
</tr>
<tr>
<td valign="top" style="font-size:8pt;"><strong>From:</strong></td></tr>
    <tr>
<td valign="top">
<input type="text" name="from" size="50" value="<%=trim(request("from"))%>" class="formelement"><br>
<em>Valid Email address or 'Friendly Name &lt;valid email address&gt;'</em>
</td>
</tr>
<tr>
<td valign="top" style="font-size:8pt;"><strong>Subject:</strong></td></tr>
<tr>
<td valign="top">
<input type="text" name="subject" size="100" value="<%=trim(request("subject"))%>" class="formelement">
</td>
</tr>
<tr>
<td valign="top" colspan="2">

<table width="100%" style="background-color:#438fbc; color: #f3f3f3;" class="bordered">
<tr>
 <td width="400">
<strong style="font-size:8pt;">View-Email Tracking Information:</strong><br>
<em>TrackingID and ActionID can be 0 if you do not wish to track 'viewed email'</em>
</td>
</tr>
 <tr>
    <td>
    TrackingID: <input type="text" value="<%if trim(request("viewedTrackingID")) <> "" then
        response.write trim(request("viewedTrackingID"))
    else
        response.write "0"
    end if%>" class="formelement" size="5" name="viewedTrackingID">
    &nbsp;&nbsp;
    ActionID: <input type="text" value="<%if trim(request("viewedActionID")) <> "" then
        response.write trim(request("viewedActionID"))
    else
        response.write "0"
    end if%>" class="formelement" size="5" name="viewedActionID">

    </td>
</tr>
<%if gBlnSystemOptOut then%>
    <tr><td colspan="2"><bR></td></tr>
    <tr>
    <td>
    <strong style="font-size:8pt;">Opt-Out Tracking Information:</strong><br>
    <em>TrackingID and ActionID must be non-zero and valid</em>
     </td>
      </tr>
    <tr>
        <td>
    TrackingID: <input type="text" value="<%=request("optOutTrackingID")%>" class="formelement" size="5" name="optOutTrackingID">
    &nbsp;&nbsp;
    ActionID: <input type="text" value="<%=request("optOutActionID")%>" class="formelement" size="5" name="optOutActionID">
    </td>
    </tr>
<%end if%>
</table>

</td>
</tr>

<tr>
    <td>
        <strong style="font-size:8pt;">HTML Source/Message:</strong><br>
<textarea class="formelement" cols="88" rows="20" name="HTMLMessage"><%=trim(request("HTMLMessage"))%></textarea>

    </td>

</tr>


</table>

<p>

<table cellpadding="5" cellspacing="0" width="700" bgColor="#f3f3f3" class="bordered">
<tr>
<td valign="top">

<table cellpadding="2" cellspacing="0">
<tr>
<td valign="top">

</td>
</tr>
<tr>
<td valign="top">
<strong style="font-size:8pt;">Opt-Out Text:</strong><br>
<textarea class="formelement" cols="50" rows="5" name="optOutText">
<%
if trim(request("optOutText")) <> "" then
    response.write trim(request("optOutText"))
else
    response.write trim(gstrOptOutText)
end if
%>
</textarea>
<br>
<%
if gBlnSystemOptOut then
    response.write "<strong style="">Opt-Out URL:</strong>" & gstrOptOutURL
end if
%>
<br>
</td>
    </tr>
    <tr>
    <td valign="top">
Send a preview email to designated recipients. Email will not be tracked.
<p style="font-size:8pt;">
Recipients for Email Preview:<br>
<textarea class="formelement" cols="30" rows="3" name="PreviewRecipients"><%=trim(request("PreviewRecipients"))%></textarea><br>
<input type="button" name="EmailPreview" value="Send Preview Email" class="formelement" onClick="submitEmailPreview();"><br>
</td>

</tr>

</table>

</td>
<td valign="top">
<br>
<table width="200" cellpadding="5" cellspacing="5" style="background-color:#f3f3f3;" class="bordered">
<tr>
<td valign="top" style="position:relative; bottom:5px;">
Preview the source HTML in a new web browser window.
<p>
<input type="button" name="Preview" value="Preview" class="formelement" onClick="submitPreview();">
</td>
</tr>
</table>
<br>

<table width="200" cellpadding="5" cellspacing="5" bgColor="#f3f3f3" class="bordered">
<tr>
</tr></table>
<br>
<table width="200" cellpadding="5" cellspacing="5" bgColor="#f3f3f3" class="bordered">
<tr>
<td valign="top">
Send Mass Email to all recipients designated from List Management query.
<p>
<input type="submit" name="PostClientForm" value="Send Mass Email" class="formelement">
</td>
</tr>
</table>
<Br>



</td>
</tr>
</table>



</form>
<br>
<%
end sub
%>

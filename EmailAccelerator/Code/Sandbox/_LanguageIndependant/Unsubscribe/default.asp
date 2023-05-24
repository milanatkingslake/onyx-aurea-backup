<% Option Explicit %>
<!--#include file="adovbs.inc"-->
<%
Const ENCODE_QUERYSTRING = "en"
Const UNSUB_TRACKING_QUERYSTRING = "unsubID"

'Database Variables
Dim gstrDBConnection
Dim gobjDBConn
Dim gobjCommand

'Other Variables
Dim gstrErrorReportEmailAddress
Dim gstrConfirmationURL
Dim gintSiteID
Dim gstrEncodedString
Dim glngIndividualID
Dim glngTrackingID
Dim glngActionID
Dim gintDecodeIntact

'Load configuration file
call LoadGlobalVariables(gstrDBConnection, gstrErrorReportEmailAddress, gstrConfirmationURL, gintSiteID)

'Test for the presence of the unsubscribe data in the querystring.
gstrEncodedString = Trim(Request(ENCODE_QUERYSTRING))

If gstrEncodedString = "" Then
	'If there is no data, stop all execution and display an error stating that no action was taken.  Do not redirect the user to the confirmation page.
	Call stopPageExecution("No encode string was passed to be processed.")
End If

On Error Resume Next

'Establish connection with Onyx database
Call Connect(gobjDBConn)


'Execute stored procedure to decrypt the encoded unsubscribe string.
Set gobjCommand = Server.CreateObject("ADODB.Command")
gobjCommand.CommandType = adCmdStoredProc
gobjCommand.ActiveConnection = gobjDBConn
gobjCommand.CommandText = "SDpcgDecryptEmailData" 
gobjCommand.Parameters.Append gobjCommand.CreateParameter("encoded_string", adVarChar, adParamInput, 100)
gobjCommand.Parameters.Append gobjCommand.CreateParameter("intact", adUnsignedTinyInt, adParamOutput)
gobjCommand.Parameters.Append gobjCommand.CreateParameter("individual_id", adGUID, adParamOutput)
gobjCommand.Parameters.Append gobjCommand.CreateParameter("tracking_code_did", adInteger, adParamOutput)
gobjCommand.Parameters.Append gobjCommand.CreateParameter("milestone_action_did", adInteger, adParamOutput)
gobjCommand("encoded_string") = gstrEncodedString
gobjCommand.Execute

'If a database error occurs at this point, and email error reporting is turned on send an email with the encoded string. Halt remaining execution of the page and immediately redirect to the confirmation page with no tracking ID in the querystring.
If err.Number <> 0 and gstrErrorReportEmailAddress <> "" Then
	Call SendErrorEmail(gstrErrorReportEmailAddress, "Unsubscribe Error", "A database error occured when trying to decode an unsubscribe string. The string will need to be decoded manually to complete the request." & vbCrLf & vbCrLf & "Unsubscribe String: " & gstrEncodedString)
	Call RedirectToConfirmation(gstrConfirmationURL ,0)
elseIf err.Number <> 0 and gstrErrorReportEmailAddress = "" Then
	Call stopPageExecution("A database error occured when trying to decode an unsubscribe string.")
End If

glngIndividualID = gobjCommand("individual_id")
glngTrackingID = gobjCommand("tracking_code_did")
glngActionID = gobjCommand("milestone_action_did")
gintDecodeIntact = gobjCommand("intact")

'Test for a valid individual ID, tracking ID, and action ID.
if isNull(glngIndividualID) then glngIndividualID = ""
If IsNull(glngTrackingID) or glngTrackingID < 1 Then glngTrackingID = 0
If IsNull(glngActionID) or glngActionID < 1 Then glngActionID = 0

'If there is no data, stop all execution and display an error stating that no action was taken.  Do not redirect the user to the confirmation page.
If glngIndividualID = "" or glngTrackingID = 0 or glngActionID = 0 or gintDecodeIntact <> 1 Then
	If gstrErrorReportEmailAddress <> "" Then
		Call SendErrorEmail(gstrErrorReportEmailAddress, "Unsubscribe Error", "An error occured when trying to unsubscribe a user. The unsubscribe string may be corrupt." & vbCrLf & vbCrLf & "Unsubscribe String: " & gstrEncodedString & vbCrLf & "IndividualID: " & glngIndividualID & vbCrLf & "Campaign Tracking ID: " & glngTrackingID & vbCrLf & "Campaign Action ID: " & glngActionID)
	End If
	Call stopPageExecution("The unsubscribe string may be corrupt.")
End If

'Clean up
set gobjCommand.ActiveConnection = nothing
set gobjCommand= nothing

'Execute stored procedure to update individual's record with the campaign tracking ID and action ID.
Set gobjCommand = Server.CreateObject("ADODB.Command")
gobjCommand.CommandType = adCmdStoredProc
gobjCommand.ActiveConnection = gobjDBConn
gobjCommand.CommandText = "SDpsiCampaign"
gobjCommand.Parameters.Append gobjCommand.CreateParameter("site_id", adInteger, adParamInput)
gobjCommand.Parameters.Append gobjCommand.CreateParameter("owner_id", adGUID, adParamInput)
gobjCommand.Parameters.Append gobjCommand.CreateParameter("tracking_code_did", adInteger, adParamInput)
gobjCommand.Parameters.Append gobjCommand.CreateParameter("milestone_action_did", adInteger, adParamInput)

gobjCommand("owner_id") = glngIndividualID
gobjCommand("tracking_code_did") = glngTrackingID
gobjCommand("milestone_action_did") = glngActionID
gobjCommand("site_id") = gintSiteID
gobjCommand.Execute

'If a database error occurs at this point, and email error reporting is turned on send an email with the individual ID, tracking ID, and action ID.
If err.Number <> 0 and gstrErrorReportEmailAddress <> "" Then
	Call SendErrorEmail(gstrErrorReportEmailAddress, "Unsubscribe Error", "A database error occured when trying to mark the campaign action and tracking IDs. The campaign action and tracking IDs will need to be marked manually to complete the request." & vbCrLf & vbCrLf & "Unsubscribe String: " & gstrEncodedString & vbCrLf & "IndividualID: " & glngIndividualID & vbCrLf & "Campaign Tracking ID: " & glngTrackingID & vbCrLf & "Campaign Action ID: " & glngActionID)
	Call RedirectToConfirmation(gstrConfirmationURL ,glngTrackingID)
ElseIf err.Number <> 0 and gstrErrorReportEmailAddress = "" Then
	Call stopPageExecution("A database error occured when trying to complete the unsubscribe request.")
End If

'Clean up
set gobjCommand.ActiveConnection = nothing
set gobjCommand= nothing
Call disconnect(gobjDBConn)

'Redirect to the confirmation page and include the tracking ID in the querystring.
Call RedirectToConfirmation(gstrConfirmationURL ,glngTrackingID)

On Error Goto 0


'***********************SUB ROUTINES*************************************************************
'************************************************************************************************
'************************************************************************************************
'************************************************************************************************
'************************************************************************************************
'************************************************************************************************
'************************************************************************************************
'************************************************************************************************
'************************************************************************************************
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

private sub LoadGlobalVariables (byRef pstrDBConnection, byRef pstrErrorReportEmailAddress, byRef pstrConfirmationURL, byRef pintSiteID)
	dim xmlConfig
	dim objErr
	
	pstrDBConnection = ""
	pstrErrorReportEmailAddress = ""
	pstrConfirmationURL = ""
	
	set xmlConfig = Server.CreateObject("Msxml2.DomDocument")
	xmlConfig.async="false"
	xmlConfig.setProperty "ServerHTTPRequest", true
	xmlConfig.load(Server.MapPath("unsubscribe.config"))
	
	Set objErr = xmlConfig.parseError 
	If objErr.errorCode <>  0 Then
		Call stopPageExecution("An error occured when loading the Configuration File. Reason: " & objErr.reason)
	else
		'Return email address for error reporting (implies use of local SMTP server)
		'Return connection string
		'Return confirmation page URL
		pstrDBConnection =  xmlConfig.getElementsByTagName("DatabaseConnectionString").item(0).text
		pstrErrorReportEmailAddress =  xmlConfig.getElementsByTagName("ErrorReportEmailAddress").item(0).text
		pstrConfirmationURL = xmlConfig.getElementsByTagName("ConfirmationURL").item(0).text
		pintSiteId = xmlConfig.getElementsByTagName("iSiteID").item(0).text
	End If
	set objErr = nothing
	set xmlConfig = nothing
end sub

Private Sub stopPageExecution(byVal pstrReason)
	Response.Write "<html><head><title>Unsubscribe Error</title></head><body bgcolor=""#FFFFFF"" text=""#000000"">"
	Response.Write "<br><font face=""Arial,Helvetica,sans-serif"" size=""2"">An internal error occured when trying to process your unsubscribe request.  If you still wish to unsubscribe, please attempt to email the organization directly.<br><br>Cause of the error:<br>" & pstrReason & "</font>"
	Response.Write "</body></html>"
	Response.End
End Sub

Private Sub connect(ByRef pcnnConnection)
	Dim strSQL
	' Create and open the connection
	Set pcnnConnection = Server.CreateObject("ADODB.Connection") 
	pcnnConnection.Open gstrDBConnection
	
	' Set connection options
    strSQL = "SET NOCOUNT ON SET ANSI_NULLS ON SET ANSI_PADDING OFF SET ANSI_WARNINGS OFF SET QUOTED_IDENTIFIER OFF SET ANSI_NULL_DFLT_ON OFF SET CONCAT_NULL_YIELDS_NULL OFF SET IMPLICIT_TRANSACTIONS OFF"
    pcnnConnection.Execute strSQL, , adExecuteNoRecords
End Sub

Private Sub disconnect(ByRef pcnnConnection)
	' Close out and kill the connection
	pcnnConnection.close
	Set pcnnConnection = Nothing
End Sub

Private Sub SendErrorEmail(byVal pstrTO, byVal pstrSubject, byVal pstrMessage)
	Dim objMsg
	
	Set objMsg = Server.CreateObject("CDO.Message")
	objMsg.From = pstrTO
	objMsg.Subject = pstrSubject
	objMsg.To = pstrTO
	objMsg.Cc = ""
	objMsg.Bcc = ""
	objMsg.TextBody = pstrMessage
	objMsg.Send
	set objMsg = nothing
End Sub

Private Sub RedirectToConfirmation(byVal pstrURL, byVal pstrTrackingID)
	Response.Redirect pstrURL & "?" & UNSUB_TRACKING_QUERYSTRING & "=" & pstrTrackingID
	Response.End
End Sub

%>
<!-- #INCLUDE FILE="../common/include/otm_helper.asp" -->
<!-- #INCLUDE FILE="../common/include/otm_common.asp" -->
<%
' Copyright Aptean 2017. All rights reserved.
'Page is executed by Microsoft.XMLHTTP Call from lm_results.js
'
'Set timeout as execution can take time
Server.ScriptTimeOut = 20000

'Declare

dim strSQL
dim strFromClause
dim oSession
dim xmldoc
dim iSiteID
dim strMasterSql
dim arraySQL
dim i
dim strNotExistsClause
dim m_oUtils
dim sGUID
dim oCall
dim oCon
dim sMethodStatus
dim sSessionID
dim oParam


' Initialise error object
Err.clear
on error resume next


'GET THE SITE ID FROM THE SESSION/APPLICATION
call initializePageSecurity(oSession, "")
iSiteID = oSession.siteId

set m_oUtils = Server.CreateObject("OnyxUtils.WebUtil")
sGUID = m_oUtils.CreateGuid(True)

if isNull(sGUID) or sGUID = "" or err.number <> 0 then
    response.write "-1"
    response.end
end if


'GET QUERY
set xmldoc = Server.CreateObject("Microsoft.XMLDOM")
xmldoc.async=false
xmldoc.load(request)
strMasterSQL = xmldoc.getElementsByTagName("query").item(0).text
set xmlDoc = nothing

'TEST FOR VALIDQUERY
if len(trim(strMasterSQL)) = 0 then
    response.write "-2"
    response.end
end if

'SQL STRING MANIPULATION
strMasterSQL = ucase(strMasterSQL)

'NEED TO SPLIT ON UNION BECAUSE MASTER SQL MAY CONTAIN MULITPLE UNION QUERIES
arraySQL = split(strMasterSQL,"UNION")

strSQL = "INSERT INTO mass_email_queue "
for i = 0 to ubound(arraySQL)
    strFromClause = right(arraySQL(i),len(arraySQL(i)) - instr(arraySQL(i),"FROM") + 1)
    strSQL = strSQL & "SELECT '" & sGUID & "', A.individual_id, '" & Now() & "' " & strFromClause 
    if i <> ubound(arraySQL) then
        strSQL = strSQL & " UNION "
    end if
    
next

set oCon = new cOTMConnection
if not oCon.bInitialize(oSession.AppName, oSession.sessionID, sMethodStatus) then
	Response.Write "-3"
	Response.End
end if


' get OTM call object
if not oCon.bCreateLBOCall(oCall, sMethodStatus) then
	Response.Write "-3"
	Response.End
end if

' initialize call object
if not oCall.bInitialize("massEmailBatch", "insertBatch", "all", "", sMethodStatus) then
	Response.Write "-3"
	Response.End
end if

' add method call parameters...
call oCall.AddParam("massEmailBatchId", sGUID)
call oCall.AddParam("massEmailBatchQuery", strSQL)

if not oCall.bExecuteLocal(sStatusType, sMethodStatus) then
	Response.Write "-3"
	Response.End
end if

' Trap any unhandled errors
if err.number <> 0 or sStatusType = "failure" then	
	Call bPushErrortoMethodStatus(ERR_SEVERITY_FAILURE, err.number, _
		err.description, ERR_ERRORTYPE_OEPUNHANDLED, ERR_SOURCETYPE_ASPFunction, _
		ROUTINE & " (" & err.source & ")", sMethodStatus)
	err.clear
    Response.Write "-3"
    Response.End
end if

Response.Write sGUID


%>


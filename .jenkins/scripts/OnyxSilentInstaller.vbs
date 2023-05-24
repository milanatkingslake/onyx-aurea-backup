Set colArgs = WScript.Arguments.Named

installerpath = colArgs.Item("installerpath")
installdir = colArgs.Item("installdir")
logdir = colArgs.Item("logdir")
appname = colArgs.Item("appname")
server = colArgs.Item("server")
transactiondbname = colArgs.Item("transactiondbname")
persistencedbname = colArgs.Item("persistencedbname")
usernamewithdomain = colArgs.Item("usernamewithdomain")
ofausernamewithdomain = colArgs.Item("ofausernamewithdomain")
password = colArgs.Item("password")
serverhost = colArgs.Item("serverhost")
isinstalloedb = colArgs.Item("isinstalloedb")
isoedbfreshinstall = colArgs.Item("isoedbfreshinstall")
isinstalloeas = colArgs.Item("isinstalloeas")
isinstalloeasconfig = colArgs.Item("isinstalloeasconfig")
isinstallfileagent = colArgs.Item("isinstallfileagent")
exchangeserver = colArgs.Item("exchangeserver")
oepmode = colArgs.Item("oepmode")

Wscript.Echo installerpath
Wscript.Echo installdir
Wscript.Echo logdir
Wscript.Echo appname
Wscript.Echo server
Wscript.Echo transactiondbname
Wscript.Echo persistencedbname
Wscript.Echo usernamewithdomain
Wscript.Echo ofausernamewithdomain
Wscript.Echo password
Wscript.Echo serverhost
Wscript.Echo isinstalloedb
Wscript.Echo isoedbfreshinstall
Wscript.Echo isinstalloeas 
Wscript.Echo isinstalloeasconfig
Wscript.Echo isinstallfileagent
Wscript.Echo exchangeserver
Wscript.Echo oepmode

If (isinstalloedb) Then
	If (isoedbfreshinstall) Then		
		Wscript.Echo "OEDB Fresh install"
		Launch_App "OEDB",""& installerpath & "\OEDB\OEDB.exe", "/s /v""/l*v "& logdir & "\OEDB.log"" /v""SILENT=1"" /v""DBFRESHINSTALL=1"" /v""IS_SQLSERVER_AUTHENTICATION=1"" /v""IS_SQLSERVER_SERVER="& server & """  /v""IS_SQLSERVER_DATABASE="& transactiondbname & """ /v""IS_SQLSERVER_USERNAME=OnyxDBO"" /v""IS_SQLSERVER_PASSWORD=onyx"" /v""TXTOTDB="& transactiondbname & """ /v""TXTOPDB="& persistencedbname & """ /v""TXTSAPASSWORD=onyx"" /v""TXTRETYPESAPASSWORD=onyx"" /v""TXTLMACCOUNT=onyxLMSql"" /v""INSTALLDIR=\"""& installdir & "\Notification_CLR"""" /v""/qn/a"""
	Else		
		' Wscript.Echo "OEDB Upgrade"		
		Launch_App "OEDB",""& installerpath & "\OEDB\OEDB.exe", "/s /v""/l*v "& logdir & "\OEDB.log"" /v""SILENT=1"" /v""DBUPGRADE=1"" /v""IS_SQLSERVER_AUTHENTICATION=1"" /v""IS_SQLSERVER_SERVER="& server & """  /v""IS_SQLSERVER_DATABASE="& transactiondbname & """ /v""IS_SQLSERVER_USERNAME=OnyxDBO"" /v""IS_SQLSERVER_PASSWORD=onyx"" /v""TXTOTDB="& transactiondbname & """ /v""TXTOPDB="& persistencedbname & """ /v""TXTSAPASSWORD=onyx"" /v""TXTRETYPESAPASSWORD=onyx"" /v""TXTLMACCOUNT=onyxLMSql"" /v""INSTALLDIR=\"""& installdir & "\Notification_CLR"""" /v""/qn/a"""		
	End If
End If

'OED Upgrade
'Launch_App "OEDUpgrade",""& installerpath & "\OEDUpgrade\OEDUpgrade.exe", "/s /v""/l*v "& logdir & "\OEDUpgrade.log"" /v""SILENT=1"" /v""LSTLOGICALAPP=Onyx"" /v""OPEN_FOLDER=0"" /v""/qn/a"""

'Copy Dictionary file
'CopyFile "C:\Program Files\Onyx\AppServer\Applications\Onyx\OED Upgrade Output\OnyxEnterpriseDictionary_7.8.xml", "C:\Program Files\Onyx\AppServer\Applications\Onyx"

'Backup OnyxEnterpriseDictionary
'RenameFile "C:\Program Files\Onyx\AppServer\Applications\Onyx\OnyxEnterpriseDictionaryWC.xml", "C:\Program Files\Onyx\AppServer\Applications\Onyx\OnyxEnterpriseDictionaryWC[" & DatePart("yyyy",Date) & "-" & Right("0" & DatePart("m",Date), 2) & "-" & Right("0" & DatePart("d",Date), 2) & "-" & Right("0" & Hour(Now), 2) & "-" & Right("0" & Minute(Now), 2) & "-" & Right("0" & Second(Now), 2) &  "].xml"

'Rename new file
'RenameFile "C:\Program Files\Onyx\AppServer\Applications\Onyx\OnyxEnterpriseDictionary_7.8.xml", "C:\Program Files\Onyx\AppServer\Applications\Onyx\OnyxEnterpriseDictionaryWC.xml"
Wscript.Echo "Skipping OED Upgrade because Harish told us there were no changes in this component from 7.8 to 7.9 and work on upgrade installer is not yet finished."

'Onyx prerequisite (SP3)
Launch_App "Onyx Prerequisite",""& installerpath & "\OnyxPrerequisite\OnyxPrerequisite.exe", "/s /v""/l*v "& logdir & "\OnyxPrerequisite.log"" /v""INSTALLDIR=\"""& installdir & "\Prerequisite\"""" /v""/qn/a"""

'OEAS(GA)
If (isinstalloeas) Then
	Launch_App "Onyx Enterprise Application Server",""& installerpath & "\OEAS\OnyxEnterpriseApplicationServer.exe", "/s /v""/l*v "& logdir & "\OEAS.log"" /v""INSTALLDIR=\"""& installdir & "\AppServer\"""" /v""USERNAME=OnyxEASUser"" /v""PASSWORD=Onyx2018"" /v""/qn/a"""
End If

'OEAS Config(GA)
If (isinstalloeasconfig) Then	
	Launch_App "Configure Middle Tier",""& installerpath & "\OEASConfig\OEASConfig.exe", "/s /v""/l*v "& logdir & "\OEASConfig.log"" /v""APPNAME="& appname & """ /v""SQLSERVER_SERVER="& server & """ /v""SQLSERVER_USERNAME=OnyxDBO"" /v""SQLSERVER_PASSWORD=onyx"" /v""SQLSERVER_DATABASE="& transactiondbname & """ /v""SQL_LOGIN=OnyxEasSql"" /v""SQL_PASSWORD=onyx"" /v""/qn/a"""
End If

'Onyx Enterprise Studio (SP1)
Launch_App "EnterpriseStudio",""& installerpath & "\OnyxEnterpriseStudio\EnterpriseStudio.exe", "/s /v""/l*v "& logdir & "\OnyxEnterpriseStudio.log"" /v""IS_OEASLOCAL=1""  /v""LOGICALAPP="& appname & """ /v""VIRTUALDIRWEB=OnyxEnterpriseStudio_Onyx"" /v""VIRTUALDIRWIN=OnyxEnterpriseStudio_Windows"" /v""SITEID=1"" /v""INSTALLDIR=\"""& installdir & "\EnterpriseStudio\""""  /v""/qn/a"""

'Create OGS User
CreateUserAccount "OGSUser",""& password & "",""& server & ""

'Onyx Gateway Service (SP3)
Launch_App "Onyx Gateway Service",""& installerpath & "\OnyxGatewayService\OnyxGatewayService.exe", "/s /v""/l*v "& logdir & "\OnyxGatewayService.log"" /v""IS_OEASLOCAL=1"" /v""LOGICALAPP="& appname & """ /v""SERVER="& server & """ /v""OTDB="& transactiondbname & """ /v""OPDB="& persistencedbname & """ /v""SQLLOGIN=OnyxDBO"" /v""SQLPASSWORD=onyx"" /v""PORT=69"" /v""SERVICEUSERNAME="& server & "\OGSUser"" /v""SERVICEPASSWORD="& password & """ /v""/qn/a"""

'Onyx Employee Portal (SP3)
Launch_App "EmployeePortal",""& installerpath & "\OnyxEmployeePortal\EmployeePortal.exe", "/s /v""/l*v "& logdir & "\OnyxEmployeePortal.log"" /v""IS_OEASLOCAL=1"" /v""LOGICALAPP="& appname & """ /v""VIRTUALDIRWEB=OnyxEmployeePortal_Onyx"" /v""VIRTUALDIRWIN=OnyxEmployeePortal_Windows"" /v""SITEID=1"" /v""MODE="& oepmode & """ /v""LOGIN=sa"" /v""PASSWORD=onyx"" /v""CONFIRM=onyx"" /v""/qn/a"""

'Change servername in config file for navigator
RemoveReadOnly ""& installdir & "\EmployeePortal\CRArchitecture\Configurations\config.xml"
ReplaceText ""& installdir & "\EmployeePortal\CRArchitecture\Configurations\config.xml","localhost",""& serverhost &""

'Onyx Mobile Web (SP3)
Launch_App "Onyx Mobile Web",""& installerpath & "\OnyxMobileWeb\OnyxMobileWeb.exe", "/s /v""/l*v "& logdir & "\OnyxMobileWeb.log"" /v""IMPERSONATE=1"" /v""LOGICALAPP="& appname & """ /v""USERNAME="& usernamewithdomain & """ /v""PASSWORD="& password & """ /v""VIRTUALDIRWEB=OnyxMobileWeb"" /v""INSTALLDIR=\"""& installdir & "\OnyxMobileWeb\"""" /v""OGSURL=http://"& serverhost &":69/ServiceGateway"" /v""OEPUSERNAME=sa"" /v""OEPPASSWORD=onyx""  /v""/qn/a"""

'Onyx File Agent (GA)
If (isinstallfileagent) Then	
	Launch_App "Onyx File Agent",""& installerpath & "\OnyxFileAgent\OnyxFileAgent.exe", "/s /v""/l*v "& logdir & "\OnyxFileAgent.log"" /v""INSTALLDIR=\"""& installdir & "\FileAgent\Components\"""" /v""GROUPNAME=OnyxFAUsers"" /v""SERVICEUSERNAME=\"""& ofausernamewithdomain & "\"""" /v""SERVICEPASSWORD="& password & """ /v""/qn/a"""
End If

'Onyx Web Services (GA)
Launch_App "Onyx Web Services",""& installerpath & "\OnyxWebServices\OnyxWebServices.exe", "/s /v""/l*v "& logdir & "\OnyxWebServices.log"" /v""INSTALLDIR=\"""& installdir & "\OnyxWebServices\"""" /v""VIRDIRWEBSERVICE=OEAS_Onyx"" /v""VIRDIRWEBOEAS=OEASAuth_Onyx"" /v""VIRDIRWINSERVICE=OEAS_Windows"" /v""VIRDIRWINOEAS=OEASAuth_Windows"" /v""/qn/a"""

'Onyx Scripting (SP3)
Launch_App "OnyxScripting",""& installerpath & "\OnyxScripting\OnyxScripting.exe", "/s /v""/l*v "& logdir & "\OnyxScripting.log"" /v""VIRTUALDIRWEB=OnyxScripting_Onyx"" /v""VIRTUALDIRWIN=OnyxScripting_Windows"" /v""/qn/a"""

'Onyx 360 Server
Launch_App "Onyx360Server",""& installerpath & "\Onyx360Server\Onyx360Server.exe", "/s /v""/l*v "& logdir & "\Onyx360Server.log"" /v""OEAS_SELECTED=1"" /v""OEDB_SELECTED=1"" /v""OED_SELECTED=1"" /v""SQLSERVER_SERVER="& server & """ /v""SQLSERVER_USERNAME=OnyxDBO"" /v""SQLSERVER_PASSWORD=onyx"" /v""SQLSERVER_DATABASE="& transactiondbname & """ /v""LOGICALAPP="& appname & """ /v""INSTALLDIR=\"""& installdir & "\AppServer\OnyxOutlookSync\"""" /v""/qn/a"""

Wscript.Echo "Onyx 360 Server Post installation steps needs to be applied. Please refer installation guide."

' Onyx 360 Client
Launch_App "Onyx360Client",""& installerpath & "\Onyx360Client\Onyx360Client.exe", "/s /v""/l*v "& logdir & "\Onyx360Client.log"" /v""INSTALLBITFLAG=2"" /v""OEASAUTHWEBSERVICE=http://"& serverhost &"/OEASAuth_Onyx/Service.asmx"" /v""OEASWEBSERVICE=http://"& serverhost &"/OEAS_Onyx/Service.asmx"" /v""OEPLAUNCHERURL=http://"& serverhost &"/onyxemployeeportal_onyx/powerpage/oep_launcher.asp"" /v""OEASAUTHWINSERVICE=http://"& serverhost &"/OEASAuth_Windows/Service.asmx"" /v""OEASWINSERVICE=http://"& serverhost &"/OEAS_Windows/Service.asmx"" /v""APPLICATIONNAME="& appname & """ /v""SITEID=1"" /v""ENABLEONYXAUTHENTICATION=1"" /v""LOGTOFILE=0"" /v""LOGLEVEL=1"" /v""LOGFILERETENTIONDAYS=7"" /v""LOGONYXADMINEMAIL=\""administrator@onyx.dev.avolin.com"""" /v""INSTALLDIR=\"""& installdir & "\Outlook360Addin\"""" /v""/qn/a"""

'Extraction Engine
Launch_App "Extraction Engine",""& installerpath & "\ExtractionEngine\ExtractionEngine.exe", "/s /v""/l*v "& logdir & "\ExtractionEngine.log"" /v""SQLSERVER_SERVER="& server & """ /v""SQLSERVER_USERNAME=OnyxDBO"" /v""SQLSERVER_PASSWORD=onyx"" /v""SQLSERVER_DATABASE="& transactiondbname & """ /v""INSTALLDIR=\"""& installdir & "\ExtractionEngine\"""" /v""/qn/a"""

Wscript.Echo "Extraction Engine Post installation steps needs to be applied. Please refer installation guide."

'Email Accelerator Server
Launch_App "Email Accelerator Server",""& installerpath & "\EmailAcceleratorServer\EmailAcceleratorServer.exe", "/s /v""/l*v "& logdir & "\EmailAcceleratorServer.log"" /v""INSTALLDIR=\"""& installdir & "\Email Accelerator\"""" /v""IS_OEASLOCAL=1"" /v""LOGICALAPP="& appname & """ /v""VIRTUALDIRTIMAGE=Timage"" /v""VIRTUALDIRUNSUBSCRIBE=Unsubscribe"" /v""SERVER="& server & """ /v""OTDB="& transactiondbname & """ /v""SQLLOGIN=OnyxEASSQL"" /v""SQLPASSWORD=onyx"" /v""EMAIL=\""administrator@onyx.dev.avolin.com"""" /v""URL=\""http://"& serverhost &"/unsubscribe/confirmation_sample.asp"""" /v""SITEID=1"" /v""/qn/a"""

'Email Accelerator Client
Launch_App "Email Accelerator Client",""& installerpath & "\EmailAcceleratorClient\EmailAcceleratorClient.exe", "/s /v""/l*v "& logdir & "\EmailAcceleratorClient.log"" /v""INSTALLDIR=\"""& installdir & "\Onyx Email Accelerator\"""" /v""VIRTUALDIR=OnyxEmailAccelerator"" /v""SERVER="& server & """ /v""OTDB="& transactiondbname & """ /v""SQLLOGIN=OnyxEASSQL"" /v""SQLPASSWORD=onyx"" /v""OPTOUTURL=\""http://"& serverhost &"/unsubscribe/default.asp\"""" /v""TIMAGEURL=\""http://"& serverhost &"/timage/"""" /v""SITEID=1"" /v""SMTPSERVER="& exchangeserver &""" /v""/qn/a"""

Wscript.Echo "Email Accelerator Client Post installation steps needs to be applied. Please refer installation guide."

'Change servername in lm_result.js file
RemoveReadOnly ""& installdir & "\EmployeePortal\listmanager\lm_results.js"
ReplaceText ""& installdir & "\EmployeePortal\listmanager\lm_results.js","internalwebserver",""& serverhost &""

'Onyx Processing Server
Launch_App "Onyx Processing Server",""& installerpath & "\OnyxProcessingServer\OnyxProcessingServer.exe", "/s /v""/l*v "& logdir & "\OnyxProcessingServer.log"" /v""IS_OEASLOCAL=1"" /v""LOGICALAPP="& appname & """ /v""VIRTUALDIRWEB=OnyxPSAdmin_Onyx"" /v""VIRTUALDIRWIN=OnyxPSAdmin_Windows"" /v""SITEID=1"" /v""SERVICEUSERNAME=onyx\OPSUser"" /v""SERVICEPASSWORD="& password & """ /v""EXCHANGESERVER="& exchangeserver &""" /v""EMAILFROM=administrator@onyx.dev.avolin.com"" /v""EMAILTO=administrator@onyx.dev.avolin.com"" /v""CHKWARNING=TRUE"" /v""CHKINFORMATION=FALSE"" /v""/qn/a"""

'OPS Config
Launch_App "OPS Configure",""& installerpath & "\OPSConfig\OPSConfig.exe", "/s /v""/l*v "& logdir & "\OPSConfig.log"" /v""LOGICALAPP="& appname & """ /v""SITEID=1"" /v""CHKWARNING=TRUE"" /v""CHKINFORMATION=FALSE"" /v""/qn/a"""

'CTI
Launch_App "CTI",""& installerpath & "\CTI\CTI.exe", "/s /v""/l*v "& logdir & "\CTI.log"" /v""OEDB_SELECTED=1""  /v""OED_SELECTED=1"" /v""OEP_SELECTED=1"" /v""SQLSERVER_SERVER="& server & """ /v""SQLSERVER_USERNAME=onyxdbo"" /v""SQLSERVER_PASSWORD=onyx"" /v""SQLSERVER_DATABASE="& transactiondbname & """ /v""LOGICALAPP="& appname & """ /v""INSTALLDIR=\"""& installdir & "\EmployeePortal"""" /v""/qn/a"""

'Enable CTI Toolbar
RemoveReadOnly ""& installdir & "\EmployeePortal\powerpage\application_main.js"
ReplaceText ""& installdir & "\EmployeePortal\powerpage\application_main.js","var mbEnableCTIToolbar = false","var mbEnableCTIToolbar = true"

Wscript.Echo "CTI Post installation steps needs to be applied. Please refer installation guide."

'ONS
Launch_App "Onyx Notification Service",""& installerpath & "\OnyxNotificationService\OnyxNotificationService.exe", "/s /v""/l*v "& logdir & "\ONS.log"" /v""IS_OEASLOCAL=1"" /v""LOGICALAPP="& appname & """ /v""SERVER="& server & """ /v""OTDB="& transactiondbname & """ /v""OPDB="& persistencedbname & """ /v""SQLLOGIN=OnyxDBO"" /v""SQLPASSWORD=onyx"" /v""PORT=70"" /v""EWSURL="& exchangeserver &""" /v""EWSSSL=0"" /v""EWSDEFAULT=0"" /v""EWSSERVER="& exchangeserver &""" /v""EWSLOGIN=administrator@onyx.dev.avolin.com"" /v""EWSPASSWORD=Aurea2018"" /v""SERVICEUSERNAME="& server & "\OGSUser"" /v""SERVICEPASSWORD="& password & """ /v""/qn/a"""

Quit_App

Function Launch_App(SetupName,strExePath, strArg)
	Dim strScriptPath : strScriptPath = Left(WScript.ScriptFullName, InStrRev(WScript.ScriptFullName, "\")-1)
	Dim WshShell
	Dim FilePath
	Dim fso
	FilePath = strExePath

	Set fso = CreateObject("Scripting.FileSystemObject")

	If (fso.FileExists(FilePath)) Then	
		Set WshShell = CreateObject("WScript.Shell") 		
		WshShell.Run """" & strExePath & """" & " " & strArg,0,True	
	Else
		Wscript.Echo "Installer not found"
	End If
End Function

Function Quit_App()
	WScript.Quit()
End Function

Function ReplaceText(filePath, strOldText, strNewText)
	Const ForReading = 1
	Const ForWriting = 2

	Set objFSO = CreateObject("Scripting.FileSystemObject")

	Set objFile = objFSO.OpenTextFile(filePath, ForReading)

	strText = objFile.ReadAll

	objFile.Close

	strNewText = Replace(strText, strOldText, strNewText)

	Set objFile = objFSO.OpenTextFile(filePath, ForWriting)

	objFile.WriteLine strNewText

	objFile.Close
End Function

Function CreateUserAccount (strUserName, strPassword, strComputer)
	Dim userExists : userExists =  IsUserExists (strUserName, strComputer)	
	if userExists = False Then
	
		set objSystem = GetObject("WinNT://" & strComputer)
		set objUser = objSystem.Create("user", strUserName)
		objUser.SetPassword strPassword
		objUser.SetInfo
		
		CONST ADS_UF_DONT_EXPIRE_PASSWD = &h10000
		
		set objLocalUser = GetObject("WinNT://" & strComputer & "/" & strUserName) 
	 
		intFlags = objLocalUser.GET("UserFlags") 
		intFlags = intFlags OR ADS_UF_DONT_EXPIRE_PASSWD 
		objLocalUser.Put "userFlags", intFlags  
		objLocalUser.SetInfo 
	 
		 
		set objLocalAdmGroup = GetObject("WinNT://" & strComputer & "/Administrators,group") 
		set objLocalUsrmGroup = GetObject("WinNT://" & strComputer & "/Users,group") 
		objLocalAdmGroup.Add(objLocalUser.AdsPath)
		objLocalUsrmGroup.Add(objLocalUser.AdsPath)		
	End If
End Function

Function IsUserExists (strUserName, strComputer)
    Set objDomain = GetObject("WinNT://" & strComputer)
    objDomain.Filter = Array("user")
	Dim returnValue
    For Each User In objDomain	
        If lcase(User.Name) = lcase(strUserName) Then
            returnValue = 1
			Exit For
		Else
			returnValue = 0
        End If				
    Next
	IsUserExists = returnValue
End Function

Function CopyFile(FiletoCopy,DestinationFolder)
	Dim fso
	Dim Filepath,WarFileLocation
	Set fso = CreateObject("Scripting.FileSystemObject")
	
	If  Right(DestinationFolder,1) <>"\"Then
		DestinationFolder=DestinationFolder&"\"
	End If
    
	fso.CopyFile FiletoCopy,DestinationFolder,True
	FiletoCopy = Split(FiletoCopy,"\")

End Function

Function RenameFile(originalFilename,changedFilename)
	Dim objFso  
	Set objFso= CreateObject("Scripting.FileSystemObject")  
	objFso.MoveFile originalFilename, changedFilename
End Function

Function RemoveReadOnly(filePath)
	Const ReadOnly = 1
	Set objFSO = CreateObject("Scripting.FileSystemObject")
	Set objFile = objFSO.GetFile(filePath)
	If objFile.Attributes AND ReadOnly Then
		objFile.Attributes = objFile.Attributes XOR ReadOnly
	End If
End Function
Set colArgs = WScript.Arguments.Named

installerpath = colArgs.Item("installerpath")
installdir = colArgs.Item("installdir")
logdir = colArgs.Item("logdir")
appname = colArgs.Item("appname")
serverhost = colArgs.Item("serverhost")

Wscript.Echo installerpath
Wscript.Echo installdir
Wscript.Echo logdir
Wscript.Echo appname
Wscript.Echo serverhost

' Onyx 360 Client
Launch_App "Onyx360Client",""& installerpath & "\Onyx360Client\Onyx360Client.exe", "/s /v""/l*v "& logdir & "\Onyx360Client.log"" /v""INSTALLBITFLAG=2"" /v""OEASAUTHWEBSERVICE=http://"& serverhost &"/OEASAuth_Onyx/Service.asmx"" /v""OEASWEBSERVICE=http://"& serverhost &"/OEAS_Onyx/Service.asmx"" /v""OEPLAUNCHERURL=http://"& serverhost &"/onyxemployeeportal_onyx/powerpage/oep_launcher.asp"" /v""OEASAUTHWINSERVICE=http://"& serverhost &"/OEASAuth_Windows/Service.asmx"" /v""OEASWINSERVICE=http://"& serverhost &"/OEAS_Windows/Service.asmx"" /v""APPLICATIONNAME="& appname & """ /v""SITEID=1"" /v""ENABLEONYXAUTHENTICATION=1"" /v""LOGTOFILE=0"" /v""LOGLEVEL=1"" /v""LOGFILERETENTIONDAYS=7"" /v""LOGONYXADMINEMAIL=\""administrator@onyx.dev.avolin.com"""" /v""INSTALLDIR=\"""& installdir & "\Outlook360Addin\"""" /v""/qn/a"""

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
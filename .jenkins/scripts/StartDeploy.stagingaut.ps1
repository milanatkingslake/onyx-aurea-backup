$host_type=$args[0]
$install_mode=$args[1]
$setup_oeas=$args[2]
$setup_ofa=$args[3]

Write-Host "Host type: $($host_type)"
Write-Host "Installation Mode: $($install_mode)"
Write-Host "Setup OEAS: $($setup_oeas)"
Write-Host "Setup OFA: $($setup_ofa)"

if ($host_type -eq "client") {
    Write-Host "Running client script..."
    C:\Windows\System32\cscript.exe C:\installers\OnyxClientSilentInstaller.vbs /installerpath:"C:\installers" /installdir:"C:\Program Files\Onyx" /logdir:"c:\installers" /appname:"Onyx" /server:"ONYXSTGAUTCLNT" /usernamewithdomain:"ONYXSTGAUTCLNT\Administrator" /ofausernamewithdomain:"ONYXSTGAUTCLNT\OnyxFAUser" /password:"Changeme123!" /serverhost:"10.25.180.204" /transactiondbname:"OEDB" /persistencedbname:"PersistenceDB" /isinstalloedb:"False" /isoedbfreshinstall:"False" /isinstalloeas:"False" /isinstalloeasconfig:"False" /isinstallfileagent:"False" /exchangeserver:"10.25.180.150" /oepmode:$install_mode
} else {
    Write-Host "Running complete script..."
    C:\Windows\System32\cscript.exe C:\installers\OnyxSilentInstaller.vbs /installerpath:"C:\installers" /installdir:"C:\Program Files\Onyx" /logdir:"c:\installers" /appname:"Onyx" /server:"onyx-test7" /usernamewithdomain:"onyx-test7\Administrator" /ofausernamewithdomain:"onyx-test7\OnyxFAUser" /password:"Changeme123!" /serverhost:"10.25.180.204" /transactiondbname:"OEDB" /persistencedbname:"PersistenceDB" /isinstalloedb:"False" /isoedbfreshinstall:"False" /isinstalloeas:$setup_oeas /isinstalloeasconfig:"False" /isinstallfileagent:$setup_ofa /exchangeserver:"10.25.180.150" /oepmode:$install_mode
}

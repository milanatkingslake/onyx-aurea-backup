setlocal

SET source=%1
SET dest=%2

xcopy "%source%\Onyx.UI\BuildScripts\Output\oep" "%dest%\OEPx64\Website\" /S /E /Y /q
xcopy "%source%\OEP_UI\Online\source\LanguageIndependent\Website" "%dest%\OEPx64\Website\" /S /E /Y /q
xcopy "%source%\OEP_UI\Online\source\English\Website\*.*" "%dest%\OEPx64\Website\" /S /E /Y /q

xcopy "%source%\Onyx.UI\Onyx.UI\Onyx.UI\Client\build\production\Login" "%dest%\OEPx64\Website\common\Login\" /S /E /Y /q
xcopy "%source%\Onyx.UI\Onyx.UI\Onyx.UI\Client\build\production\HomePage" "%dest%\OEPx64\Website\homepage\" /S /E /Y /q
xcopy "%source%\Onyx.UI\Onyx.UI\Onyx.UI\Client\build\production\Notification" "%dest%\OEPx64\Website\preferences\Notification\" /S /E /Y /q


xcopy "%source%\Installers\StagingFiles\OEPx64\Website\Help" "%dest%\OEPx64\Website\Help\" /S /E /Y /q


mkdir "%dest%\OEPx64\ucf"
xcopy "%source%\OEP_UI\Online\source\LanguageIndependent\DLLs\ucf\BuildScripts\Output\*.dll" "%dest%\OEPx64\ucf\" /S /E /Y /q
copy "%source%\OEP_UI\Online\source\LanguageIndependent\DLLs\ucf\UcfDynamicForms\BuildScripts\Output\Onyx.Ucf.ScriptCreatorAsp.dll" "%dest%\OEPx64\ucf\"
mkdir "%dest%\OEPx64\OEP_Shared"
xcopy "%source%\OEP_UI\Online\source\LanguageIndependent\DLLs\ucf\BuildScripts\Output\*.dll" "%dest%\OEPx64\OEP_Shared\" /S /E /Y /q
copy "%source%\OEP_UI\Online\source\LanguageIndependent\DLLs\OEPShared\Output\Release\x64\LIB\OEPEncrypt.dll" "%dest%\OEPx64\OEP_Shared\"
copy "%source%\OEP_UI\Online\source\LanguageIndependent\DLLs\OEPShared\Output\Release\x64\LIB\OnyxUtils.dll" "%dest%\OEPx64\OEP_Shared\"
xcopy "%source%\ThirdParty\aspupload64.dll" "%dest%\OEPx64\OEP_Shared\" /S /E /Y /q
copy "%source%\OEP_UI\Online\source\LanguageIndependent\DLLs\ucf\UcfDynamicForms\BuildScripts\Output\Onyx.Ucf.ScriptCreatorAsp.dll" "%dest%\OEPx64\OEP_Shared\"
xcopy "%source%\Installers\StagingFiles\OnyxScripting\bin\Microsoft.Web.Infrastructure.dll" "%dest%\OEPx64\Website\bin\" /S /E /Y /q
mkdir "%dest%\OEPx64\Website\Campaigns\Mode2"
mkdir "%dest%\OEPx64\Website\common\include\resources\locale"
copy "%source%\OEP_UI\Online\source\LanguageIndependent\Website\common\include\httpheaders.asp" "%dest%\OEPx64\Website\common\include\resources\locale\"
mkdir "%dest%\OEPx64\Website\eng\common\javascript"
copy "%source%\ThirdParty\microloader.jsp" "%dest%\OEPx64\Website\common\Login"
mkdir "%dest%\OEPx64\Website\common\Login\classic\resources\OnyxUtilities"

mkdir "%dest%\OEPx64\Website\homepage\classic\resources\OnyxUtilities"
mkdir "%dest%\OEPx64\Website\homepage\classic\resources\libraries"
copy "%source%\ThirdParty\microloader.jsp" "%dest%\OEPx64\Website\homepage"

mkdir "%dest%\OEPx64\Website\preferences\Notification\classic\resources\OnyxUtilities"
copy "%source%\ThirdParty\microloader.jsp" "%dest%\OEPx64\Website\preferences\Notification\"
mkdir "%dest%\OEPx64\Website\worknotes\images"
mkdir "%dest%\OEPx64\Website\ucf\data\custom"
mkdir "%dest%\OEPx64\Website\ucf\data\layers\active"

REM get rid of Installer\StaginFiles copying. Use only build artifacts.
xcopy "%source%\Installers\StagingFiles\OEPx64\Website\Login\*.*" "%dest%\OEPx64\Website\common\Login\" /S /E /Y /q
xcopy "%source%\Installers\StagingFiles\OEPx64\Website\homepage\*.*" "%dest%\OEPx64\Website\homepage\" /S /E /Y /q
xcopy "%source%\Installers\StagingFiles\OEPx64\Website\Notification\*.*" "%dest%\OEPx64\Website\preferences\Notification\" /S /E /Y /q

REM Navigator Staging Area
xcopy "%source%\Onyx.UI\Onyx.UI\Onyx.UI\Client\build\production\Navigator" "%dest%\OEPx64\Website\Quicksearch\" /S /E /Y /q
xcopy "%source%\OEP_UI\Online\source\LanguageIndependent\Website\QuickSearch\*.*" "%dest%\OEPx64\Website\Quicksearch\" /S /E /Y /q
copy "%source%\ThirdParty\microloader.jsp" "%dest%\OEPx64\Website\Quicksearch"

call "%source%\OEP_UI\Online\source\LanguageIndependent\DLLs\ucf\BuildScripts\UcfPublish.bat" "%source%" "%dest%\OEPx64\Website"
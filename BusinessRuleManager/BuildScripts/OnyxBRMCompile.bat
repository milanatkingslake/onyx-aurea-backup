@ECHO on

ECHO Windows 10.1 SDK should be installed to run the batch script
ECHO TLBIMP.exe is available in "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools"

SET PATH=%PATH%;C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools;

REM EXECUTE THE BATCH FILE
call "%Vs2017ToolsDir%\VsDevCmd.bat"

ECHO *************************************************************************************************************
ECHO Starting OGS Compilation

..\..\.jenkins\utils\nuget\NuGet.exe restore ..\Engine\BusinessRuleManager.sln || exit /b 1

MSBUILD ..\Engine\BusinessRuleManager.sln /p:Configuration=Release /p:Platform="Any CPU" /t:Rebuild  /p:Outdir=%CD%\Output

XCOPY ..\Engine\Shared %CD%\Output

ECHO END OGS Compilation
ECHO *************************************************************************************************************

if errorlevel 1 (
	exit 1
) else (
	exit 0
)

@ECHO on

ECHO Windows 10 SDK should be installed to run the batch script
ECHO TLBIMP.exe is available in "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools"

SET PATH=%PATH%;C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.1 Tools;

REM EXECUTE THE BATCH FILE
call "%Vs2017ToolsDir%\VsDevCmd.bat"
REM   ==============================================================
TITLE Building Timage 
REM   ==============================================================
MSBUILD ..\Code\Build\_LanguageIndependant\TImage\ImageTrackerHandler.sln /p:Configuration=Release /t:Rebuild /p:Outdir=%CD%\Output 

if errorlevel 1 (
	exit 1
) else (
	exit 0
)

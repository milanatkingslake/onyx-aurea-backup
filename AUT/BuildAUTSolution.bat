@ECHO on

REM EXECUTE THE BATCH FILE
call "%Vs2017ToolsDir%\VsDevCmd.bat"
@echo on

@set ONYX_ROOT=%~dp0..

cd /d %~dp0

%ONYX_ROOT%\.jenkins\utils\nuget\nuget.exe restore Avolin.Onyx.AUT.Tests.sln
if errorlevel 1 exit /b 1

MSBUILD Avolin.Onyx.AUT.Tests.sln /p:Configuration=Debug /p:Platform="Any CPU" /t:Rebuild 
if errorlevel 1 exit /b 1

exit /b 0

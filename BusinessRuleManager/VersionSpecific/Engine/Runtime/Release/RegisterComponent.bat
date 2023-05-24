echo off

REM Use this for .Net 2.0
REM %SystemRoot%\Microsoft.NET\Framework\v2.0.50727\RegSvcs.exe /noreconfig /extlb:OnyxCSStepTemplate.tlb bin\Debug\OnyxCSStepTemplate.dll

echo Registering component with COM+ Services
echo.
echo  - This will create the COM+ library application automatically if it does 
echo    not exist already. You will still need to configure security on it
echo.
echo  - If this batch file does not work, you might need to change the path 
echo    to the RegSvcs.exe file if you have a newer version of .NET installed
echo.

REM This is the core Business Rule Manager
%SystemRoot%\Microsoft.NET\Framework\v2.0.50727\RegSvcs.exe /noreconfig ConsonaCRM.BusinessRuleManager.dll


pause

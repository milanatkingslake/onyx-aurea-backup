
REM   ==============================================================
TITLE Building Timage 
REM   ==============================================================

%msbuildpath%msbuild %BLD_drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code\_LanguageIndependant\TImage\ImageTrackerHandler.sln /t:Rebuild /p:Configuration=Debug
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

%msbuildpath%msbuild %BLD_drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code\_LanguageIndependant\TImage\ImageTrackerHandler.sln /t:Rebuild /p:Configuration=Release
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

GOTO DONE

:ERROREND
@ECHO ***BuildError***
@ECHO ErrorLevel is:  %ErrorLevel%
pause
GOTO DONE

:DONE
TITLE Building Timage Complete
@ECHO End of TImage_msbuild.bat Script
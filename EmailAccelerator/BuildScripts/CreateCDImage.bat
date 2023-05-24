
SET BASE_DIR=%BLD_Drive%:\Email_Accelerator\Finished_Builds\%BLD_LABEL_VSS%

md %BASE_DIR%
md %BASE_DIR%\Code
md %BASE_DIR%\Code\OEP\listmanager
md %BASE_DIR%\Code\OEP\res\listmanager
md %BASE_DIR%\Code\OEP\res
md %BASE_DIR%\Code\OnyxEmailAccelerator
md %BASE_DIR%\Code\SQL
md %BASE_DIR%\Code\TImage
md %BASE_DIR%\Code\TImage\bin
md %BASE_DIR%\Code\TImage\images
md %BASE_DIR%\Code\Unsubscribe
md %BASE_DIR%\Documentation
md "%BASE_DIR%\Sample Email Templates"
md %BASE_DIR%\Code\OED
md %BASE_DIR%\Documentation
md "%BASE_DIR%\Sample Email Templates"


SET fromDir=%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%

xcopy %fromDir%\Code\_LanguageIndependant\OEP_UI\listmanager\*.* %BASE_DIR%\Code\OEP\listmanager /E /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

xcopy %fromDir%\Code\English\OEP_UI\res\listmanager\*.* %BASE_DIR%\Code\OEP\res\listmanager /E /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

xcopy %fromDir%\Code\_LanguageIndependant\OnyxEmailAccelerator\*.* %BASE_DIR%\Code\OnyxEmailAccelerator /E /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

copy %fromDir%\Code\_LanguageIndependant\SQL\Combined\AcceleratorBuildScript.sql %BASE_DIR%\Code\SQL /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

copy %fromDir%\Code\_LanguageIndependant\TImage\bin\Release\ImageTrackerHandler.dll %BASE_DIR%\Code\TImage\bin /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

copy %fromDir%\Code\_LanguageIndependant\TImage\web.config %BASE_DIR%\Code\TImage /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

copy %fromDir%\Code\_LanguageIndependant\TImage\images\space.gif %BASE_DIR%\Code\TImage\images /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

copy %fromDir%\Code\_LanguageIndependant\Unsubscribe\*.* %BASE_DIR%\Code\Unsubscribe /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

copy "%fromDir%\Product Docs\OnyxEmailAcceleratorSystemAdministratorGuide.pdf" %BASE_DIR%\Documentation /Y
IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

xcopy "%fromDir%\Code\English\Sample Email Templates\*.*" "%BASE_DIR%\Sample Email Templates" /E /Y

xcopy "%fromDir%\Code\English\MasterDictionary\*.*" "%BASE_DIR%\Code\OED" /E /Y

IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

GOTO DONE

%buildDrive%
cd %BLD_Drive%:\Email_Accelerator\BuildScripts


REM   ###################################################################################
:ERROREND
REM   ###################################################################################
@ECHO ***BuildError***
pause
GOTO DONE


REM   ###################################################################################
:DONE
REM   ###################################################################################
@ECHO Build Create CD Image Script Complete.

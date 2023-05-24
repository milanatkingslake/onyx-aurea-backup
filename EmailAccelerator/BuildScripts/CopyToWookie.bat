

REM If NOT EXIST "\\wookie\builds\Onyx\EmailAccelerator\version %BLD_VER_MAJOR%.%BLD_VER_MINOR%\%BLD_LANG_LONG%\%BLD_LABEL_VSS%\CD" md "\\wookie\builds\EmailAccelerator\version %BLD_VER_MAJOR%.%BLD_VER_MINOR%\%BLD_LANG_LONG%\%BLD_LABEL_VSS%\CD"

If NOT EXIST "\\qalab.local\crm\builds\sandbox\Onyx\EmailAccelerator\version %BLD_VER_MAJOR%.%BLD_VER_MINOR%\%BLD_LANG_LONG%\%BLD_LABEL_VSS%\CD" md "\\qalab.local\crm\builds\sandbox\Onyx\EmailAccelerator\version %BLD_VER_MAJOR%.%BLD_VER_MINOR%\%BLD_LANG_LONG%\%BLD_LABEL_VSS%\CD"

IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

xcopy %BLD_Drive%:\Email_Accelerator\Finished_Builds\%BLD_LABEL_VSS%\*.* "\\qalab.local\crm\builds\sandbox\onyx\EmailAccelerator\version %BLD_VER_MAJOR%.%BLD_VER_MINOR%\%BLD_LANG_LONG%\%BLD_LABEL_VSS%\CD" /E /Y

IF NOT %ERRORLEVEL% == 0 GOTO ERROREND

GOTO DONE

REM   ###################################################################################
:ERROREND
REM   ###################################################################################
@ECHO ***BuildError***
GOTO DONE


REM   ###################################################################################
:DONE
REM   ###################################################################################
@ECHO Copy To Wookie Script Complete.

TITLE GET OEP_Wireless Source from Visual Source Safe
SET vssDbPath=\\dumbo\EmailAccelerator
SET SSUSER=toolg
SET SSDIR=\\dumbo\EmailAccelerator
SET vssLabel=%BLD_LABEL_VSS%

REM   ==========================================================================================
TITLE  Get $/Rivendell/Code/Build
REM   ==========================================================================================
ss cp $/
IF %ErrorLevel% == 0 GOTO CommonExists
@ECHO VSS Project %vssPath% cannot be found!
GOTO ERROREND
:CommonExists

ss cp "$/Rivendell/Code/Build"
IF %ErrorLevel% == 0 GOTO LIExists
@ECHO VSS Project %vssPath% cannot be found!
GOTO ERROREND
:LIExists

IF NOT EXIST "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code" MD "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code" 
cd /d "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code"

@ECHO Start %BLD_LABEL_VSS% GET of %BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code
ss Get *.* -o- -nl -r -gwr -i-y -VL%vssLabel%
IF %ErrorLevel% == 0 GOTO GetLIOK
@ECHO Get Failed!
GOTO ERROREND
:GetLIOK

attrib -S -H -r *.* /s
del *.scc /s /q >nul

IF NOT EXIST "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code" goto ERROREND

REM   ==========================================================================================
TITLE  Copy Product Docs
REM   ==========================================================================================

IF NOT EXIST "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Product Docs" MD "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Product Docs" 
cd /d "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Product Docs"

copy "\\wookie\ProductDocs\EmailAccelerator\version %BLD_VER_MAJOR%.%BLD_VER_MINOR%\%BLD_LANG_DOCS%\%DOC_Version%\OnyxEmailAcceleratorSystemAdministratorGuide.pdf" "%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Product Docs" /Y
IF %ErrorLevel% == 0 GOTO CopyDocOK
GOTO ERROREND

:CopyDocOK

REM   ==========================================================================================
goto   DONE
REM   ==========================================================================================


:ERROREND
@echo ***BuildError***
@echo Get from VSS failed !!!
goto DONE

:DONE
TITLE Done with vss get script

@ECHO VSS_get script complete.

%buildDrive%
cd %BLD_Drive%:\Email_Accelerator\BuildScripts
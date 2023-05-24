TITLE GET Email Accelerator Source from TFS
SET vssLabel=%PARAM1%

set localPath=%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code
set TFSPath="$/%tfsProject%/%tfsBranch%/EmailAccelerator/Code/Build"
REM   ==========================================================================================
TITLE  Get %TFSPath%
REM   ==========================================================================================
@ECHO Start %BLD_LABEL_VSS% GET of %TFSPath% 
if not exist %localPath% MD %localPath%
pushd %localPath%
tf get %tfsPath% /version:L%BLD_LABEL_VSS% /force /recursive /noprompt
popd
IF %ErrorLevel% == 0 GOTO Get2
@ECHO Get Failed!
GOTO ERROREND

:Get2


set localPath="%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Product Docs"
set TFSPath="$/%tfsProject%/%tfsBranch%/EmailAccelerator/ProductDocs"
REM   ==========================================================================================
TITLE  Get %TFSPath%
REM   ==========================================================================================
@ECHO Start %BLD_LABEL_VSS% GET of %TFSPath% 
if not exist %localPath% MD %localPath%
pushd %localPath%
tf get %tfsPath% /version:L%BLD_LABEL_VSS% /force /recursive /noprompt
popd
IF %ErrorLevel% == 0 GOTO Done
@ECHO Get Failed!
GOTO ERROREND



REM   ==========================================================================================
goto   DONE
REM   ==========================================================================================

:ERROREND
@echo ***BuildError***
@echo Get from TFS failed !!!
goto DONE

:DONE
@ECHO TFSGetFromLabelCore.bat complete.

Attrib -R "%BLD_Drive%:\Email_Accelerator\*.*" /S
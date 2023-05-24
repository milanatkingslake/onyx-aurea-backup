REM **********************************************************************
REM Creates the working folders and mappings used by the build tool
REM for the "Email Broadcaser " build.  
REM
REM The following folders in TFS are used in this build and we will create
REM a workfolder for each:
REM 1) $/%tfsProject%/%tfsBranch%/OeasSqlGen/Build/common/_LanguageIndependent
REM 2) $/%tfsProject%/%tfsBranch%/OeasSqlGen/Build/sqlsvr/_LanguageIndependent
REM 3) $/%tfsProject%/%tfsBranch%/OES/Build/_LanguageIndependent
REM 4) $/%tfsProject%/%tfsBranch%/OeasSqlGen/Dependencies
REM 5) $/%tfsProject%/%tfsBranch%/OeasSqlGen/Build/sqlsvr/English/MasterDictionary
REM 6) $/%tfsProject%/dev/Navigator/Navigator-Client	
REM **********************************************************************

set localPath=%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Code
set tfsPath="$/%tfsProject%/%tfsBranch%/EmailAccelerator/Code/Build"
REM   ==========================================================================================
TITLE  Create workfolder for %tfsPath%
REM   ==========================================================================================
tf workfold %tfsPath% %localPath% /workspace:%tfsWorkspace%
IF %ErrorLevel% == 0 GOTO CreateFold2
@ECHO Creation of Workfolder %tfsPath% Failed - error number %ErrorLevel%
GOTO ERROREND

:CreateFold2

set localPath="%BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS%\Product Docs"
set tfsPath="$/%tfsProject%/%tfsBranch%/EmailAccelerator/ProductDocs"
REM   ==========================================================================================
TITLE  Create workfolder for %tfsPath%
REM   ==========================================================================================
tf workfold %tfsPath% %localPath% /workspace:%tfsWorkspace%
IF %ErrorLevel% == 0 GOTO Done
@ECHO Creation of Workfolder %tfsPath% Failed - error number %ErrorLevel%
GOTO ERROREND


:ERROREND
@ECHO ***BuildError***  Error creating TFS workfolders!

:DONE
@ECHO Script TFSCreateWorkingFoldersEmail.bat Complete

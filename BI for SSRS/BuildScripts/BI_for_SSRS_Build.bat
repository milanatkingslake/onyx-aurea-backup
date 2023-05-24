
REM **************************************************************
REM REM The following need to be configured for the BI for SSRS builds

REM tfsServer 			= the TFS server name
REM tfsWorkspace 		= name of the workspace to do this build in.
REM buildDrive 			= buildDrive=local HD for build
REM projectName 		= the name of the TFS team project that the code is in.
REM branchName 			= the branch that he code is in.
REM tfsFolder			= folder name on TFS for the code
REM tfsRootPath			= the root TFS path of the project
REM codeLabel 			= the label to use on the code, typically the version number
REM codeLabelComment 	= a comment used when labelling the code
REM buildFolder 		= manual build folder name
REM localSourceFolder	= the location to get the code for build
REM stagePath			= the local staging directory
REM networkStagePath	= the network build staging area, e.g. "build sandbox" 

set tfsServer=lab-tfs-001
set tfsWorkspace=SSRSBuild
set buildDrive=C
set projectName=CCM
set branchName=Main
set tfsFolder="BI for SSRS"
set tfsRootPath=$/%projectName%/%branchName%/%tfsFolder%
set codeLabel=SSRS_2.00.001
set codeLabelComment="Automated step as part of BI for SSRS build."
set buildFolder=%buildDrive%:\_ManualBuild\SSRS
set localSourceFolder=%buildFolder%\source
set stagePath=%buildDrive%:\_BuildStaging\SSRS\%codeLabel%
set networkStagePath="\\qalab.local\crm\builds\SANDBOX\ONYX\BI for SSRS\version 2.0\English\%codelabel%"


:Step1
set step=1
REM **************************************************************
REM Step 1 - set up the TFS environment
REM Delete the previous workspace if it exists
tf workspace /delete /noprompt /server:%tfsServer% %tfsWorkspace%

REM Create a new local folder and map it to a TFS workspace
if exist %localSourceFolder% RMDIR /S /Q %localSourceFolder%
if not exist %localSourceFolder% MD %localSourceFolder%
pushd %localSourceFolder%

REM create the workspace
tf workspace /new /noprompt /server:lab-tfs-001 %tfsWorkspace% /comment:%codeLabelComment%

IF %ErrorLevel% == 0 GOTO CreateWorkspaceOK
@ECHO ERROR - Step 1 - Creation of Workspace Failed - error number %ErrorLevel%
GOTO ERROREND

:CreateWorkspaceOK
REM Create the workFolder for the build.
tf workfold %tfsRootPath% %localSourceFolder% /workspace:%tfsWorkspace%

IF %ErrorLevel% == 0 GOTO Step2
@ECHO ERROR -  Step 1 - Creation of Workfolder Failed - error number %ErrorLevel%
GOTO ERROREND


:Step2
set step=2
REM **************************************************************
REM Step 2 - Label code in TFS
tf label %codeLabel% %tfsRootPath% /recursive /child:merge /comment:%codeLabelComment%

IF %ErrorLevel% == 0 GOTO Step3
@ECHO ERROR -  Step 2 - Failed to Label code
GOTO ERROREND


:Step3
set step=3
REM **************************************************************
REM Step 3 - Get code from label
if not exist %localSourceFolder% MD %localSourceFolder%
pushd %localSourceFolder%

tf get %tfsRootPath%/BIDS-Project-OnyxOEDB /version:L%codeLabel% /force /recursive /noprompt
tf get %tfsRootPath%/code /version:L%codeLabel% /force /recursive /noprompt
tf get %tfsRootPath%/ReportBuilder /version:L%codeLabel% /force /recursive /noprompt

IF %ErrorLevel% == 0 GOTO Step4
@ECHO ERROR -  Step 3 - Source Get Failed!
GOTO ERROREND


:Step4
set step=4
REM **************************************************************
REM Step 4 Concatenate SQL files
cd %localSourceFolder%\code
echo | type *.sql > %localSourceFolder%\OEDBModelViews.sql

IF %ErrorLevel% == 0 GOTO Step5
@ECHO ERROR - Step 4 - Concatenate failed!
GOTO ERROREND


:Step5
set step=5
REM **************************************************************
REM Step 5 - Create Staging folder structure
if exist %stagePath% RMDIR /S /Q %stagePath%
MD %stagePath%
MD %stagePath%\Documentation
MD %stagePath%\"OEDB Scripts"
MD %stagePath%\"Onyx Model for SSRS"
MD %stagePath%\"Onyx Sample Reports"

IF %ErrorLevel% == 0 GOTO Step6
@ECHO ERROR -  Step 5 - build staging folder creation failed.
GOTO ERROREND


:Step6
set step=6
REM **************************************************************
REM Step 6 - Copy required files to staging structure

robocopy %localSourceFolder% "%stagePath%\OEDB Scripts" OEDBModelViews.sql /NP
robocopy %localSourceFolder%\BIDS-Project-OnyxOEDB "%stagePath%\Onyx Model for SSRS" /S /NP /XF OnyxOEDB.smdlproj.user
robocopy %localSourceFolder%\ReportBuilder "%stagePath%\Onyx Sample Reports" /S /NP

SET RoboError=%ErrorLevel%
REM Robocopy has many return codes, only those greater or equal to 8 should cause concern
IF NOT %RoboError% GEQ 8 SET %ErrorLevel=0
IF %ErrorLevel% == 0 GOTO Step7
@ECHO ERROR -  Step 6 - copy to local staging area failed.
GOTO ERROREND


:Step7
set step=7
REM **************************************************************
REM Step 7 - Get Documentation Deliverables

REM README to root stage folder
set copyLocation="\\qalab.local\crm\documentation\ONYX\6.0 and earlier\Onyx BI for SSRS\version 1.00\Readme"
xcopy %copyLocation% %stagePath%

REM Installation Guide to documentation folder
set copyLocation="\\qalab.local\crm\documentation\ONYX\6.0 and earlier\Onyx BI for SSRS\version 1.00\Installation Guide\Onyx BI 1.0 for SSRS Installation Guide.pdf"
xcopy %copyLocation% %stagePath%\Documentation

REM System Requirements to documentation folder
set copyLocation="\\qalab.local\crm\documentation\ONYX\6.0 and earlier\Onyx BI for SSRS\version 1.00\System Requirements"
xcopy %copyLocation% %stagePath%\Documentation

IF %ErrorLevel% == 0 GOTO Step8
@ECHO ERROR -  Step 7 - documentation copy failed.
GOTO ERROREND


:Step8
set step=8
REM **************************************************************
REM Step 8 - Copy entire build stage to a network share
robocopy %stagePath% %networkStagePath% /S /NP

SET RoboError=%ErrorLevel%
REM Robocopy has many return codes, only those greater or equal to 8 should cause concern
IF NOT %RoboError% GEQ 8 SET %ErrorLevel=0
IF %ErrorLevel% == 0 GOTO DONE
@ECHO ERROR -  Step 8 - copy to network staging area failed.
GOTO ERROREND


REM **************************************************************
:ERROREND
@ECHO ***BuildError***  in step %step%


:DONE
popd
@ECHO Script Complete

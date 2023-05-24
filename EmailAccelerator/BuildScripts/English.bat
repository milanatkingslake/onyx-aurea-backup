@echo off
REM Run this batch file, not Build_CopyFiles.bat

set BLD_LANG_LONG=English
set BLD_Short_Name=ENG
set BLD_VER_MAJOR=7
set BLD_VER_MINOR=01
set BLD_VER_RELEASE=072
set BLD_VER_RELEASE_REVISION=
set BLD_LANG_DOCS=%BLD_LANG_LONG%
set BLD_Drive=d
set BLD_LABEL_VSS=EA%BLD_VER_MAJOR%.%BLD_VER_MINOR%.%BLD_VER_RELEASE%%BLD_VER_RELEASE_REVISION%
REM SET BLD_VSS_DB=\\dumbo\EmailAccelerator
REM SET BLD_VSS_USER=toolg
REM SET BLD_VSS_PASSWORD=OnyxBuild
SET projectName=Unity
SET tfsServer=lab-tfs-001
SET tfsProject=CCM
SET tfsBranch=Main
SET tfsWorkspace=Email_Accelerator
SET msbuildpath=C:\WINNT\Microsoft.NET\Framework\v2.0.50727\

REM Delete old source
RD %BLD_Drive%:\Email_Accelerator\Source\%BLD_LABEL_VSS% /S /Q


%BLD_Drive%:
cd %BLD_Drive%:\Email_Accelerator\BuildScripts

call TFSCreateWorkspaceEmail.cmd

call TFSCreateWorkingFoldersEmail.cmd

call TFSApplyBuildLabelToEmail.cmd

call TFSGetFromLabelEmail.cmd

Call TImage_msbuild.bat

Call CreateCDImage.bat

Call CopyToWookie.bat

pause










REM **********************************************************************
REM Creates the TFS workspace used by the build tool for the "Email Broadcaster" build.  
REM **********************************************************************

tf workspace /delete /noprompt /server:lab-tfs-001 %tfsWorkspace%
if NOT EXIST %BLD_Drive%:\Email_Accelerator MD %BLD_Drive%:\Email_Accelerator
Pushd %BLD_Drive%:\Email_Accelerator
tf workspace /new /noprompt /server:lab-tfs-001 %tfsWorkspace% /comment:"Automatically created by build step TFSCreateWorkspaceEmail.cmd"

IF %ErrorLevel% == 0 GOTO CreateWorkspaceOK
@ECHO Creation of Workspace Failed - error number %ErrorLevel%
GOTO ERROREND

:CreateWorkspaceOK
tf workfold /server:lab-tfs-001 /workspace:%tfsWorkspace%  /unmap $/
IF %ErrorLevel% == 0 GOTO DONE
@ECHO Creation of Workspace Failed - error number %ErrorLevel%
GOTO ERROREND

:ERROREND
@ECHO ***BuildError***  Error creating TFS workspace!

:DONE
Popd
@ECHO Script TFSCreateWorkspace.bat Complete

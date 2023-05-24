TITLE Apply Build Label to Email Accelerator
@ECHO ON

REM SET BLD_VSS_LABEL=%BLD_LABEL_VSS%

SET BLD_VSS_LABEL_COMMENT="Labelled by build script as part of Email Accelerator build."

REM  =====================================================================
TITLE Labeling $/%tfsProject%/%tfsBranch%/EmailAccelerator
REM  =====================================================================
tf label %BLD_LABEL_VSS% "$/%tfsProject%/%tfsBranch%/EmailAccelerator" /server:%tfsServer% /recursive /child:merge /comment:%BLD_VSS_LABEL_COMMENT%
IF %ErrorLevel% EQU 0 GOTO LABEL1
@ECHO ***BuildError*** FAILED to Label $/%tfsProject%/%tfsBranch%/EmailAccelerator
GOTO ERROREND
:LABEL1
@ECHO $/%tfsProject%/%tfsBranch%/EmailAccelerator Labeled Successfully




REM  =====================================================================
GOTO DONE
REM  =====================================================================

:ERROREND
@ECHO ***BuildError***  Error with Labeling!

:DONE
SET BLD_VSS_LABEL=
@ECHO Script TFSApplyBuildLabelToEmail Complete
@ECHO %ErrorLevel%
TITLE Apply Build Label to OEP_Wireless VSS Projects
@ECHO ON
SET vssDbPath=\\dumbo\EmailAccelerator
SET SSUSER=toolg
SET SSDIR=\\dumbo\EmailAccelerator
SET vssLabel=%BLD_LABEL_VSS%

REM  =====================================================================
TITLE Labeling $/Rivendell/Code/Build
REM  =====================================================================
ss cp $/
ss label "$/Rivendell/Code/Build" -L%vssLabel% -I- -C- > nul
IF %ErrorLevel% EQU 0 GOTO LABEL1
@ECHO ***BuildError*** FAILED to Label $/Rivendell/Code/Build
GOTO ERROREND
:LABEL1
@ECHO $/Rivendell/Code/Build Labeled Successfully

REM  =====================================================================
TITLE Labeling $/Rivendell/Code/Sandbox
REM  =====================================================================
ss cp $/
ss label "$/Rivendell/Code/Sandbox" -L%vssLabel% -I- -C- > nul
IF %ErrorLevel% EQU 0 GOTO LABEL2
@ECHO ***BuildError*** FAILED to Label $/Rivendell/Code/Sandbox
GOTO ERROREND
:LABEL2
@ECHO $/Rivendell/Code/Sandbox Labeled Successfully


REM  =====================================================================
TITLE Labeling $/Rivendell/Product Docs
REM  =====================================================================
ss cp $/
ss label "$/Rivendell/Product Docs" -L%vssLabel% -I- -C- > nul
IF %ErrorLevel% EQU 0 GOTO LABEL3
@ECHO ***BuildError*** FAILED to Label $/Rivendell/Product Docs
GOTO ERROREND
:LABEL3
@ECHO $/Rivendell/Product Docs Labeled Successfully

:ERROREND
@ECHO ***BuildError***  Error with Labeling!

:DONE
@ECHO Script vss_label Complete
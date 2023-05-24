@ECHO on
SET SOURCEPATH=C:\TFS\Onyx\Main\BusinessRuleManager\BuildScripts\Output
SET DESTINATIONPATH=C:\TFS\Onyx\Main\Symbols\BusinessRuleManager
ECHO *************************************************************************************************************
ECHO Starting BRM Compilation

ROBOCOPY /S "%SOURCEPATH%" "%DESTINATIONPATH%" *.pdb /LOG+:PDBCopy.txt /TEE

ECHO *************************************************************************************************************
ECHO END BRM Compilation

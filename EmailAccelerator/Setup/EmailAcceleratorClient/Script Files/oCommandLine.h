prototype OParseCommandLine();
prototype _DisplayHelp();
prototype _FindNextBlankChar( STRING,INT );

typedef COMMANDLINE
begin
	STRING szServer[64];
	STRING szDataBaseName[64];
	STRING szUserName[64];
	STRING szPassword[64];
	STRING szSourceDir[128];
	STRING szTargetDir[128];
	STRING szEncryption[20];
	STRING szAutoUpgradeSelect[128];
	STRING szAutoUpgradeDeselect[128];
	INT szSimulation;
	INT szDebug;
	BOOL bDisableReqCheck;
end;

COMMANDLINE g_structCmdLine;





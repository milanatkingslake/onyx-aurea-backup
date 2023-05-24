/*
prototype OExtraStuff();
prototype _SearchServerExtras();
prototype _RegMTSFiles();
prototype _Create_OEP_Components();
prototype _RemoveMTSTempFiles();
*/

prototype _RunOFSAdminConfig();
prototype _RunOFSISServConfig();
prototype OFSVCINS.ISAdminConfig(HWND);
prototype OFSVCINS.ISSvcConfig(HWND);
prototype OConfigMiddleTier();
prototype OCheckForLogicalApp(STRING);
prototype oRunDictionaryInstall();
prototype OSLFEncryptString(STRING,STRING,BYREF STRING);
prototype OSLFDecryptString(STRING,STRING,BYREF STRING);
prototype LONG OSLFEncrypt.EncryptStringA(STRING,STRING,STRING,BYREF STRING);
//prototype LONG OSLFEncrypt.DecryptStringA(BYREF STRING,BYREF STRING,BYREF STRING,INT);
prototype LONG OSLFEncrypt.EncryptPasswordA(STRING,STRING,BYREF STRING);
prototype LONG OEPEncrypt.EncryptA(STRING, BYREF STRING);
prototype OSLFEncryptPassword(STRING,STRING,BYREF STRING);
prototype OEPEncryptString(STRING,BYREF STRING);
prototype OEncryptAccountIntoReg(ACCOUNT_INFO POINTER, STRING, STRING, STRING);
prototype OSetUCFDirectoryPermissions(STRING);
prototype OSetProductionEnv();









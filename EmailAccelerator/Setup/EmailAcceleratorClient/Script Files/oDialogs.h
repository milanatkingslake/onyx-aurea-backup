
/* String table values used in dialogs, defined in other places besides ScriptFiles
@SETUP_DESCRIPTION_DEVELOPMENT
@SETUP_DESCRIPTION_PRODUCTION
@SETUP_NAME_DEVELOPMENT
@SETUP_NAME_PRODUCTION
*/

    prototype DialogShowSdWelcome();
    prototype DialogShowSdLicense();
    prototype DialogShowSdShowInfoList( STRING, STRING, STRING );
    prototype DialogShowSdRegisterUserEx();
    prototype DialogShowSdAskDestPath(BYREF INT);
    prototype DialogShowSdSetupType( STRING );
    prototype DialogShowSdComponentDialog2();
    prototype DialogShowSdSelectFolder();
    prototype DialogShowSdStartCopy();
    prototype DialogShowSdFinishReboot();
	prototype DialogShowRebuildCodeWarning();
	prototype DialogShowOperation2CodeWarning();
    prototype DialogShowSetSystemParameters();
    prototype ODialogShowOperations( BYREF STRING,NUMBER);
//OFS 	prototype OListSingleOperation(BYREF STRING,BYREF STRING,BYREF STRING);
//OFS 	prototype OListTwoOperations(STRING,STRING,INT,BYREF STRING);
    prototype ODialogShowDatabaseInfo( DATABASE_INFO POINTER,INT );
    prototype ODialogShowAccountInfo( STRING,STRING,ACCOUNT_INFO POINTER,INT,INT,INT,BOOL);
	prototype ODlgShowDomainAccountInfo(STRING,STRING,DOMAIN_ACCOUNT_INFO POINTER);
    prototype ODialogShowGetEntry( STRING,STRING,BYREF STRING,STRING,INT,INT,INT);
	prototype OGetSharedValueInReg(STRING,STRING,BYREF STRING);
	prototype OStoreSharedValueInReg(STRING,STRING,STRING);
    prototype ODialogShowGetEntry2( STRING,STRING,BYREF STRING,BYREF STRING,STRING,STRING,INT,INT);
    prototype ODialogShowGetDSNEntry( STRING,STRING,DSN_INFO POINTER,STRING);
	prototype ODialogShowGetAppName();
    prototype DialogLogFiles();
    prototype DialogShowShutdownServices(NUMBER);
	prototype ODialogShowAskToOverwrite(BYREF STRING,STRING,STRING);
	prototype ODialogShowGetVirtualDir(VWS_INFO POINTER,STRING,INT);
	prototype ODialogShowGetSiteID(VWS_INFO POINTER,STRING);
	prototype ODialogShowRemoteServerReg(BYREF STRING);
	prototype ODialogShowSelectApp(STRING,INT);
	prototype ODialogShowGetProxy(INT);
	

	
/*  --Old database login dialog control numbers
#define IDFLD_SERVER                    1000
#define IDFLD_DATABASE                  1001
#define IDFLD_LOGIN                     1002
#define IDFLD_PASSWORD                  1003
#define IDLBL_SERVER                    1005
#define IDLBL_DATABASE                  1006
#define IDLBL_LOGIN                     1007
#define IDLBL_PASSWORD                  1008
#define IDLBL_DATABASE_INSTRUCTIONS     1009
#define IDC_STATIC                      -1
*/

//  --New database login dialog control numbers
#define IDD_DATABASE                    30001
#define IDFLD_SERVER                    100
#define IDFLD_DATABASE                  101
#define IDFLD_LOGIN                     102
#define IDFLD_PASSWORD                  103
#define IDLBL_SERVER                    770
#define IDLBL_DATABASE                  771
#define IDLBL_LOGIN                     772
#define IDLBL_PASSWORD                  773
#define IDLBL_DATABASE_INSTRUCTIONS     550
#define IDC_STATIC                      -1

	
//constants for password edit control
#define EM_SETPASSWORDCHAR      0x00CC
#define ASTERISK 				42








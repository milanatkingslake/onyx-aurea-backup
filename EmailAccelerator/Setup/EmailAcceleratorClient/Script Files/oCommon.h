////////////////////// header file includes ////////////////////////////
#include "LaunchAppEx.h"


//OnyxEncrypt.dll encryption key
//override value in "Action - Encrypt MTS Account" component in IDE
//#define ENCRYPT_KEY "2FB1A9A0-E7B3-11d2-B50C-00104B38DCE5"  //used on OFS.
#define ENCRYPT_KEY "G8sahg7fb" // Apollo and voyager key.

//constants needed for RegAddMulti();
#define NEW_DELIMITER "#"
#define OLD_DELIMITER "" //
#define OLD_DELIMITER_NUMBER 0 // ascii value of old delimiter (i.e. "" = 0 or "@" = 64)

//toolkit stuff
#define TEMP_MEDIA	"TempMedia"
#define BITMAPS "DialogBitmaps"
#define SETUPLOG "setuplog.txt"

// Neede for GetComputerName()
#define MAX_COMPUTERNAME_LENGTH 31

typedef SETUP_MODE
begin
	STRING	szType[32];	//Operation1, 2, 3 (like NEW,UPGRADE,REINSTALL...)
	BOOL	bNoOperation;	//do not prompt user for operation selection.
	BOOL	bNoPrompt;	//do not prompt user for destination dir.
	BOOL	bCopyNewFile;	//do not use old data files.
	BOOL	bSilent;	//running in silent mode
	BOOL	bSimulation;	//running in test or do nothing mode
	BOOL	bRecord;	//record response mode (for silent)
	BOOL	bRecovery;	//recovering from a previous run of setup.
	BOOL	bRebooted;  //setup to be rerun after reboot using runonce
	BOOL	bNoReg;		//no registry entires with this setup.
	BOOL	bNoSetupReg; //no setup version reg left with this setup.
	BOOL	bNoReboot;	//set this value to surpress reboot dialog.
	BOOL	bParentTypical;  //indiactes setup was run from Launcher as a typical install.
	STRING	szSQLProtocol[20];  //string representing Named Pipes or TCP/IP
	BOOL	bStopIfOlder;  //if set, do not continue if setup has older files than target system.
	INT	nDebug;		//number representing debug level.
	STRING	sDeleteFiles[256];	//delete files in the dir specified before installing files.
	INT		nCodePage;	//OS code page number (from GetACP call)
	STRING	szCodePage[10];  //string equivalent of above
end;

typedef OLD_DATA
begin
	BOOL	bCopyNewFile;	//do not use old data files.
	STRING	szFile[128];			//name of file to copy
	STRING	szSubDir[256];		//sub dir on cd image where data file is.
	STRING	szRegPath[512];		//reg path for data file
	STRING	szRegKey[256];		//reg key name for data file
	STRING	szRegType[20];		//data type to read/store.
	STRING	szRegData[256];		//old data in registry.
end;    	

typedef FROM_LAUNCHER
begin
	BOOL	bIsChild;		//set to indicate setup is run from another setup
	BOOL	bShareData;		//set to share data with additional child setups.
	STRING  szParentDir[256];	//this setup was run from another setup.
end;

BOOL bDoneOnce2;
INT hLogFile;
SETUP_MODE g_structSetupMode;
OLD_DATA g_structOldData;
FROM_LAUNCHER g_structLauncher;


/* replaced in LaunchAppEx
typedef STARTUPINFO
begin
	NUMBER   cb;
    POINTER  lpReserved;
    POINTER  lpDesktop;
    POINTER  lpTitle;
    NUMBER   dwX;
    NUMBER   dwY;
    NUMBER   dwXSize;
    NUMBER   dwYSize;
    NUMBER   dwXCountChars;
    NUMBER   dwYCountChars;
    NUMBER   dwFillAttribute;
    NUMBER   dwFlags;
    // the following is actually two words, but we know
    // we want 0 as the value, so we cheat & create one NUMBER
    NUMBER    wShowWindow;
    //WORD    cbReserved2;
    NUMBER    cbReserved2;
    POINTER  lpReserved2;
    HWND  hStdInput;
    HWND  hStdOutput;
    HWND  hStdError;
end;

typedef PROCESS_INFORMATION
begin
    NUMBER hProcess;
    HWND hThread;
    NUMBER dwProcessId;
    NUMBER dwThreadId;
end;
*/

//--- user-defined database types ---
typedef DATABASE_INFO
begin
	STRING szDescription[255];
    STRING szServer[255];
    STRING szDatabase[255];
    STRING szLogin[255];
    STRING szPassword[255];
    STRING szINISection[80];
    STRING szSubDir[80];
    STRING szSQL_Ver[20];
    STRING szOCC_Ver[20];
    STRING szInsight_Ver[20];
    STRING szOEP_Ver[20];
    STRING szProductVer1[20];
    STRING szProductVer2[20];
    STRING szProductVer3[20];
    STRING szProductVer4[20];
    STRING szLanguageCode[20];
end;

DATABASE_INFO g_structDatabase;
DATABASE_INFO g_structDatabase2;

//---account data structure---
typedef ACCOUNT_INFO
begin
	STRING szLogin[100];
	STRING szPassword[40];
	STRING szEncryptedPassword[80];
	STRING szOEPEncryptedLogin[200];
	STRING szOEPEncryptedPassword[80];
	BOOL bLockName;
	BOOL bNewInstall;
end;

ACCOUNT_INFO g_structSQLAccount;
ACCOUNT_INFO g_structSQLEUAccount; //account "extended users" table of db itself.
ACCOUNT_INFO g_structNTAccount;
ACCOUNT_INFO g_structNTGroup;
ACCOUNT_INFO g_structAppName;
ACCOUNT_INFO g_structOnyxSA;
ACCOUNT_INFO g_structLMAccount;

typedef DOMAIN_ACCOUNT_INFO
begin
	STRING szDomain[80];
	STRING szLogin[80];
	STRING szPassword[80];
	STRING szEncryptedPassword[80];
	BOOL bLockName;
	INT  nSpaceOkInPW;
end;

DOMAIN_ACCOUNT_INFO g_structDomainAccount;

//---DSN data structure---
typedef DSN_INFO
begin
	STRING szName[128];
	STRING szServer[128];
	STRING szDatabase[128];
	STRING szDesc[128];
end;

DSN_INFO g_structDSN;

//---website data structure---
typedef VWS_INFO
begin
	STRING szTitle[240];
	STRING szName[240];
	STRING szHelpName[240];
	BOOL   bDisableAnonymous;
	STRING szSiteId[10];
	STRING szAspScriptTimeout[10];
	STRING szDefaultDoc[240];
	STRING szHttpExpires[50];
end;

VWS_INFO g_structVWS1;
VWS_INFO g_structVWS2;
VWS_INFO g_structVWS3; //used for SiteId prompt

//---Logical Application Data
typedef APP_DATA
begin
	STRING szAppServer[100];
	STRING szProxyFile[255];
	STRING szProxyDir[100];
end;

APP_DATA g_structAppData;


#if _ISCRIPT_VER < 0x600
	#ifndef BYVAL
		#define BYVAL
	#endif
#endif

typedef OPS_APPLOG_SETTINGS
begin
	STRING	szFileOutput[512];
	STRING	szFileSource[100];
	STRING	szGlobalLogSettings[20];
end;

OPS_APPLOG_SETTINGS g_OPSAppLogSettings;


prototype SetupInit();
//prototype OSelectOptionFromList(STRING,STRING,LIST,BYREF STRING);
//prototype OAskOptionsFromLists(BYREF STRING,BYREF STRING,LIST,LIST,INT);
//OFS prototype OGetLanguageDir(BYREF STRING);
prototype OParseMacros(BYREF STRING);
prototype _GetMacroVar(BYREF STRING);
//prototype OAddIcon(BYREF STRING);
//prototype _CheckForDefaultString(BYREF STRING,STRING,STRING);
//prototype _CheckForDefaultNumber(BYREF INT,STRING,INT);
prototype OChangeBitmap(STRING);
prototype OSetDebug();
prototype OLogOpen();
prototype OLog(STRING);
prototype OLogStore();
//prototype OStoreModes();
//	prototype OSaveOperationMode(STRING,STRING);
//OFS prototype OGetOperationMode(STRING,BYREF STRING);
prototype OIsValueEqualOrGreater(STRING,STRING);
prototype OIsValueEqualOrGreaterVer(STRING,STRING);
prototype OIsValueEqualOrLess(STRING,STRING);
prototype OIsValueGreater(STRING,STRING);
prototype OIsValueEqual(STRING,STRING);
prototype OCatStrings(BYREF STRING,STRING,STRING);
//prototype OAskExit();
prototype OLookForProduct(BYREF STRING,NUMBER);
//OFS prototype ORegisterFilesWithREGIT();
prototype OIsRebootNeeded();
//prototype _LookForOldData(BYREF INT);
//prototype _CopyDataFiles();
prototype _SetRegBase(STRING);
prototype ODebugDsp(STRING,INT);
//prototype OHextoDecimal(BYREF STRING);
//prototype _XToThePowerofY(INT,INT);
//OFS prototype OTestFileVer(STRING,STRING);
//OFS prototype ORegAddMulti(STRING, STRING, STRING, STRING, NUMBER);
prototype GiveUserReadPermission();

prototype NUMBER kernel32.WinExec(STRING, NUMBER);
prototype LONG KERNEL32.GetComputerName(BYREF STRING, BYREF LONG);

prototype STRING _GetComputerName(BYREF STRING);
prototype OCheckDiskSpace(STRING,STRING,STRING);
prototype OCopyFileTryAgain(STRING,STRING,BOOL);
prototype OBackupFile(STRING);
prototype OBackupFilesListedInINI();
prototype OXCopyFileTryAgain(STRING,STRING,NUMBER);
prototype OCopyFileWithStatus(STRING,STRING);
prototype _HandleCopyFileError(STRING,INT);
//prototype ODeleteFile(STRING);
prototype OGetUNCPath(BYREF STRING,BYREF INT);
prototype OIsFileEmpty(STRING);
prototype OCheckFileVer(STRING,STRING,BYREF STRING);
prototype DetectLauncher();
prototype OMuteDialog(STRING);
prototype OMuteDialogSetStatus(STRING,STRING);
prototype OMuteDialogGetStatus(STRING,BYREF STRING);
prototype LONG onyxencrypt.EncryptString(BYREF STRING,BYREF STRING,BYREF STRING,INT);
prototype LONG onyxencrypt.DecryptString(BYREF STRING,BYREF STRING,BYREF STRING,INT);
prototype OEncryptString(STRING,STRING,BYREF STRING);
prototype ODecryptString(STRING,BYREF STRING,STRING);
prototype OIsFirstDialog(STRING);
prototype OGetValueFromINI(STRING,STRING,BYREF STRING);
prototype OGetSectionFromINI(STRING,LIST);
prototype OGetPluginStatus(BYREF STRING);
prototype OCheckForIllegalChars(STRING,STRING,INT,INT,INT);
prototype _CheckCharsInString(BYREF STRING,STRING);
prototype _CheckForANSIchars(STRING,INT,INT);
prototype _CompareStringsByASCII(STRING,STRING);
prototype OEncryptEntryToReg(STRING,STRING,STRING,STRING,STRING);
prototype ODecryptEntryFromReg(STRING,STRING,STRING,BYREF STRING,STRING);
prototype OEncryptDBAccountIntoReg(ACCOUNT_INFO POINTER, DATABASE_INFO POINTER);
prototype OPutStringInReg(STRING, STRING, STRING, STRING, INT);
prototype OPutNumInReg(STRING, STRING, STRING, STRING);
prototype OGetStringFromReg(STRING, STRING, STRING, BYREF STRING);
//prototype ORegTypeLibraryFile(STRING);
prototype OFileExist(STRING);
//prototype ORegIt(STRING);
prototype OProcessRegFiles(BOOL);
prototype ORegFileKeysToRegistry(STRING);
prototype OComponentError(STRING);
prototype OPutDSNintoASAFile(STRING);
prototype OPutSQLintoASAFile(STRING);
prototype OPutINIDataIntoFiles();
prototype OPutINIintoFile(STRING,STRING);
prototype OPutItemIntoFile(STRING,STRING,STRING);
prototype OUpdateLineAfterEqual(STRING,BYREF STRING,STRING,STRING,BOOL);
//prototype OGetLastDir(BYREF STRING);
prototype ORemoveLastDir(BYREF STRING);
prototype OCreateVWS(STRING,STRING);
prototype OGetVWSAnonymousUser(STRING,BYREF STRING);
prototype OSetVWSAnonymousUser(STRING);
prototype OSetVWSAnonymousUserOFF(STRING);
prototype OEnableVWSParentPaths();
prototype OAddSVGMimeType(STRING,STRING);
prototype OAddVBIMimeType(STRING,STRING);
prototype OCheckForVWS(BYREF STRING);
prototype OSetOutOfProcessVWS(STRING,STRING,STRING,STRING);
prototype OCheckDiskSpaceForComp(BYREF STRING,BYREF STRING);
prototype ODetermineSoftwareComp(BYREF STRING);
prototype OCheckForExistingComponents(STRING,STRING);
prototype OAbort();
prototype OCheckStringLength(STRING,INT,STRING);
prototype OCheckForSpaceChar(STRING,STRING);
prototype OReplacePasswordWithStar(BYREF STRING);
prototype _ReadIniWriteReg(STRING,STRING,STRING,STRING,INT,INT);
prototype OPutValueInRegIfNew(STRING,STRING,STRING,INT);
prototype _ParseAfterItem(STRING,STRING,BYREF STRING);
prototype ORegDBDeleteKeyIfEmpty(STRING);
prototype OCheckRegistry();
prototype OComponentListAllItems(STRING, STRING, LIST);
prototype GetDotNetFilesToRegister(LIST, STRING);
prototype RegisterDotNetComponents();
prototype _CountConfiguredApps(STRING);
prototype ProcessMacrosInFile(STRING, STRING,STRING,STRING);
prototype OSpawnBCP(DATABASE_INFO POINTER, STRING, LIST, BYREF NUMBER, INT);

//for set/remove path environment var.
prototype SetEnvPath(STRING, BOOL);
//prototype RemoveFromPath(STRING);
prototype OIsPathRoot(STRING);
prototype oGetACP(BYREF INT);
prototype NUMBER kernel32.GetACP();
prototype OReplace(STRING, STRING, STRING, BYREF STRING);
prototype OPadd(STRING, STRING,NUMBER, BYREF STRING);
prototype OCreateEventLog(STRING);
prototype _GetColorFromINI(STRING);
prototype OReplaceInFile(STRING, STRING, STRING);
prototype OGetCurrentUser(BYREF STRING);

/*
  STRING REPLACEMENT MODULE
  Rev:  Submitted to InstallSite 2-26-1999

  by James Frater

  See documentation in _StrReplace.rul
*/

prototype   _Right ( BYREF STRING, STRING, LONG );
prototype   _Left  ( BYREF STRING, STRING, LONG );
prototype   _LTrim ( BYREF STRING );
prototype   _RTrim ( BYREF STRING );
prototype   _Trim  ( BYREF STRING );

prototype   _StrStripLeading ( BYREF STRING, STRING );
prototype   _StrStripTrailing ( BYREF STRING, STRING );

prototype   _StrFind ( STRING, STRING, LONG );

LONG        glOccurrences;
prototype   _StrReplace ( BYREF STRING, STRING, STRING, BYREF LONG, LONG );
prototype ClearFileAttributes (STRING, STRING);


//End string replacement declarations

//Used for multiline registry entries

prototype RegDBSetMultiSZ(NUMBER,STRING,STRING,LIST);
prototype RegDBGetMultiSZ(NUMBER,STRING,STRING,LIST);

//for internal use	
prototype Advapi32.RegOpenKeyA(NUMBER, POINTER, POINTER);
prototype Advapi32.RegCloseKey(NUMBER);
prototype Advapi32.RegSetValueExA(NUMBER,POINTER,NUMBER,NUMBER,POINTER,NUMBER);
#define DELIMITER "|"










prototype ORunAllSQLItems(STRING,INT);
prototype ODBValidate( DATABASE_INFO POINTER, BYREF STRING );
prototype ODBExecuteSQLString( DATABASE_INFO POINTER, STRING, STRING );
prototype ORunSQLScripts( DATABASE_INFO POINTER,STRING,STRING,INT,INT,INT);
prototype _DisableTracing(POINTER,STRING);
prototype _EnableTracing(POINTER,STRING);
prototype OGetSQLValuesFromReg( DATABASE_INFO POINTER , STRING, STRING);
prototype OGetSQLValuesFromINI( DATABASE_INFO POINTER , STRING);
prototype _CheckForEncOveride(BYREF INT);
prototype OSwitchDSQuery(STRING);
prototype OSetDSQuery(STRING);
prototype ORestoreDSQuery(STRING);
prototype _CheckSQLAccount(DATABASE_INFO POINTER,ACCOUNT_INFO POINTER);
prototype _CheckSQLAccountDbOwner(DATABASE_INFO POINTER,ACCOUNT_INFO POINTER);
prototype _CheckOtherSQLAccount(DATABASE_INFO POINTER, STRING);
prototype OPSLoginInfo(DATABASE_INFO POINTER,ACCOUNT_INFO POINTER);
prototype _CheckWTUpgrade(DATABASE_INFO POINTER);
prototype _CheckDbRole(DATABASE_INFO POINTER, ACCOUNT_INFO POINTER, STRING);
prototype OCheckExistingDatabase(DATABASE_INFO POINTER);

//prototype ORunINISQLStrings(DATABASE_INFO POINTER,STRING,STRING,BYREF STRING);
//prototype _DetermineINISection(BYREF STRING,BYREF STRING);


//---- ISOnyxIns.DLL function prototypes
//1.3 version
//prototype ISOnyxIns.ISOpenInstaller(STRING, STRING, STRING, STRING, STRING, STRING, NUMBER, POINTER, STRING, NUMBER);

/*
prototype ISOnyxIns.ISOpenInstaller(NUMBER, STRING, STRING, STRING, STRING, STRING, STRING, NUMBER, NUMBER, POINTER, STRING, NUMBER);
prototype ISOnyxIns.ISCloseInstaller(POINTER, NUMBER, STRING, NUMBER);
prototype ISOnyxIns.ISExecuteFile(POINTER, STRING, NUMBER, STRING, NUMBER);
prototype ISOnyxIns.ISExecuteString(POINTER, STRING, NUMBER, STRING, NUMBER);
prototype ISOnyxIns.ISExecuteQuery(POINTER,STRING,NUMBER,STRING,NUMBER,STRING,NUMBER);	
prototype ISOnyxIns.ISInsertFile(POINTER, STRING, STRING, NUMBER, STRING, NUMBER);
//prototype ISOnyxIns.ISInsertFileW(POINTER, STRING, STRING, NUMBER, STRING, NUMBER);
*/

//unicode version
prototype OnyxIns.OpenInstallerA(NUMBER, STRING, STRING, STRING, STRING, STRING, STRING, NUMBER, NUMBER, POINTER, STRING, NUMBER);
prototype OnyxIns.VBOpenInstallerA(NUMBER, STRING, STRING, STRING, STRING, STRING, STRING, NUMBER, NUMBER, POINTER, STRING, NUMBER);
prototype OnyxIns.OpenInstallerW(NUMBER, STRING, STRING, STRING, STRING, STRING, STRING, NUMBER, NUMBER, POINTER, STRING, NUMBER);
prototype OnyxIns.CloseInstallerA(POINTER, NUMBER, STRING, NUMBER);
prototype OnyxIns.ExecuteFileA(POINTER, STRING, NUMBER, STRING, NUMBER);
prototype OnyxIns.ExecuteStringA(POINTER, STRING, NUMBER, STRING, NUMBER);
prototype OnyxIns.ExecuteQueryA(POINTER,STRING,NUMBER,STRING,NUMBER,STRING,NUMBER);	
prototype OnyxIns.InsertFileA(POINTER, STRING, STRING, NUMBER, STRING, NUMBER);
prototype OnyxIns.BcpDataFileA(POINTER, STRING, STRING, NUMBER, STRING, NUMBER);

/*
//ONYXINS.DLL v1.1 "openinstaller" function switches.  Very critical and undocumented.
#define  EV_ERROR  0x1          // log errors
#define  EV_WARNING  0x2        // log warnings
#define  EV_OPERATION  0x4      // log operation begin/end
#define  EV_CAUSE  0x8          // log cause of errors/warnings
#define  EV_QUERY  0x10         // log queries processed
#define  EV_LINE  0x10          // log lines of SQL
#define  EV_BLOCK  0x40         // log blocks processed
#define  EV_ROW  0x20           // log inserted rows
#define  EV_UNMODIFIED  0x100   // log unmodified objects
#define  EV_MODIFIED  0x200     // log modified objects
#define  EV_SQL  0x400          // log executed SQL
#define  EV_RESULT  0x800       // log query results
#define  EV_MESSAGE  0x1000     // log user messages
#define  EV_DEBUG  0x2000       // log internal debug messages
//
// flOptions
#define  FL_BATCH  0x1          // batch processing (ignore errors)
#define  FL_APPEND_LOG  0x2      // append to existing log
#define  FL_CRASH_LOG  0x4       // disable log buffering  - write to log right away
// WITH ENCRYPTION keyword added to sproc definitions
#define  FL_MODIFY_QUERY  0x8    // enable SQL query modifications
#define  FL_MODIFY_LINE  0x10    // enable SQL line modifications
#define  FL_MODIFY_BLOCK  0x20   // enable SQL block modifications
#define  FL_MODIFY_ROW  0x40     // enable SQL row modifications
//if run in test mode, will log to files but never actually execute a query
//need to add the options evModified or evUnmodified to see the code being logged to the file
#define  FL_TEST  0x80          // run in test mode
*/

//ONYXINS.DLL v1.3 "openinstaller" function switches.
#define  EV_ERROR  0x1          // log errors
#define  EV_WARNING  0x2        // log warnings
#define  EV_OPERATION  0x4      // log operation begin/end
#define  EV_CAUSE  0x8          // log cause of errors/warnings
#define  EV_QUERY  0x10         // evSQL, log executed SQL
#define  EV_ROW  0x20           // log inserted rows
#define  EV_RESULT  0x40        // log query results
#define  EV_MESSAGE  0x80       // log user messages
#define  EV_DEBUG  0x100        // log internal debug messages
//
// flOptions
#define  FL_BATCH  0x1           // flBatch, batch processing (ignore errors)
#define  FL_APPEND_LOG  0x2      // flAppendLog, append to existing log
#define  FL_CRASH_LOG  0x4       // flCrashLog, disable log buffering  - write to log right away
#define  FL_MODIFY_SQL  0x8      // flModifySQL, enable SQL query modifications
#define  FL_MODIFY_ROW  0x10     // flModifyRow, enable SQL row modifications
#define  FL_TEST  0x20           // run in test mode
#define  FL_OLD_DATA_FORMAT  0x40     // convert old data format
//if run in test mode, will log to files but never actually execute a query
//need to add the options evModified or evUnmodified to see the code being logged to the file
//-----------------------------------

//#define ONYXINSDLL "ISonyxins.dll"
#define ONYXINSDLL "onyxins.dll"












//Toolkit functions
prototype OLookForNTServices(LIST);
prototype OShutDownNTServices(LIST);
prototype OShutDownService(STRING);
prototype ORestartServices();
prototype OAddUserToGroup(STRING,STRING);
prototype OAddFileAccessRights(STRING,STRING);
prototype OCreateNTAccount(STRING,STRING,STRING,STRING);
prototype OCheckLocalAccount(STRING,BYREF INT);
prototype OCreateNTGroup(STRING,STRING);
prototype _CreateNTService(STRING, STRING,
                    NUMBER, NUMBER, NUMBER,
                    STRING, STRING, NUMBER,
                    STRING, STRING, STRING);
prototype _InitServiceConnections(STRING);
prototype _ChangePassword(STRING);
prototype DeleteOSSService();
prototype OSetBatchLogonRight(STRING);
prototype OSetServiceLogonRight(STRING);
prototype OSetDCOMLaunchActivation(STRING, STRING);
prototype OSetDCOMAccessPermissions(STRING, STRING);

/////////////////////////////////////////////////////////////////////////////
//NT services
//
//declare   //FIX IS3
// constants copied from Winsvc.h
  #define SC_MANAGER_ALL_ACCESS          0x000F003F
  #define SERVICE_ALL_ACCESS             0x000F01FF
  #define SERVICE_CONTROL_STOP           0x00000001

// You need this defines only if you want to pause and continue a service.
  #define SERVICE_CONTROL_PAUSE          0x00000002
  #define SERVICE_CONTROL_CONTINUE       0x00000003
  #define SERVICE_CONTROL_INTERROGATE    0x00000004
  #define SERVICE_CONTROL_SHUTDOWN       0x00000005

  #define SERVICE_STOPPED                0x00000001
// Possible other return values for QueryServiceStatus
  #define SERVICE_START_PENDING          0x00000002
  #define SERVICE_STOP_PENDING           0x00000003
  #define SERVICE_RUNNING                0x00000004
  #define SERVICE_CONTINUE_PENDING       0x00000005
  #define SERVICE_PAUSE_PENDING          0x00000006
  #define SERVICE_PAUSED                 0x00000007

  // Start Type
#define SERVICE_BOOT_START             0x00000000
#define SERVICE_SYSTEM_START           0x00000001
#define SERVICE_AUTO_START             0x00000002
#define SERVICE_DEMAND_START           0x00000003
#define SERVICE_DISABLED               0x00000004

// Error control type
#define SERVICE_ERROR_IGNORE           0x00000000
#define SERVICE_ERROR_NORMAL           0x00000001
#define SERVICE_ERROR_SEVERE           0x00000002
#define SERVICE_ERROR_CRITICAL         0x00000003

// Service Types (Bit Mask)
#define SERVICE_KERNEL_DRIVER          0x00000001
#define SERVICE_FILE_SYSTEM_DRIVER     0x00000002
#define SERVICE_ADAPTER                0x00000004
#define SERVICE_RECOGNIZER_DRIVER      0x00000008
#define SERVICE_DRIVER                 (SERVICE_KERNEL_DRIVER | SERVICE_FILE_SYSTEM_DRIVER | SERVICE_RECOGNIZER_DRIVER)
#define SERVICE_WIN32_OWN_PROCESS      0x00000010
#define SERVICE_WIN32_SHARE_PROCESS    0x00000020
#define SERVICE_WIN32                  (SERVICE_WIN32_OWN_PROCESS | SERVICE_WIN32_SHARE_PROCESS)
#define SERVICE_INTERACTIVE_PROCESS    0x00000100
#define SERVICE_TYPE_ALL               (SERVICE_WIN32  | SERVICE_ADAPTER | SERVICE_DRIVER  | SERVICE_INTERACTIVE_PROCESS)

//
// Controls Accepted  (Bit Mask)
//
#define SERVICE_ACCEPT_STOP                    0x00000001
#define SERVICE_ACCEPT_PAUSE_CONTINUE          0x00000002
#define SERVICE_ACCEPT_SHUTDOWN                0x00000004
#define SERVICE_ACCEPT_PARAMCHANGE             0x00000008
#define SERVICE_ACCEPT_NETBINDCHANGE           0x00000010
#define SERVICE_ACCEPT_HARDWAREPROFILECHANGE   0x00000020
#define SERVICE_ACCEPT_POWEREVENT              0x00000040

  typedef SERVICE_STATUS
  begin
   NUMBER dwServiceType;
   NUMBER dwCurrentState;
   NUMBER dwControlsAccepted;
   NUMBER dwWin32ExitCode;
   NUMBER dwServiceSpecificExitCode;
   NUMBER dwCheckPoint;
   NUMBER dwWaitHint;
  end;

  // Prototype the service control APIs
  prototype NUMBER AdvAPI32.OpenSCManagerA(POINTER, POINTER, NUMBER);
  prototype NUMBER Advapi32.OpenServiceA(NUMBER, POINTER, NUMBER);
  prototype BOOL   Advapi32.StartServiceA(NUMBER, NUMBER, POINTER);
  prototype BOOL   AdvAPI32.ControlService(NUMBER, NUMBER, POINTER);
  prototype BOOL   AdvAPI32.CloseServiceHandle(NUMBER);
  prototype BOOL   Advapi32.QueryServiceStatus(NUMBER, POINTER);
  prototype BOOL   Advapi32.DeleteService(NUMBER);
  prototype NUMBER KERNEL.GetLastError();
  prototype NUMBER AdvAPI32.CreateServiceA(NUMBER, POINTER, POINTER, NUMBER, NUMBER, NUMBER, NUMBER, POINTER, POINTER, POINTER, POINTER, POINTER, POINTER);
  prototype NUMBER  OPSSvcInst.ChangeSvcAcctAndDes(STRING , STRING ,STRING );


  // prototype the InstallScript functions.
prototype _StartNTService(STRING);
prototype _StopNTService(STRING);
prototype _IsNTServiceStopped(STRING);
prototype _DeleteNTService(STRING);
prototype _ValidateAccount(STRING,STRING,STRING);
prototype _CloseServiceConnections();
prototype InstallOSSService();
prototype OldInstallOSSService();
prototype _IsServiceAvailable(STRING);
prototype RegisterOSS();

//end of NT services

//Add user account
//prototype instvc.AddUserAccount( STRING, STRING );
//prototype instvc.RemoveUserAccount(STRING);
prototype websecur.AddFileAccessRights(STRING,STRING);
prototype websecur.AddLocalAccount(STRING,STRING,STRING,STRING,STRING);
prototype websecur.AddUserToGroup(STRING,STRING,INT,STRING); 		
prototype websecur.AddNewGroup(STRING,STRING,INT,STRING);
prototype INT websecur.GetUserAccountInfo(STRING,STRING,BYREF INT,BYREF STRING,BYREF STRING,BYREF STRING);
prototype websecur.ValidateUserAccount(STRING,STRING,STRING);
prototype websecur.SetGroupPermissionsOnFolder(STRING, STRING);
prototype websecur.SetBatchLogonRight(STRING, STRING);
prototype websecur.SetServiceLogonRight(STRING, STRING);
prototype websecur.SetDCOMLaunchActivation(STRING, STRING, STRING);
prototype websecur.SetDCOMAccessPermissions(STRING, STRING, STRING);

typedef USER_INFO_STRUCT
begin
	STRING   sUserName[128];
    STRING   sPassword[128];
    LONG     lPasswordAge;
    LONG     lPriv;
    STRING   sHomeDir[128];
    STRING   sComment[128];
    LONG     lFlags;
    STRING   sScriptPath[128];
end;

//constants needed for NetUserAdd
/*
#define USER_PRIV_MASK      0x3
#define USER_PRIV_GUEST     0
#define USER_PRIV_USER      1
#define USER_PRIV_ADMIN     2

#define UF_SCRIPT               0x0001
#define UF_ACCOUNTDISABLE       0x0002
#define UF_HOMEDIR_REQUIRED     0x0008
#define UF_LOCKOUT              0x0010
#define UF_PASSWD_NOTREQD       0x0020
#define UF_PASSWD_CANT_CHANGE   0x0040

#define UF_TEMP_DUPLICATE_ACCOUNT       0x0100
#define UF_NORMAL_ACCOUNT               0x0200
#define UF_INTERDOMAIN_TRUST_ACCOUNT    0x0800
#define UF_WORKSTATION_TRUST_ACCOUNT    0x1000
#define UF_SERVER_TRUST_ACCOUNT         0x2000
*/
#define ERROR_ACCESS_DENIED                 000000005
#define NERR_Success			0
#define NERR_BASE				2100
#define NERR_GroupNotFound		(NERR_BASE+120) /* The group name could not be found. */
#define NERR_GroupExists		(NERR_BASE+123) /* The group already exists. */
#define NERR_UserExists			(NERR_BASE+124) /* The user account already exists. */
#define NERR_NotPrimary			(NERR_BASE+126) /* This operation is only allowed on the primary domain controller of the domain. */
#define NERR_PasswordTooShort	(NERR_BASE+145) /* The password is shorter than required. */
#define NERR_InvalidComputer	(NERR_BASE+251) /* This computer name is invalid. */

// global service handles, filled and released
POINTER ptrMcName, ptrDBName, pszSStartName;
NUMBER  schService, schSCManager;

	// Windows NT Security
	#define DACL_SECURITY_INFORMATION 0x00000004
	#define GENERIC_ALL               0x10000000
	#define NO_INHERITANCE            0x0
	#define SUB_CONTAINERS_AND_OBJECTS_INHERIT  0x3
	#define SE_FILE_OBJECT            1
	#define SE_PRINTER                3
	#define SE_REGISTRY_KEY           4
	#define TRUSTEE_IS_SID            0
	#define TRUSTEE_IS_UNKNOWN        0
	#define NO_MULTIPLE_TRUSTEE       0
	#define SET_ACCESS                2


	// Windows Security: TRUSTEE structure
	typedef TRUSTEE
	begin
		POINTER pMultipleTrustee;
		LONG    MultipleTrusteeOperation;
		LONG    TrusteeForm;
		LONG    TrusteeType;
		POINTER ptstrName; 		
	end;

	// Windows Security: EXPLICIT_ACCESS structure
	typedef EXPLICIT_ACCESS
	begin
		NUMBER  grfAccessPermissions;
		LONG    grfAccessMode;
		NUMBER  grfInheritance;
		TRUSTEE Trustee;		
	end;

	// Windows Security: SID_IDENTIFIER_AUTHORITY
	typedef SID_IDENTIFIER_AUTHORITY
	begin
    	CHAR Value1;
    	CHAR Value2;
    	CHAR Value3;
    	CHAR Value4;
    	CHAR Value5;
    	CHAR Value6;
    end;

	// Windows Security
    prototype LONG advapi32.GetNamedSecurityInfoA(BYREF STRING, LONG, LONG, POINTER, POINTER, POINTER, POINTER, POINTER);
	prototype LONG advapi32.SetNamedSecurityInfoA(BYREF STRING, LONG, LONG, POINTER, POINTER, POINTER, POINTER);
	prototype LONG advapi32.SetEntriesInAclA(LONG, POINTER, POINTER, POINTER);
	prototype LONG advapi32.AllocateAndInitializeSid(POINTER, CHAR, LONG, LONG, LONG, LONG, LONG, LONG, LONG, LONG, POINTER);
	prototype LONG advapi32.FreeSid(LONG);
	
	// Common Windows API
	prototype LONG KERNEL.LocalFree(HWND);




















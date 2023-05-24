

////////////////////// string defines ////////////////////////////

    #define UNINST_LOGFILE_NAME      "Uninst.isu"  //replace with product name.

    // Directories
    #define SQLEDIR                  SUPPORTDIR // ^ "SQLE" //Comment this out for now
    #define SQLUDIR                  SUPPORTDIR ^ "SQLU"
    #define SCM_DLL					 SUPPORTDIR ^ "opssvcinst.DLL"
    #define PIA_SRC_DIR				 "\\Customization Support\\Onyx Enterprise Application Server\\MS .NET Support"
    #define SETUP_STRING			 "setup"
	#define LOCALWORKDIR			 "C:\\_ONYXINS"

	// .NET Registration strings (for Setup.INI or maybe component "Miscellaneous" field)
	#define REGASM 					"RegASM"
	#define REG_GAC					"RegisterInGAC"
	#define REG_PIA					"RegisterPIA"
	
	// PLATFORM TYPES
	#define SQL_PLATFORM			1
	#define ORACLE_PLATFORM			2
    #define ORACLE_DB_TYPE			 2
    #define SQL_DB_TYPE				 1	

    // Setup Types
    #define SETUP_TYPE_BASE          "[Selected Functional Components]"

    // Database install types
    #define DATABASE_REBUILD		"rebuild"
    #define DATABASE_NEWINSTALL		"newinstall"
    #define DATABASE_UPGRADE		"upgrade"

    // Media Library
    #define BASE_MEDIA               "BaseMedia"
    #define SOFTWARE_MEDIA           "SoftwareMedia"

    // Misc
    #define CHOICE_MARKER            "Choice - "
	#define UCF_EVENT_LOG					"OnyxUCF"

	// OEP Setup Types
	#define OEP_SETUP_TYPE_DEV				"Operation1 - Development"
	#define OEP_SETUP_TYPE_PRODUCTION		"Operation1 - Production"

    // Software Components
    #define COMP_SOFTWARE            		"[Software Components]"
    #define SCOMP_OPERATION1_ROOT   		COMP_SOFTWARE + "\\Operation1"
    #define SCOMP_O1_NEW_RUNLIST   			SCOMP_OPERATION1_ROOT + "\\Files - SQL Run Lists\\Files - NewInstall"
    #define SCOMP_O1_REBUILD_RUNLIST   		SCOMP_OPERATION1_ROOT + "\\Files - SQL Run Lists\\Files - Rebuild"
    #define SCOMP_O1_PROGRAM_FILES  		SCOMP_OPERATION1_ROOT + "\\Program Files"
    #define SCOMP_O1_HELP					SCOMP_O1_PROGRAM_FILES + "\\Help Files"
    #define SCOMP_O1_APPSERVER_TYPE_LIBS 	SCOMP_O1_PROGRAM_FILES + "\\AppServer Folder\\Type Libraries"
    #define SCOMP_O1_APPSERVER_OED 			SCOMP_O1_PROGRAM_FILES + "\\AppServer Folder\\OED"
    #define SCOMP_O1_TYPE_LIBS  			SCOMP_O1_PROGRAM_FILES + "\\Type Libraries"
    #define SCOMP_O1_NT_SERVICES			SCOMP_O1_PROGRAM_FILES + "\\NT Services"
    #define SCOMP_O1_REG_FILES  			SCOMP_O1_PROGRAM_FILES + "\\Registry Files"
    #define SCOMP_O1_UCF_COMP  				SCOMP_O1_PROGRAM_FILES + "\\UCF .NET Components"
    #define SCOMP_O1_UCF_DEV_COMP  			SCOMP_O1_PROGRAM_FILES + "\\UCF .NET Development Components"
    #define SCOMP_O1_APP_FILES				SCOMP_O1_PROGRAM_FILES + "\\Application Files"
    #define SCOMP_O1_COMPLUS_COMPONENTS		SCOMP_O1_PROGRAM_FILES + "\\Components Folder\\COM+ Components"	
    #define SCOMP_O1_ONYXWEBSITE			SCOMP_O1_PROGRAM_FILES + "\\OEAS_OnyxWebSite"
    #define SCOMP_O1_ONYXAUTHWEBSITE		SCOMP_O1_PROGRAM_FILES + "\\OEASAuth_OnyxWebSite"
    #define SCOMP_O1_ONYXSOURCECODE			SCOMP_O1_PROGRAM_FILES + "\\OEAS_OnyxSourceCode"
    #define SCOMP_O1_ONYXAUTHSOURCECODE		SCOMP_O1_PROGRAM_FILES + "\\OEASAuth_OnyxSourceCode"
    #define SCOMP_O1_WINDOWSWEBSITE			SCOMP_O1_PROGRAM_FILES + "\\OEAS_WindowsWebSite"
    #define SCOMP_O1_WINDOWSAUTHWEBSITE		SCOMP_O1_PROGRAM_FILES + "\\OEASAuth_WindowsWebSite"
    #define SCOMP_O1_WINDOWSSOURCECODE		SCOMP_O1_PROGRAM_FILES + "\\OEAS_WindowsSourceCode"
    #define SCOMP_O1_WINDOWSAUTHSOURCECODE	SCOMP_O1_PROGRAM_FILES + "\\OEASAuth_WindowsSourceCode"

    #define SCOMP_O1_PLUGIN1				SCOMP_OPERATION1_ROOT + "\\Plugin1"
    #define SCOMP_O1_PLUGIN2				SCOMP_OPERATION1_ROOT + "\\Plugin2"
    #define SCOMP_O1_PLUGIN3				SCOMP_OPERATION1_ROOT + "\\Plugin3"
    #define SCOMP_OPERATION2_ROOT       	COMP_SOFTWARE + "\\Operation2"
    #define SCOMP_OPERATION3_ROOT       	COMP_SOFTWARE + "\\Operation3"
    #define SCOMP_OPERATION4_ROOT  			COMP_SOFTWARE + "\\Operation4"

	// File Groups
	#define FILE_GROUP_TYPE_LIBS	"Software - Type Library Files"
	#define FILE_GROUP_NT_SERVICES	"Software - NT Services"
	#define FILE_GROUP_REG_FILES	"Software - Registry Files"

	// Functional (script or virtual) Components
    #define COMP_SETUP               "[Functional Components]"
    #define COMP_CHECK_REQ		COMP_SETUP + "\\Action - Check Prerequisites"
    #define COMP_OS				COMP_CHECK_REQ + "\\Options - Operating System"
    #define COMP_WIN31		COMP_OS + "\\Option - Windows 3.1"
    #define COMP_WIN95		COMP_OS + "\\Option - Windows 95"
    #define COMP_WIN98		COMP_OS + "\\Option - Windows 98"
    #define COMP_WINNT351WS		COMP_OS + "\\Option - Windows NT 3.51 Workstation"
    #define COMP_WINNT40		COMP_OS + "\\Option - Windows NT 4.0"
    #define COMP_WINNT40WS	COMP_WINNT40 + "\\Option - Workstation"
    #define COMP_WINNT40SV	COMP_WINNT40 + "\\Option - Server"
    #define COMP_WINNT40ADD	COMP_WINNT40 + "\\Option - Additional Requirements"	
	#define COMP_WINNT40SP3	COMP_WINNT40ADD + "\\AND Service Pack 3 or newer"
    #define COMP_WINNT40ADMIN	COMP_WINNT40ADD + "\\AND System Administrator"
    #define COMP_WINNT40ONLY	COMP_WINNT40ADD + "\\AND Not a higher version"
    #define COMP_WINNT2K			COMP_OS + "\\Option - Windows 2000"
    #define COMP_WINNT2KSV		COMP_WINNT2K + "\\Option - Server"
    #define COMP_WINNT2KASV		COMP_WINNT2K + "\\Option - Advanced Server"
    #define COMP_WINNT2KADD		COMP_WINNT2K + "\\Option - Additional Requirements"	
	#define COMP_WINNT2KSP		COMP_WINNT2KADD + "\\AND Service Pack"
	#define COMP_WINNT2KADMIN	COMP_WINNT2KADD + "\\AND System Administrator"
 	#define COMP_WINNT2KONLY	COMP_WINNT2KADD + "\\AND Not a higher version"    					
 	#define COMP_WINNT2K3			COMP_OS + "\\Option - Windows 2003"
	#define COMP_WINNT2K3ADD		COMP_WINNT2K3 + "\\Option - Additional Requirements"	
	#define COMP_WINNT2K3SP		COMP_WINNT2K3ADD + "\\AND Service Pack"
	#define COMP_WINNT2K3ADMIN	COMP_WINNT2K3ADD + "\\AND System Administrator"
	#define COMP_WINNT2K3ONLY	COMP_WINNT2K3ADD + "\\AND Not a higher version"    					
 	#define COMP_OBPSSETUP		COMP_CHECK_REQ + "\\Options - BPS Setup"  					
 	#define COMP_ODBC			COMP_CHECK_REQ + "\\Options - ODBC"
 	#define COMP_ODBC16		COMP_ODBC + "\\Option - 16-bit ODBC"
 	#define COMP_ODBC32		COMP_ODBC + "\\Option - 32-bit ODBC"
	#define COMP_SQL			COMP_CHECK_REQ + "\\Options - SQL Server"
 	#define COMP_SQL65		COMP_SQL + "\\Option - SQL Server 6.5 Installed"
    #define COMP_SQL70		COMP_SQL + "\\Option - SQL Server 7.0 Installed"
 	#define COMP_IIS			COMP_CHECK_REQ + "\\Options - Internet Information Server"
	#define COMP_IIS6		COMP_IIS + "\\Option - IIS v6.0"
	#define COMP_JVM		COMP_IIS + "\\Option - Java VM"
	#define COMP_WSH 		COMP_IIS + "\\Option - WSH"
	#define COMP_WORD			COMP_CHECK_REQ + "\\Options - Microsoft Word"
	#define COMP_WORD_INS	COMP_WORD + "\\Option - Microsoft Word Installed"
	#define COMP_EXCEL			COMP_CHECK_REQ + "\\Options - Microsoft Excel"
	#define COMP_EXCEL95	COMP_EXCEL + "\\Option - Microsoft Excel 95 Installed"
	#define COMP_EXCEL97	COMP_EXCEL + "\\Option - Microsoft Excel 97 Installed"
	#define COMP_OCC			COMP_CHECK_REQ + "\\Options - Onyx Customer Center"
	#define COMP_OCC40		COMP_OCC + "\\Option - OCC 4.0 Installed"
	#define COMP_OCC_ADMIN50		COMP_OCC + "\\Option - OCC 5.0 Admin 16 bit"
	#define COMP_ONYX_ADMIN_SNAPIN	COMP_OCC + "\\Option - Onyx Admin Snap-In"
	#define COMP_ONYX_EBUSINESS		COMP_OCC + "\\Option - Onyx eBusiness Platform"
	#define COMP_INSIGHT		COMP_CHECK_REQ + "\\Options - Onyx Insight"
	#define COMP_INSIGHT_SS		COMP_INSIGHT + "\\Option - Onyx Insight Search Server Installed"
	#define COMP_INSIGHT_SC		COMP_INSIGHT + "\\Option - Onyx Insight Search Client Installed"
	#define COMP_INSIGHT_ADMIN	COMP_INSIGHT + "\\Option - Onyx Adminstrator Installed"
	#define COMP_MDAC				COMP_CHECK_REQ + "\\Options - MDAC"     			
	#define COMP_MDAC20			COMP_MDAC + "\\Option - MDAC 2.0"
	#define COMP_MDAC_INI		COMP_MDAC + "\\Option - MDAC per INI"	
	#define COMP_IS					COMP_CHECK_REQ + "\\Options - Index Server"     			
	#define COMP_IS20			COMP_IS + "\\Option - Index Server 2.0"
	#define COMP_DCOM				COMP_CHECK_REQ + "\\Options - DCOM (win95 only)"
	#define COMP_DCOM12			COMP_DCOM + "\\Option - DCOM 1.2"
	#define COMP_COMCTL				COMP_CHECK_REQ + "\\Options - COMCTL32 (win95 only)"
	#define COMP_COMCTL47		COMP_COMCTL + "\\Option - COMCTL32 v4.7"
	#define COMP_MTS				COMP_CHECK_REQ + "\\Options - MTS"
	#define COMP_MTS2			COMP_MTS + "\\Option - MTS v2.0"
	#define COMP_MMC				COMP_CHECK_REQ + "\\Options - MMC"
	#define COMP_IE					COMP_CHECK_REQ + "\\Options - IE"
	#define COMP_XML_PARSER			COMP_CHECK_REQ + "\\Options - XML Parser"
	#define COMP_XML_PARSERS		COMP_CHECK_REQ + "\\Options - XML Parsers"
	#define COMP_MSXML3			COMP_XML_PARSER + "\\Option - XML 3.0"
	#define COMP_XML_PARSER3		COMP_XML_PARSERS + "\\Options - MSXML3"
	#define COMP_MSXML4			COMP_XML_PARSER + "\\Option - XML 4.0"
	#define COMP_CR_BEGIN_PLUGIN	COMP_CHECK_REQ + "\\{Plugin - Begin Setup}"
	#define COMP_XML_PARSER4		COMP_XML_PARSERS + "\\Options - MSXML4"
	#define COMP_EXTENDED_MAPI	    COMP_CHECK_REQ + "\\Options - Extended MAPI"
	#define COMP_CDO		    COMP_CHECK_REQ + "\\Options - CDO"
	#define COMP_COGNOS				COMP_CHECK_REQ + "\\Options - Cognos"
	#define COMP_DOT_NET			COMP_CHECK_REQ + "\\Options - Check .Net Framework"	
	#define COMP_OEAS				COMP_CHECK_REQ + "\\Options - OEAS"

	#define COMP_LOOK_FOR_PRODUCT		COMP_SETUP + "\\Action - Look For Product"
	#define COMP_LF_OLD_VERSION		COMP_LOOK_FOR_PRODUCT + "\\Action - Look for older version"
	#define COMP_LF_OLD_PAKS	COMP_LF_OLD_VERSION + "\\Option - Find Old Packages"
	#define COMP_LF_CURRENT_VERSION	COMP_LOOK_FOR_PRODUCT + "\\Action - Look for this version"
	#define COMP_LF_NEWER_VERSION	COMP_LOOK_FOR_PRODUCT + "\\Action - Look for newer version"
	#define COMP_LF_OLD_DATA		COMP_LOOK_FOR_PRODUCT + "\\Dialog - Use Old Data"

	#define COMP_DLG                 COMP_SETUP + "\\Show Dialogs"
	#define COMP_WELCOME             COMP_DLG + "\\Dialog - Welcome"
	#define COMP_LICENSE             COMP_DLG + "\\Dialog - Accept License Agreement"
	#define COMP_REGISTER_USER       COMP_DLG + "\\Dialog - Register User"
	#define COMP_SHOW_DESTINATION    COMP_DLG + "\\Dialog - Show Destination"
	#define COMP_SHOW_STARTCOPY       COMP_DLG + "\\Dialog - Show StartCopy"
	#define COMP_SHUTDOWN			COMP_DLG + "\\Dialog - Shutdown Services"
	#define COMP_SHUTDOWN_MTS	COMP_SHUTDOWN + "\\Option - MTS Components"
	#define COMP_SHUTDOWN_IIS	COMP_SHUTDOWN + "\\Option - IIS Default Web Site"
	#define COMP_SHUTDOWN_NT_SERVICES	COMP_SHUTDOWN + "\\Option - NT Services"
	#define COMP_PROMPT_DLG          COMP_DLG + "\\Dialog - Prompt For Data"
	#define COMP_DLG_APPNAME    COMP_PROMPT_DLG + "\\Dialog - Application Name"
	#define COMP_DLG_SEL_INSTALL    COMP_PROMPT_DLG + "\\Dialog - Select Install Type"
	#define COMP_DATABASE            	COMP_PROMPT_DLG + "\\Dialog - Ask Database Info"
	#define COMP_DB_NAMED_PIPES		COMP_DATABASE + "\\Dialog - Switch DB to Named Pipes"
	#define COMP_DB_SQL_LOGIN       COMP_DATABASE + "\\Action - Verify Database Login"
	#define COMP_DB_SQL_VERSION     COMP_DATABASE + "\\Action - Verify SQL version in DB"
	#define COMP_DB_SUPRESS_LANG    COMP_DB_SQL_VERSION + "\\Action - Supress Language Code Check"
	#define COMP_DB_OCC_VERSION     COMP_DATABASE + "\\Action - Verify OCC version in DB"
	#define COMP_DB_INSIGHT_VERSION COMP_DATABASE + "\\Action - Verify Insight version in DB"
	#define COMP_DB_OEP_VERSION     COMP_DATABASE + "\\Action - Verify Enterprise Portal version in DB"
	#define COMP_DB_ERROR_ABORT     COMP_DATABASE + "\\Option - Abort Setup On SQL Error"
	#define COMP_DB_PRODUCT_VERSION     COMP_DATABASE + "\\Action - Verify Product Version in DB"
	#define COMP_DB_DATABASE_VERSION     COMP_DATABASE + "\\Action - Verify Database Version"
	#define COMP_DATABASE2            	COMP_PROMPT_DLG + "\\Dialog - Ask Database Info 2"
	#define COMP_DB_SQL_LOGIN2      COMP_DATABASE2 + "\\Action - Verify Database Login 2"
	#define COMP_DB_SQL_VERSION2    COMP_DATABASE2 + "\\Action - Verity SQL version in DB 2"
	#define COMP_DB_OCC_VERSION2    COMP_DATABASE2 + "\\Action - Verify OCC version in DB 2"
	#define COMP_DB_INSIGHT_VERSION2     COMP_DATABASE2 + "\\Action - Verify Insight version in DB 2"
	#define COMP_DLG_VWS         COMP_PROMPT_DLG + "\\Dialog - Virtual Web Site"
	#define COMP_DLG_VWS_SITEID  COMP_PROMPT_DLG + "\\Dialog - Web Site SiteID"
	#define COMP_DLG_SQL         COMP_PROMPT_DLG + "\\Dialog - SQL Account"
	#define COMP_DLG_ONYXSA      COMP_PROMPT_DLG + "\\Dialog - OnyxSA Info"
	#define COMP_DLG_DSN         COMP_PROMPT_DLG + "\\Dialog - DSN Name"
	#define COMP_DLG_NTACCOUNT   COMP_PROMPT_DLG + "\\Dialog - NT Account"
	#define COMP_DLG_NTGROUP     COMP_PROMPT_DLG + "\\Dialog - NT Group"
	#define COMP_DLG_DOMAIN_ACCOUNT		COMP_PROMPT_DLG + "\\Dialog - Domain Account"
	#define COMP_DLG_REMOTE_SERVER		COMP_PROMPT_DLG + "\\Dialog - Prompt For Remote Server"
	#define COMP_DLG_SELECT_APP			COMP_PROMPT_DLG + "\\Dialog - Select Application Name"
	#define COMP_DLG_REMOTE_PROXY		COMP_PROMPT_DLG + "\\Dialog - Select Proxy Folder"
	#define COMP_DLG_EMAIL				COMP_PROMPT_DLG + "\\Dialog - Email Information"
	#define COMP_DLG_LOGSETTINGS		COMP_PROMPT_DLG + "\\Dialog - Log Settings"
	#define COMP_DLG_LINEUPDATE			COMP_PROMPT_DLG + "\\Dialog - Line Update Buffer Size"
	#define COMP_DLG_ONYXOWNER	 		COMP_PROMPT_DLG + "\\Dialog - ONYX Owner"
	#define COMP_DLG_LMUSER	  			COMP_PROMPT_DLG + "\\Dialog - LM User"


	#define COMP_OPERATIONS_ROOT     COMP_SETUP + "\\Operation (Loop)"
	#define COMP_OPERATIONS          COMP_OPERATIONS_ROOT + "\\Dialog - Select Operation"
	#define COMP_OPERATIONS_BRANCH   COMP_OPERATIONS

	#define COMP_OPERATION_OPERATION1  		COMP_OPERATIONS_BRANCH + "\\Choice - Operation1"
	#define COMP_O1_DATABASE            COMP_OPERATION_OPERATION1 + "\\Dialog - Ask Database Info"
	#define COMP_O1_DB_SQL_LOGIN       COMP_O1_DATABASE + "\\Action - Verify Database Login"
	#define COMP_O1_DB_SQL_VERSION     COMP_O1_DATABASE + "\\Action - Verity SQL version in DB"
	#define COMP_O1_DB_OCC_VERSION     COMP_O1_DATABASE + "\\Action - Verify OCC version in DB"
	#define COMP_O1_DB_INSIGHT_VERSION		COMP_O1_DATABASE + "\\Action - Verify Insight version in DB"
	#define COMP_O1_DB_OEP_VERSION		COMP_O1_DATABASE + "\\Action - Verify Enterprise Portal version in DB"
	#define COMP_O1_ASK_PATH            COMP_OPERATION_OPERATION1 + "\\Dialog - Ask Path"
	#define COMP_O1_PROMPT_PATH     COMP_O1_ASK_PATH + "\\Action - Prompt For Path"
	#define COMP_O1_CHECK_FILES     COMP_O1_ASK_PATH + "\\Action - Check For Files"
	#define COMP_O1_ASK_SETUP_TYPE      COMP_OPERATION_OPERATION1 + "\\Dialog - Ask Setup Type"
	#define COMP_O1_TYPICAL			COMP_O1_ASK_SETUP_TYPE + "\\Choice - Operation1 - Typical"
	#define COMP_O1_CUSTOM			COMP_O1_ASK_SETUP_TYPE + "\\Choice - Operation1 - Custom"
	#define COMP_O1_ASK_COMPONENTS      	COMP_O1_CUSTOM + "\\Dialog - Ask Components"
	#define COMP_O1_FIND_ADDITIONAL_FILES	COMP_O1_CUSTOM + "\\Action - Find Additional Files"                       	
	#define COMP_O1_COMPACT			COMP_O1_ASK_SETUP_TYPE + "\\Choice - Operation1 - Compact"
	#define COMP_O1_NETWORK			COMP_O1_ASK_SETUP_TYPE + "\\Choice - Operation1 - Network"
	#define COMP_O1_DEVELOPMENT			COMP_O1_ASK_SETUP_TYPE + "\\" + CHOICE_MARKER + OEP_SETUP_TYPE_DEV 						
	#define COMP_O1_ASK_GROUP			COMP_O1_DEVELOPMENT + "\\Dialog - Ask NT Group"
	#define COMP_O1_PRODUCTION		COMP_O1_ASK_SETUP_TYPE + "\\" + CHOICE_MARKER + OEP_SETUP_TYPE_PRODUCTION
	#define COMP_O1_ASK_FOLDER      COMP_OPERATION_OPERATION1 + "\\Dialog - Ask Folder"
	#define COMP_O1_SYSTEM_PARMS        COMP_OPERATION_OPERATION1 + "\\Action - Commit System Parameters"
	#define COMP_CREATE_DSN			COMP_O1_SYSTEM_PARMS + "\\Action - Create DSN name"
	#define COMP_DSN_TO_ASA			COMP_O1_SYSTEM_PARMS + "\\Action - Put DSN name in ASA file"
	#define COMP_SQL_TO_ASA			COMP_O1_SYSTEM_PARMS + "\\Action - Put SQL data in ASA file"
	#define COMP_INI_TO_ASA			COMP_O1_SYSTEM_PARMS + "\\Action - Put INI data into ASA File"
	#define COMP_INI_TO_FILE		COMP_O1_SYSTEM_PARMS + "\\Action - Put INI data into Files"
	#define COMP_ENCRYPT_ACCOUNT	COMP_O1_SYSTEM_PARMS + "\\Action - Encrypt MTS Account"
	#define COMP_CREATE_NT_GROUP	COMP_O1_SYSTEM_PARMS + "\\Action - NT Group"
	#define COMP_CREATE_NT_ACCOUNT	COMP_O1_SYSTEM_PARMS + "\\Action - NT Account"
	#define COMP_CREATE_MTS_COMP	COMP_O1_SYSTEM_PARMS + "\\Action - Import MTS package"
	#define COMP_PROCESS_PROPS    	COMP_O1_SYSTEM_PARMS + "\\Action - Process Properties File"
	#define COMP_EXPORT_MTS_PAK		COMP_O1_SYSTEM_PARMS + "\\Dialog - Export MTS package"
	#define COMP_CREATE_COM_APP		COMP_O1_SYSTEM_PARMS + "\\Action - Create COM+ Appliction"
	#define COMP_CREATE_VWS1		COMP_O1_SYSTEM_PARMS + "\\Action - Create Virtual WebSite1"
	#define COMP_ADD_SVG_MIMETYPE   COMP_O1_SYSTEM_PARMS + "\\Action - Add SVG MIME Type"
	#define COMP_ADD_VBI_MIMETYPE   COMP_O1_SYSTEM_PARMS + "\\Action - Add VBI MIME Type"
	#define COMP_VWS_PRODUCT1		COMP_CREATE_VWS1 + "\\Product Virtual Dir"						
	#define COMP_VWS_HELP			COMP_CREATE_VWS1 + "\\Help Virtual Dir"						
	#define COMP_VWS_ANONYMOUS		COMP_CREATE_VWS1 + "\\Set VWS Anonymous User"
	#define COMP_VWS_ANONYMOUS_OFF	COMP_CREATE_VWS1 + "\\Set VWS dir Anonymous User OFF"
	#define COMP_CREATE_VWS2		COMP_O1_SYSTEM_PARMS + "\\Action - Create Virtual WebSite2"
	#define COMP_VWS_PRODUCT2		COMP_CREATE_VWS2 + "\\Product Virtual Dir"
	#define COMP_ADDDOT_NET_COMP	COMP_O1_SYSTEM_PARMS + "\\Action - Register Dot Net Components"
	#define COMP_CONFIG_MIDDLETIER	COMP_O1_SYSTEM_PARMS + "\\Action - Config Middle Tier"
	#define COMP_OFS_ADMIN_CONF		COMP_O1_SYSTEM_PARMS + "\\Action - OFS Admin Config"
	#define COMP_OFS_ISSERV_CONF	COMP_O1_SYSTEM_PARMS + "\\Action - OFS IS Server Config"
	#define COMP_SET_DB_TCPIP		COMP_O1_SYSTEM_PARMS + "\\Dialog - Switch DB to TCPIP"
	#define COMP_UPGRADE_DICTIONARY	COMP_O1_SYSTEM_PARMS + "\\Action - Upgrade XML Dictionary"
	#define COMP_SET_PATH			COMP_O1_SYSTEM_PARMS + "\\Action - Set Path"
	#define COMP_EXECUTE_PROXY		COMP_O1_SYSTEM_PARMS + "\\Action - Execute Proxy MSI"
	#define COMP_ADD_MIME    		COMP_O1_SYSTEM_PARMS + "\\Action - Add VBI Mime type"
	#define COMP_UPDATE_SERVER_CONN COMP_O1_SYSTEM_PARMS + "\\Action - Update Server Connections"
	#define COMP_EXECUTE_OPSSYNCREG		COMP_O1_SYSTEM_PARMS + "\\Action - Call OPSSync Reg"
	#define COMP_EXECUTE_ACCESSRIGHTSREG		COMP_O1_SYSTEM_PARMS + "\\Action - Call OnyxPSExchangeAccessRights Reg"
	#define COMP_WRITE_XML			COMP_O1_SYSTEM_PARMS + "\\Action - Copy Sync XML"

	#define COMP_O1_BEGIN_PLUGIN        COMP_OPERATION_OPERATION1 + "\\{Plugin - Begin Operation1}"
	#define COMP_O1_VERIFY              COMP_OPERATION_OPERATION1 + "\\Dialog - Validate User Input"
	#define COMP_O1_COPY_FILES          COMP_OPERATION_OPERATION1 + "\\Action - Copy Files"
	#define COMP_O1_COPY_ADDITIONAL_FILES	COMP_O1_COPY_FILES + "\\Action - Copy Additional Files"
	#define COMP_O1_PROCESS_REG_FILES		COMP_O1_COPY_FILES + "\\Action - Process REG files"
	#define COMP_O1_RUN_SQL             COMP_OPERATION_OPERATION1 + "\\Action - Run SQL Scripts"
	#define COMP_O1_SHOW_SQL_RESULTS    COMP_OPERATION_OPERATION1 + "\\Dialog - Show SQL Results"
	#define COMP_O1_PLUGIN_MESSAGE      COMP_OPERATION_OPERATION1 + "\\Dialog - End O1 Plugin Message"
	#define COMP_O1_ASK_FOLDER_POST		COMP_OPERATION_OPERATION1 + "\\Dialog - Ask Folder Post Install"
	#define COMP_O1_END_PLUGIN          COMP_OPERATION_OPERATION1 + "\\{Plugin - End Operation1}"

	#define COMP_OPERATION_OPERATION2		COMP_OPERATIONS_BRANCH + "\\Choice - Operation2"
	#define COMP_O2_ASK_SETUP_TYPE      COMP_OPERATION_OPERATION2 + "\\Dialog - Ask Operation2 Setup Type"
	#define COMP_O2_COMPLETE     	COMP_O2_ASK_SETUP_TYPE + "\\Choice - Operation2 - Complete"
	#define COMP_O2_TYPICAL			COMP_O2_ASK_SETUP_TYPE + "\\Choice - Operation2 - Typical"
	#define COMP_O2_MSG					COMP_OPERATION_OPERATION2 + "\\Dialog - Confirm Operation2"
	#define COMP_O2_SYSTEM_PARMS        COMP_OPERATION_OPERATION2 + "\\Dialog - Set System Parameters"
	#define COMP_O2_BEGIN_PLUGIN        COMP_OPERATION_OPERATION2 + "\\{Plugin - Begin Operation2}"
	#define COMP_O2_VERIFY              COMP_OPERATION_OPERATION2 + "\\Dialog - Validate User Input"
	#define COMP_O2_COPY_FILES          COMP_OPERATION_OPERATION2 + "\\Action - Copy Files"
	#define COMP_O2_COPY_ADDITIONAL_FILES          COMP_O2_COPY_FILES + "\\Action - Copy Additional Files"
	#define COMP_O2_RUN_SQL             COMP_OPERATION_OPERATION2 + "\\Action - Run SQL Scripts"
	#define COMP_O2_SHOW_SQL_RESULTS    COMP_OPERATION_OPERATION2 + "\\Dialog - Show SQL Results"
	#define COMP_O2_END_PLUGIN          COMP_OPERATION_OPERATION2 + "\\{Plugin - End Operation2}"

	#define COMP_OPERATION_OPERATION3		COMP_OPERATIONS_BRANCH + "\\Choice - Operation3"
	#define COMP_O3_SYSTEM_PARMS        COMP_OPERATION_OPERATION3 + "\\Dialog - Set System Parameters"
	#define COMP_O3_BEGIN_PLUGIN        COMP_OPERATION_OPERATION3 + "\\{Plugin - Begin Operation3}"
	#define COMP_O3_VERIFY              COMP_OPERATION_OPERATION3 + "\\Dialog - Validate User Input"
	#define COMP_O3_MSG		            COMP_OPERATION_OPERATION3 + "\\Dialog - Confirm Rebuild"
	#define COMP_O3_COPY_FILES          COMP_OPERATION_OPERATION3 + "\\Action - Copy Files"
	#define COMP_O3_COPY_ADDITIONAL_FILES          COMP_O3_COPY_FILES + "\\Action - Copy Additional Files"
	#define COMP_O3_RUN_SQL             COMP_OPERATION_OPERATION3 + "\\Action - Run SQL Scripts"
	#define COMP_O3_SHOW_SQL_RESULTS    COMP_OPERATION_OPERATION3 + "\\Dialog - Show SQL Results"
	#define COMP_O3_END_PLUGIN          COMP_OPERATION_OPERATION3 + "\\{Plugin - End Operation3}"

	#define COMP_OPERATION_OPERATION4		COMP_OPERATIONS_BRANCH + "\\Choice - Operation4"
	#define COMP_O4_SYSTEM_PARMS        COMP_OPERATION_OPERATION4 + "\\Dialog - Set System Parameters"
	#define COMP_O4_BEGIN_PLUGIN        COMP_OPERATION_OPERATION4 + "\\{Plugin - Begin Operation4}"
	#define COMP_O4_VERIFY              COMP_OPERATION_OPERATION4 + "\\Dialog - Validate User Input"
	#define COMP_O4_MSG		            COMP_OPERATION_OPERATION4 + "\\Dialog - Confirm Rebuild"
	#define COMP_O4_COPY_FILES          COMP_OPERATION_OPERATION4 + "\\Action - Copy Files"
	#define COMP_O4_COPY_ADDITIONAL_FILES    COMP_O4_COPY_FILES + "\\Action - Copy Additional Files"
	#define COMP_O4_RUN_SQL             COMP_OPERATION_OPERATION4 + "\\Action - Run SQL Scripts"
	#define COMP_O4_SHOW_SQL_RESULTS    COMP_OPERATION_OPERATION4 + "\\Dialog - Show SQL Results"
	#define COMP_O4_END_PLUGIN          COMP_OPERATION_OPERATION4 + "\\{Plugin - End Operation4}"				

	#define COMP_EXIT_SETUP              COMP_SETUP + "\\Exit Setup"
	#define COMP_EXIT_PLUGIN         COMP_EXIT_SETUP + "\\{Plugin - End Setup}"
	#define COMP_EXIT_LOGFILES    COMP_EXIT_SETUP + "\\Dialog -  Location of log files"
	#define COMP_EXIT_REG	         COMP_EXIT_SETUP + "\\Action - Register files with REGIT"
	#define COMP_EXIT_FINISH_DLG     COMP_EXIT_SETUP + "\\Dialog - Finish"

	#define COMP_ASK_COPY_OR_INSTALL	COMP_PROMPT_DLG + "\\Dialog - Ask Copy or Install"



//////////////////// installation declarations ///////////////////

// ----- DLL function prototypes -----
prototype _regtlb.RegTlbFile32 ( STRING );  //for registering TLB files.

// ---- script function prototypes -----

    // generated by the Project Wizard
    prototype ShowDialogs();
    prototype MoveFileData();
    prototype HandleMoveDataError( NUMBER );
    prototype ProcessBeforeDataMove();
    prototype ProcessAfterDataMove();
    prototype SetupRegistry();
    prototype SetupFolders();
    prototype CleanUpInstall();
    prototype SetupInstall();
    prototype SetupScreen();
    //prototype CheckRequirements();

    // your script function prototypes
    prototype OCreateNewMedia( STRING, STRING, STRING, BOOL );
    prototype OAddChildComponentsToList( STRING, STRING, BYREF LIST );
    prototype OIsComponentSelected( STRING );
    prototype OIsUpgrade();
    prototype OLaunchAppAndWait( STRING, STRING );
	prototype OShowDataBaseDialogs(NUMBER);
	prototype OOperation1DataBaseDialogs(NUMBER);
	prototype ODataBaseDialogs(STRING,NUMBER,NUMBER);
	prototype OShowPromptDialogs(NUMBER);
    prototype OShowOperation1Dialogs( NUMBER );
    prototype OShowOperation2Dialogs( NUMBER );
    prototype OShowOperation3Dialogs( NUMBER );
    prototype OShowOperation4Dialogs( NUMBER );
//    prototype OShowLicensingDialogs( NUMBER );
//    prototype OShowRecoverDialogs( NUMBER );
//    prototype OActionValidate( );
    prototype OLaunchExesInComponent( STRING );
    prototype OPlugin( STRING );
    prototype OPluginReadIni(BYREF STRING,BYREF STRING);
    prototype OPluginEndOperation();
    prototype OSearchAndReplace( BYREF STRING, STRING, STRING );
    prototype OIsSetupTypeCustom( STRING );
    prototype ORegTypeLibraries();
    prototype OSkipSetup();
//    prototype ORegNTServices();
//    prototype _RegHelpFiles();
    prototype _InitUninstall();
	prototype _SetupUninstDll(STRING);
	prototype _CreateUninstINI(STRING);
	prototype _GetNextAvailableEntryNumber(STRING,BYREF STRING,STRING);
	prototype OBreakPoint();
	prototype _EstablishDefaultDir(BYREF STRING);

    // ----- global variables ------

    // generated by the Project Wizard
    BOOL        bWinNT, bIsShellExplorer, bInstallAborted, bIs32BitSetup;
    STRING      gszProductName,gszProductVersion,gszProductKeyPath,gszProductKey,gszProductIcon,gszFolderName;
    STRING		gszDir;
    STRING      gszProductNameOnly,gszProductNameEnglish,gszName,gszCompany,gszSerial;
    STRING      gszSetupType;
    BOOL        g_bCompletedFileTransfer;  // Have we called MoveFileData() yet?

    // your global variables
	BOOL	gbRecovery; //set to TRUE if setup is in a restart or recovery mode.
	BOOL	gbCopyForMod;	 // copy schema files for midification
	BOOL	gbCopyFiles,gbCopyExtraFiles,gbRunSQL,gbSQLResults,gbMTSinfo,gbSystemParms,gbRegFiles; //set to copy files or not.
	STRING	gszOperationComponent,gszFirstDialog;
	STRING  gszDotNetInstallRoot;
	STRING  gszMajorVersion, gszMinorVersion;
	STRING  gszOnyxApplicationPath;
	
	STRING	gszOCC,gsz_OBPSUser,gsz_OBPSDesc; //for components that have to be installed to OCC dir.
	STRING  gszTemp,gszMsg[1024]; //for displaying messages.
	STRING  gszHelpUser,gszHelpPassword; //depends on if it's DB login or NT login
	INT		nTemp;
	STRING	gszDatabaseType;		// platform flag
	STRING	gszDatabaseInstallType; //whether it's a new install, an upgrade, or a rebuild
	STRING  gszSQLAOE;				// path used to process sql through sqlplus  (79 char limit)
	STRING	gszSQLPathOp1E;			// path for newinstall.txt
	STRING  gsCmplistPath;
	BOOL    gbIIS7;
	#define OCC_DEFAULT_DIR "Customer Center"

	LIST glistServicesToStart,glistOfOldVersions,glistOfOldPackages;

	STRING	gsApptarget, gsEmailServer, gsEmailFrom, gsEmailTo, gsOSSServer, gszLineUpdate;

	NUMBER	gnLogSettings, gnPlatformType;










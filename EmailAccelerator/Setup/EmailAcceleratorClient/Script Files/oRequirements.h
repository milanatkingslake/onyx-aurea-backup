prototype oCheckRequirements();
prototype ODetermineOPSPlatform();
prototype _ReqErrorChk(BYREF NUMBER,BYREF NUMBER,BYREF STRING,BYREF STRING);
prototype _DetermineOperation(STRING,STRING,BYREF STRING,BYREF STRING,BYREF NUMBER);
prototype _CheckReqVersion(STRING,STRING,BYREF STRING);
prototype _IsItemRequired(STRING);
prototype OCheckSQLRequirements(POINTER);
prototype _CheckForWord(BYREF STRING);
prototype _GetWordVersion(STRING);
prototype _GetVerFromDB(POINTER,STRING,BYREF STRING,BYREF STRING);
prototype _GetSQLVerFromDB(POINTER,BYREF STRING);
prototype _GetOCCVerFromDB(POINTER,BYREF STRING);
prototype _GetInsightVerFromDB(POINTER,BYREF STRING);
prototype _GetOEPVerFromDB(POINTER,BYREF STRING);
prototype _CheckForCognos();
prototype _PreviousVersionFound();
prototype _CheckForDotNetFrameWork();
prototype _GetLanguageCodeFromDB(POINTER, BYREF STRING);
//prototype OIsDataEqualToMisc(STRING,STRING,STRING,BYREF STRING);
prototype OIsDataGreaterThanMisc(STRING,STRING,STRING,BYREF STRING);
prototype _CheckDBCollation(POINTER, DATABASE_INFO POINTER);
prototype _CheckForIIS(STRING);
prototype _CheckForJVM(BYREF STRING);
prototype _CheckForWSH(BYREF STRING);
prototype _CheckForODBC32();
prototype _CheckForINSIGHT_ADMIN();
prototype _CheckForINSIGHT_SS();
prototype _CheckForINSIGHT_SC();
prototype _CheckForMDAC(BYREF STRING);
prototype _CheckForIS(STRING);
prototype _CheckForOCC(STRING);
prototype _CheckForOCCAdmin(STRING);
prototype _CheckForOnyxAdminPI(BYREF STRING);
prototype _CheckForDCOM(STRING);
prototype _CheckForCOMCTL32(STRING);
prototype _CheckForMTS(STRING);
prototype _CheckForMMC(BYREF STRING);
prototype _CheckForIE(BYREF STRING);
prototype _CheckForXMLParser(BYREF STRING);
prototype _CheckForXMLParser3(BYREF STRING);
prototype _CheckForXMLParser4(BYREF STRING);
prototype _CheckPreviousVersion(BYREF STRING, BYREF STRING, BYREF STRING);
prototype _CheckSideBySide();
prototype _GetIEVersion(BYREF INT,BYREF INT,BYREF INT,BYREF INT,BYREF INT,BYREF STRING);
prototype _GetPreviousVersionInReg(BYREF STRING,BYREF STRING,BYREF STRING);
prototype _SetPreviousVersionInReg(BYREF STRING,BYREF STRING,BYREF STRING);
prototype _CheckForPreviousProduct(STRING);
prototype _GetProductAppPath(STRING,BYREF STRING);
prototype _IsItemAlreadyInstalled(STRING,STRING,STRING);
prototype OCheckDataCatMsg(STRING,STRING,BYREF STRING,STRING);
//prototype _CatAllStrings(BYREF STRING,BYREF STRING,BYREF STRING,BYREF STRING,BYREF STRING,BYREF STRING,BYREF STRING,BYREF STRING,BYREF STRING);
prototype _CheckNT(BYREF STRING);
prototype _CheckWin2k(BYREF STRING);
prototype _CheckWin2k3(BYREF STRING);
prototype _IsNTServer();
prototype _IsWin2KServer();
prototype _DetermineMAPIVersion();
prototype _DetermineCDOVersion();
prototype _CheckForOBPSSetup(BYREF STRING);
prototype _Check2KSP(STRING);

prototype mpr.WNetGetConnectionA(BYREF STRING, BYREF STRING, BYREF LONG);

/*
#define REQ_ODBC "ODBC"
#define REQ_SQL "SQL"
#define REQ_WORD "Word"
#define REQ_EXCEL "Excel"
#define REQ_OCC "OCC"
#define REQ_OEP "OEP"
#define REQ_INSIGHT "Insight"
#define REQ_INSIGHT_ADMIN "Insight Admin"
#define REQ_INSIGHT_SS "Insight Search Server"
#define REQ_INSIGHT_SC "Insight Search Client"
#define REQ_MDAC "Microsoft Data Access Components"
#define REQ_DCOM "Distributed Component Object Model"
#define REQ_COMCTL32 "Component Control DLL"
*/
#define REQ_ODBC @REQ_ODBC
#define REQ_SQL @REQ_SQL
#define REQ_WORD @REQ_WORD
#define REQ_EXCEL @REQ_EXCEL
#define REQ_MMC @REQ_MMC
#define REQ_OCC @REQ_OCC
#define REQ_ONYX_ADMIN_16 @REQ_ONYX_ADMIN_16
#define REQ_ONYX_ADMIN_SNAPIN @REQ_ONYX_ADMIN_SNAPIN
#define REQ_ONYX_FULLFILLMENT @REQ_ONYX_FULLFILLMENT
#define REQ_OEP @REQ_OEP
#define REQ_INSIGHT @REQ_INSIGHT
#define REQ_INSIGHT_ADMIN @REQ_INSIGHT_ADMIN
#define REQ_INSIGHT_SS @REQ_INSIGHT_SS
#define REQ_INSIGHT_SC @REQ_INSIGHT_SC
#define REQ_MDAC @REQ_MDAC
#define REQ_DCOM @REQ_DCOM
#define REQ_COMCTL32 @REQ_COMCTL32

//dll contants
#define ERROR_NOT_CONNECTED              2250
#define NO_ERROR	0

typedef SYS_INFO //data of software on machine running setup.
begin
	NUMBER nOS_Type;
	STRING szOS[20];
	STRING szOS_Version[20];
	STRING szODBC_Version[20];
	STRING szSQL_Version[20];
	STRING szSQL_Path[255];
	STRING szWord_Version[20];
	STRING szWord_Path[255];
	STRING szExcel_Version[20];
	STRING szExcel_Path[255];
	STRING szOCC_Version[20];
	STRING szOCC_Path[255];
	STRING szOCCAdmin_Version[20];
	STRING szOCCAdmin_Path[255];
	STRING szOCCAdminSI_Version[20];
	STRING szOCCAdminSI_Path[255];
	STRING szInsight_Version[20];
	STRING szInsight_Path[255];
	STRING szInsight_Admin_Version[20];
	STRING szInsight_Admin_Path[255];
	STRING szInsight_SS_Version[20];
	STRING szInsight_SS_Path[255];
	STRING szInsight_SC_Version[20];
	STRING szInsight_SC_Path[255];
	STRING szIIS_Version[20];
	STRING szIIS_Path[255];
	STRING szMDAC_Version[20];
	STRING szIS_Version[20];
	STRING szDCOM_Version[20];
	STRING szCOMCTL32_Version[20];
	STRING szMTS_Version[20];
	STRING szMMC_Version[20];
	STRING szIE_Version[20];
	STRING szPrevious_Name[128];
	STRING szPrevious_Version[20];
	STRING szPrevious_Path[256];
	STRING szCurrent_Version[20];
	STRING szKey_File1[256];
	STRING szKey_File2[256];
	STRING szKey_File3[256];
	STRING szBisObj_Ver[20];
end;

SYS_INFO g_structSystemData;




























































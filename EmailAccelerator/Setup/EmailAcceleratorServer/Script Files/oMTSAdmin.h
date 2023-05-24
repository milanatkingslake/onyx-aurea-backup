prototype OInstallMTSPackages(BYREF STRING);
//prototype _GetPAKfileCLSID(BYREF STRING,BYREF STRING);

LONG gAdminDLLRefCount;

//for COM+ components
typedef SETUP_COM
begin
	STRING szRole1[80];
	STRING szRole2[80];
	STRING szRole3[80];
	STRING szRole4[80];
end;
SETUP_COM g_structCOM;

#define E_INVALIDARG	0x80070057L
#define E_MTS_CANTCOPYFILE	0x8011040d
#define E_MTS_BADPATH					0x8011040a					
#define E_MTS_ALREADYINSTALLED			0x80110404			
#define E_MTS_PACKAGEEXISTS				0x8011040b
#define E_MTS_USERPASSWDNOTVALID		0x80110414
#define E_MTS_PDFWRITEFAIL				0x80110407
#define E_MTS_CLSIDORIIDMISMATCH		0x80110418
#define E_MTS_OBJECTERRORS				0x80110401
#define E_ACCESSDENIED					0x80070005
#define E_COMPONENT_EXISTS				0x80041011

#define COM_APP_INI	"Component Services Appliction"

prototype AddRefMTSAdminDLL();
prototype ReleaseMTSAdminDLL();
prototype OMTSIns.ShutdownPackageByName(STRING);
prototype OMTSIns.ImportPackagesFrom(STRING, STRING, STRING);
prototype OMTSIns.ShutdownPackage(STRING);
prototype OMTSIns.RemovePackage(STRING);
prototype OMTSIns.ImportPackage(STRING,STRING,STRING,STRING);
prototype OMTSIns.ExportPackage(STRING,STRING);
prototype OMTSIns.GetComponentPath(STRING,STRING);
prototype oMTSShutdownPackageByTag(STRING);
//prototype oMTSInstallPackagesFrom(STRING, STRING, STRING);
//prototype oMTSInstallPackages(STRING);
prototype OMTSShutdownPackages(BYREF LIST);
prototype OComShutdownApps();
prototype oMTSShutdownPackage(STRING);
prototype oMTSRemovePackage(STRING);
prototype oMTSImportPackage(STRING,STRING,STRING,STRING);
prototype oMTSExportPackages(BYREF STRING,BYREF STRING);
prototype oMTSExportPackage(BYREF STRING,BYREF STRING);
prototype oMTSGetComponentPath(STRING,BYREF STRING);
prototype oMTSPromptForExportPath(BYREF STRING);
//prototype OGetListOfOldPackages(STRING,BYREF LIST);
prototype ODeleteOldPackages(BYREF LIST);
prototype oMTSPackageError(BYREF STRING,INT);
prototype oCOMAddApp();
prototype _PutRoleIntoStruct(BYREF STRING,INT);
prototype _COMAppError();





//---OEDUpgrade Data
#define SCHEMA_CONVERSION_LOG            		"OED_schema_conversion_log.txt"
#define OED_UPGRADE_LOG            				"OED_upgrade_log.txt"
#define OED_UPGRADE_EXE            				"OnyxDictionaryInstall.exe"
#define SCHEMA_CONVERSION_SCRIPT      			"OnyxSchemaConversionScript.vbs"
#define MASTER_OED_FILENAME						"OnyxEnterpriseDictionary.xml"
#define CURRENT_OED_FILENAME					"OnyxEnterpriseDictionary.xml"
#define BACKUP_OED_FILENAME						"OnyxEnterpriseDictionary_backup.xml"
#define TEMP_CONVERTED_OED_FILENAME				"TempConvertedOED.xml"
#define FINAL_OUTPUT_OED_FILENAME				"OnyxEnterpriseDictionary_6.0.xml"
#define OED_VERSION_SEARCH_STRING				"OEASVersion="
#define ORIGINAL_OED_MASK						"OED_V*.XML"
#define OED_UPGRADE_RULES_MASK					"OEDUpgrade_rules*.xml"
#define OUTPUT_FOLDER_NAME						"OED Upgrade Output"
#define READ_ME_FILE_NAME						"ReadMe.txt"
#define UPGRADE_LOG_FILE_NAME					"OED_upgrade_log.txt"

typedef OED_UPGRADE_DATA
begin
	STRING szAppName[100];
	STRING szAppPath[255];
	STRING szOutputPath[255];
	STRING szInputOedFile[255];
	STRING szNewMasterOedFile[255];	
	STRING szOriginalOedPath[255];	
	STRING szWorkingPath[255];
	STRING szOutputOedFile[255];
	STRING szLogFilePath[255];
	STRING szRulesFile[255];
end;

OED_UPGRADE_DATA g_structOEDUpgradeData;


prototype OInstallOED();
prototype OCreateRegKeys();
//prototype OSetRegKeys( string );
prototype ORunInstaller();
prototype ORunSchemaConversion();
//prototype OAutoUpgradeOED();
prototype OManualUpgradeOED();
prototype OBackupOED( string );
prototype OUpgradeRegistry( string );
//prototype OGetSQLValuesFromReg(string, BYREF string, BYREF string, BYREF string);
//prototype OGetNewOEDVersion(BYREF string);








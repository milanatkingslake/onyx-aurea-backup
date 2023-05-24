prototype OFindExtraFiles();
prototype _AddGroupToLists(BYREF STRING,BYREF STRING);
prototype _DisplayExtraFiles();
prototype OCopyExtraFiles();
prototype _GetGroupDataThenCopy(STRING,STRING);
prototype _GetGroupItem(STRING,STRING,STRING,BYREF INT,INT);
prototype _CheckGroupIntegrity(BYREF STRING,BYREF STRING);

BOOL bExtraFiles,bDoneOnce;
STRING szExtraFilesDir,szExtraFilesIni;

#define EXTRA_FILE_MEDIA "ExtraFileMedia"
#define EXTRA_FILES "extrafiles"
#define ALL_LANG "all"
#define EXTRA_FILES_INI "extrafiles.ini"
#define SELECT_SECTION "UserSelect"
#define SELECT_KEY_BASE "Select"
#define FILE_KEY_BASE "File"
#define GROUP_KEY_BASE "Group"









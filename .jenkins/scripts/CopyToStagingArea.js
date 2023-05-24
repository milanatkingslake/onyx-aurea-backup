var fso = new ActiveXObject("Scripting.FileSystemObject");
var shell = new ActiveXObject("WScript.Shell");

var al = WScript.Arguments.length;
if (al < 1) {
    WScript.StdErr.WriteLine("Error: Missing input file name.");
    WScript.Quit(-1);
}

// Test users for the PBS automated developer tests.

function main() {
    var scriptName = WScript.ScriptName;
    var folderspec = fso.GetAbsolutePathName(WScript.Arguments.Item(0));
    var folder = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    
    DeleteFolder(folder);
    WatchTheMoonFor(3000);

	WScript.Echo("Starting...");
    PrerequisiteStage(folderspec);
    OEASStage(folderspec);
    OnyxFileAgentStage(folderspec);
    OGPStage(folderspec);
    OGSStage(folderspec);
    OnyxWebServiceStage(folderspec);
    EmailAccelaratorStage(folderspec);

	WScript.Echo("Finished");

}

function WatchTheMoonFor(milliseconds) {
    var start = new Date().getTime();
    for (var i = 0; i < 3e8; i++) {
        var now = new Date().getTime();
        if ((now - start) > milliseconds) {
            break;
        }
    }
}

function DeleteFolder(folder) {
    if (!FolderExists(folder)) {
        return true;
    }

    var fso = new ActiveXObject("Scripting.FileSystemObject");
    
    WScript.Echo("Trying to delete folder: " + folder);
    fso.DeleteFolder(folder, true);
}

function FileExists(filename) {
    var fso = new ActiveXObject("Scripting.FileSystemObject");
    var exists = fso.FileExists(filename);

    WScript.Echo("File " + filename + " exists? " + exists);
    return exists;
}
function DeleteFile(filename) {
    if (!FileExists(filename)) {
        return;
    }

    var fso = new ActiveXObject("Scripting.FileSystemObject");
    WScript.Echo("Trying to delete: " + filename);
    fso.DeleteFile(filename, true);
}

function PrerequisiteStage(folderspec)
{
    WScript.Echo(" Starting Prerequisite Stage...");
       
	var src = folderspec + "\\" + "PrimaryInteropAssembly\\Reference";
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    var preTLBFolder = dest + "\\" + "Onyx Prerequisite\\TLB";
    CreateFolder(preTLBFolder);
    CopyFile("istepstring.tlb", src, preTLBFolder);

    var src = folderspec + "\\" + "OEAS\\Core\\LanguageIndependent\\Output\\Release\\Win32\\IDL";
    CopyFile("istep.tlb", src, preTLBFolder);
    CopyFile("iaction.tlb", src, preTLBFolder);
    
    var prereqGACFolder = dest + "\\" + "Onyx Prerequisite\\GAC";
    CreateFolder(prereqGACFolder);

    CopyFile("*.*",
        folderspec + "\\PrimaryInteropAssembly\\Output\\GAC",
        prereqGACFolder);
    CopyFile("*.*",
        folderspec + "\\PrimaryInteropAssembly\\Output\\Development",
        prereqGACFolder);
    CopyFile("*.*",
        folderspec + "\\PrimaryInteropAssembly\\Output\\GAC_Policy",
        prereqGACFolder);
    CopyFile("*.*",
        folderspec + "\\PrimaryInteropAssembly\\Reference\\GAC_Policy",
        prereqGACFolder);
    CopyFile("*.*",
        folderspec + "\\PrimaryInteropAssembly\\Reference\\Development_Policy",
        prereqGACFolder);        
    CopyFile("*.*",
        folderspec + "\\PrimaryInteropAssembly\\Output\\Development_Policy",
        prereqGACFolder);
    // CopyFile("ogsService.config",
    //     folderspec + "\\Installers\\StagingFiles",
    //     dest + "\\Onyx Prerequisite\\OnyxSDK\\configurationfile\\");

   	WScript.Echo(" Finished Prerequisite Stage");
}

function OEASStage(folderspec)
{
   	WScript.Echo(" Starting OEAS Stage...");

    var src = folderspec + "\\" + "OEAS\\SQLServer\\English\\MasterDictionary";
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    var OEAS = dest + "\\" + "OEAS";
    CreateFolder(OEAS);
    CopyFile("OnyxEnterpriseDictionary.xml", src, OEAS);
    CopyFile("OnyxEnterpriseDictionarySchema.xml", src, OEAS);

    var src = folderspec + "\\" + "BusinessRuleManager\\BuildScripts\\Output";
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    var OEASBRM = dest + "\\" + "OEAS\\BusinessRuleManager\\Engine";
    CreateFolder(OEASBRM);

    CopyFile("businessRuleManager.messages.xml", src, OEASBRM);
    CopyFile("businessRuleManager.repositories.xml", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Base.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Boolean.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Data.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Date.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.File.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Float.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Integer.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Onyx.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.Process.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.BusinessRuleManager.String.dll", src, OEASBRM);
    CopyFile("ConsonaCRM.Onyx.StepComponentBase.dll", src, OEASBRM);
    CopyFile("OnyxEDCachePIA.dll", src, OEASBRM);
    CopyFile("OnyxGetAppDataPIA.dll", src, OEASBRM);

    var src = folderspec + "\\" + "CommonLibrary\\Output";
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    var OEASComp = dest + "\\" + "OEAS\\Components";
    CreateFolder(OEASComp);
    CopyFile("OGSConfiguration.exe", src, OEASComp);
    CopyFile("OGSProxyConfiguration.exe", src, OEASComp);
    CopyFile("ONSConfiguration.exe", src, OEASComp);
    CopyFile("PasswordEncryptLibrary.dll", src, OEASComp);
    CopyFile("publicKey.puk", src, OEASComp);

    var src = folderspec + "\\" + "OEAS\\Core\\BuildScripts\\Output\\Release";
    
    CopyFile("OEDDACCacheLoc.dll", src, OEASComp);
    CopyFile("OnyxNatLangAdminStepLoc.dll", src, OEASComp);
    CopyFile("OnyxDictionaryCacheProxyLoc.dll", src, OEASComp);
    CopyFile("OnyxMasterDetailRetrievalStepLoc.dll", src, OEASComp);
    CopyFile("OnyxTransformStepLoc.dll", src, OEASComp);
    CopyFile("OnyxWorkNoteStepLoc.dll", src, OEASComp);
    CopyFile("OnyxEDCacheLoc.dll", src, OEASComp);
    CopyFile("OnyxTMLoc.dll", src, OEASComp);
    CopyFile("OnyxWorkNoteDetailStepLoc.dll", src, OEASComp);
    CopyFile("OnyxWorkNoteHeaderStepLoc.dll", src, OEASComp);
    CopyFile("OnyxCollectionManagerLoc.dll", src, OEASComp);
    
    CopyFile("OnyxMethodCacheLoc.dll", src, OEASComp);
    CopyFile("OnyxSGLoc.dll", src, OEASComp);
    CopyFile("OnyxOSLFEncryptStepLoc.dll", src, OEASComp);
    CopyFile("OnyxPublishableObjectDACLoc.dll", src, OEASComp);
    CopyFile("OnyxDataValidationStepLoc.dll", src, OEASComp);
    CopyFile("OnyxPropagateActionStepLoc.dll", src, OEASComp);
    CopyFile("OnyxEmailSendStepLoc.dll", src, OEASComp);
    CopyFile("OnyxMethodCallExecuteStepLoc.dll", src, OEASComp);
    CopyFile("OnyxOptionalForeignKeyStepLoc.dll", src, OEASComp);
    CopyFile("OnyxGuidGeneratorStepLoc.dll", src, OEASComp);
    CopyFile("OnyxScriptCacheLoc.dll", src, OEASComp);

    CopyFile("OnyxActionBatchExecuteStepLoc.dll", src, OEASComp);
    CopyFile("OnyxScriptEngineStepLoc.dll", src, OEASComp);
    CopyFile("OnyxDMLoc.dll", src, OEASComp);
    CopyFile("OnyxNatLangDAC.dll", src, OEASComp);
    CopyFile("OnyxNatLangProxy.dll", src, OEASComp);
    CopyFile("OnyxStringBuffer.dll", src, OEASComp);
    CopyFile("OnyxFileLog.dll", src, OEASComp);
    CopyFile("OnyxTimer.dll", src, OEASComp);
    CopyFile("GetAppData.dll", src, OEASComp);
    CopyFile("OnyxDictionaryCacheProxy.dll", src, OEASComp);
    CopyFile("OnyxOEDDACCache.dll", src, OEASComp);

    CopyFile("OnyxNatLangCache.dll", src, OEASComp);
    CopyFile("OnyxMethodCache.dll", src, OEASComp);
    CopyFile("OnyxAuthenticate.dll", src, OEASComp);
    CopyFile("OnyxOSLFEncryptStep.dll", src, OEASComp);
    CopyFile("OnyxSGPublish.dll", src, OEASComp);
    CopyFile("OnyxAuthNT.dll", src, OEASComp);
    CopyFile("OnyxCollectionManager.dll", src, OEASComp);
    CopyFile("OnyxSGEngine.dll", src, OEASComp);
    CopyFile("OnyxAssignmentStep.dll", src, OEASComp);
    CopyFile("OnyxEDCache.dll", src, OEASComp);
    CopyFile("OnyxSM.dll", src, OEASComp);

    CopyFile("OnyxActionBatchExecuteStep.dll", src, OEASComp);
    CopyFile("OnyxPublishableObjectDAC.dll", src, OEASComp);
    CopyFile("OnyxNatLangAdminStep.dll", src, OEASComp);
    CopyFile("OnyxMethodCallExecuteStep.dll", src, OEASComp);
    CopyFile("OnyxGuidGeneratorStep.dll", src, OEASComp);
    CopyFile("OnyxMasterDetailRetrievalStep.dll", src, OEASComp);
    CopyFile("OnyxTransformStep.dll", src, OEASComp);
    CopyFile("OnyxBPMaintenanceStep.dll", src, OEASComp);
    CopyFile("OnyxBPExecuteStep.dll", src, OEASComp);
    CopyFile("OnyxWorkNoteHeaderStep.dll", src, OEASComp);
    CopyFile("OnyxWorkNoteDetailStep.dll", src, OEASComp);

    CopyFile("OnyxTM.dll", src, OEASComp);
    CopyFile("OnyxPropagateActionStep.dll", src, OEASComp);
    CopyFile("OnyxWorkNoteStep.dll", src, OEASComp);
    CopyFile("OnyxEBusQE.dll", src, OEASComp);
    //CopyFile("OnyxEBusQE.dll", src, OEASComp);
    CopyFile("OnyxEmailSendStep.dll", src, OEASComp);
    CopyFile("OnyxEASServicesTM.dll", src, OEASComp);
    CopyFile("OnyxOptionalForeignKeyStep.dll", src, OEASComp);
    CopyFile("OnyxSGPrep.dll", src, OEASComp);
    CopyFile("OnyxScriptCache.dll", src, OEASComp);
    CopyFile("OnyxDM.dll", src, OEASComp);
    CopyFile("OnyxScriptEngineStep.dll", src, OEASComp);

    var src = folderspec + "\\" + "OEAS\\LBOAdapters\\OnyxNotificationLBOAdapter\\ConfigFiles";
    CopyFile("LBOAdapter.config", src, OEASComp);

    var src = folderspec + "\\" + "PrimaryInteropAssembly\\Output\\Development";
    CopyFile("*.*", src, OEASComp);

    var src = folderspec + "\\" + "OEAS\\OPS\\BuildScripts\\Output\\OPSStep";
    CopyFile("OnyxPSSysDocStepLoc.dll", src, OEASComp);
    CopyFile("OnyxPSLabelStepLoc.dll", src, OEASComp);
    CopyFile("OnyxPSLabelStep.dll", src, OEASComp);
    CopyFile("OnyxPSSysDocStep.dll", src, OEASComp);

    var src = folderspec + "\\" + "OEAS\\Core\\BuildScripts\\Output\\Release";
    CopyFile("OnyxDataValidationStep.dll", src, OEASComp);

    var src = folderspec + "\\" + "OEAS\\LBOAdapters\\BuildScripts\\Output";
    CopyFile("OnyxNotificationLBOAdapter.dll", src, OEASComp);
    CopyFile("OnyxEDDACLoc.dll", src, OEASComp);
    CopyFile("OnyxDACHelper.dll", src, OEASComp);
    CopyFile("OnyxEDDAC.dll", src, OEASComp);
    CopyFile("OnyxSSRS.dll", src, OEASComp);
    DeleteFile(OEASComp + "\\" + "OnyxPSLogPIA.dll");

    var OEASShareOnyxLog = dest + "\\" + "OEAS\\OEAS_Shared\\OnyxLog";
    CreateFolder(OEASShareOnyxLog);
    var src = folderspec + "\\" + "OEAS\\Core\\BuildScripts\\Output\\Release";
    CopyFile("OnyxLog.dll", src, OEASShareOnyxLog);
    CopyFile("OnyxLogRes.dll", src, OEASShareOnyxLog);


    var OEASShareOSLF = dest + "\\" + "OEAS\\OEAS_Shared\\OSLF";
    CreateFolder(OEASShareOSLF);
    var src = folderspec + "\\" + "OEAS\\Core\\BuildScripts\\Output\\Release";
    CopyFile("OSLFEncrypt.dll", src, OEASShareOSLF);
    CopyFile("OSLFLoc.dll", src, OEASShareOSLF);

    var OEASMasterDict = dest + "\\" + "OEAS";
    CopyFile("OnyxEnterpriseDictionary.xml", src, OEASMasterDict);
    CopyFile("OnyxEnterpriseDictionarySchema.xml", src, OEASMasterDict);
  
   	WScript.Echo(" Finished OEAS Stage");

}


function OnyxFileAgentStage(folderspec) {
   	WScript.Echo(" Starting OFA Stage...");
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    var OFA = dest + "\\" + "OnyxFileAgent";
    var src = folderspec + "\\" + "OEAS\\OnyxFileAgent\\BuildScripts\\Output";
    CreateFolder(OFA);
    CopyFile("OnyxFileAgent.dll", src, OFA);
    CopyFile("OnyxFileAgentLogRes.dll", src, OFA);
    CopyFile("OnyxFileAgentStringRes.dll", src, OFA);

    // ????
    CopyFile("OnyxFileAgent.tlb", folderspec + "\\Installers\\StagingFiles", OFA);    
   
   	WScript.Echo(" Finished OFA Stage");   
}


function OGPStage(folderspec)
{
    WScript.Echo(" Starting OGP Stage...");
       
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    var OGPWeb  = dest + "\\" + "OnyxGatewayProxy\\OnyxProxyWebServices";
    CreateFolder(OGPWeb);
    CopyFile("ClientAccessPolicy.xml", folderspec + "\\ThirdParty", OGPWeb);
    CopyFile("CrossDomainPolicy.xml", folderspec + "\\ThirdParty", OGPWeb);

    var src = folderspec + "\\" + "OnyxGatewayProxy\\OnyxGatewayProxyWebHost";
    CopyFile("Global.asax", src, OGPWeb);
    CopyFile("Web.config", src, OGPWeb);
    
    var src = folderspec + "\\" + "OnyxGatewayProxy\\BuildScripts\\Output";
    CopyFile("privateKey.pvk", src, OGPWeb);
    var OGPWebbin = dest + "\\" + "OnyxGatewayProxy\\OnyxProxyWebServices\\Bin";
    CreateFolder(OGPWebbin);
    CopyFile("log4net.dll", src, OGPWebbin);
    CopyFile("Onyx.CrossOriginSupportData.dll", src, OGPWebbin);    
    CopyFile("Onyx.Gateway.Data.dll", src, OGPWebbin);
    CopyFile("Onyx.Gateway.SharedLibrary.dll", src, OGPWebbin);
    CopyFile("Onyx.GatewayContract.dll", src, OGPWebbin);
    CopyFile("Onyx.GatewayProxy.dll", src, OGPWebbin);
    CopyFile("Onyx.GatewayProxy.Helper.dll", src, OGPWebbin);
    CopyFile("Onyx.LoggerService.dll", src, OGPWebbin);
    CopyFile("PasswordEncryptLibrary.dll", src, OGPWebbin);

    var src = folderspec + "\\" + "CommonLibrary\\Output";
    CopyFile("Onyx.CrossOriginSupportWeb.dll", src, OGPWebbin);

    var src = folderspec + "\\" + "OnyxGatewayProxy\\BuildScripts\\Output";
    var OGPWindows = dest + "\\" + "OnyxGatewayProxy\\OnyxProxyWindowsServices";
    CreateFolder(OGPWindows);
    CopyFile("log4net.dll", src, OGPWindows);
    CopyFile("Onyx.CrossOriginSupportData.dll", src, OGPWindows);
    CopyFile("Onyx.CrossOriginSupportService.dll", src, OGPWindows);
    CopyFile("Onyx.Gateway.Data.dll", src, OGPWindows);
    CopyFile("Onyx.Gateway.SharedLibrary.dll", src, OGPWindows);
    CopyFile("Onyx.GatewayContract.dll", src, OGPWindows);
    CopyFile("Onyx.GatewayProxy.dll", src, OGPWindows);
    CopyFile("Onyx.GatewayProxy.Helper.dll", src, OGPWindows);    
    CopyFile("Onyx.GatewayProxy.WindowsService.exe", src, OGPWindows);    
    CopyFile("Onyx.GatewayProxy.WindowsService.exe.config", src, OGPWindows);
    CopyFile("Onyx.LoggerService.dll", src, OGPWindows);
    CopyFile("PasswordEncryptLibrary.dll", src, OGPWindows);
    CopyFile("privateKey.pvk", src, OGPWindows);
    CopyFile("ClientAccessPolicy.xml", folderspec + "\\ThirdParty", OGPWindows);
    CopyFile("CrossDomainPolicy.xml", folderspec + "\\ThirdParty", OGPWindows);


   	WScript.Echo(" Finished OGP Stage");
}

function OGSStage(folderspec) {
    WScript.Echo(" Starting OGS Stage...");
       
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));

    var OGS = dest + "\\" + "OnyxGatewayServices";
    CreateFolder(OGS);
    var src = folderspec + "\\" + "OnyxGatewayService\\BuildScripts\\Output";
    CopyFile("*.dll", src, OGS);
    CopyFile("CustomEntityHelper.exe", src, OGS);
    CopyFile("OnyxGatewayWindowsService.exe", src, OGS);
    CopyFile("privateKey.pvk", src, OGS);
    CopyFile("emfExtension.config", src, OGS);
    CopyFile("OnyxGatewayWindowsService.exe.config", src, OGS);
    CopyFile("ClientAccessPolicy.xml", folderspec + "\\ThirdParty", OGS);
    CopyFile("CrossDomainPolicy.xml", folderspec + "\\ThirdParty", OGS);

    CreateFolder(OGS + "\\Config");
    CopyFile("*.*", src + "\\Config", OGS + "\\Config");

    var OGSAppdata = dest + "\\" + "OnyxGatewayServices\\App_Data";
    CreateFolder(OGSAppdata);
    var src = folderspec + "\\" + "OnyxGatewayService\\BuildScripts\\Output\\App_Data";    
    CopyFile("*.*", src, OGSAppdata);
    
    // Those 5 XML files required for upgrade from 7.8 to 7.9, but were removed in 7.9 GA. We need to maintain them for installer to build successfully.
    CopyFile("PercentPicker.xml", folderspec + "\\Installers\\StagingFiles", OGSAppdata);
    CopyFile("ScriptStatusDomainData.xml", folderspec + "\\Installers\\StagingFiles", OGSAppdata);
    CopyFile("AttachmentOwnerDomainData.xml", folderspec + "\\Installers\\StagingFiles", OGSAppdata);
    CopyFile("EmailPriorityDomainData.xml", folderspec + "\\Installers\\StagingFiles", OGSAppdata);
    CopyFile("NavigatorBrowseEntities.xml", folderspec + "\\Installers\\StagingFiles", OGSAppdata);
    
    var navigatorProfiles = OGSAppdata + "\\NavigatorProfiles";
    CreateFolder(navigatorProfiles);

    var OGSAppdata = dest + "\\" + "OnyxGatewayServices\\App_Data\\NavigatorProfiles";
    CreateFolder(OGSAppdata);
    var src = folderspec + "\\" + "OnyxGatewayService\\BuildScripts\\Output\\App_Data\\NavigatorProfiles";
    CopyFile("*.*", src, OGSAppdata);
    // Below files required for upgrade from 7.8 to 7.9, but were removed in 7.9 GA. We need to maintain them for installer to build successfully.
    CopyFile("*.*", folderspec + "\\Installers\\StagingFiles\\NavigatorProfiles", navigatorProfiles, true);
    
    var profiles = dest + "\\OnyxGatewayServices\\App_Data\\Profiles";
    CreateFolder(profiles);
    var src = folderspec + "\\OnyxGatewayService\\BuildScripts\\Output\\App_Data\\Profiles";
    CopyFile("IncidentDetails.xml", src, OGSAppdata);
    // Below files required for upgrade from 7.8 to 7.9, but were removed in 7.9 GA. We need to maintain them for installer to build successfully.    
    CopyFolderContents(folderspec + "\\Installers\\StagingFiles\\Profiles", profiles);    

    var OGSAppdata = dest + "\\" + "OnyxGatewayServices\\App_Data\\Templates";
    CreateFolder(OGSAppdata);
    var src = folderspec + "\\" + "OnyxGatewayService\\BuildScripts\\Output\\App_Data\\Templates";
    CopyFile("*.*", src, OGSAppdata);

   	WScript.Echo(" Finished OGS Stage");

}


function OnyxWebServiceStage(folderspec)
{
   	WScript.Echo(" Starting OnyxWebService Stage...");
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));
    var OWS = dest + "\\" + "OnyxWebServices";
    CreateFolder(OWS);
    var src = "C:\\TFS\\Onyx\\Main\\OEAS\\OnyxWebServices\\Publish";
    CopyFolder("*.*", src, OWS);
   	WScript.Echo(" Finished OnyxwebService Stage");
}

function EmailAccelaratorStage(folderspec)
{
   	WScript.Echo(" Starting EmailAccelerator Stage...");
    
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(1));

    var OEAClient = dest + "\\" + "Email Accelerator\\Client\\OnyxEmailAccelerator";
    CreateFolder(OEAClient);
    var src = folderspec + "\\" + "EmailAccelerator\\Code\\Build\\_LanguageIndependant\\OnyxEmailAccelerator";
    CopyFolder("*.*", src, OEAClient);

    var OEAServ = dest + "\\" + "Email Accelerator\\Server";
    CreateFolder(OEAServ);

    var OEAServTImage = dest + "\\" + "Email Accelerator\\Server\\Timage";
    CreateFolder(OEAServTImage);

    var OEAServImage = OEAServ + "\\" + "Timage\\images";
    CreateFolder(OEAServImage);
    
    var OEAServbin = dest + "\\" + "Email Accelerator\\Server\\Timage\\bin";
    CreateFolder(OEAServbin);

    var OEAServRel = dest + "\\" + "Email Accelerator\\Server\\Timage\\bin\\Release";
    CreateFolder(OEAServRel);

    var OEAServUnsub = OEAServ + "\\" + "Unsubscribe";
    CreateFolder(OEAServUnsub);

    var src = folderspec + "\\" + "EmailAccelerator\\BuildScripts\\Output";
    CopyFile("ImageTrackerHandler.dll", src, OEAServRel);
    CopyFile("ImageTrackerHandler.dll", src, OEAServbin);
    CopyFile("web.config", src, OEAServRel);
    CopyFile("web.config", src, OEAServTImage);

    var src = folderspec + "\\" + "EmailAccelerator\\Code\\Build\\_LanguageIndependant\\Unsubscribe";
    CopyFile("*.*", src, OEAServUnsub);

    var src = folderspec + "\\" + "EmailAccelerator\\Code\\Build\\_LanguageIndependant\\TImage\\images";
    CopyFile("space.gif", src, OEAServImage);

    CreateFolder(dest + "\\Email Accelerator\\Client\\OnyxEmailAccelerator\\images");
    CreateFolder(dest + "\\Email Accelerator\\Server\\Timage\\images");
    CopyFile("space.png",
        folderspec + "\\EmailAccelerator\\Code\\Build\\_LanguageIndependant\\TImage\\images",
        dest + "\\Email Accelerator\\Server\\Timage\\images");

    
   	WScript.Echo(" Finished EmailAccelerator Stage");

}

function CopyUpgradeMSI()
{
   	WScript.Echo(" Starting CopyUpgradeMSI Stage...");
    var dest = fso.GetAbsolutePathName(WScript.Arguments.Item(0));
    DeleteFolder("C:\\FolderInWhichMSIWillBeExtracted");
   // var src = "\\10.101.64.81\\dfs$\\builds\\ONYX\\ConsonaCM\\Public";
    var src = fso.GetAbsolutePathName(WScript.Arguments.Item(3));
    var src = src + "\\" + "Platform Components\\Application Server (OEAS)\\OnyxGatewayService";
    var OGSUpgradeItem = dest + "\\" + "Installers\\OnyxGatewayService\\v760";
    var OGStemp = "C:\\FolderInWhichMSIWillBeExtracted\\OGS";
    CreateFolder(OGStemp);
    CopyFolder("*.*", src, OGStemp);
    CreateFolder(OGSUpgradeItem);
    cmd = OGStemp + "\\" + "OnyxGatewayService.exe " + "/s /x /b" + OGSUpgradeItem + " /v\"/qn\"";
    LaunchAndWait(cmd);

    var src = fso.GetAbsolutePathName(WScript.Arguments.Item(3));
    var src = src + "\\" + "Platform Components\\Web Server\\Onyx For Desktop";
    var OEPUpgradeItem = dest + "\\" + "Installers\\OEP\\v760";
    var OEPtemp = "C:\\FolderInWhichMSIWillBeExtracted\\OEP";
    CreateFolder(OEPtemp);
    CopyFolder("*.*", src, OEPtemp);
    CreateFolder(OEPUpgradeItem);
    cmd = OEPtemp + "\\" + "EmployeePortal.exe " + "/s /x /b" + OEPUpgradeItem + " /v\"/qn\"";
    LaunchAndWait(cmd);

   	WScript.Echo(" Finished CopyUpgradeMSI Stage");
}

function LaunchAndWait(cmd) {
    // Modify command so that caller can use command-line redirectors (e.g. > or >>).
    var cmd2 = "%comspec% /c \"" + cmd + "\"";

    var WshShell = new ActiveXObject("WScript.Shell");

    var r = 0;
    if (cmd2.length <= 2029) {
        r = WshShell.Run(cmd2, 1, true);
    }
    else {
        var tempBatch = "tempBatch2029.bat";
        WriteTextFile(tempBatch, cmd2);

        r = WshShell.Run(tempBatch, 1, true);

        DeleteFile(tempBatch);
    }

    return r;
}

function FolderExists(folder) {
    var fso = new ActiveXObject("Scripting.FileSystemObject");
    var exists = fso.FolderExists(folder);

    WScript.Echo("Folder " + folder + " exists? " + exists);
    return exists;
}

function CreateFolder(folder) {
    if (folder == "" || folder == null || folder == undefined) {
        WScript.Echo("Create folder failed. Folder var is empty, null or undefined.");
        return false;
    }

    if (FolderExists(folder)) {
        /*cmd = "icacls \"" + folder + "\"" + " /grant SWG\\svc_TFSLABSVC:(OI)(CI)F";
        LaunchAndWait(cmd);*/
        return true;
    }

    var fso = new ActiveXObject("Scripting.FileSystemObject");

    var parent = fso.GetParentFolderName(folder);
    CreateFolder(parent);

    WScript.Echo("Creating folder: " + folder);
    fso.CreateFolder(folder);
    /*cmd = "icacls \"" + folder + "\"" + " /grant SWG\\svc_TFSLABSVC:(OI)(CI)F";
    LaunchAndWait(cmd);*/
    return true;
}

function CopyFile(filename, src, dest, overwrite) {
    try {
        var src = src + "\\" + filename;
        var src = "\"" + src + "\"";
        var dest = "\"" + dest + "\"";
        //var fso = new ActiveXObject("Scripting.FileSystemObject");
        //fso.CopyFile(src , dest, true);
        cmd = "xcopy "+ src + " " + dest;
        if (overwrite) {
            cmd = cmd + " /Y ";
        }
        LaunchAndWait(cmd);
    }
    catch (e) {
        Output("Exception:\n" + e.number + "\n" + e.name + "\n" + e.message + "\n" + e.description);
        WScript.Quit(1);
        return false;
    }

    return true;
}

function CopyFolder(filename, src, dest) {
    try {
        var src = src + "\\" + filename;
        var src = "\"" + src + "\"";
        var dest = "\"" + dest + "\"";
        //var fso = new ActiveXObject("Scripting.FileSystemObject");
        //fso.CopyFile(src , dest, true);
        cmd = "xcopy " + "/s /e " + src + " " + dest;
        LaunchAndWait(cmd);
    }
    catch (e) {
        Output("Exception:\n" + e.number + "\n" + e.name + "\n" + e.message + "\n" + e.description);
        WScript.Quit(1);
        return false;
    }

    return true;
}



function CopyFolderContents(src, dest) {
    var fso = new ActiveXObject("Scripting.FileSystemObject");

    try {
        // Find a better way to deal with the case when the folder to be copied has no subfolders.
        try {
            fso.CopyFolder(src + "\\*", dest, true);
        }
        catch (e) {
        }

        fso.CopyFile(src + "\\*", dest + "\\", true);
    }
    catch (e) {
        WScript.Echo("Error copying \"" + src + "\" to \"" + dest + "\": " + e.description + " (" + e.number + ").");
        return false;
    }

    return true;
}
// Outputs the specified message to the console and to the event log.
function Output(message) {
    var date = new Date();
    var str = "[" + date.toLocaleTimeString() + "] " + message;

    // 4 = Information.
    shell.LogEvent(4, message);
    WScript.Echo(str);
}

try {
    main();
} catch (e) {
    Output("Exception:\n" + e.number + "\n" + e.name + "\n" + e.message + "\n" + e.description);
    WScript.Quit(1);
}


REM ONYX Staging 7.9
REM *****************************
setlocal 


SET source=%1
SET dest=%2


REM CTI
mkdir "%dest%\CTI\OEDB\DataScripts"
xcopy "%source%\OnyxCTI\Code\English\Database\DataScripts\cti_data.sql" "%dest%\CTI\OEDB\DataScripts" /S /E /Y /q
mkdir "%dest%\CTI\OEDB\DropProcedure"
xcopy "%source%\Installers\StagingFiles\CTI\OEDB\*.*" "%dest%\CTI\OEDB\" /S /E /Y /q
mkdir "%dest%\CTI\OEDB\DropScript"
mkdir "%dest%\CTI\OEDB\SchemaScripts\"
xcopy "%source%\OnyxCTI\Code\_LanguageIndependent\Database\SchemaScripts\*.sql" "%dest%\CTI\OEDB\SchemaScripts\" /S /E /Y /q
mkdir "%dest%\CTI\OEDB\UpgradeScripts"
xcopy "%source%\OnyxCTI\Code\English\Database\UpgradeScripts\*.sql" "%dest%\CTI\OEDB\UpgradeScripts" /S /E /Y /q
mkdir "%dest%\CTI\OEDB\Views\MultipleLanguage"
xcopy "%source%\OnyxCTI\Code\_LanguageIndependent\Database\Views\MultipleLanguage\*.*" "%dest%\CTI\OEDB\Views\MultipleLanguage" /S /E /Y /q
mkdir "%dest%\CTI\OEP"
xcopy "%source%\OnyxCTI\Code\English\Website\*.*" "%dest%\CTI\OEP" /S /E /Y /q
mkdir "%dest%\CTI\Platform"
xcopy "%source%\OnyxCTI\Code\English\MasterDictionary\cti_oed_additions.xml" "%dest%\CTI\Platform" /S /E /Y /q
 

REM Extraction Engine
mkdir "%dest%\Extraction Engine\DB70" 
xcopy "%source%\OnyxKB\Source\DB70\*.sql" "%dest%\Extraction Engine\DB70" /S /E /Y /q
mkdir "%dest%\Extraction Engine\Extraction Engine\Engine"
xcopy "%source%\CommonLibrary\ExtractionEngineConfiguration\EEConfiguration\obj\Release\EEConfiguration.exe" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Extraction_engine_net\BuildScripts\Output\EntityFramework.dll" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Extraction_engine_net\BuildScripts\Output\EntityFramework.SqlServer.dll" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Extraction_engine_net\BuildScripts\Output\ExtractAll.bat" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Engine\incident.htm.onx" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Extraction_engine_net\BuildScripts\Output\KBengine.exe" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Extraction_engine_net\BuildScripts\Output\KBengine.exe.config" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\CommonLibrary\Output\log4net.dll" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Extraction_engine_net\BuildScripts\Output\PasswordEncryptLibrary.dll" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Extraction_engine_net\BuildScripts\Output\privateKey.pvk" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
xcopy "%source%\OnyxKB\Source\Extraction_Engine\Engine\workticket.htm.onx" "%dest%\Extraction Engine\Extraction Engine\Engine" /S /E /Y /q
mkdir "%dest%\Extraction Engine\Runtime Files\WinCommon"
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\adme.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\dbmssocn.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\dbmsspxn.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q 
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\dbmsvinn.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\dtccm.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\dtctrace.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\msrdo20.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\msvbvm50.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\ntwdblib.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\rdocurs.dll" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q
xcopy "%source%\OnyxKB\Runtime Files\WinCommon\stdole2.tlb" "%dest%\Extraction Engine\Runtime Files\WinCommon" /S /E /Y /q


REM OEAS
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\GemBox.Document.dll" "%dest%\OEAS\Components" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxDocumentMergeTemplate.dll" "%dest%\OEAS\Components" /S /E /Y /q


REM OEAS Config
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary" "%dest%\OEAS Config\MasterDictionary\" /S /E /Y /q
copy "%source%\OEAS\SQLServer\English\MasterDictionary\OnyxEnterpriseDictionary.xml" "%dest%\OEAS Config\MasterDictionary\OnyxEnterpriseDictionaryWC.xml"

xcopy "%source%\BusinessRuleManager\Configuration\businessRuleManager\*.*" "%dest%\OEAS Config\businessRuleManager\" /S /E /Y /q

xcopy "%source%\OeasSqlGen\Build\common\_LanguageIndependent\FeatureSpecific\OnyxTransformStep\OnyxEMSIncidentInsert.xsl" "%dest%\OEAS Config\Templates\" /S /E /Y /q

xcopy "%source%\OEAS\LBOAdapters\OnyxDocumentMergeTemplate\OnyxDocumentMergeTemplate.config" "%dest%\OEAS Config\Configuration\" /S /E /Y /q

REM CHeck later
xcopy "%source%\Installers\StagingFiles\OEAS Config" "%dest%\OEAS Config" /S /E /Y /q


REM OED Upgrade
mkdir "%dest%\OED Upgrade\Original OED"
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OED_V6.00.xml" "%dest%\OED Upgrade\Original OED\"  /S /E /Y /q
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OED_V7.01.xml" "%dest%\OED Upgrade\Original OED\"  /S /E /Y /q
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OED_V7.05.xml" "%dest%\OED Upgrade\Original OED\"  /S /E /Y /q
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OED_V7.06.xml" "%dest%\OED Upgrade\Original OED\"  /S /E /Y /q
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OED_V7.07.xml" "%dest%\OED Upgrade\Original OED\"  /S /E /Y /q
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OED_V7.07.013.xml" "%dest%\OED Upgrade\Original OED\"  /S /E /Y /q
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OED_V7.08.xml" "%dest%\OED Upgrade\Original OED\"  /S /E /Y /q

xcopy "%source%\OEAS\SQLServer\LanguageIndependent\Utilities\OED Upgrade\Other Files\*.*" "%dest%\OED Upgrade\Other Files"  /S /E /Y /q /i
xcopy "%source%\OEAS\SQLServer\English\MasterDictionary\OnyxEnterpriseDictionary.xml" "%dest%\OED Upgrade\Other Files\OnyxEnterpriseDictionary.xml" /S /E /Y /q


REM OEDB
mkdir "%dest%\OEDB"
pushd "%source%\OEAS\SQLServer\BuildScripts\"
call AllCopyToStagingarea.bat "%source%" "%dest%\OEDB"
popd


REM Onyx360
mkdir "%dest%\Onyx360\Client\"
xcopy "%source%\Onyx360\BuildScripts\Output\*.*" "%dest%\Onyx360\Client\" /S /E /Y /q
copy "%source%\Onyx360\Client_Addin\OnyxOutlookAddin\Localization\en-US\OnyxOutlookAddin.resources.dll" "%dest%\Onyx360\Client\"
REM update this one when we get the new CHM file from the documentation guys
copy "%source%\Installers\StagingFiles\Onyx360\Onyx 360 for Outlook Help.chm" "%dest%\Onyx360\Client"

mkdir "%dest%\Onyx360\Server\OEAS"
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxDACHelper.dll" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxDACHelper.xml" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxEBusQEPIA.dll" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxEDCachePIA.dll" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxGetAppDataPIA.dll" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxLogPIA.dll" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxNatLangCachePIA.dll" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\OEAS\LBOAdapters\BuildScripts\Output\OnyxOutlookSync.dll" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q
xcopy "%source%\Onyx360\ServerSide_ClientSideConfig_files\XSl file\OutlookSyncProperty.xsl" "%dest%\Onyx360\Server\OEAS" /S /E /Y /q

mkdir "%dest%\Onyx360\Server\OEDB"
xcopy "%source%\Onyx360\OEDB\*.*" "%dest%\Onyx360\Server\OEDB" /S /E /Y /q
xcopy "%source%\Onyx360\OEDB\sproc\*.*" "%dest%\Onyx360\Server\OEDB\sproc" /S /E /Y /q
copy "%source%\Onyx360\OEDB\undo.sql" "%dest%\Onyx360\Server\OEDB\sproc"
copy "%source%\Onyx360\OEDB\undo_JPN.sql" "%dest%\Onyx360\Server\OEDB\sproc"
xcopy "%source%\Onyx360\OEDB\Schema Scripts\*.*" "%dest%\Onyx360\Server\OEDB\Schema Scripts" /S /E /Y /q
copy "%source%\Onyx360\OEDB\data upgrade\upgrade_oeas_post_insert_data.sql" "%dest%\Onyx360\Server\OEDB\data upgrade"
copy "%source%\Onyx360\OEDB\data upgrade\Japanese\upgrade_oeas_post_insert_data_JPN.sql" "%dest%\Onyx360\Server\OEDB\data upgrade"

mkdir "%dest%\Onyx360\Server\Platform\config"
xcopy "%source%\Onyx360\ServerSide_ClientSideConfig_files\OutlookAddinListsConfig.xml" "%dest%\Onyx360\Server\Platform\config" /S /E /Y /q
xcopy "%source%\Onyx360\ServerSide_ClientSideConfig_files\OutlookSyncConfig.xml" "%dest%\Onyx360\Server\Platform\config" /S /E /Y /q
xcopy "%source%\Onyx360\delta_oed\OED_Delta.xml" "%dest%\Onyx360\Server\Platform" /S /E /Y /q


REM OnyxPrerequisite
xcopy "%source%\OnyxSDK\OnyxDotNetSDK\Output\buildfiles\*.*" "%dest%\Onyx Prerequisite\OnyxSDK\" /S /E /Y /q
xcopy "%source%\OEAS\Core\BuildScripts\Output\Release\IDL\iaction.tlb" "%dest%\Onyx Prerequisite\TLB\"
xcopy "%source%\OEAS\Core\BuildScripts\Output\Release\IDL\istep.tlb" "%dest%\Onyx Prerequisite\TLB\"
xcopy "%source%\OEAS\Core\BuildScripts\Output\Release\IDL\istepstring.tlb" "%dest%\Onyx Prerequisite\TLB\"


REM Onyx Scripting
REM In progress
mkdir "%dest%\OnyxScripting"
REM xcopy "%source%\Onyx.UI\Output\scripting" "%dest%\OnyxScripting" /S /E /Y /q
xcopy "%source%\Onyx.UI\BuildScripts\Output\scripting" "%dest%\OnyxScripting" /S /E /Y /q
copy "%source%\ThirdParty\microloader.jsp" "%dest%\OnyxScripting\"
xcopy "%source%\Installers\StagingFiles\OnyxScripting\*.*" "%dest%\OnyxScripting\" /S /E /Y /q
xcopy "%source%\Onyx.UI\Onyx.UI\Onyx.UI\Client\build\production\scripting_sa\*.*" "%dest%\OnyxScripting\" /S /E /Y /q

REM OPS
mkdir "%dest%\OPS\Administration\"
xcopy "%source%\OEAS\OPS\LanguageIndependent\Admin\Website\*.*" "%dest%\OPS\Administration\" /S /E /Y /q
xcopy "%source%\OEAS\OPS\English\Admin\Website\*.*" "%dest%\OPS\Administration\" /S /E /Y /q

mkdir "%dest%\OPS\Administration\Help"
REM update this one when we get the new doc files from the documentation team
xcopy "%source%\Installers\StagingFiles\OPS\Administration\Help\*.*" "%dest%\OPS\Administration\Help" /S /E /Y /q

mkdir "%dest%\OPS\Applications\Onyx"
xcopy "%source%\OeasSqlGen\Build\common\_LanguageIndependent\OPS\ConfigFiles\OnyxSyncSubsystemConfiguration.xml" "%dest%\OPS\Applications\Onyx"

mkdir "%dest%\OPS\Components"
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\CharsetMaps.xml" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\emimap4.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\emmsg.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\emssl.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\GemBox.Document.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\log4net.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\ThirdParty\packages\Unity.4.0.1\lib\net45\Microsoft.Practices.Unity.Configuration.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\ThirdParty\packages\Unity.4.0.1\lib\net45\Microsoft.Practices.Unity.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\Onyx.GemBoxLicense.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\Onyx.LoggerService.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxCollisionHandler.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxCollisionHandlerLOC.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxMAPIConnector.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxMAPIConnectorLoc.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPS.Fulfillment.Helper.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPS.Fulfillment.IActionEngine.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPS.Fulfillment.PrintEngine.Data.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPS.Fulfillment.PrintEngine.Extension.dll" "%dest%\OPS\Components" /S /E /Y /q
rem xcopy "%dest%7.8_From_Harish\OPS\Components\OnyxPS.Fulfillment.PrintEngine.Extension.reg" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPS.Fulfillment.PrintEngine.Report.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSEmailEngine.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSExchangeAccessRights.exe" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSExchangeAcl.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSExchangeSyncConnector.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSFileLog.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSGetRegData.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSLitProductCache.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSLitProductCacheLOC.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSLOC.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSLog.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSLogRes.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSOEASConnector.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OnyxPSPrintEngine.dll" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OPSBatch.exe" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OPSEMonitor.exe" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OPSFulfill.exe" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OPSFulfill.exe" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OPSSvc.exe" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OPSSync.exe" "%dest%\OPS\Components" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\OPSFulfill.exe.config" "%dest%\OPS\Components" /S /E /Y /q

mkdir "%dest%\OPS\Document Templates\"
xcopy "%source%\OEAS\OPS\English\Utilities_ProductDocumentation\EmailTemplateTestUtility\_Install\*.*" "%dest%\OPS\Document Templates\" /S /E /Y /q
xcopy "%source%\OEAS\OPS\English\Utilities_ProductDocumentation\FaxEmailTemplateTestUtility\_Install\*.*" "%dest%\OPS\Document Templates\" /S /E /Y /q
xcopy "%source%\OEAS\OPS\BuildScripts\Output\Utilities\*.docx" "%dest%\OPS\Document Templates\" /S /E /Y /q

mkdir "%dest%\OPS\OPS_Shared\OPS\OSLF\"
xcopy "%source%\OeasSqlGen\Build\common\OPSBUILD\CompiledComponents\*.dll" "%dest%\OPS\OPS_Shared\OPS\OSLF\" /S /E /Y /q
copy "%source%\OEAS\Core\BuildScripts\Output\Release\32BIT\" "%dest%\OPS\OPS_Shared\OPS\OSLF\"

mkdir "%dest%\OPS\Administration\common\objects\"
copy "%source%\OES\Build\_LanguageIndependent\WebSite\common\objects\msxml3.cab" "%dest%\OPS\Administration\common\objects\"

copy "%source%\OEAS\OPS\English\Utilities_ProductDocumentation\OnyxLogo.jpg" "%dest%\OPS\Document Templates\"
copy "%source%\OEAS\OPS\BuildScripts\Output\OPSCore\orderBatchPrintSample.xml" "%dest%\OPS\Document Templates\"


REM OPSConfig
mkdir "%dest%\OPS Config\ConfigFiles"
xcopy "%source%\OeasSqlGen\Build\common\_LanguageIndependent\OPS\ConfigFiles\OnyxSyncSubsystemConfiguration.xml" "%dest%\OPS Config\ConfigFiles" /S /E /Y /q


REM OES Folder
mkdir "%dest%\OES\Website"
xcopy "%source%\OES\Build\_LanguageIndependent\Website" "%dest%\OES\Website" /S /E /Y /q
xcopy "%source%\OES\Build\English\Website\*.xml" "%dest%\OES\Website\" /S /E /Y /q
mkdir "%dest%\OES\Website\Help"
REM update this one when we get the new CHM file from the documentation guys
xcopy "%source%\Installers\StagingFiles\OES\Website\Help" "%dest%\OES\Website\Help" /S /E /Y /q


REM Notification Services
mkdir "%dest%\OnyxNotificationService"
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\Config\*.*" "%dest%\OnyxNotificationService\Config\" /S /E /Y /q
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\Profiles\*.*" "%dest%\OnyxNotificationService\Profiles\" /S /E /Y /q
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\Templates\*.*" "%dest%\OnyxNotificationService\Templates\" /S /E /Y /q
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\*.dll" "%dest%\OnyxNotificationService\" /S /E /Y /q
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\OnyxNotificationServiceWindowsService.exe" "%dest%\OnyxNotificationService\" /S /E /Y /q
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\OnyxNotificationServiceWindowsService.exe.config" "%dest%\OnyxNotificationService\" /S /E /Y /q
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\privateKey.pvk" "%dest%\OnyxNotificationService\" /S /E /Y /q
xcopy "%source%\OnyxNotificationService\BuildScripts\Output\PublishingAgent.xaml" "%dest%\OnyxNotificationService\" /S /E /Y /q


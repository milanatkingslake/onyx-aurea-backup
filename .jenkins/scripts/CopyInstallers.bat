REM copies generated installers from their source code location to the specified folder

setlocal

SET source=%1
SET dest=%2

mkdir "%dest%\Onyx360Client" 
xcopy "%source%\Installers\Onyx360Client\Onyx360Client\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\Onyx360Client" /E

mkdir "%dest%\OnyxEmployeePortal" 
xcopy "%source%\Installers\OEPx64\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxEmployeePortal" /E

mkdir "%dest%\EmailAcceleratorServer" 
xcopy "%source%\Installers\EmailAcceleratorServer\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\EmailAcceleratorServer" /E

mkdir "%dest%\EmailAcceleratorClient" 
xcopy "%source%\Installers\EmailAcceleratorClient\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\EmailAcceleratorClient" /E

mkdir "%dest%\OPSConfig" 
xcopy "%source%\Installers\OPSConfig\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OPSConfig" /E

mkdir "%dest%\OnyxWebServices" 
xcopy "%source%\Installers\OnyxWebServices\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxWebServices" /E

mkdir "%dest%\OnyxFileAgent" 
xcopy "%source%\Installers\OFA\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxFileAgent" /E

mkdir "%dest%\OnyxEnterpriseStudio" 
xcopy "%source%\Installers\OES\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxEnterpriseStudio" /E

mkdir "%dest%\OnyxNotificationService" 
xcopy "%source%\Installers\OnyxNotificationService\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxNotificationService" /E

mkdir "%dest%\OGSProxy" 
xcopy "%source%\Installers\OGSProxy\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OGSProxy" /E

mkdir "%dest%\OnyxGatewayService" 
xcopy "%source%\Installers\OnyxGatewayService\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxGatewayService" /E

mkdir "%dest%\OEASConfig" 
xcopy "%source%\Installers\Configure Middle Tier\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OEASConfig" /E

mkdir "%dest%\OEAS" 
xcopy "%source%\Installers\OEAS\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OEAS" /E

mkdir "%dest%\OEDB" 
xcopy "%source%\Installers\OEDB\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OEDB" /E

mkdir "%dest%\ExtractionEngine" 
xcopy "%source%\Installers\ExtractionEngine\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\ExtractionEngine" /E

mkdir "%dest%\Onyx360Server" 
xcopy "%source%\Installers\Onyx360Server\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\Onyx360Server" /E

mkdir "%dest%\CTI" 
xcopy "%source%\Installers\CTI\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\CTI" /E

mkdir "%dest%\OEDUpgrade" 
xcopy "%source%\Installers\OED Upgrade\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OEDUpgrade" /E

mkdir "%dest%\OnyxPrerequisite" 
xcopy "%source%\Installers\Onyx Prerequisite\Onyx Prerequisite\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxPrerequisite" /E

mkdir "%dest%\OnyxProcessingServer" 
xcopy "%source%\Installers\OPS\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxProcessingServer" /E

mkdir "%dest%\OnyxMobileWeb" 
xcopy "%source%\Installers\OnyxMobileWeb\V7.8_SP3\*.*" "%dest%\OnyxMobileWeb" /E

mkdir "%dest%\OnyxScripting" 
xcopy "%source%\Installers\OnyxScripting\Product Configuration 1\Release 1\DiskImages\DISK1\*.*" "%dest%\OnyxScripting" /E
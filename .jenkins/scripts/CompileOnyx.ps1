##############Functions#########################
Function Verify-FailedOnLog{
  param(
    [Parameter(Mandatory=$true)] [string] $filePath
    )  
    return (Select-String -Path $filePath -Pattern "BUILD FAILED" -SimpleMatch) -eq $null
}

##############Functions#########################

$components=Get-Content CompileList.txt

cd ../..
$defaultPath=Get-Location
Write-Host $defaultPath
md -Force -Path $defaultPath\buildlogs
Remove-Item $defaultPath\buildlogs\*.* -ErrorAction Ignore
Remove-Item $defaultPath\OnyxGatewayProxy\BuildScripts\Output\privateKey.pvk -Force -ErrorAction Ignore
Remove-Item $defaultPath\OnyxGatewayService\BuildScripts\Output\privateKey.pvk -Force -ErrorAction Ignore

# Adding symbolic link with Sencha files
# $senchaPath="e:\installers\ext-6.6.0-trial\ext-6.6.0"
$senchaPath="e:\installers\ext-6.5.3.57\ext-6.5.3.57"
New-Item -Path $defaultPath\Onyx.ui\Onyx.UI\Onyx.UI\client\ext -ItemType SymbolicLink -Value $senchaPath

New-Item -ItemType Directory -Force -Path $defaultPath\.jenkins\installers

# Temporary symbolic link with 7.8 Installers
# REMOVE IT WHEN WE START GENERATING THE INSTALLERS DURING BUILD
$tempInstallers="e:\installers\Onyx7.8"
New-Item -Path $defaultPath\.jenkins\installers\packages -ItemType SymbolicLink -Value $tempInstallers

$StartTimeAll = $(get-date)

foreach($component in $components) {
	$enable, $path, $file = $component -split ','

	if ($enable -eq 0) {
		continue
	}

	Write-Host "--------------------------------------------------------------------------------------------"
	Write-Host "Starting $path $file at $(get-date)"
	$StartTime = $(get-date)

	Set-Location $path
	$buildCommandArgs=" /k $file >> $defaultPath\buildlogs\$file.txt"
	Write-Host $buildCommandArgs
	$buildCommand=Start-Process cmd.exe -ArgumentList $buildCommandArgs -NoNewWindow -PassThru
	$handle = $buildCommand.Handle # cache proc.Handle. Workaround to show ExitCode
	$buildCommand.WaitForExit()
	Write-Host "ExitCode: $($buildCommand.ExitCode)  "

	$buildSucceeded=Verify-FailedOnLog -filePath "$defaultPath\buildlogs\$file.txt"
    Write-Host "Build result: $buildSucceeded"
    if(!$buildSucceeded){
      Write-Host "+++++++++++++++++++++++++++++++++++++++++"
      Write-Host "Build failed on: $file"
      Write-Host "+++++++++++++++++++++++++++++++++++++++++"
	  $buildlog = Get-Content "$defaultPath\buildlogs\$file.txt"
	  Write-Host $buildlog
      throw "Build failed on: $file"
      exit 1
    }

	$elapsedTime = $(get-date) - $StartTime
	$totalTime = "{0:HH:mm:ss}" -f ([datetime]$elapsedTime.Ticks)
	Write-Host "Build time: $totalTime"

	Write-Host "Finished $path $file"

	Set-Location $defaultPath
}

$elapsedTimeAll = $(get-date) - $StartTimeAll
$totalTimeAll = "{0:HH:mm:ss}" -f ([datetime]$elapsedTimeAll.Ticks)
Write-Host "--------------------------------------------------------------------------------------------"
Write-Host "Total Build Time: $totalTimeAll"


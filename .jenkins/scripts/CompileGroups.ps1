param (
 [string]$buildCoreOEAS = "TRUE"
)

##############Functions#########################
Function Verify-FailedOnLog{
  param(
    [Parameter(Mandatory=$true)] [string] $filePath
    )  
    return (Select-String -Path $filePath -Pattern "BUILD FAILED" -SimpleMatch) -eq $null
}

$processComponent = {
    Param(
        [string] $buildArgs,
        [string] $defaultPath,
        [string] $batPath
    )

    Set-Location $defaultpath\$batPath
    & cmd.exe $buildArgs
}

##############Functions#########################

Write-Host "buildCoreOEAS = $buildCoreOEAS"

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

New-Item -ItemType Directory -Force -Path $defaultPath\.jenkins\installers\packages

$StartTimeAll = $(get-date)

For($i=1; $i -le 8; $i++) {

    $fileGroup="$defaultpath\.jenkins\scripts\CompileGroup$i.txt"
    Write-Host "--------------------------------------------------------------------------------------------"
    Write-Host "Processing $fileGroup at $(get-date)"
    $StartTime = $(get-date)

    $components=Get-Content $fileGroup

    $jobs=@()

    foreach($component in $components) {
        $enable, $path, $file = $component -split ','

        if ($enable -eq 0) {
            continue
        }
        if (($file -eq "OnyxOEAS_CoreCompile.bat") -And ($buildCoreOEAS -ne "TRUE")) {
            Write-Host "Skipping ${file}"
            continue
        }

        Set-Location $path
        $buildCommandArgs=" /k $file >> $defaultPath\buildlogs\$file.txt"
        Write-Host $buildCommandArgs

        $jobs += Start-Job -ScriptBlock $processComponent -Name $file -ArgumentList $buildCommandArgs, $defaultPath, $path

        Set-Location $defaultPath
    }

    Write-Host "Running $fileGroup jobs..."
    Wait-Job -Job $jobs | Out-Null
    Write-Host "$fileGroup components finished. Getting Info..."

    foreach($job in $jobs) {
        Write-Host $job.Name

        if ($job.State -eq 'Failed') {
            Write-Host ($job.JobStateInfo.Reason.Message) -ForegroundColor Red
        } else {
            Write-Host ($job.State) # (Receive-Job $job) -ForegroundColor Green 
        }

        $file = $job.Name

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
    }

  	$elapsedTime = $(get-date) - $StartTime
	$totalTime = "{0:HH:mm:ss}" -f ([datetime]$elapsedTime.Ticks)
	Write-Host "Build time for $fileGroup -> $totalTime"

}

$elapsedTimeAll = $(get-date) - $StartTimeAll
$totalTimeAll = "{0:HH:mm:ss}" -f ([datetime]$elapsedTimeAll.Ticks)
Write-Host "--------------------------------------------------------------------------------------------"
Write-Host "Total Build Time: $totalTimeAll"


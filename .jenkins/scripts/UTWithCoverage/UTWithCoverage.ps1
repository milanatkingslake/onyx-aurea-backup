param (
 [string]$run_auto_ut = "TRUE",
 [string]$run_manual_ut = "TRUE"
)

Write-Host "run_auto_ut = $run_auto_ut"
Write-Host "run_manual_ut = $run_manual_ut"

if (($run_auto_ut -ne "TRUE") -and ($run_manual_ut -ne "TRUE")) {
  Write-Host "No tests to run - exiting" 
  exit 1
}

# Copied from responsetek product, file name was build\steps\execute_unittest.ps1
# Some portions are from AUT's sample:
# powershellScriptToCoverageReport\Modules\Internal\Aurea\TestGenerator\Invoke-VsTestConsole.psm1 
Write-Host "Starting UTWithCoverage.ps1"

Write-Host "Enabling PowerShell tracing"
Set-PSDebug -Trace 1

if (!(Test-Path "AUT") -or !(Test-Path ".jenkins")) { 
  Write-Host "Run UTWithCoverage.ps1 from the root of ONYX repository"
  exit 1
}

$onyxRoot = $(Get-Location)

$enableCodeCoverage = $TRUE
Write-Host "Code coverage enable: $enableCodeCoverage"

$resultsDir="$onyxRoot\buildlogs\UTresults"
$trxFile="$resultsDir\vstestlog\testResults.test.trx"

Write-Host "Removing old results dir and creating new dirs" -ForegroundColor "Cyan"
Write-Host "========================================" -ForegroundColor "Cyan"

if (Test-Path $resultsDir) { 
  Remove-Item $resultsDir -Recurse; 
  if (-not $?) {
    Write-Host "Failed to remove directory: $resultsDir"
    exit 1 
  }
}

New-Item -ItemType directory -Path $resultsDir -Force
if (-not $?) {
  Write-Host "Failed to create directory: $resultsDir"
  exit 1 
}

$testsJsonDir="$resultsDir\Tests.json"
New-Item -ItemType directory -Path "$testsJsonDir" -Force
if (-not $?) {
  Write-Host "Failed to create directory: $testsJsonDir"
  exit 1 
}

Write-Host "Restoring nuget" -ForegroundColor "Cyan"
Write-Host "========================================" -ForegroundColor "Cyan"

Function Verify-FailedOnLog{
  param(
    [Parameter(Mandatory=$true)] [string] $filePath
    )
    return (Select-String -Path $filePath -Pattern "BUILD FAILED" -SimpleMatch) -eq $null
}


Write-Host "Running VSTestConsole" -ForegroundColor "Cyan"
Write-Host "========================================" -ForegroundColor "Cyan"

$VStestConsoleExe="C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe"

$testAssemblies=@()
if($run_auto_ut -eq "TRUE") {
  $testAssemblies = $testAssemblies + (Get-ChildItem -r "$onyxRoot\AUT\bin\Debug\*.AUT.Tests.dll")
}

if($run_manual_ut -eq "TRUE") {
  $testAssemblies = $testAssemblies + @(
   "$onyxRoot\OnyxGatewayService\BuildScripts\Output\Onyx.GatewayService.UnitTests.dll")
}
  
$VStestConsoleArgs="$($testAssemblies) /settings:$onyxRoot\.jenkins\scripts\UTWithCoverage\testsettings.xml /TestAdapterPath:$onyxRoot\AUT\packages\NUnit3TestAdapter.3.12.0\build\net35  /logger:trx;LogFileName=$trxFile /platform:x64 /Parallel /logger:""console;verbosity=normal"""

if($enableCodeCoverage){
  # $VStestConsoleArgs+=" /collect:""Code Coverage"""
  $VStestConsoleArgs+=" /Enablecodecoverage"
}

Write-Host "Will run <$VStestConsoleExe> with <$VStestConsoleArgs>"
$buildCommand=Start-Process $VStestConsoleExe -ArgumentList $VStestConsoleArgs -NoNewWindow -PassThru -WorkingDirectory "$resultsDir" -Wait

if($buildCommand.exitCode -ne 0) {  Write-Host "VsTestConsole failed"; exit 1 }

if($enableCodeCoverage) {

  Write-Host "Installing ReportGenerator" -ForegroundColor "Cyan"
  Write-Host "========================================" -ForegroundColor "Cyan"

  & "$onyxRoot\.jenkins\utils\nuget\nuget.exe" install ReportGenerator -Version 4.0.0-rc4 -Source https://www.nuget.org/api/v2/ -OutputDirectory .\.jenkins\utils
  if ($LastExitCode) {exit 1}

  Push-Location "$resultsDir"
  
  # & "$($config.codeCoverageLocation)" analyze /output:$vsReport (Get-ChildItem -r TestResults\\*\\*.coverage)
  
  $reportXml2 = "CodeCoverageOutput.xml";
     
  $CodeCoverageExe = "c:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\Team Tools\\Dynamic Code Coverage Tools\\CodeCoverage.exe" 
  & "$CodeCoverageExe" analyze /output:$reportXml2 (Get-ChildItem -path ".\TestResults\*.coverage" -recurse)
  if ($LastExitCode) {exit 1}  

  #$fileOut="ConvertedCoverage.coveragexml"
  #$coverageFile = (Get-ChildItem -path ".\TestResults\*.coverage" -recurse) | Select-Object -First 1
  
  #Write-Host "Running CoverageConversion"
  #Measure-Command {
  #  & "$onyxRoot\.jenkins\utils\CoverageConversion\CoverageConversion.exe" $coverageFile binariesFolderList.txt "$fileOut"
  #  if ($LastExitCode) {exit 1}
  #}

  Write-Host "Running ReportGenerator" -ForegroundColor "Cyan"
  Write-Host "========================================" -ForegroundColor "Cyan"
  
  Write-Host "fileOut = $fileOut"
  
  & "$onyxRoot\.jenkins\utils\ReportGenerator.4.0.0-rc4\tools\net47\ReportGenerator.exe" -reports:"$reportXml2" -targetdir:"$resultsDir\coverage-reports" -assemblyfilters:"-nunit3.*;-nunit.*;-moq.*" -reporttypes:"htmlsummary" 
  if ($LastExitCode) {exit 1}
  
  Pop-Location
  }

exit 0

# $resultsDir


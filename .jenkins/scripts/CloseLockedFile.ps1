Function Close-LockedFile{
Param(
    [Parameter(Mandatory=$true,ValueFromPipeline=$true)][String[]]$Filename
)
Begin{
    $HandleApp = 'C:\sysinternals\Handle.exe'
    If(!(Test-Path $HandleApp)){Write-Host "Handle.exe not found at $HandleApp`nPlease download it from www.sysinternals.com and save it in the afore mentioned location.";break}
}
Process{
    $HandleOut = Invoke-Expression ($HandleApp+' '+$Filename)
    $Locks = $HandleOut |?{$_ -match "(.+?)\s+pid: (\d+?)\s+type: File\s+(\w+?): (.+)\s*$"}|%{
        [PSCustomObject]@{
            'AppName' = $Matches[1]
            'PID' = $Matches[2]
            'FileHandle' = $Matches[3]
            'FilePath' = $Matches[4]
        }
    }
    ForEach($Lock in $Locks){
        Invoke-Expression ($HandleApp + " -p " + $Lock.PID + " -c " + $Lock.FileHandle + " -y") | Out-Null
        If ( ! $LastexitCode ) { "Successfully closed " + $Lock.AppName + "'s lock on " + $Lock.FilePath}
    }
}
}

Write-Host "Closing OnyxFileAgent.tlb"
Close-LockedFile "OnyxFileAgent.tlb"
Write-Host "Finished Closing OnyxFileAgent.tlb"

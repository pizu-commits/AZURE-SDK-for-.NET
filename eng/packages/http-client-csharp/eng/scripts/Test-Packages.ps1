#Requires -Version 7.0

param(
    [switch] $UnitTests,
    [switch] $GenerationChecks,
    [string] $Filter = "."
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version 3.0
. "$PSScriptRoot/../../../../common/scripts/common.ps1"
Set-ConsoleEncoding

$emitterPackagePath = Resolve-Path "$PSScriptRoot/../.."
Push-Location $emitterPackagePath
try {
    if ($UnitTests) {
        # test the generator
        Invoke-LoggedCommand "dotnet test generator /bl:artifacts/logs/debug.binlog --logger `"trx;LogFileName=$root/artifacts/test-results/debug.trx`""

        # test the emitter
        Push-Location "emitter"
        try {
            Invoke-LoggedCommand "npm run prettier" -GroupOutput
            Invoke-LoggedCommand "npm run lint" -GroupOutput
            Invoke-LoggedCommand "npm run build" -GroupOutput
            Invoke-LoggedCommand "npm run test -- --passWithNoTests" -GroupOutput
        }
        finally {
            Pop-Location
        }
    }

    if ($GenerationChecks) {
        Set-StrictMode -Version 1
        # run E2E Test for TypeSpec emitter
        & "eng/scripts/CodeGenerationCheck.ps1" -Filter $Filter -Reset
    }
}
finally {
    Pop-Location
}

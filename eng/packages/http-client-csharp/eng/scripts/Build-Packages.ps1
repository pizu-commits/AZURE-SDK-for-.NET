#Requires -Version 7.0

param(
    [string] $BuildNumber,
    [string] $Output,
    [switch] $Prerelease,
    [switch] $PublishInternal
)

$ErrorActionPreference = 'Stop'
Set-StrictMode -Version 3.0
. "$PSScriptRoot/../../../../common/scripts/common.ps1"
Set-ConsoleEncoding

$emitterPackagePath = Resolve-Path "$PSScriptRoot/../.."
$artifactsPath = Join-Path $emitterPackagePath "artifacts"
$outputPath = $Output ? $Output : (Join-Path $artifactsPath "ci-build")

Push-Location $emitterPackagePath
try {

    # try to remove the artifacts folder if it exists
    if (Test-Path $artifactsPath) {
        Remove-Item -Recurse -Force $artifactsPath
    }

    # create the output folders
    $artifactsPath = New-Item -ItemType Directory -Force -Path $artifactsPath | Select-Object -ExpandProperty FullName
    $outputPath = New-Item -ItemType Directory -Force -Path $outputPath | Select-Object -ExpandProperty FullName

    $emitterVersion = node -p -e "require('package.json').version"

    if ($BuildNumber) {
        # set package versions
        $versionTag = $Prerelease ? "-alpha" : "-beta"

        $emitterVersion = "$emitterVersion$versionTag.$BuildNumber"
        Write-Host "Setting output variable 'emitterVersion' to $emitterVersion"
        Write-Host "##vso[task.setvariable variable=emitterVersion;isoutput=true]$emitterVersion"
    }

    ## build the nuget package
    #$versionOption = $BuildNumber ? "/p:Version=$generatorVersion" : ""
    #Invoke-LoggedCommand "dotnet pack src/AutoRest.CSharp/AutoRest.CSharp.csproj $versionOption -o $outputPath/packages -warnaserror -c Release" -GroupOutput

    # # pack the c# npm package
    # Push-Location "$artifactsPath/bin/AutoRest.CSharp/Release/net8.0/"
    # try {
    #     Write-Host "Working in $PWD"
    #     if ($BuildNumber) {
    #         Invoke-LoggedCommand "npm version --no-git-tag-version $generatorVersion" -GroupOutput
    #     }

    #     $file = Invoke-LoggedCommand "npm pack -q"
    #     Copy-Item $file -Destination "$outputPath/packages"
    # }
    # finally {
    #     Pop-Location
    # }

    # build and pack the emitter
    Write-Host "Working in $PWD"
    Invoke-LoggedCommand "npm run build" -GroupOutput

    if ($BuildNumber) {
        Write-Host "Updating version package.json to the new emitter version`n"
        npm pkg set version=$emitterVersion
    }

    # remove any existing tarballs
    Remove-Item -Path "./*.tgz" -Force | Out-Null
    
    #pack the emitter
    Invoke-LoggedCommand "npm pack"
    $file = Get-ChildItem -Filter "*.tgz" | Select-Object -ExpandProperty FullName
    Invoke-LoggedCommand "tar --list --file $file"
    Copy-Item $file -Destination "$outputPath/packages"

    if ($PublishInternal) {
        $feedUrl = "https://pkgs.dev.azure.com/azure-sdk/public/_packaging/azure-sdk-for-js-test-autorest/npm/registry"

        $overrides = @{
            "@azure-typespec/http-client-csharp" = "$feedUrl/@azure-typespec/http-client-csharp/-/http-client-csharp-$emitterVersion.tgz"
        }
    }
    else {
        $overrides = @{}
    }

    $overrides | ConvertTo-Json | Set-Content "$outputPath/overrides.json"

    $packageMatrix = [ordered]@{
        "emitter"   = $emitterVersion
    }

    $packageMatrix | ConvertTo-Json | Set-Content "$outputPath/package-versions.json"
}
finally {
    Pop-Location
}

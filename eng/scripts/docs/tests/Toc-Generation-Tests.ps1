<#
```
Invoke-Pester -Output Detailed $PSScriptRoot\tests\Toc-Generation-Tests.ps1
```
#>

Import-Module Pester

BeforeAll {
    . $PSScriptRoot/../Docs-ToC.ps1
    function Backup-File($targetPath, $backupFolder) {
        $fileName = (Split-Path $targetPath -leaf)
        $backupFile = "$backupFolder/temp-$fileName"
        $null = New-Item $backupFile -ItemType "file" -Force
        $null = Copy-Item $targetPath -Destination $backupFile
    }
    function Reset-File($targetPath, $backupFolder) {
        $fileName = (Split-Path $targetPath -leaf)
        $null = Copy-Item "$backupFolder/temp-$fileName" -Destination $targetPath
    }
}

AfterAll {
    $tempLocation = (Join-Path ([System.IO.Path]::GetTempPath()) "extractNupkg")
    # Remove-Item "$tempLocation/*" -Recurse
}
# Test plan:
# 1. Tests on Fetch-NamespacesFromNupkg from nuget source. 
# 2. Tests on Fetch-NamespacesFromNupkg from public feeds. 
Describe "Fetch-NamespacesFromNupkg-Nuget" -Tag "UnitTest" {
    # Passed cases
    It "Fetch namespaces from package downloads from nuget" -TestCases @(
        @{ package = "Azure.Core"; version="1.24.0"; expectNamespaces = @('Azure', 'Azure.Core', 'Azure.Core.Cryptography', 'Azure.Core.Diagnostics', 'Azure.Core.Extensions', 'Azure.Core.GeoJson', 'Azure.Core.Pipeline', 'Azure.Core.Serialization', 'Azure.Messaging') }
        @{ package = "Azure.Template"; version="1.0.3-beta.20201112"; expectNamespaces = @('Azure.Template', 'Azure.Template.Models') }
        @{ package = "Azure.Search.Documents"; version="11.5.0-beta.2"; expectNamespaces = @('Azure.Search.Documents', 'Azure.Search.Documents.Indexes', 'Azure.Search.Documents.Indexes.Models', 'Azure.Search.Documents.Models', 'Microsoft.Extensions.Azure') }
    ) {
        $namespaces = Fetch-NamespacesFromNupkg -package $package -version $version
        $namespaces | Should -Be $expectNamespaces
    }
    # Failed cases
    It "The package does not exist in Nuget" -TestCases @(
        @{ package = "Azure.Core.NotExist"; version="1.24.0" }
        @{ package = "Azure.Core"; version="1.24.0.notexist" }
        @{ package = "Azure.Core"; version="1.26.0-alpha.20221102.2" }
    ) {
        $namespaces = Fetch-NamespacesFromNupkg -package $package -version $version
        $namespaces | Should -BeNullOrEmpty
    }
}

Describe "Fetch-NamespacesFromNupkg-PublicFeeds" -Tag "UnitTest" {
    BeforeAll {
        Set-Variable -Name 'PackageSourceOverride' -Value "https://pkgs.dev.azure.com/azure-sdk/public/_packaging/azure-sdk-for-net/nuget/v3/index.json" -ErrorAction 'Ignore'
    }
    # passed cases
    It "Fetch namespaces from package downloads from public feeds" -TestCases @(
        @{ package = "Azure.AI.FormRecognizer"; version="4.1.0-alpha.20221101.1"; expectNamespaces = @('Azure.AI.FormRecognizer', 'Azure.AI.FormRecognizer.DocumentAnalysis', 'Azure.AI.FormRecognizer.Models', 'Azure.AI.FormRecognizer.Training', 'Microsoft.Extensions.Azure') }
        @{ package = "Azure.AI.TextAnalytics"; version="5.3.0-alpha.20221102.2"; expectNamespaces = @('Azure.AI.TextAnalytics', 'Microsoft.Extensions.Azure') }
        @{ package = "Azure.ResourceManager.Advisor"; version="1.0.0-alpha.20221102.1"; expectNamespaces = @('Azure.ResourceManager.Advisor', 'Azure.ResourceManager.Advisor.Models') }
    ) {
        $namespaces = Fetch-NamespacesFromNupkg -package $package -version $version
        $namespaces | Should -Be $expectNamespaces
    }
    # Failed cases
    It "Empty project array" -TestCases @(
        @{ projGroupArray = ,@(); }
        @{ projGroupArray = @(); }
    ) {
        { Write-Test-Dependency-Group-To-Files -ProjectGroups $projGroupArray -MatrixOutputFolder "$PSScriptRoot/testFolder" }
            | Should -Throw -ExceptionType ([System.Management.Automation.RuntimeException])
    }
    AfterEach {
        Set-Variable -Name 'PackageSourceOverride' -Value "" -ErrorAction 'Ignore'
    }
}

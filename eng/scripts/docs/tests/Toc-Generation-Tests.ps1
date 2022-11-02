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
    Remove-Item "$tempLocation/*" -Recurse
}
# Test plan:
# 1. Tests on Fetch-NamespacesFromNupkg from nuget source. 
# 2. Tests on Fetch-NamespacesFromNupkg from public feeds. 
Describe "Fetch-NamespacesFromNupkg-Nuget" -Tag "UnitTest" {
    # Passed cases
    It "Fetch namespaces from package downloads from nuget" -TestCases @(
        @{ package = "Azure.Core"; version="1.24.0"; expectNamespaces = @() }
        @{ package = "Azure.Template"; version="1.0.3-beta.20201117"; expectNamespaces = @() }
        @{ package = "Azure.Search.Documents"; version="11.5.0-beta.2"; expectNamespaces = @() }
    ) {
        $namespaces = Fetch-NamespacesFromNupkg -package $package -version $version
        $namespaces | Should -Be $expectNamespaces
    }
    # Failed cases
    # It "Zero test projects per job" -TestCases @(
    #     @{ projectFile = "$PSScriptRoot/inputs/projects.txt"; NumOfTestProjectsPerJob = 0}
    #     @{ projectFile = "$PSScriptRoot/inputs/empty_projects.txt"}
    # ) {
    #     {Split-Project-File-To-Groups -ProjectFile $projectFile -NumberOfTestsPerJob $NumOfTestProjectsPerJob `
    #         -ExcludeService $true -ServiceDirToExclude "core"} | Should -Throw -ExceptionType ([System.Management.Automation.RuntimeException])
    # }
}

Describe "Fetch-NamespacesFromNupkg-PublicFeeds" -Tag "UnitTest" {
    BeforeAll {
        Set-Variable -Name 'PackageSourceOverride' -Value "https://pkgs.dev.azure.com/azure-sdk/public/_packaging/azure-sdk-for-net/nuget/v3/index.json" -ErrorAction 'Ignore'
    }
    # passed cases
    It "Fetch namespaces from package downloads from public feeds" -TestCases @(
        @{ package = "Azure.AI.FormRecognizer"; version="4.1.0-alpha.20221101.1"; expectNamespaces = @() }
        @{ package = "Azure.AI.TextAnalytics"; version="5.3.0-alpha.20221102.2"; expectNamespaces = @() }
        @{ package = "Azure.ResourceManager.Advisor"; version="1.0.0-alpha.20221102.1"; expectNamespaces = @() }
    ) {
        $namespaces = Fetch-NamespacesFromNupkg -package $package -version $version
        $namespaces | Should -Be $expectNamespaces
    }
    # Failed cases
    # It "Empty project array" -TestCases @(
    #     @{ projGroupArray = ,@(); }
    #     @{ projGroupArray = @(); }
    # ) {
    #     { Write-Test-Dependency-Group-To-Files -ProjectGroups $projGroupArray -MatrixOutputFolder "$PSScriptRoot/testFolder" }
    #         | Should -Throw -ExceptionType ([System.Management.Automation.RuntimeException])
    # }
    AfterEach {
        Set-Variable -Name 'PackageSourceOverride' -Value "" -ErrorAction 'Ignore'
    }
}

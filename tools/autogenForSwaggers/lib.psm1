function Remove-All {
    param([string]$path)

    If (Test-Path $path){
	    Remove-Item $path -Recurse -Force
    }
}

function New-Dir {
    param([string]$path)

    New-Item -Path $path -ItemType Directory | Out-Null
}

function Clear-Dir {
    param([string]$path)

    Remove-All -path $path
    New-Dir -path $path
}

function Set-Default {
    param([psobject] $object, [string] $member, $value)

    if (-Not ($object | Get-Member -Name $member))
    {
        $object | Add-Member -type NoteProperty -name $member -value $value
    }
}

function Update-SdkInfo {
    param([psobject] $info, [string] $commit)

    # isArm
    Set-Default -object $info -member isArm -value $info.name.StartsWith("arm-")

    # isComposite
    $isComposite = $info.sources | Where-Object {$_.StartsWith("composite") }
    Set-Default -object $info -member isComposite -value $isComposite

    # dotNet
    $dotNet = New-Object -TypeName PSObject
    Set-Default -object $info -member dotNet -value $dotNet
    $dotNet = $info.dotNet

    # dotNet.ft
    Set-Default -object $dotNet -member ft -value 0

    # dotNet.name
    $dotNetName = $info.name.Split("/")[0]
    $dotNetName = If ($info.isArm) { $dotNetName.SubString(4) } Else { $dotNetName }
    $dotNetNameArray = $dotNetName.Split("-") | ForEach-Object {$_.SubString(0, 1).ToUpper() + $_.SubString(1)}
    Set-Default -object $dotNet -member name -value ([string]::Join(".", $dotNetNameArray))

    # dotNet.folder
    Set-Default -object $dotNet -member folder -value $dotNet.name

    # dotNet.output
    $prefix = If ($info.isArm) { "Management." } Else { "dataPlane\Microsoft.Azure." }
    Set-Default -object $dotNet -member output -value "$prefix$($dotNet.name)\Generated"

    # dotNet.test
    $test = "$($dotNet.name).Tests"
    Set-Default -object $dotNet -member test -value "$test\$test.csproj"

    # dotNet.namespace
    $prefix = If ($info.isArm) { "Management." } Else { "" }
    Set-Default -object $dotNet -member namespace -value "Microsoft.Azure.$prefix$($dotNet.name)"

    # dotNet.commit
    Set-Default -object $dotNet -member commit -value $commit
}

function Read-SdkInfoList {
    param([string] $project, [string] $sdkInfo, [string] $commit)

    $array = Get-Content $sdkInfo | Out-String | ConvertFrom-Json
    $array = $array | Where-Object { $_.name -like $project }

    if (-Not $array)
    {
        throw "unknown project $project"
    }

    $array | ForEach-Object { Update-SdkInfo $_ $commit }

    return $array
}

function Get-DotNetPath {
    param([string] $sdkDir, [psobject]$dotNet, [string]$folder)

    Join-Path $sdkDir "src\SDKs\$($dotNet.folder)\$folder"
}

function Get-SourcePath {
    param([string] $specs, [psobject]$info, [string]$source)

    if (Is-Url -specs $specs) {
        "$specs/$($info.name)/$source"
    } else {
        Join-Path (Join-Path $specs $info.name) $source
    }
}

function Get-LangInfo {
    param([psobject] $lang)

    if (-Not $lang) {
        [PSCustomObject] @{
            jsonRpc = $false
            script = $false
        }
    } else {
        [PSCustomObject] @{
            jsonRpc = $true
            script = $lang -ne "json-rpc"
        }
    }
}

function Generate-Sdk {
    param([string] $specs, [psobject] $info, [string] $sdkDir, [string] $lang)

    $dotNet = $info.dotNet

    $info

    "Generating SDK..."

    "AutoRest: $($dotNet.autorest)"
    if ($dotNet.autorest) {
        # get a specific version of AutoRest
        $index = $dotNet.autorest.IndexOf('.')
        $package = $dotNet.autorest.SubString(0, $index)
        $version = $dotNet.autorest.SubString($index + 1)
        $packages = Join-Path $sdkDir "packages"
        $autoRestExe = Join-Path $packages "$($dotNet.autorest)\tools\AutoRest.exe"
        $r = @(
            "install",
            $package,
            "-Version",
            $version,
            "-o",
            $packages
        )
        if ($version.Contains("-"))
        {
            $r += "-Source"
            $r += "https://www.myget.org/F/autorest/api/v2"
        }
        $r
        $tools = Join-Path $sdkDir "tools\nuget.exe"
        & $tools $r
        if (-Not $?) {
            Write-Error "autorest restore errors"
            exit $LASTEXITCODE
        }
    } else {
        $autoRestExe = "autorest"
    }

    $langInfo = Get-LangInfo -lang $lang

    $commit = if ($dotNet.commit) { $dotNet.commit } else { "master" }

    $isUrl = Is-Url -specs $specs
    "Commit: $commits"
    if (-Not $isUrl) {
        $location = Get-Location
        Set-Location $specs
        git checkout $commit
        Set-Location $location
    } else {
        $specs = $specs.Replace('https://github.com/', 'https://raw.githubusercontent.com/')
        $specs = "$specs/$commit"
    }

    "Clear $output"
    $output = Get-DotNetPath -sdkDir $sdkDir -dotNet $dotNet -folder $dotNet.output
    Clear-Dir -path $output

    if ($dotNet.autorest -or $info.isLegacy) {
        if ($langInfo.jsonRpc) {
            Write-Error "JSON RPC is not supported for $($info.name)"
            exit -1
        }
        # Run AutoRest for all sources.
        $info.sources | ForEach-Object {
            $modeler = if ($info.isComposite) { "CompositeSwagger" } else { "Swagger" }
            $input = Get-SourcePath -specs $specs -info $info -source $_
            $r = @(
                "-Modeler",
                $modeler,
                "-CodeGenerator",
                "Azure.CSharp",
                "-Namespace",
                $dotNet.namespace,
                "-outputDirectory",
                $output,
                "-Header",
                "MICROSOFT_MIT",
                "-ft",
                $dotNet.ft,
                "-Input",
                $input
            )
            if ($dotNet.client) {
                $r += "-name"
                $r += $dotNet.client
            }
            $r
            & $autoRestExe $r
            if (-Not $?) {
                Write-Error "generation errors"
                exit $LASTEXITCODE
            }
        }
    } else {
        $autoRestExe = "autorest"
        $r = @(
            "--csharp.azure-arm",
            "--namespace=$($dotNet.namespace)",
            "--output-folder=$output",
            "--license-header=MICROSOFT_MIT",
            "--payload-flattening-threshold=$($dotNet.ft)"
        )
        if ($langInfo.jsonRpc) {
            $r += "--json-rpc"
        }
        $title = $dotNet.client
        if ($info.isComposite) {
            $info.sources | ForEach-Object {
                $compositeDir = Split-Path -Path $_ -Parent
                $compositeInput = Get-SourcePath -specs $specs -info $info -source $_
                $compositeStr = if (Is-Url -specs $specs) {
                    $web = New-Object Net.WebClient
                    $web.DownloadString($compositeInput)
                } else {
                    Get-Content $compositeInput | Out-String
                }
                $composite = $compositeStr | ConvertFrom-Json
                $composite.documents | ForEach-Object {
                    $input = Get-SourcePath -specs $specs -info $info -source "$compositeDir/$_"
                    $r += "--input-file=$input"
                }
                if(-Not $title) {
                    $title = $composite.info.title
                }
            }
        } else {
            $info.sources | % {
                $input = Get-SourcePath -specs $specs -info $info -source $_
                $r += "--input-file=$input"
            }
        }
        if ($title) {
            $r += "--override-info.title=$title"
        }
        $r
        & $autoRestExe $r
        if (-Not $?) {
            Write-Error "generation errors"
            exit $LASTEXITCODE
        }
    }
}

function Build-Project {
    param([string] $project)

    $p = Join-Path (Get-Location) "common.targets"

    "Restoring test project NuGet packages..."
    dotnet restore $project

    "& dotnet build $project /p:CustomAfterMicrosoftCommonTargets=$p"
    & dotnet build $project /p:CustomAfterMicrosoftCommonTargets=$p
    if (-Not $?) {
        Write-Error "build errors"
        exit $LASTEXITCODE
    }
}

function Get-DotNetTest {
    param([string] $sdkDir, [psobject] $dotNet)

    Get-DotNetPath -sdkDir $sdkDir -dotNet $dotNet -folder $dotNet.test
}

function Get-DotNetTestList {
    param([string] $sdkDir, [psobject] $infoList)

    return $infoList | ForEach-Object { Get-DotNetTest -sdkDir $sdkDir -dotNet $_.dotNet } | Get-Unique
}

function Is-Url {
    param([string] $specs)

    return $specs.StartsWith("http")
}

function Get-SdkInfoPath {
    param([string] $sdkDir, [string] $fileName = "sdkinfo.json")

    Join-Path (Join-Path $sdkDir "tools\autogenForSwaggers") $fileName
}

function Get-SdkInfoLockPath {
    param([string] $sdkDir)

    Get-SdkInfoPath -sdkDir $sdkDir -fileName "sdkinfo.lock.json"
}

function GenerateAndBuild {
    param([string] $project, [string] $specs, [string] $sdkDir)

    $sdkInfoLock = Get-SdkInfoLockPath -sdkDir $sdkDir

    $infoList = Read-SdkInfoList -project $project -sdkInfo $sdkInfoLock

    $infoList | ForEach-Object { Generate-Sdk -sdkDir $sdkDir -specs $specs -info $_ }

    $testProjectList = Get-DotNetTestList -sdkDir $sdkDir -infoList $infoList

    $testProjectList | ForEach-Object { Build-Project -sdkDir $sdkDir -project $_ }
}

Export-ModuleMember -Function Read-SdkInfoList
Export-ModuleMember -Function Generate-Sdk
Export-ModuleMember -Function Build-Project
Export-ModuleMember -Function Get-DotNetTestList
Export-ModuleMember -Function Is-Url
Export-ModuleMember -Function GenerateAndBuild
Export-ModuleMember -Function Get-SdkInfoPath
Export-ModuleMember -Function Get-SdkInfoLockPath

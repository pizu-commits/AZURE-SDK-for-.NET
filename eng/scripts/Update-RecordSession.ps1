[CmdletBinding()]
param (
    [Parameter(Position=0)]
    [ValidateNotNullOrEmpty()]
    [string] $SessionRecordsFolder
)

Get-ChildItem -Recurse $SessionRecordsFolder -Filter *.json | 
Foreach-Object {
#    $records = Get-Content $_.FullName -Raw | ConvertFrom-Json 
#    $records.Entries = $records.Entries | Where-Object { -not ($_.RequestMethod -eq "GET" -And $_.ResponseBody.status -ne "Succeeded" -And $_.RequestUri.Contains("operationResults")) }
#    ConvertTo-Json @($records) -Depth 100 | Out-File $_.FullName
    $outFile = ""
    $record = ""
    $pulling = 0
    $isEntries = $false
    $enclose = 0
    foreach($line in Get-Content -encoding ASCII $_.FullName) {
        if ($isEntries)
        {
            if ($enclose -eq 0) {
                if ($line.Trim() -eq "{") {
                    # Start a new record
                    $enclose = 1
                    $pulling = 0;
                    $record = $line
                }
                else{
                    # Finished
                    $outFile += "`r`n" + $line
                    $isEntries = $false
                }
            }
            else {
                $record += "`r`n" + $line
                
                if ($line.Contains("{")) {
                    $enclose++
                }
                if ($line.Contains("}")) {
                    $enclose--
                }
                #Write-Host "Enclose:" + $enclose + $line
                if ($enclose -eq 0) {
                    # End a record
                    # Write-Host $pulling
                    if ($pulling -ne 7) {
                        # Not pulling record
                        $outFile += "`r`n" + $record
                    }
                }
                if ($line.Contains("""RequestUri"":") -and $line.Contains("/operationResults/")) {
                    $pulling += 1
                }
                elseif ($line.Contains("""RequestMethod"": ""GET""")) {
                    $pulling += 2
                }
                elseif ($line.Contains("""status"":") -and ($line -NotContains """status"": ""Succeeded""")) {
                    $pulling += 4
                }
            }
        }
        else {
            if ($outFile -eq "") {
                $outFile = $line
            }
            else {
                $outFile += "`r`n" + $line
            }
            if ($line.Trim() -eq """Entries"": [") {
                # Start the work
                $isEntries = $true
            }
        }
    }
    $outFile | Out-File -encoding ASCII $_.FullName
    #$outFile | Out-File -encoding ASCII "$_.bak"
}

Import-Module -Name ../../eng/scripts/X509Certificate2 -Verbose

$cert = New-X509Certificate2 -SubjectName 'E=opensource@microsoft.com, CN=Azure SDK, OU=Azure SDK, O=Microsoft, L=Frisco, S=TX, C=US' -ValidDays 3652


Write-Host "test"
$PSBoundParameters
Test2 -a 'aa' -b 'bb'

function Test1 {
    param($a, $b)

    $OutPut = New-Object 'System.Collections.Generic.Dictionary[String,String]'
    $pem = Format-X509Certificate2 -Certificate $cert
    $pk = Format-X509Certificate2 -Type Pkcs8 -Certificate $cert
    $Output['CL_PEM'] =  $pem;
    $OutPut['CL_PEM_PK'] = $pk;

    return $OutPut
 }
 
 function Test2 {
    param($a, $b)
    # Run the Test1 function with $a and $b.
    $output = Test1 @$PSBoundParameters

    $PSBoundParameters['Pre-Output'] = $output
    
    Write-Host 'Test2'
    
    Test3 @PSBoundParameters
 }


 function Test3 {
    param($a, $b)
    
    Write-Host 'Test3'
#    $PSBoundParameters

    Write-Host $PSBoundParameters['Pre-Output']['CL_PEM']
    Write-Host F$PSBoundParameters['Pre-Output']['CL_PEM_PK']
 }

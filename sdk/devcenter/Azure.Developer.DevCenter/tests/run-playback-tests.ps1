$env:AZURE_TEST_MODE="Playback"

# Note: this script adapts these existing env vars to .NET's expected format. Ensure these valuess are defined in your
# user-defined environment variables before running.
$env:DEFAULT_DEVCENTER_ENDPOINT=$env:DEVCENTER_ENDPOINT

dotnet test

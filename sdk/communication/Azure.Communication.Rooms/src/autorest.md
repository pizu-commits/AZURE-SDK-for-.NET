# Azure.Communication.CallingServer

When a new version of the swagger needs to be updated:
1. Open Azure.Communication.sln and under sdk\communication, run `dotnet msbuild /t:GenerateCode` to generate code.

2. Upload the Azure.Communication.Call.dll to the [apiview.dev tool](https://apiview.dev/).
If any of the new objects needs to be overwritten, add the required changes to the 'Models' folder.

3. Repeat 2 and 3 until the desided interface is reflected in the apiview.dev.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
title: Rooms
model-namespace: false
require:
    -  https://raw.githubusercontent.com/Azure/azure-rest-api-specs/ea1a21b30050e1a4b992dcb9d33db1245fa30b89/specification/communication/data-plane/Rooms/readme.md
payload-flattening-threshold: 10
clear-output-folder: true
generation1-convenience-client: true
```

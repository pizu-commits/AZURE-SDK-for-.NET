# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/dcf548aea9f776d166e8c53f8ecb8eff9beef2a5/specification/devcenter/data-plane/Microsoft.DevCenter/preview/2023-01-01-preview/devcenter.json
  - https://github.com/Azure/azure-rest-api-specs/blob/dcf548aea9f776d166e8c53f8ecb8eff9beef2a5/specification/devcenter/data-plane/Microsoft.DevCenter/preview/2023-01-01-preview/devbox.json
  - https://github.com/Azure/azure-rest-api-specs/blob/dcf548aea9f776d166e8c53f8ecb8eff9beef2a5/specification/devcenter/data-plane/Microsoft.DevCenter/preview/2023-01-01-preview/environments.json

namespace: Azure.Developer.DevCenter
security: AADToken
security-scopes: https://devcenter.azure.com/.default

directive:
  # Move project name to method level parameters
  - from: swagger-document
    where: $.parameters["ProjectNameParameter"]
    transform: >-
      $["x-ms-parameter-location"] = "method"

  # Ensure we use Uri rather than string in .NET
  - from: swagger-document
    where: "$.parameters.EndpointParameter"
    transform: >-
      $["format"] = "url";

  # @autorest/csharp hasn't yet shipped a version which understands operation-location. Until then, pull the options.
  # TODO: remove these directives once fix makes it to a version of @autorest/csharp
  - from: swagger-document
    where-operation: DevBoxes_DeleteDevBox
    transform: >-
      delete $["x-ms-long-running-operation-options"];

  - from: swagger-document
    where-operation: DevBoxes_RestartDevBox
    transform: >-
      delete $["x-ms-long-running-operation-options"];

  - from: swagger-document
    where-operation: DevBoxes_StartDevBox
    transform: >-
      delete $["x-ms-long-running-operation-options"];

  - from: swagger-document
    where-operation: DevBoxes_StopDevBox
    transform: >-
      delete $["x-ms-long-running-operation-options"];
```

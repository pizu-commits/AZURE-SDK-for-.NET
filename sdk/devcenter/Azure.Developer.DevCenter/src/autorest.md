# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
- autorest.md

namespace: Azure.Developer.DevCenter
security: AADToken
security-scopes: https://devcenter.azure.com/.default

input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/dcf548aea9f776d166e8c53f8ecb8eff9beef2a5/specification/devcenter/data-plane/Microsoft.DevCenter/preview/2023-01-01-preview/devcenter.json
  - https://github.com/Azure/azure-rest-api-specs/blob/dcf548aea9f776d166e8c53f8ecb8eff9beef2a5/specification/devcenter/data-plane/Microsoft.DevCenter/preview/2023-01-01-preview/devbox.json
  - https://github.com/Azure/azure-rest-api-specs/blob/dcf548aea9f776d166e8c53f8ecb8eff9beef2a5/specification/devcenter/data-plane/Microsoft.DevCenter/preview/2023-01-01-preview/environments.json

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

  # Override operation names to match SDK naming preferences
  # TODO: update these names in the Swagger itself for the 2023-07-01-preview version
  - from: swagger-document
    where-operation: DevBoxes_DelayActions
    transform: >-
      $.operationId = "DevBoxes_DelayAllActions";

  - from: swagger-document
    where-operation: DevBoxes_GetDevBoxByUser
    transform: >-
      $.operationId = "DevBoxes_GetDevBox";

  - from: swagger-document
    where-operation: DevBoxes_ListDevBoxesByUser
    transform: >-
      $.operationId = "DevBoxes_ListDevBoxes";

  - from: swagger-document
    where-operation: DevBoxes_ListSchedulesByPool
    transform: >-
      $.operationId = "DevBoxes_ListSchedules";

  - from: swagger-document
    where-operation: DevBoxes_GetScheduleByPool
    transform: >-
      $.operationId = "DevBoxes_GetSchedule";

  - from: swagger-document
    where-operation: DevCenter_ListAllDevBoxes
    transform: >-
      $.operationId = "DevBoxes_ListAllDevBoxes";

  - from: swagger-document
    where-operation: DevCenter_ListAllDevBoxesByUser
    transform: >-
      $.operationId = "DevBoxes_ListAllDevBoxesByUser";

  - from: swagger-document
    where-operation: Environments_CreateOrReplaceEnvironment
    transform: >-
      $.operationId = "DeploymentEnvironments_CreateOrUpdateEnvironment";

  - from: swagger-document
    where-operation: Environments_DeleteEnvironment
    transform: >-
      $.operationId = "DeploymentEnvironments_DeleteEnvironment";

  - from: swagger-document
    where-operation: Environments_GetCatalog
    transform: >-
      $.operationId = "DeploymentEnvironments_GetCatalog";

  - from: swagger-document
    where-operation: Environments_GetEnvironmentByUser
    transform: >-
      $.operationId = "DeploymentEnvironments_GetEnvironment";

  - from: swagger-document
    where-operation: Environments_GetEnvironmentDefinition
    transform: >-
      $.operationId = "DeploymentEnvironments_GetEnvironmentDefinition";

  - from: swagger-document
    where-operation: Environments_ListCatalogsByProject
    transform: >-
      $.operationId = "DeploymentEnvironments_ListCatalogs";

  - from: swagger-document
    where-operation: Environments_ListEnvironmentDefinitionsByCatalog
    transform: >-
      $.operationId = "DeploymentEnvironments_ListEnvironmentDefinitionsByCatalog";

  - from: swagger-document
    where-operation: Environments_ListEnvironmentDefinitionsByProject
    transform: >-
      $.operationId = "DeploymentEnvironments_ListEnvironmentDefinitions";

  - from: swagger-document
    where-operation: Environments_ListEnvironments
    transform: >-
      $.operationId = "DeploymentEnvironments_ListAllEnvironments";

  - from: swagger-document
    where-operation: Environments_ListEnvironmentsByUser
    transform: >-
      $.operationId = "DeploymentEnvironments_ListEnvironments";

  - from: swagger-document
    where-operation: Environments_ListEnvironmentTypes
    transform: >-
      $.operationId = "DeploymentEnvironments_ListEnvironmentTypes";
```

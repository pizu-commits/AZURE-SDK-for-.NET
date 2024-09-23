// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_ServiceWorkspaceNamedValueCollection
    {
        // ApiManagementListWorkspaceNamedValues
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ApiManagementListWorkspaceNamedValues()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementListWorkspaceNamedValues.json
            // this example is just showing the usage of "WorkspaceNamedValue_ListByService" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation and iterate over the result
            await foreach (ServiceWorkspaceNamedValueResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementNamedValueData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ApiManagementGetWorkspaceNamedValue
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetWorkspaceNamedValue()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceNamedValue.json
            // this example is just showing the usage of "WorkspaceNamedValue_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testarmTemplateproperties2";
            ServiceWorkspaceNamedValueResource result = await collection.GetAsync(namedValueId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementNamedValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetWorkspaceNamedValue
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetWorkspaceNamedValue()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceNamedValue.json
            // this example is just showing the usage of "WorkspaceNamedValue_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testarmTemplateproperties2";
            bool result = await collection.ExistsAsync(namedValueId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetWorkspaceNamedValue
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetWorkspaceNamedValue()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceNamedValue.json
            // this example is just showing the usage of "WorkspaceNamedValue_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testarmTemplateproperties2";
            NullableResponse<ServiceWorkspaceNamedValueResource> response = await collection.GetIfExistsAsync(namedValueId);
            ServiceWorkspaceNamedValueResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementNamedValueData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementGetWorkspaceNamedValueWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetWorkspaceNamedValueWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceNamedValueWithKeyVault.json
            // this example is just showing the usage of "WorkspaceNamedValue_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testprop6";
            ServiceWorkspaceNamedValueResource result = await collection.GetAsync(namedValueId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementNamedValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementGetWorkspaceNamedValueWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ApiManagementGetWorkspaceNamedValueWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceNamedValueWithKeyVault.json
            // this example is just showing the usage of "WorkspaceNamedValue_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testprop6";
            bool result = await collection.ExistsAsync(namedValueId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetWorkspaceNamedValueWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ApiManagementGetWorkspaceNamedValueWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementGetWorkspaceNamedValueWithKeyVault.json
            // this example is just showing the usage of "WorkspaceNamedValue_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testprop6";
            NullableResponse<ServiceWorkspaceNamedValueResource> response = await collection.GetIfExistsAsync(namedValueId);
            ServiceWorkspaceNamedValueResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ApiManagementNamedValueData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ApiManagementCreateWorkspaceNamedValue
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceNamedValue()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateWorkspaceNamedValue.json
            // this example is just showing the usage of "WorkspaceNamedValue_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testprop2";
            ApiManagementNamedValueCreateOrUpdateContent content = new ApiManagementNamedValueCreateOrUpdateContent()
            {
                Tags =
{
"foo","bar"
},
                IsSecret = false,
                DisplayName = "prop3name",
                Value = "propValue",
            };
            ArmOperation<ServiceWorkspaceNamedValueResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, namedValueId, content);
            ServiceWorkspaceNamedValueResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementNamedValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateWorkspaceNamedValueWithKeyVault
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApiManagementCreateWorkspaceNamedValueWithKeyVault()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/preview/2023-03-01-preview/examples/ApiManagementCreateWorkspaceNamedValueWithKeyVault.json
            // this example is just showing the usage of "WorkspaceNamedValue_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WorkspaceContractResource created on azure
            // for more information of creating WorkspaceContractResource, please refer to the document of WorkspaceContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            ResourceIdentifier workspaceContractResourceId = WorkspaceContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId);
            WorkspaceContractResource workspaceContract = client.GetWorkspaceContractResource(workspaceContractResourceId);

            // get the collection of this ServiceWorkspaceNamedValueResource
            ServiceWorkspaceNamedValueCollection collection = workspaceContract.GetServiceWorkspaceNamedValues();

            // invoke the operation
            string namedValueId = "testprop6";
            ApiManagementNamedValueCreateOrUpdateContent content = new ApiManagementNamedValueCreateOrUpdateContent()
            {
                Tags =
{
"foo","bar"
},
                IsSecret = true,
                DisplayName = "prop6namekv",
                KeyVault = new KeyVaultContractCreateProperties()
                {
                    SecretIdentifier = "https://contoso.vault.azure.net/secrets/aadSecret",
                    IdentityClientId = "ceaa6b06-c00f-43ef-99ac-f53d1fe876a0",
                },
            };
            ArmOperation<ServiceWorkspaceNamedValueResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, namedValueId, content);
            ServiceWorkspaceNamedValueResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementNamedValueData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

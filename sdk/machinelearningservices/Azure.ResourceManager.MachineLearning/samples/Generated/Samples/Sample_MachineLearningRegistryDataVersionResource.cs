// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningRegistryDataVersionResource
    {
        // Delete Registry Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteRegistryDataVersionBase()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/DataVersionBase/delete.json
            // this example is just showing the usage of "RegistryDataVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryDataVersionResource created on azure
            // for more information of creating MachineLearningRegistryDataVersionResource, please refer to the document of MachineLearningRegistryDataVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "registryName";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningRegistryDataVersionResourceId = MachineLearningRegistryDataVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, name, version);
            MachineLearningRegistryDataVersionResource machineLearningRegistryDataVersion = client.GetMachineLearningRegistryDataVersionResource(machineLearningRegistryDataVersionResourceId);

            // invoke the operation
            await machineLearningRegistryDataVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Registry Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetRegistryDataVersionBase()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/DataVersionBase/get.json
            // this example is just showing the usage of "RegistryDataVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryDataVersionResource created on azure
            // for more information of creating MachineLearningRegistryDataVersionResource, please refer to the document of MachineLearningRegistryDataVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "registryName";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningRegistryDataVersionResourceId = MachineLearningRegistryDataVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, name, version);
            MachineLearningRegistryDataVersionResource machineLearningRegistryDataVersion = client.GetMachineLearningRegistryDataVersionResource(machineLearningRegistryDataVersionResourceId);

            // invoke the operation
            MachineLearningRegistryDataVersionResource result = await machineLearningRegistryDataVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Registry Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateRegistryDataVersionBase()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/DataVersionBase/createOrUpdate.json
            // this example is just showing the usage of "RegistryDataVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryDataVersionResource created on azure
            // for more information of creating MachineLearningRegistryDataVersionResource, please refer to the document of MachineLearningRegistryDataVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "registryName";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningRegistryDataVersionResourceId = MachineLearningRegistryDataVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, name, version);
            MachineLearningRegistryDataVersionResource machineLearningRegistryDataVersion = client.GetMachineLearningRegistryDataVersionResource(machineLearningRegistryDataVersionResourceId);

            // invoke the operation
            MachineLearningDataVersionData data = new MachineLearningDataVersionData(new MachineLearningTable(new Uri("string"))
            {
                ReferencedUris =
{
new Uri("string")
},
                IsAnonymous = false,
                IsArchived = false,
                Description = "string",
                Properties =
{
["string"] = "string",
},
                Tags =
{
["string"] = "string",
},
            });
            ArmOperation<MachineLearningRegistryDataVersionResource> lro = await machineLearningRegistryDataVersion.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningRegistryDataVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrGetStartPendingUpload Registry Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrGetStartPendingUpload_CreateOrGetStartPendingUploadRegistryDataVersionBase()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Registry/DataVersionBase/createOrGetStartPendingUpload.json
            // this example is just showing the usage of "RegistryDataVersions_CreateOrGetStartPendingUpload" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningRegistryDataVersionResource created on azure
            // for more information of creating MachineLearningRegistryDataVersionResource, please refer to the document of MachineLearningRegistryDataVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string registryName = "registryName";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningRegistryDataVersionResourceId = MachineLearningRegistryDataVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, name, version);
            MachineLearningRegistryDataVersionResource machineLearningRegistryDataVersion = client.GetMachineLearningRegistryDataVersionResource(machineLearningRegistryDataVersionResourceId);

            // invoke the operation
            PendingUploadRequestDto body = new PendingUploadRequestDto()
            {
                PendingUploadId = "string",
                PendingUploadType = PendingUploadType.None,
            };
            PendingUploadResponseDto result = await machineLearningRegistryDataVersion.CreateOrGetStartPendingUploadAsync(body);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

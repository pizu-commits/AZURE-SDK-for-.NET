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
    public partial class Sample_MachineLearningDataVersionResource
    {
        // Delete Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteWorkspaceDataVersionBase()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/DataVersionBase/delete.json
            // this example is just showing the usage of "DataVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataVersionResource created on azure
            // for more information of creating MachineLearningDataVersionResource, please refer to the document of MachineLearningDataVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningDataVersionResourceId = MachineLearningDataVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningDataVersionResource machineLearningDataVersion = client.GetMachineLearningDataVersionResource(machineLearningDataVersionResourceId);

            // invoke the operation
            await machineLearningDataVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWorkspaceDataVersionBase()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/DataVersionBase/get.json
            // this example is just showing the usage of "DataVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataVersionResource created on azure
            // for more information of creating MachineLearningDataVersionResource, please refer to the document of MachineLearningDataVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningDataVersionResourceId = MachineLearningDataVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningDataVersionResource machineLearningDataVersion = client.GetMachineLearningDataVersionResource(machineLearningDataVersionResourceId);

            // invoke the operation
            MachineLearningDataVersionResource result = await machineLearningDataVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CreateOrUpdate Workspace Data Version Base.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateWorkspaceDataVersionBase()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Workspace/DataVersionBase/createOrUpdate.json
            // this example is just showing the usage of "DataVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningDataVersionResource created on azure
            // for more information of creating MachineLearningDataVersionResource, please refer to the document of MachineLearningDataVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string name = "string";
            string version = "string";
            ResourceIdentifier machineLearningDataVersionResourceId = MachineLearningDataVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, name, version);
            MachineLearningDataVersionResource machineLearningDataVersion = client.GetMachineLearningDataVersionResource(machineLearningDataVersionResourceId);

            // invoke the operation
            MachineLearningDataVersionData data = new MachineLearningDataVersionData(new MachineLearningUriFileDataVersion(new Uri("string"))
            {
                IsAnonymous = false,
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
            ArmOperation<MachineLearningDataVersionResource> lro = await machineLearningDataVersion.UpdateAsync(WaitUntil.Completed, data);
            MachineLearningDataVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningDataVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

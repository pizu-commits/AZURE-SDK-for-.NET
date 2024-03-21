// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridNetwork.Models;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_NetworkFunctionDefinitionVersionResource
    {
        // Delete a network function definition version
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteANetworkFunctionDefinitionVersion()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionDefinitionVersionDelete.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestNetworkFunctionDefinitionGroupName";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            await networkFunctionDefinitionVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Delete a network function definition version for AzureCore VNF
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteANetworkFunctionDefinitionVersionForAzureCoreVNF()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureCore/VirtualNetworkFunctionDefinitionVersionDelete.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestNetworkFunctionDefinitionGroupName";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            await networkFunctionDefinitionVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Delete a network function definition version for AzureOperatorNexus VNF
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteANetworkFunctionDefinitionVersionForAzureOperatorNexusVNF()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureOperatorNexus/VirtualNetworkFunctionDefinitionVersionDelete.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestNetworkFunctionDefinitionGroupName";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            await networkFunctionDefinitionVersion.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a network function definition version resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetANetworkFunctionDefinitionVersionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionDefinitionVersionGet.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestNetworkFunctionDefinitionGroupName";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            NetworkFunctionDefinitionVersionResource result = await networkFunctionDefinitionVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionDefinitionVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get network function definition version resource for AzureCore VNF
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkFunctionDefinitionVersionResourceForAzureCoreVNF()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureCore/VirtualNetworkFunctionDefinitionVersionGet.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestNetworkFunctionDefinitionGroupName";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            NetworkFunctionDefinitionVersionResource result = await networkFunctionDefinitionVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionDefinitionVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get network function definition version resource for AzureOperatorNexus VNF
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkFunctionDefinitionVersionResourceForAzureOperatorNexusVNF()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/AzureOperatorNexus/VirtualNetworkFunctionDefinitionVersionGet.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestNetworkFunctionDefinitionGroupName";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            NetworkFunctionDefinitionVersionResource result = await networkFunctionDefinitionVersion.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionDefinitionVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update the network function definition version tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateTheNetworkFunctionDefinitionVersionTags()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionDefinitionVersionUpdateTags.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestNetworkFunctionDefinitionGroupName";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            TagsObject tagsObject = new TagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            NetworkFunctionDefinitionVersionResource result = await networkFunctionDefinitionVersion.UpdateAsync(tagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFunctionDefinitionVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update network function definition version state
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateState_UpdateNetworkFunctionDefinitionVersionState()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkFunctionDefinitionVersionUpdateState.json
            // this example is just showing the usage of "NetworkFunctionDefinitionVersions_updateState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkFunctionDefinitionVersionResource created on azure
            // for more information of creating NetworkFunctionDefinitionVersionResource, please refer to the document of NetworkFunctionDefinitionVersionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkFunctionDefinitionGroupName = "TestSkuGroup";
            string networkFunctionDefinitionVersionName = "1.0.0";
            ResourceIdentifier networkFunctionDefinitionVersionResourceId = NetworkFunctionDefinitionVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkFunctionDefinitionGroupName, networkFunctionDefinitionVersionName);
            NetworkFunctionDefinitionVersionResource networkFunctionDefinitionVersion = client.GetNetworkFunctionDefinitionVersionResource(networkFunctionDefinitionVersionResourceId);

            // invoke the operation
            NetworkFunctionDefinitionVersionUpdateState networkFunctionDefinitionVersionUpdateState = new NetworkFunctionDefinitionVersionUpdateState()
            {
                VersionState = VersionState.Active,
            };
            ArmOperation<NetworkFunctionDefinitionVersionUpdateState> lro = await networkFunctionDefinitionVersion.UpdateStateAsync(WaitUntil.Completed, networkFunctionDefinitionVersionUpdateState);
            NetworkFunctionDefinitionVersionUpdateState result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

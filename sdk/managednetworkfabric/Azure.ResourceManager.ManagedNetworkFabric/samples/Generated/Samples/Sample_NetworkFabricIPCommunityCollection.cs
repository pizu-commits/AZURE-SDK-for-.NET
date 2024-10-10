// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkFabricIPCommunityCollection
    {
        // IpCommunities_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_IpCommunitiesCreateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/IpCommunities_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "IpCommunities_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkFabricIPCommunityResource
            NetworkFabricIPCommunityCollection collection = resourceGroupResource.GetNetworkFabricIPCommunities();

            // invoke the operation
            string ipCommunityName = "example-ipcommunity";
            NetworkFabricIPCommunityData data = new NetworkFabricIPCommunityData(new AzureLocation("eastus"))
            {
                Annotation = "annotation",
                IPCommunityRules =
{
new IPCommunityRule(CommunityActionType.Permit,4155123341L,new string[]
{
"1:1"
})
{
WellKnownCommunities =
{
WellKnownCommunity.Internet
},
}
},
                Tags =
{
["keyId"] = "KeyValue",
},
            };
            ArmOperation<NetworkFabricIPCommunityResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ipCommunityName, data);
            NetworkFabricIPCommunityResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricIPCommunityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // IpCommunities_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_IpCommunitiesGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/IpCommunities_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "IpCommunities_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkFabricIPCommunityResource
            NetworkFabricIPCommunityCollection collection = resourceGroupResource.GetNetworkFabricIPCommunities();

            // invoke the operation
            string ipCommunityName = "example-ipcommunity";
            NetworkFabricIPCommunityResource result = await collection.GetAsync(ipCommunityName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkFabricIPCommunityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // IpCommunities_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_IpCommunitiesGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/IpCommunities_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "IpCommunities_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkFabricIPCommunityResource
            NetworkFabricIPCommunityCollection collection = resourceGroupResource.GetNetworkFabricIPCommunities();

            // invoke the operation
            string ipCommunityName = "example-ipcommunity";
            bool result = await collection.ExistsAsync(ipCommunityName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // IpCommunities_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_IpCommunitiesGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/IpCommunities_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "IpCommunities_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkFabricIPCommunityResource
            NetworkFabricIPCommunityCollection collection = resourceGroupResource.GetNetworkFabricIPCommunities();

            // invoke the operation
            string ipCommunityName = "example-ipcommunity";
            NullableResponse<NetworkFabricIPCommunityResource> response = await collection.GetIfExistsAsync(ipCommunityName);
            NetworkFabricIPCommunityResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkFabricIPCommunityData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // IpCommunities_ListByResourceGroup_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_IpCommunitiesListByResourceGroupMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/IpCommunities_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "IpCommunities_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this NetworkFabricIPCommunityResource
            NetworkFabricIPCommunityCollection collection = resourceGroupResource.GetNetworkFabricIPCommunities();

            // invoke the operation and iterate over the result
            await foreach (NetworkFabricIPCommunityResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkFabricIPCommunityData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

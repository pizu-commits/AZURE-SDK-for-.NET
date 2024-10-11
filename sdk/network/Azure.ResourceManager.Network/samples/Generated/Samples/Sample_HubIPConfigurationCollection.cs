// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_HubIPConfigurationCollection
    {
        // VirtualHubVirtualHubRouteTableV2Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualHubIpConfigurationGet.json
            // this example is just showing the usage of "VirtualHubIpConfiguration_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this HubIPConfigurationResource
            HubIPConfigurationCollection collection = virtualHub.GetHubIPConfigurations();

            // invoke the operation
            string ipConfigName = "ipconfig1";
            HubIPConfigurationResource result = await collection.GetAsync(ipConfigName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HubIPConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubVirtualHubRouteTableV2Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualHubIpConfigurationGet.json
            // this example is just showing the usage of "VirtualHubIpConfiguration_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this HubIPConfigurationResource
            HubIPConfigurationCollection collection = virtualHub.GetHubIPConfigurations();

            // invoke the operation
            string ipConfigName = "ipconfig1";
            bool result = await collection.ExistsAsync(ipConfigName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VirtualHubVirtualHubRouteTableV2Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_VirtualHubVirtualHubRouteTableV2Get()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualHubIpConfigurationGet.json
            // this example is just showing the usage of "VirtualHubIpConfiguration_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this HubIPConfigurationResource
            HubIPConfigurationCollection collection = virtualHub.GetHubIPConfigurations();

            // invoke the operation
            string ipConfigName = "ipconfig1";
            NullableResponse<HubIPConfigurationResource> response = await collection.GetIfExistsAsync(ipConfigName);
            HubIPConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HubIPConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // VirtualHubIpConfigurationPut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualHubIpConfigurationPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualHubIpConfigurationPut.json
            // this example is just showing the usage of "VirtualHubIpConfiguration_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this HubIPConfigurationResource
            HubIPConfigurationCollection collection = virtualHub.GetHubIPConfigurations();

            // invoke the operation
            string ipConfigName = "ipconfig1";
            HubIPConfigurationData data = new HubIPConfigurationData()
            {
                Subnet = new SubnetData()
                {
                    Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/vnet1/subnets/subnet1"),
                },
            };
            ArmOperation<HubIPConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ipConfigName, data);
            HubIPConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HubIPConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualHubRouteTableV2List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualHubRouteTableV2List()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualHubIpConfigurationList.json
            // this example is just showing the usage of "VirtualHubIpConfiguration_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualHubResource created on azure
            // for more information of creating VirtualHubResource, please refer to the document of VirtualHubResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string virtualHubName = "hub1";
            ResourceIdentifier virtualHubResourceId = VirtualHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualHubName);
            VirtualHubResource virtualHub = client.GetVirtualHubResource(virtualHubResourceId);

            // get the collection of this HubIPConfigurationResource
            HubIPConfigurationCollection collection = virtualHub.GetHubIPConfigurations();

            // invoke the operation and iterate over the result
            await foreach (HubIPConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HubIPConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

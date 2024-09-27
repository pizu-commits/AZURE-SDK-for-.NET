// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VpnGatewayNatRuleCollection
    {
        // NatRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NatRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NatRuleGet.json
            // this example is just showing the usage of "NatRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // get the collection of this VpnGatewayNatRuleResource
            VpnGatewayNatRuleCollection collection = vpnGateway.GetVpnGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            VpnGatewayNatRuleResource result = await collection.GetAsync(natRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnGatewayNatRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NatRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_NatRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NatRuleGet.json
            // this example is just showing the usage of "NatRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // get the collection of this VpnGatewayNatRuleResource
            VpnGatewayNatRuleCollection collection = vpnGateway.GetVpnGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            bool result = await collection.ExistsAsync(natRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NatRuleGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_NatRuleGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NatRuleGet.json
            // this example is just showing the usage of "NatRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // get the collection of this VpnGatewayNatRuleResource
            VpnGatewayNatRuleCollection collection = vpnGateway.GetVpnGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            NullableResponse<VpnGatewayNatRuleResource> response = await collection.GetIfExistsAsync(natRuleName);
            VpnGatewayNatRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnGatewayNatRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // NatRulePut
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_NatRulePut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NatRulePut.json
            // this example is just showing the usage of "NatRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // get the collection of this VpnGatewayNatRuleResource
            VpnGatewayNatRuleCollection collection = vpnGateway.GetVpnGatewayNatRules();

            // invoke the operation
            string natRuleName = "natRule1";
            VpnGatewayNatRuleData data = new VpnGatewayNatRuleData()
            {
                VpnNatRuleType = VpnNatRuleType.Static,
                Mode = VpnNatRuleMode.EgressSnat,
                InternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "10.4.0.0/24",
}
},
                ExternalMappings =
{
new VpnNatRuleMapping()
{
AddressSpace = "192.168.21.0/24",
}
},
                IPConfigurationId = "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworkGateways/cloudnet1-VNG/ipConfigurations/default",
            };
            ArmOperation<VpnGatewayNatRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, natRuleName, data);
            VpnGatewayNatRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VpnGatewayNatRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NatRuleList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_NatRuleList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NatRuleList.json
            // this example is just showing the usage of "NatRules_ListByVpnGateway" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VpnGatewayResource created on azure
            // for more information of creating VpnGatewayResource, please refer to the document of VpnGatewayResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string gatewayName = "gateway1";
            ResourceIdentifier vpnGatewayResourceId = VpnGatewayResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, gatewayName);
            VpnGatewayResource vpnGateway = client.GetVpnGatewayResource(vpnGatewayResourceId);

            // get the collection of this VpnGatewayNatRuleResource
            VpnGatewayNatRuleCollection collection = vpnGateway.GetVpnGatewayNatRules();

            // invoke the operation and iterate over the result
            await foreach (VpnGatewayNatRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VpnGatewayNatRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

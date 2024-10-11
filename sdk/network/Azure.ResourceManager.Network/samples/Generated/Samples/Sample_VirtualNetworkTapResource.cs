// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualNetworkTapResource
    {
        // Delete Virtual Network Tap resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualNetworkTapResource()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkTapDelete.json
            // this example is just showing the usage of "VirtualNetworkTaps_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkTapResource created on azure
            // for more information of creating VirtualNetworkTapResource, please refer to the document of VirtualNetworkTapResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string tapName = "test-vtap";
            ResourceIdentifier virtualNetworkTapResourceId = VirtualNetworkTapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, tapName);
            VirtualNetworkTapResource virtualNetworkTap = client.GetVirtualNetworkTapResource(virtualNetworkTapResourceId);

            // invoke the operation
            await virtualNetworkTap.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Virtual Network Tap
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualNetworkTap()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkTapGet.json
            // this example is just showing the usage of "VirtualNetworkTaps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkTapResource created on azure
            // for more information of creating VirtualNetworkTapResource, please refer to the document of VirtualNetworkTapResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string tapName = "testvtap";
            ResourceIdentifier virtualNetworkTapResourceId = VirtualNetworkTapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, tapName);
            VirtualNetworkTapResource virtualNetworkTap = client.GetVirtualNetworkTapResource(virtualNetworkTapResourceId);

            // invoke the operation
            VirtualNetworkTapResource result = await virtualNetworkTap.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkTapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update virtual network tap tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateVirtualNetworkTapTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkTapUpdateTags.json
            // this example is just showing the usage of "VirtualNetworkTaps_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualNetworkTapResource created on azure
            // for more information of creating VirtualNetworkTapResource, please refer to the document of VirtualNetworkTapResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string tapName = "test-vtap";
            ResourceIdentifier virtualNetworkTapResourceId = VirtualNetworkTapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, tapName);
            VirtualNetworkTapResource virtualNetworkTap = client.GetVirtualNetworkTapResource(virtualNetworkTapResourceId);

            // invoke the operation
            NetworkTagsObject tapParameters = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            VirtualNetworkTapResource result = await virtualNetworkTap.UpdateAsync(tapParameters);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualNetworkTapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all virtual network taps
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualNetworkTaps_ListAllVirtualNetworkTaps()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/VirtualNetworkTapListAll.json
            // this example is just showing the usage of "VirtualNetworkTaps_ListAll" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (VirtualNetworkTapResource item in subscriptionResource.GetVirtualNetworkTapsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualNetworkTapData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

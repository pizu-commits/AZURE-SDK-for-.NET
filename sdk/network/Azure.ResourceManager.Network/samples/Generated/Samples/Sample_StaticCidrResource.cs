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
    public partial class Sample_StaticCidrResource
    {
        // StaticCidrs_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_StaticCidrsCreate()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/StaticCidrs_Create.json
            // this example is just showing the usage of "StaticCidrs_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticCidrResource created on azure
            // for more information of creating StaticCidrResource, please refer to the document of StaticCidrResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            string staticCidrName = "TestStaticCidr";
            ResourceIdentifier staticCidrResourceId = StaticCidrResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName, staticCidrName);
            StaticCidrResource staticCidr = client.GetStaticCidrResource(staticCidrResourceId);

            // invoke the operation
            StaticCidrData data = new StaticCidrData();
            ArmOperation<StaticCidrResource> lro = await staticCidr.UpdateAsync(WaitUntil.Completed, data);
            StaticCidrResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticCidrData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StaticCidrs_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_StaticCidrsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/StaticCidrs_Get.json
            // this example is just showing the usage of "StaticCidrs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticCidrResource created on azure
            // for more information of creating StaticCidrResource, please refer to the document of StaticCidrResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            string staticCidrName = "TestStaticCidr";
            ResourceIdentifier staticCidrResourceId = StaticCidrResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName, staticCidrName);
            StaticCidrResource staticCidr = client.GetStaticCidrResource(staticCidrResourceId);

            // invoke the operation
            StaticCidrResource result = await staticCidr.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticCidrData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // StaticCidrs_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_StaticCidrsDelete()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/StaticCidrs_Delete.json
            // this example is just showing the usage of "StaticCidrs_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticCidrResource created on azure
            // for more information of creating StaticCidrResource, please refer to the document of StaticCidrResource
            string subscriptionId = "11111111-1111-1111-1111-111111111111";
            string resourceGroupName = "rg1";
            string networkManagerName = "TestNetworkManager";
            string poolName = "TestPool";
            string staticCidrName = "TestStaticCidr";
            ResourceIdentifier staticCidrResourceId = StaticCidrResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName, poolName, staticCidrName);
            StaticCidrResource staticCidr = client.GetStaticCidrResource(staticCidrResourceId);

            // invoke the operation
            await staticCidr.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_DedicatedHostGroupResource
    {
        // DedicatedHostGroups_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DedicatedHostGroupsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroups_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "DedicatedHostGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaa";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // invoke the operation
            DedicatedHostGroupPatch patch = new DedicatedHostGroupPatch()
            {
                Zones =
{
"aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
},
                PlatformFaultDomainCount = 3,
                SupportAutomaticPlacement = true,
                Tags =
{
["key9921"] = "aaaaaaaaaa",
},
            };
            DedicatedHostGroupResource result = await dedicatedHostGroup.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DedicatedHostGroups_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DedicatedHostGroupsUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroups_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "DedicatedHostGroups_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaaaaaaaaa";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // invoke the operation
            DedicatedHostGroupPatch patch = new DedicatedHostGroupPatch();
            DedicatedHostGroupResource result = await dedicatedHostGroup.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DedicatedHostGroups_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DedicatedHostGroupsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroups_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "DedicatedHostGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "a";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // invoke the operation
            await dedicatedHostGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // DedicatedHostGroups_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DedicatedHostGroupsDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroups_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "DedicatedHostGroups_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaa";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // invoke the operation
            await dedicatedHostGroup.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Create a dedicated host group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CreateADedicatedHostGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroup_Get.json
            // this example is just showing the usage of "DedicatedHostGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // invoke the operation
            DedicatedHostGroupResource result = await dedicatedHostGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create an ultraSSDEnabled dedicated host group.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CreateAnUltraSSDEnabledDedicatedHostGroup()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroup_Get_UltraSSDEnabledDedicatedHostGroup.json
            // this example is just showing the usage of "DedicatedHostGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostGroupResource created on azure
            // for more information of creating DedicatedHostGroupResource, please refer to the document of DedicatedHostGroupResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            ResourceIdentifier dedicatedHostGroupResourceId = DedicatedHostGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName);
            DedicatedHostGroupResource dedicatedHostGroup = client.GetDedicatedHostGroupResource(dedicatedHostGroupResourceId);

            // invoke the operation
            DedicatedHostGroupResource result = await dedicatedHostGroup.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DedicatedHostGroups_ListBySubscription_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDedicatedHostGroups_DedicatedHostGroupsListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroups_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "DedicatedHostGroups_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DedicatedHostGroupResource item in subscriptionResource.GetDedicatedHostGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedHostGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // DedicatedHostGroups_ListBySubscription_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDedicatedHostGroups_DedicatedHostGroupsListBySubscriptionMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHostGroups_ListBySubscription_MinimumSet_Gen.json
            // this example is just showing the usage of "DedicatedHostGroups_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (DedicatedHostGroupResource item in subscriptionResource.GetDedicatedHostGroupsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DedicatedHostGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

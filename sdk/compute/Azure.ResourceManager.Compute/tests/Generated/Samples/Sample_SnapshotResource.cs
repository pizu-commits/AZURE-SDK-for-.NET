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
    public partial class Sample_SnapshotResource
    {
        // Update a snapshot with accelerated networking.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateASnapshotWithAcceleratedNetworking()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_Update_WithAcceleratedNetwork.json
            // this example is just showing the usage of "Snapshots_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "mySnapshot";
            ResourceIdentifier snapshotResourceId = SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            SnapshotPatch patch = new SnapshotPatch()
            {
                Tags =
{
["department"] = "Development",
["project"] = "UpdateSnapshots",
},
                DiskSizeGB = 20,
                SupportedCapabilities = new SupportedCapabilities()
                {
                    AcceleratedNetwork = false,
                },
            };
            ArmOperation<SnapshotResource> lro = await snapshot.UpdateAsync(WaitUntil.Completed, patch);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_Update.json
            // this example is just showing the usage of "Snapshots_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "mySnapshot";
            ResourceIdentifier snapshotResourceId = SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            SnapshotPatch patch = new SnapshotPatch()
            {
                Tags =
{
["department"] = "Development",
["project"] = "UpdateSnapshots",
},
                DiskSizeGB = 20,
            };
            ArmOperation<SnapshotResource> lro = await snapshot.UpdateAsync(WaitUntil.Completed, patch);
            SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInformationAboutASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "mySnapshot";
            ResourceIdentifier snapshotResourceId = SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            SnapshotResource result = await snapshot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get information about an incremental snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetInformationAboutAnIncrementalSnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_GetIncrementalSnapshot.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "myIncrementalSnapshot";
            ResourceIdentifier snapshotResourceId = SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            SnapshotResource result = await snapshot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_Delete.json
            // this example is just showing the usage of "Snapshots_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "mySnapshot";
            ResourceIdentifier snapshotResourceId = SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            await snapshot.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // List all snapshots in a subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSnapshots_ListAllSnapshotsInASubscription()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_ListBySubscription.json
            // this example is just showing the usage of "Snapshots_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (SnapshotResource item in subscriptionResource.GetSnapshotsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SnapshotData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a sas on a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GrantAccess_GetASasOnASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_BeginGetAccess.json
            // this example is just showing the usage of "Snapshots_GrantAccess" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "mySnapshot";
            ResourceIdentifier snapshotResourceId = SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            GrantAccessData data = new GrantAccessData(AccessLevel.Read, 300);
            ArmOperation<AccessUri> lro = await snapshot.GrantAccessAsync(WaitUntil.Completed, data);
            AccessUri result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Revoke access to a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RevokeAccess_RevokeAccessToASnapshot()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/DiskRP/stable/2022-07-02/examples/snapshotExamples/Snapshot_EndGetAccess.json
            // this example is just showing the usage of "Snapshots_RevokeAccess" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "mySnapshot";
            ResourceIdentifier snapshotResourceId = SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            await snapshot.RevokeAccessAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

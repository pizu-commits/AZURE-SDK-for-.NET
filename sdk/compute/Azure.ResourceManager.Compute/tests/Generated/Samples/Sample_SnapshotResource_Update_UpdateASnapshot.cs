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

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_SnapshotResource_Update_UpdateASnapshot
    {
        // Update a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/snapshotExamples/Snapshot_Update.json
            // this example is just showing the usage of "Snapshots_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SnapshotResource created on azure
            // for more information of creating SnapshotResource, please refer to the document of SnapshotResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string snapshotName = "mySnapshot";
            ResourceIdentifier snapshotResourceId = Compute.SnapshotResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, snapshotName);
            Compute.SnapshotResource snapshot = client.GetSnapshotResource(snapshotResourceId);

            // invoke the operation
            Compute.Models.SnapshotPatch patch = new SnapshotPatch()
            {
                Tags =
{
["department"] = "Development",
["project"] = "UpdateSnapshots",
},
                DiskSizeGB = 20,
            };
            ArmOperation<Compute.SnapshotResource> lro = await snapshot.UpdateAsync(WaitUntil.Completed, patch);
            Compute.SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

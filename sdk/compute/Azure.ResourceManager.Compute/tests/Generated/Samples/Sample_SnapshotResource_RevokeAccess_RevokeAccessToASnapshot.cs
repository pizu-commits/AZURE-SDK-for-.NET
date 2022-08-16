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

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_SnapshotResource_RevokeAccess_RevokeAccessToASnapshot
    {
        // Revoke access to a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RevokeAccess()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/snapshotExamples/Snapshot_EndGetAccess.json
            // this example is just showing the usage of "Snapshots_RevokeAccess" operation, for the dependent resources, they will have to be created separately.

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
            await snapshot.RevokeAccessAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

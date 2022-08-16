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
    public partial class Sample_SnapshotCollection_CreateOrUpdate_CreateASnapshotByImportingAnUnmanagedBlobFromTheSameSubscription
    {
        // Create a snapshot by importing an unmanaged blob from the same subscription.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/snapshotExamples/Snapshot_Create_ByImportingAnUnmanagedBlobFromTheSameSubscription.json
            // this example is just showing the usage of "Snapshots_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this SnapshotResource
            Compute.SnapshotCollection collection = resourceGroupResource.GetSnapshots();

            // invoke the operation
            string snapshotName = "mySnapshot1";
            Compute.SnapshotData data = new SnapshotData(new AzureLocation("West US"))
            {
                CreationData = new DiskCreationData(DiskCreateOption.Import)
                {
                    SourceUri = new Uri("https://mystorageaccount.blob.core.windows.net/osimages/osimage.vhd"),
                },
            };
            ArmOperation<Compute.SnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            Compute.SnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.SnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

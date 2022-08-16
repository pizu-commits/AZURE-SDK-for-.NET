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
    public partial class Sample_DiskImageCollection_CreateOrUpdate_CreateAVirtualMachineImageFromASnapshot
    {
        // Create a virtual machine image from a snapshot.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/imageExamples/Image_CreateFromASnapshot.json
            // this example is just showing the usage of "Images_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this DiskImageResource
            Compute.DiskImageCollection collection = resourceGroupResource.GetDiskImages();

            // invoke the operation
            string imageName = "myImage";
            Compute.DiskImageData data = new DiskImageData(new AzureLocation("West US"))
            {
                StorageProfile = new ImageStorageProfile()
                {
                    OSDisk = new ImageOSDisk(SupportedOperatingSystemType.Linux, OperatingSystemStateType.Generalized)
                    {
                        SnapshotId = new ResourceIdentifier("subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/snapshots/mySnapshot"),
                    },
                    ZoneResilient = false,
                },
            };
            ArmOperation<Compute.DiskImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, imageName, data);
            Compute.DiskImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

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
    public partial class Sample_GalleryImageVersionCollection_CreateOrUpdate_CreateOrUpdateASimpleGalleryImageVersionUsingVhdAsASource
    {
        // Create or update a simple Gallery Image Version using vhd as a source.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Create_WithVHD.json
            // this example is just showing the usage of "GalleryImageVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryImageResource created on azure
            // for more information of creating GalleryImageResource, please refer to the document of GalleryImageResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryImageName = "myGalleryImageName";
            ResourceIdentifier galleryImageResourceId = Compute.GalleryImageResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryImageName);
            Compute.GalleryImageResource galleryImage = client.GetGalleryImageResource(galleryImageResourceId);

            // get the collection of this GalleryImageVersionResource
            Compute.GalleryImageVersionCollection collection = galleryImage.GetGalleryImageVersions();

            // invoke the operation
            string galleryImageVersionName = "1.0.0";
            Compute.GalleryImageVersionData data = new GalleryImageVersionData(new AzureLocation("West US"))
            {
                PublishingProfile = new GalleryImageVersionPublishingProfile()
                {
                    TargetRegions =
{
new TargetRegion("West US")
{
RegionalReplicaCount = 1,
Encryption = new EncryptionImages()
{
OSDiskImage = new OSDiskImageEncryption()
{
DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSet/myDiskEncryptionSet"),
},
DataDiskImages =
{
new DataDiskImageEncryption(1)
{
DiskEncryptionSetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/diskEncryptionSet/myOtherDiskEncryptionSet"),
}
},
},
},new TargetRegion("East US")
{
RegionalReplicaCount = 2,
StorageAccountType = ImageStorageAccountType.StandardZrs,
}
},
                },
                StorageProfile = new GalleryImageVersionStorageProfile()
                {
                    OSDiskImage = new GalleryOSDiskImage()
                    {
                        HostCaching = HostCaching.ReadOnly,
                        Source = new GalleryArtifactVersionSource()
                        {
                            Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.Storage/storageAccounts/{storageAccount}"),
                            Uri = new Uri("https://gallerysourcencus.blob.core.windows.net/myvhds/Windows-Server-2012-R2-20171216-en.us-128GB.vhd"),
                        },
                    },
                    DataDiskImages =
{
new GalleryDataDiskImage(1)
{
HostCaching = HostCaching.None,
Source = new GalleryArtifactVersionSource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/myResourceGroup/providers/Microsoft.Storage/storageAccounts/{storageAccount}"),
Uri = new Uri("https://gallerysourcencus.blob.core.windows.net/myvhds/Windows-Server-2012-R2-20171216-en.us-128GB.vhd"),
},
}
},
                },
            };
            ArmOperation<Compute.GalleryImageVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, galleryImageVersionName, data);
            Compute.GalleryImageVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

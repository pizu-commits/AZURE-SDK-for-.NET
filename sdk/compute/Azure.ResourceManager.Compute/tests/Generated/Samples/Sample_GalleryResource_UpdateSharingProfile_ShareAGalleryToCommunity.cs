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
    public partial class Sample_GalleryResource_UpdateSharingProfile_ShareAGalleryToCommunity
    {
        // share a gallery to community.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateSharingProfile()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/Gallery_EnableCommunityGallery.json
            // this example is just showing the usage of "GallerySharingProfile_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = Compute.GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            Compute.GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // invoke the operation
            Compute.Models.SharingUpdate sharingUpdate = new SharingUpdate(SharingUpdateOperationType.EnableCommunity);
            ArmOperation<Compute.Models.SharingUpdate> lro = await gallery.UpdateSharingProfileAsync(WaitUntil.Completed, sharingUpdate);
            Compute.Models.SharingUpdate result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

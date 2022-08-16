// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_GalleryImageVersionCollection_Get_GetAGalleryImageVersionWithSnapshotsAsASource
    {
        // Get a gallery image version with snapshots as a source.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryImageVersion_Get_WithSnapshotsAsSource.json
            // this example is just showing the usage of "GalleryImageVersions_Get" operation, for the dependent resources, they will have to be created separately.

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
            Compute.GalleryImageVersionResource result = await collection.GetAsync(galleryImageVersionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryImageVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

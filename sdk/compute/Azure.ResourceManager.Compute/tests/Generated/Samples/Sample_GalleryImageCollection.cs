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
    public partial class Sample_GalleryImageCollection
    {
        // Create or update a simple gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateASimpleGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2022-03-03/examples/galleryExamples/GalleryImage_Create.json
            // this example is just showing the usage of "GalleryImages_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // get the collection of this GalleryImageResource
            GalleryImageCollection collection = gallery.GetGalleryImages();

            // invoke the operation
            string galleryImageName = "myGalleryImageName";
            GalleryImageData data = new GalleryImageData(new AzureLocation("West US"))
            {
                OSType = SupportedOperatingSystemType.Windows,
                OSState = OperatingSystemStateType.Generalized,
                HyperVGeneration = HyperVGeneration.V1,
                Identifier = new GalleryImageIdentifier("myPublisherName", "myOfferName", "mySkuName"),
            };
            ArmOperation<GalleryImageResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, galleryImageName, data);
            GalleryImageResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2022-03-03/examples/galleryExamples/GalleryImage_Get.json
            // this example is just showing the usage of "GalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // get the collection of this GalleryImageResource
            GalleryImageCollection collection = gallery.GetGalleryImages();

            // invoke the operation
            string galleryImageName = "myGalleryImageName";
            GalleryImageResource result = await collection.GetAsync(galleryImageName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GalleryImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2022-03-03/examples/galleryExamples/GalleryImage_Get.json
            // this example is just showing the usage of "GalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // get the collection of this GalleryImageResource
            GalleryImageCollection collection = gallery.GetGalleryImages();

            // invoke the operation
            string galleryImageName = "myGalleryImageName";
            bool result = await collection.ExistsAsync(galleryImageName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List gallery images in a gallery.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListGalleryImagesInAGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2022-03-03/examples/galleryExamples/GalleryImage_ListByGallery.json
            // this example is just showing the usage of "GalleryImages_ListByGallery" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryResource created on azure
            // for more information of creating GalleryResource, please refer to the document of GalleryResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            ResourceIdentifier galleryResourceId = GalleryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName);
            GalleryResource gallery = client.GetGalleryResource(galleryResourceId);

            // get the collection of this GalleryImageResource
            GalleryImageCollection collection = gallery.GetGalleryImages();

            // invoke the operation and iterate over the result
            await foreach (GalleryImageResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GalleryImageData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

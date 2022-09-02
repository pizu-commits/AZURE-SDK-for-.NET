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
    public partial class Sample_SharedGalleryImageResource
    {
        // Get a shared gallery image.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASharedGalleryImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2022-01-03/examples/sharedGalleryExamples/SharedGalleryImage_Get.json
            // this example is just showing the usage of "SharedGalleryImages_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SharedGalleryImageResource created on azure
            // for more information of creating SharedGalleryImageResource, please refer to the document of SharedGalleryImageResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string galleryUniqueName = "galleryUniqueName";
            string galleryImageName = "myGalleryImageName";
            ResourceIdentifier sharedGalleryImageResourceId = SharedGalleryImageResource.CreateResourceIdentifier(subscriptionId, location, galleryUniqueName, galleryImageName);
            SharedGalleryImageResource sharedGalleryImage = client.GetSharedGalleryImageResource(sharedGalleryImageResourceId);

            // invoke the operation
            SharedGalleryImageResource result = await sharedGalleryImage.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SharedGalleryImageData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

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
    public partial class Sample_GalleryCollection_CreateOrUpdate_CreateOrUpdateASimpleGalleryWithSharingProfile
    {
        // Create or update a simple gallery with sharing profile.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/Gallery_Create_WithSharingProfile.json
            // this example is just showing the usage of "Galleries_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this GalleryResource
            Compute.GalleryCollection collection = resourceGroupResource.GetGalleries();

            // invoke the operation
            string galleryName = "myGalleryName";
            Compute.GalleryData data = new GalleryData(new AzureLocation("West US"))
            {
                Description = "This is the gallery description.",
                SharingProfile = new SharingProfile()
                {
                    Permission = GallerySharingPermissionType.Groups,
                },
            };
            ArmOperation<Compute.GalleryResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, galleryName, data);
            Compute.GalleryResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

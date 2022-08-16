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
    public partial class Sample_CommunityGalleryImageVersionCollection_Exists_GetACommunityGalleryImageVersion
    {
        // Get a community gallery image version.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/communityGalleryExamples/CommunityGalleryImageVersion_Get.json
            // this example is just showing the usage of "CommunityGalleryImageVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CommunityGalleryImageResource created on azure
            // for more information of creating CommunityGalleryImageResource, please refer to the document of CommunityGalleryImageResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string publicGalleryName = "publicGalleryName";
            string galleryImageName = "myGalleryImageName";
            ResourceIdentifier communityGalleryImageResourceId = Compute.CommunityGalleryImageResource.CreateResourceIdentifier(subscriptionId, location, publicGalleryName, galleryImageName);
            Compute.CommunityGalleryImageResource communityGalleryImage = client.GetCommunityGalleryImageResource(communityGalleryImageResourceId);

            // get the collection of this CommunityGalleryImageVersionResource
            Compute.CommunityGalleryImageVersionCollection collection = communityGalleryImage.GetCommunityGalleryImageVersions();

            // invoke the operation
            string galleryImageVersionName = "myGalleryImageVersionName";
            bool result = await collection.ExistsAsync(galleryImageVersionName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

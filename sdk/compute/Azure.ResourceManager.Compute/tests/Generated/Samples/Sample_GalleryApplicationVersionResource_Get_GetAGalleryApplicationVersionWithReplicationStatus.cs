// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_GalleryApplicationVersionResource_Get_GetAGalleryApplicationVersionWithReplicationStatus
    {
        // Get a gallery Application Version with replication status.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-01-03/GalleryRP/examples/galleryExamples/GalleryApplicationVersion_Get_WithReplicationStatus.json
            // this example is just showing the usage of "GalleryApplicationVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this GalleryApplicationVersionResource created on azure
            // for more information of creating GalleryApplicationVersionResource, please refer to the document of GalleryApplicationVersionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string galleryName = "myGalleryName";
            string galleryApplicationName = "myGalleryApplicationName";
            string galleryApplicationVersionName = "1.0.0";
            ResourceIdentifier galleryApplicationVersionResourceId = Compute.GalleryApplicationVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, galleryName, galleryApplicationName, galleryApplicationVersionName);
            Compute.GalleryApplicationVersionResource galleryApplicationVersion = client.GetGalleryApplicationVersionResource(galleryApplicationVersionResourceId);

            // invoke the operation
            Compute.Models.ReplicationStatusType? expand = ReplicationStatusType.ReplicationStatus;
            Compute.GalleryApplicationVersionResource result = await galleryApplicationVersion.GetAsync(expand: expand);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.GalleryApplicationVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

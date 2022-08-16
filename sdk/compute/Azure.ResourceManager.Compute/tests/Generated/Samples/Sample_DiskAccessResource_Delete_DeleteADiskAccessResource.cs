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

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_DiskAccessResource_Delete_DeleteADiskAccessResource
    {
        // Delete a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskAccessExamples/DiskAccess_Delete.json
            // this example is just showing the usage of "DiskAccesses_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DiskAccessResource created on azure
            // for more information of creating DiskAccessResource, please refer to the document of DiskAccessResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskAccessName = "myDiskAccess";
            ResourceIdentifier diskAccessResourceId = Compute.DiskAccessResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskAccessName);
            Compute.DiskAccessResource diskAccess = client.GetDiskAccessResource(diskAccessResourceId);

            // invoke the operation
            await diskAccess.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

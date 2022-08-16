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
    public partial class Sample_DiskAccessResource_Update_UpdateADiskAccessResource
    {
        // Update a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskAccessExamples/DiskAccess_Update.json
            // this example is just showing the usage of "DiskAccesses_Update" operation, for the dependent resources, they will have to be created separately.

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
            Compute.Models.DiskAccessPatch patch = new DiskAccessPatch()
            {
                Tags =
{
["department"] = "Development",
["project"] = "PrivateEndpoints",
},
            };
            ArmOperation<Compute.DiskAccessResource> lro = await diskAccess.UpdateAsync(WaitUntil.Completed, patch);
            Compute.DiskAccessResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DiskAccessData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

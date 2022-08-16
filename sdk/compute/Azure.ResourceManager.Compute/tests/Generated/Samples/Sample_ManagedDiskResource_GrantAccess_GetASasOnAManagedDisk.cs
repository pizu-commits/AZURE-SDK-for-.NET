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
    public partial class Sample_ManagedDiskResource_GrantAccess_GetASasOnAManagedDisk
    {
        // Get a sas on a managed disk.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GrantAccess()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskExamples/Disk_BeginGetAccess.json
            // this example is just showing the usage of "Disks_GrantAccess" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ManagedDiskResource created on azure
            // for more information of creating ManagedDiskResource, please refer to the document of ManagedDiskResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskName = "myDisk";
            ResourceIdentifier managedDiskResourceId = Compute.ManagedDiskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskName);
            Compute.ManagedDiskResource managedDisk = client.GetManagedDiskResource(managedDiskResourceId);

            // invoke the operation
            Compute.Models.GrantAccessData data = new GrantAccessData(AccessLevel.Read, 300);
            ArmOperation<Compute.Models.AccessUri> lro = await managedDisk.GrantAccessAsync(WaitUntil.Completed, data);
            Compute.Models.AccessUri result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

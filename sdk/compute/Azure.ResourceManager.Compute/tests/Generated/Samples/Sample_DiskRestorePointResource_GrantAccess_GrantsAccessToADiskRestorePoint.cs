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
    public partial class Sample_DiskRestorePointResource_GrantAccess_GrantsAccessToADiskRestorePoint
    {
        // Grants access to a diskRestorePoint.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GrantAccess()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskRestorePointExamples/DiskRestorePoint_BeginGetAccess.json
            // this example is just showing the usage of "DiskRestorePoint_GrantAccess" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DiskRestorePointResource created on azure
            // for more information of creating DiskRestorePointResource, please refer to the document of DiskRestorePointResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpc";
            string vmRestorePointName = "vmrp";
            string diskRestorePointName = "TestDisk45ceb03433006d1baee0_b70cd924-3362-4a80-93c2-9415eaa12745";
            ResourceIdentifier diskRestorePointResourceId = Compute.DiskRestorePointResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName, vmRestorePointName, diskRestorePointName);
            Compute.DiskRestorePointResource diskRestorePoint = client.GetDiskRestorePointResource(diskRestorePointResourceId);

            // invoke the operation
            Compute.Models.GrantAccessData data = new GrantAccessData(AccessLevel.Read, 300);
            ArmOperation<Compute.Models.AccessUri> lro = await diskRestorePoint.GrantAccessAsync(WaitUntil.Completed, data);
            Compute.Models.AccessUri result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

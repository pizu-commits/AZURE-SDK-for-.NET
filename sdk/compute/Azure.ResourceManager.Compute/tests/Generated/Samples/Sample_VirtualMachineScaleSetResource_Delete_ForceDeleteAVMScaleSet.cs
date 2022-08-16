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
    public partial class Sample_VirtualMachineScaleSetResource_Delete_ForceDeleteAVMScaleSet
    {
        // Force Delete a VM scale set.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSet_Delete_Force.json
            // this example is just showing the usage of "VirtualMachineScaleSets_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            ResourceIdentifier virtualMachineScaleSetResourceId = Compute.VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            Compute.VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // invoke the operation
            bool? forceDeletion = true;
            await virtualMachineScaleSet.DeleteAsync(WaitUntil.Completed, forceDeletion: forceDeletion);

            Console.WriteLine($"Succeeded");
        }
    }
}

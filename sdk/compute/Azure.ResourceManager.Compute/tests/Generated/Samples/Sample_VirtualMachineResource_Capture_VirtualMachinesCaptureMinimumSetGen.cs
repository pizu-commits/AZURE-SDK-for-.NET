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
    public partial class Sample_VirtualMachineResource_Capture_VirtualMachinesCaptureMinimumSetGen
    {
        // VirtualMachines_Capture_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Capture()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineExamples/VirtualMachines_Capture_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachines_Capture" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineResource created on azure
            // for more information of creating VirtualMachineResource, please refer to the document of VirtualMachineResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string vmName = "aaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineResourceId = Compute.VirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName);
            Compute.VirtualMachineResource virtualMachine = client.GetVirtualMachineResource(virtualMachineResourceId);

            // invoke the operation
            Compute.Models.VirtualMachineCaptureContent content = new VirtualMachineCaptureContent("aaaaaaaaa", "aaaaaaa", true);
            ArmOperation<Compute.Models.VirtualMachineCaptureResult> lro = await virtualMachine.CaptureAsync(WaitUntil.Completed, content);
            Compute.Models.VirtualMachineCaptureResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

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
    public partial class Sample_VirtualMachineScaleSetVmRunCommandCollection
    {
        // Create VirtualMachineScaleSet VM run command.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateVirtualMachineScaleSetVMRunCommand()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/runCommandExamples/VirtualMachineScaleSetVMRunCommand_CreateOrUpdate.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetVmResource created on azure
            // for more information of creating VirtualMachineScaleSetVmResource, please refer to the document of VirtualMachineScaleSetVmResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            ResourceIdentifier virtualMachineScaleSetVmResourceId = VirtualMachineScaleSetVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId);
            VirtualMachineScaleSetVmResource virtualMachineScaleSetVm = client.GetVirtualMachineScaleSetVmResource(virtualMachineScaleSetVmResourceId);

            // get the collection of this VirtualMachineScaleSetVmRunCommandResource
            VirtualMachineScaleSetVmRunCommandCollection collection = virtualMachineScaleSetVm.GetVirtualMachineScaleSetVmRunCommands();

            // invoke the operation
            string runCommandName = "myRunCommand";
            VirtualMachineRunCommandData data = new VirtualMachineRunCommandData(new AzureLocation("West US"))
            {
                Source = new VirtualMachineRunCommandScriptSource()
                {
                    Script = "Write-Host Hello World!",
                },
                Parameters =
{
new RunCommandInputParameter("param1","value1"),new RunCommandInputParameter("param2","value2")
},
                AsyncExecution = false,
                RunAsUser = "user1",
                RunAsPassword = "<runAsPassword>",
                TimeoutInSeconds = 3600,
            };
            ArmOperation<VirtualMachineScaleSetVmRunCommandResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, runCommandName, data);
            VirtualMachineScaleSetVmRunCommandResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineRunCommandData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get VirtualMachineScaleSet VM run commands.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachineScaleSetVMRunCommands()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/runCommandExamples/VirtualMachineScaleSetVMRunCommand_Get.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetVmResource created on azure
            // for more information of creating VirtualMachineScaleSetVmResource, please refer to the document of VirtualMachineScaleSetVmResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            ResourceIdentifier virtualMachineScaleSetVmResourceId = VirtualMachineScaleSetVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId);
            VirtualMachineScaleSetVmResource virtualMachineScaleSetVm = client.GetVirtualMachineScaleSetVmResource(virtualMachineScaleSetVmResourceId);

            // get the collection of this VirtualMachineScaleSetVmRunCommandResource
            VirtualMachineScaleSetVmRunCommandCollection collection = virtualMachineScaleSetVm.GetVirtualMachineScaleSetVmRunCommands();

            // invoke the operation
            string runCommandName = "myRunCommand";
            VirtualMachineScaleSetVmRunCommandResource result = await collection.GetAsync(runCommandName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineRunCommandData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get VirtualMachineScaleSet VM run commands.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVirtualMachineScaleSetVMRunCommands()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/runCommandExamples/VirtualMachineScaleSetVMRunCommand_Get.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetVmResource created on azure
            // for more information of creating VirtualMachineScaleSetVmResource, please refer to the document of VirtualMachineScaleSetVmResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            ResourceIdentifier virtualMachineScaleSetVmResourceId = VirtualMachineScaleSetVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId);
            VirtualMachineScaleSetVmResource virtualMachineScaleSetVm = client.GetVirtualMachineScaleSetVmResource(virtualMachineScaleSetVmResourceId);

            // get the collection of this VirtualMachineScaleSetVmRunCommandResource
            VirtualMachineScaleSetVmRunCommandCollection collection = virtualMachineScaleSetVm.GetVirtualMachineScaleSetVmRunCommands();

            // invoke the operation
            string runCommandName = "myRunCommand";
            bool result = await collection.ExistsAsync(runCommandName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List run commands in Vmss instance.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListRunCommandsInVmssInstance()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/runCommandExamples/VirtualMachineScaleSetVMRunCommand_List.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMRunCommands_List" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this VirtualMachineScaleSetVmResource created on azure
            // for more information of creating VirtualMachineScaleSetVmResource, please refer to the document of VirtualMachineScaleSetVmResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "myvmScaleSet";
            string instanceId = "0";
            ResourceIdentifier virtualMachineScaleSetVmResourceId = VirtualMachineScaleSetVmResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName, instanceId);
            VirtualMachineScaleSetVmResource virtualMachineScaleSetVm = client.GetVirtualMachineScaleSetVmResource(virtualMachineScaleSetVmResourceId);

            // get the collection of this VirtualMachineScaleSetVmRunCommandResource
            VirtualMachineScaleSetVmRunCommandCollection collection = virtualMachineScaleSetVm.GetVirtualMachineScaleSetVmRunCommands();

            // invoke the operation and iterate over the result
            await foreach (VirtualMachineScaleSetVmRunCommandResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualMachineRunCommandData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_VirtualMachineRunCommandResource
    {
        // VirtualMachineRunCommandList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualMachineRunCommands_VirtualMachineRunCommandList()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/runCommandExamples/RunCommand_List.json
            // this example is just showing the usage of "VirtualMachineRunCommands_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            AzureLocation location = new AzureLocation("SoutheastAsia");
            await foreach (RunCommandDocumentBase item in subscriptionResource.GetVirtualMachineRunCommandsAsync(location))
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineRunCommandGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualMachineRunCommand_VirtualMachineRunCommandGet()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/runCommandExamples/RunCommand_Get.json
            // this example is just showing the usage of "VirtualMachineRunCommands_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "24fb23e3-6ba3-41f0-9b6e-e41131d5d61e";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("SoutheastAsia");
            string commandId = "RunPowerShellScript";
            RunCommandDocument result = await subscriptionResource.GetVirtualMachineRunCommandAsync(location, commandId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Update a run command.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateARunCommand()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/runCommandExamples/VirtualMachineRunCommand_Update.json
            // this example is just showing the usage of "VirtualMachineRunCommands_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineRunCommandResource created on azure
            // for more information of creating VirtualMachineRunCommandResource, please refer to the document of VirtualMachineRunCommandResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string vmName = "myVM";
            string runCommandName = "myRunCommand";
            ResourceIdentifier virtualMachineRunCommandResourceId = VirtualMachineRunCommandResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, runCommandName);
            VirtualMachineRunCommandResource virtualMachineRunCommand = client.GetVirtualMachineRunCommandResource(virtualMachineRunCommandResourceId);

            // invoke the operation
            VirtualMachineRunCommandUpdate runCommand = new VirtualMachineRunCommandUpdate()
            {
                Source = new VirtualMachineRunCommandScriptSource()
                {
                    Script = "Write-Host Hello World! ; Remove-Item C:\test\testFile.txt",
                },
                Parameters =
{
new RunCommandInputParameter("param1","value1"),new RunCommandInputParameter("param2","value2")
},
                AsyncExecution = false,
                RunAsUser = "user1",
                RunAsPassword = "<runAsPassword>",
                TimeoutInSeconds = 3600,
                OutputBlobUri = new Uri("https://mystorageaccount.blob.core.windows.net/myscriptoutputcontainer/outputUri"),
                ErrorBlobUri = new Uri("https://mystorageaccount.blob.core.windows.net/mycontainer/MyScriptError.txt"),
                ErrorBlobManagedIdentity = new RunCommandManagedIdentity()
                {
                    ObjectId = "4231e4d2-33e4-4e23-96b2-17888afa6072",
                },
            };
            ArmOperation<VirtualMachineRunCommandResource> lro = await virtualMachineRunCommand.UpdateAsync(WaitUntil.Completed, runCommand);
            VirtualMachineRunCommandResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineRunCommandData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a run command.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteARunCommand()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/runCommandExamples/VirtualMachineRunCommand_Delete.json
            // this example is just showing the usage of "VirtualMachineRunCommands_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineRunCommandResource created on azure
            // for more information of creating VirtualMachineRunCommandResource, please refer to the document of VirtualMachineRunCommandResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string vmName = "myVM";
            string runCommandName = "myRunCommand";
            ResourceIdentifier virtualMachineRunCommandResourceId = VirtualMachineRunCommandResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, runCommandName);
            VirtualMachineRunCommandResource virtualMachineRunCommand = client.GetVirtualMachineRunCommandResource(virtualMachineRunCommandResourceId);

            // invoke the operation
            await virtualMachineRunCommand.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a run command.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetARunCommand()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2024-03-01/examples/runCommandExamples/VirtualMachineRunCommand_Get.json
            // this example is just showing the usage of "VirtualMachineRunCommands_GetByVirtualMachine" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineRunCommandResource created on azure
            // for more information of creating VirtualMachineRunCommandResource, please refer to the document of VirtualMachineRunCommandResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string vmName = "myVM";
            string runCommandName = "myRunCommand";
            ResourceIdentifier virtualMachineRunCommandResourceId = VirtualMachineRunCommandResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vmName, runCommandName);
            VirtualMachineRunCommandResource virtualMachineRunCommand = client.GetVirtualMachineRunCommandResource(virtualMachineRunCommandResourceId);

            // invoke the operation
            VirtualMachineRunCommandResource result = await virtualMachineRunCommand.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineRunCommandData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

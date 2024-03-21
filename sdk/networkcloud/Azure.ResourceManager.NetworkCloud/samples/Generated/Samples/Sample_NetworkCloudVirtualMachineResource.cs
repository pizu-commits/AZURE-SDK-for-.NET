// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.NetworkCloud.Samples
{
    public partial class Sample_NetworkCloudVirtualMachineResource
    {
        // List virtual machines for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetNetworkCloudVirtualMachines_ListVirtualMachinesForSubscription()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_ListBySubscription.json
            // this example is just showing the usage of "VirtualMachines_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (NetworkCloudVirtualMachineResource item in subscriptionResource.GetNetworkCloudVirtualMachinesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkCloudVirtualMachineData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_Get.json
            // this example is just showing the usage of "VirtualMachines_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // invoke the operation
            NetworkCloudVirtualMachineResource result = await networkCloudVirtualMachine.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudVirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_Delete.json
            // this example is just showing the usage of "VirtualMachines_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // invoke the operation
            await networkCloudVirtualMachine.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Patch virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_Patch.json
            // this example is just showing the usage of "VirtualMachines_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // invoke the operation
            NetworkCloudVirtualMachinePatch patch = new NetworkCloudVirtualMachinePatch()
            {
                Tags =
{
["key1"] = "myvalue1",
["key2"] = "myvalue2",
},
                VmImageRepositoryCredentials = new ImageRepositoryCredentials("myacr.azurecr.io", "myuser")
                {
                    Password = "{password}",
                },
            };
            ArmOperation<NetworkCloudVirtualMachineResource> lro = await networkCloudVirtualMachine.UpdateAsync(WaitUntil.Completed, patch);
            NetworkCloudVirtualMachineResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkCloudVirtualMachineData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Power off virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PowerOff_PowerOffVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_PowerOff.json
            // this example is just showing the usage of "VirtualMachines_PowerOff" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // invoke the operation
            VirtualMachinePowerOffContent content = new VirtualMachinePowerOffContent()
            {
                SkipShutdown = SkipShutdown.True,
            };
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudVirtualMachine.PowerOffAsync(WaitUntil.Completed, content: content);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Reimage virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Reimage_ReimageVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_Reimage.json
            // this example is just showing the usage of "VirtualMachines_Reimage" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudVirtualMachine.ReimageAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Restart virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_RestartVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_Restart.json
            // this example is just showing the usage of "VirtualMachines_Restart" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudVirtualMachine.RestartAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }

        // Start virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Start_StartVirtualMachine()
        {
            // Generated from example definition: specification/networkcloud/resource-manager/Microsoft.NetworkCloud/stable/2023-07-01/examples/VirtualMachines_Start.json
            // this example is just showing the usage of "VirtualMachines_Start" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkCloudVirtualMachineResource created on azure
            // for more information of creating NetworkCloudVirtualMachineResource, please refer to the document of NetworkCloudVirtualMachineResource
            string subscriptionId = "123e4567-e89b-12d3-a456-426655440000";
            string resourceGroupName = "resourceGroupName";
            string virtualMachineName = "virtualMachineName";
            ResourceIdentifier networkCloudVirtualMachineResourceId = NetworkCloudVirtualMachineResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineName);
            NetworkCloudVirtualMachineResource networkCloudVirtualMachine = client.GetNetworkCloudVirtualMachineResource(networkCloudVirtualMachineResourceId);

            // invoke the operation
            ArmOperation<NetworkCloudOperationStatusResult> lro = await networkCloudVirtualMachine.StartAsync(WaitUntil.Completed);
            NetworkCloudOperationStatusResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ManagedNetworkFabric.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric.Samples
{
    public partial class Sample_NetworkDeviceInterfaceResource
    {
        // NetworkInterfaces_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_NetworkInterfacesGetMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkInterfaces_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkInterfaces_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkDeviceInterfaceResource created on azure
            // for more information of creating NetworkDeviceInterfaceResource, please refer to the document of NetworkDeviceInterfaceResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkDeviceName = "example-device";
            string networkInterfaceName = "example-interface";
            ResourceIdentifier networkDeviceInterfaceResourceId = NetworkDeviceInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkDeviceName, networkInterfaceName);
            NetworkDeviceInterfaceResource networkDeviceInterface = client.GetNetworkDeviceInterfaceResource(networkDeviceInterfaceResourceId);

            // invoke the operation
            NetworkDeviceInterfaceResource result = await networkDeviceInterface.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkDeviceInterfaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkInterfaces_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_NetworkInterfacesUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkInterfaces_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkInterfaces_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkDeviceInterfaceResource created on azure
            // for more information of creating NetworkDeviceInterfaceResource, please refer to the document of NetworkDeviceInterfaceResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkDeviceName = "example-device";
            string networkInterfaceName = "example-interface";
            ResourceIdentifier networkDeviceInterfaceResourceId = NetworkDeviceInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkDeviceName, networkInterfaceName);
            NetworkDeviceInterfaceResource networkDeviceInterface = client.GetNetworkDeviceInterfaceResource(networkDeviceInterfaceResourceId);

            // invoke the operation
            NetworkDeviceInterfacePatch patch = new NetworkDeviceInterfacePatch()
            {
                Annotation = "annotation",
            };
            ArmOperation<NetworkDeviceInterfaceResource> lro = await networkDeviceInterface.UpdateAsync(WaitUntil.Completed, patch);
            NetworkDeviceInterfaceResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkDeviceInterfaceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // NetworkInterfaces_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_NetworkInterfacesDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkInterfaces_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkInterfaces_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkDeviceInterfaceResource created on azure
            // for more information of creating NetworkDeviceInterfaceResource, please refer to the document of NetworkDeviceInterfaceResource
            string subscriptionId = "94D0FD57-C08B-4CA3-A926-6B76D8B7B956";
            string resourceGroupName = "rgNetworkDevices";
            string networkDeviceName = "sjzd";
            string networkInterfaceName = "emrgu";
            ResourceIdentifier networkDeviceInterfaceResourceId = NetworkDeviceInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkDeviceName, networkInterfaceName);
            NetworkDeviceInterfaceResource networkDeviceInterface = client.GetNetworkDeviceInterfaceResource(networkDeviceInterfaceResourceId);

            // invoke the operation
            await networkDeviceInterface.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // NetworkInterfaces_UpdateAdministrativeState_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task UpdateAdministrativeState_NetworkInterfacesUpdateAdministrativeStateMaximumSetGen()
        {
            // Generated from example definition: specification/managednetworkfabric/resource-manager/Microsoft.ManagedNetworkFabric/stable/2023-06-15/examples/NetworkInterfaces_UpdateAdministrativeState_MaximumSet_Gen.json
            // this example is just showing the usage of "NetworkInterfaces_UpdateAdministrativeState" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkDeviceInterfaceResource created on azure
            // for more information of creating NetworkDeviceInterfaceResource, please refer to the document of NetworkDeviceInterfaceResource
            string subscriptionId = "1234ABCD-0A1B-1234-5678-123456ABCDEF";
            string resourceGroupName = "example-rg";
            string networkDeviceName = "example-device";
            string networkInterfaceName = "example-interface";
            ResourceIdentifier networkDeviceInterfaceResourceId = NetworkDeviceInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkDeviceName, networkInterfaceName);
            NetworkDeviceInterfaceResource networkDeviceInterface = client.GetNetworkDeviceInterfaceResource(networkDeviceInterfaceResourceId);

            // invoke the operation
            UpdateAdministrativeStateContent content = new UpdateAdministrativeStateContent()
            {
                State = AdministrativeEnableState.Enable,
                ResourceIds =
{
new ResourceIdentifier("")
},
            };
            ArmOperation<StateUpdateCommonPostActionResult> lro = await networkDeviceInterface.UpdateAdministrativeStateAsync(WaitUntil.Completed, content);
            StateUpdateCommonPostActionResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

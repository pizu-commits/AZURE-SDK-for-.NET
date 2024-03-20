// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.DeviceUpdate.Samples
{
    public partial class Sample_DeviceUpdatePrivateLinkCollection
    {
        // PrivateLinkResourcesList
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateLinkResourcesList()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateLinkResources/PrivateLinkResources_ListByAccount.json
            // this example is just showing the usage of "PrivateLinkResources_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateLinkResource
            DeviceUpdatePrivateLinkCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateLinks();

            // invoke the operation and iterate over the result
            await foreach (DeviceUpdatePrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceUpdatePrivateLinkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateLinkResourcesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateLinkResources/PrivateLinkResources_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateLinkResource
            DeviceUpdatePrivateLinkCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateLinks();

            // invoke the operation
            string groupId = "adu";
            DeviceUpdatePrivateLinkResource result = await collection.GetAsync(groupId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeviceUpdatePrivateLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateLinkResourcesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateLinkResources/PrivateLinkResources_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateLinkResource
            DeviceUpdatePrivateLinkCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateLinks();

            // invoke the operation
            string groupId = "adu";
            bool result = await collection.ExistsAsync(groupId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateLinkResourcesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/deviceupdate/resource-manager/Microsoft.DeviceUpdate/stable/2023-07-01/examples/PrivateLinkResources/PrivateLinkResources_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeviceUpdateAccountResource created on azure
            // for more information of creating DeviceUpdateAccountResource, please refer to the document of DeviceUpdateAccountResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "test-rg";
            string accountName = "contoso";
            ResourceIdentifier deviceUpdateAccountResourceId = DeviceUpdateAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DeviceUpdateAccountResource deviceUpdateAccount = client.GetDeviceUpdateAccountResource(deviceUpdateAccountResourceId);

            // get the collection of this DeviceUpdatePrivateLinkResource
            DeviceUpdatePrivateLinkCollection collection = deviceUpdateAccount.GetDeviceUpdatePrivateLinks();

            // invoke the operation
            string groupId = "adu";
            NullableResponse<DeviceUpdatePrivateLinkResource> response = await collection.GetIfExistsAsync(groupId);
            DeviceUpdatePrivateLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DeviceUpdatePrivateLinkData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

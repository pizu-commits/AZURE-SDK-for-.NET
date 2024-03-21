// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_VirtualApplianceSiteCollection
    {
        // GetNetwork Virtual Appliance Site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetNetworkVirtualApplianceSite()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkVirtualApplianceSiteGet.json
            // this example is just showing the usage of "VirtualApplianceSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this VirtualApplianceSiteResource
            VirtualApplianceSiteCollection collection = networkVirtualAppliance.GetVirtualApplianceSites();

            // invoke the operation
            string siteName = "site1";
            VirtualApplianceSiteResource result = await collection.GetAsync(siteName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplianceSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetNetwork Virtual Appliance Site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetNetworkVirtualApplianceSite()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkVirtualApplianceSiteGet.json
            // this example is just showing the usage of "VirtualApplianceSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this VirtualApplianceSiteResource
            VirtualApplianceSiteCollection collection = networkVirtualAppliance.GetVirtualApplianceSites();

            // invoke the operation
            string siteName = "site1";
            bool result = await collection.ExistsAsync(siteName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetNetwork Virtual Appliance Site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetNetworkVirtualApplianceSite()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkVirtualApplianceSiteGet.json
            // this example is just showing the usage of "VirtualApplianceSites_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this VirtualApplianceSiteResource
            VirtualApplianceSiteCollection collection = networkVirtualAppliance.GetVirtualApplianceSites();

            // invoke the operation
            string siteName = "site1";
            NullableResponse<VirtualApplianceSiteResource> response = await collection.GetIfExistsAsync(siteName);
            VirtualApplianceSiteResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualApplianceSiteData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create Network Virtual Appliance Site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateNetworkVirtualApplianceSite()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkVirtualApplianceSitePut.json
            // this example is just showing the usage of "VirtualApplianceSites_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this VirtualApplianceSiteResource
            VirtualApplianceSiteCollection collection = networkVirtualAppliance.GetVirtualApplianceSites();

            // invoke the operation
            string siteName = "site1";
            VirtualApplianceSiteData data = new VirtualApplianceSiteData()
            {
                AddressPrefix = "192.168.1.0/24",
                O365BreakOutCategories = new BreakOutCategoryPolicies()
                {
                    Allow = true,
                    Optimize = true,
                    Default = true,
                },
            };
            ArmOperation<VirtualApplianceSiteResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, siteName, data);
            VirtualApplianceSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualApplianceSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all Network Virtual Appliance sites for a given Network Virtual Appliance
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllNetworkVirtualApplianceSitesForAGivenNetworkVirtualAppliance()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-09-01/examples/NetworkVirtualApplianceSiteList.json
            // this example is just showing the usage of "VirtualApplianceSites_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkVirtualApplianceResource created on azure
            // for more information of creating NetworkVirtualApplianceResource, please refer to the document of NetworkVirtualApplianceResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string networkVirtualApplianceName = "nva";
            ResourceIdentifier networkVirtualApplianceResourceId = NetworkVirtualApplianceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkVirtualApplianceName);
            NetworkVirtualApplianceResource networkVirtualAppliance = client.GetNetworkVirtualApplianceResource(networkVirtualApplianceResourceId);

            // get the collection of this VirtualApplianceSiteResource
            VirtualApplianceSiteCollection collection = networkVirtualAppliance.GetVirtualApplianceSites();

            // invoke the operation and iterate over the result
            await foreach (VirtualApplianceSiteResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualApplianceSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

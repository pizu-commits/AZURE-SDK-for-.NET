// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager.Samples
{
    public partial class Sample_TrafficManagerProfileResource
    {
        // NameAvailabilityTest_NameAvailablePOST21
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckTrafficManagerRelativeDnsNameAvailability_NameAvailabilityTestNameAvailablePOST21()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/NameAvailabilityTest_NameAvailable-POST-example-21.json
            // this example is just showing the usage of "Profiles_CheckTrafficManagerRelativeDnsNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            TrafficManagerRelativeDnsNameAvailabilityContent content = new TrafficManagerRelativeDnsNameAvailabilityContent()
            {
                Name = "azsmnet5403",
                ResourceType = new ResourceType("microsoft.network/trafficmanagerprofiles"),
            };
            TrafficManagerNameAvailabilityResult result = await tenantResource.CheckTrafficManagerRelativeDnsNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameAvailabilityTest_NameNotAvailablePOST23
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckTrafficManagerRelativeDnsNameAvailability_NameAvailabilityTestNameNotAvailablePOST23()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/NameAvailabilityTest_NameNotAvailable-POST-example-23.json
            // this example is just showing the usage of "Profiles_CheckTrafficManagerRelativeDnsNameAvailability" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResource created on azure
            // for more information of creating TenantResource, please refer to the document of TenantResource
            var tenantResource = client.GetTenants().GetAllAsync().GetAsyncEnumerator().Current;

            // invoke the operation
            TrafficManagerRelativeDnsNameAvailabilityContent content = new TrafficManagerRelativeDnsNameAvailabilityContent()
            {
                Name = "azsmnet4696",
                ResourceType = new ResourceType("microsoft.network/trafficmanagerprofiles"),
            };
            TrafficManagerNameAvailabilityResult result = await tenantResource.CheckTrafficManagerRelativeDnsNameAvailabilityAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameAvailabilityV2Test_NameAvailablePOST21
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckTrafficManagerNameAvailabilityV2_NameAvailabilityV2TestNameAvailablePOST21()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/NameAvailabilityV2Test_NameAvailable-POST-example-21.json
            // this example is just showing the usage of "Profiles_CheckTrafficManagerNameAvailabilityV2" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            TrafficManagerRelativeDnsNameAvailabilityContent content = new TrafficManagerRelativeDnsNameAvailabilityContent()
            {
                Name = "azsmnet5403",
                ResourceType = new ResourceType("microsoft.network/trafficmanagerprofiles"),
            };
            TrafficManagerNameAvailabilityResult result = await subscriptionResource.CheckTrafficManagerNameAvailabilityV2Async(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // NameAvailabilityV2Test_NameNotAvailablePOST23
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CheckTrafficManagerNameAvailabilityV2_NameAvailabilityV2TestNameNotAvailablePOST23()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/NameAvailabilityV2Test_NameNotAvailable-POST-example-23.json
            // this example is just showing the usage of "Profiles_CheckTrafficManagerNameAvailabilityV2" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            TrafficManagerRelativeDnsNameAvailabilityContent content = new TrafficManagerRelativeDnsNameAvailabilityContent()
            {
                Name = "azsmnet4696",
                ResourceType = new ResourceType("microsoft.network/trafficmanagerprofiles"),
            };
            TrafficManagerNameAvailabilityResult result = await subscriptionResource.CheckTrafficManagerNameAvailabilityV2Async(content);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetTrafficManagerProfiles_ListBySubscription()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/Profile-GET-BySubscription.json
            // this example is just showing the usage of "Profiles_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (TrafficManagerProfileResource item in subscriptionResource.GetTrafficManagerProfilesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                TrafficManagerProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Profile-GET-WithEndpoints
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ProfileGETWithEndpoints()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/Profile-GET-WithEndpoints.json
            // this example is just showing the usage of "Profiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // invoke the operation
            TrafficManagerProfileResource result = await trafficManagerProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Profile-GET-WithTrafficViewDisabled
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ProfileGETWithTrafficViewDisabled()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/Profile-GET-WithTrafficViewDisabled.json
            // this example is just showing the usage of "Profiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // invoke the operation
            TrafficManagerProfileResource result = await trafficManagerProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Profile-GET-WithTrafficViewEnabled
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ProfileGETWithTrafficViewEnabled()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/Profile-GET-WithTrafficViewEnabled.json
            // this example is just showing the usage of "Profiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // invoke the operation
            TrafficManagerProfileResource result = await trafficManagerProfile.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Profile-DELETE
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ProfileDELETE()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/Profile-DELETE.json
            // this example is just showing the usage of "Profiles_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // invoke the operation
            await trafficManagerProfile.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Profile-PATCH-MonitorConfig
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ProfilePATCHMonitorConfig()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/Profile-PATCH-MonitorConfig.json
            // this example is just showing the usage of "Profiles_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerProfileResource created on azure
            // for more information of creating TrafficManagerProfileResource, please refer to the document of TrafficManagerProfileResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager2583";
            string profileName = "azuresdkfornetautoresttrafficmanager6192";
            ResourceIdentifier trafficManagerProfileResourceId = TrafficManagerProfileResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName);
            TrafficManagerProfileResource trafficManagerProfile = client.GetTrafficManagerProfileResource(trafficManagerProfileResourceId);

            // invoke the operation
            TrafficManagerProfileData data = new TrafficManagerProfileData()
            {
                MonitorConfig = new TrafficManagerMonitorConfig()
                {
                    Protocol = TrafficManagerMonitorProtocol.Http,
                    Port = 80,
                    Path = "/testpath.aspx",
                    IntervalInSeconds = 30,
                    TimeoutInSeconds = 6,
                    ToleratedNumberOfFailures = 4,
                    CustomHeaders =
{
new TrafficManagerMonitorConfigCustomHeaderInfo()
{
Name = "header-1",
Value = "value-1",
},new TrafficManagerMonitorConfigCustomHeaderInfo()
{
Name = "header-2",
Value = "value-2",
}
},
                },
            };
            TrafficManagerProfileResource result = await trafficManagerProfile.UpdateAsync(data);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

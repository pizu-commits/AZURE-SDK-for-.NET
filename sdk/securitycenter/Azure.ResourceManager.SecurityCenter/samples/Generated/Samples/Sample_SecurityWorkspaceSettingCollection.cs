// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_SecurityWorkspaceSettingCollection
    {
        // Get workspace settings on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetWorkspaceSettingsOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2017-08-01-preview/examples/WorkspaceSettings/GetWorkspaceSettings_example.json
            // this example is just showing the usage of "WorkspaceSettings_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityWorkspaceSettingResource
            SecurityWorkspaceSettingCollection collection = subscriptionResource.GetSecurityWorkspaceSettings();

            // invoke the operation and iterate over the result
            await foreach (SecurityWorkspaceSettingResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityWorkspaceSettingData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a workspace setting on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAWorkspaceSettingOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2017-08-01-preview/examples/WorkspaceSettings/GetWorkspaceSetting_example.json
            // this example is just showing the usage of "WorkspaceSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityWorkspaceSettingResource
            SecurityWorkspaceSettingCollection collection = subscriptionResource.GetSecurityWorkspaceSettings();

            // invoke the operation
            string workspaceSettingName = "default";
            SecurityWorkspaceSettingResource result = await collection.GetAsync(workspaceSettingName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityWorkspaceSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a workspace setting on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAWorkspaceSettingOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2017-08-01-preview/examples/WorkspaceSettings/GetWorkspaceSetting_example.json
            // this example is just showing the usage of "WorkspaceSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityWorkspaceSettingResource
            SecurityWorkspaceSettingCollection collection = subscriptionResource.GetSecurityWorkspaceSettings();

            // invoke the operation
            string workspaceSettingName = "default";
            bool result = await collection.ExistsAsync(workspaceSettingName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a workspace setting on subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAWorkspaceSettingOnSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2017-08-01-preview/examples/WorkspaceSettings/GetWorkspaceSetting_example.json
            // this example is just showing the usage of "WorkspaceSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityWorkspaceSettingResource
            SecurityWorkspaceSettingCollection collection = subscriptionResource.GetSecurityWorkspaceSettings();

            // invoke the operation
            string workspaceSettingName = "default";
            NullableResponse<SecurityWorkspaceSettingResource> response = await collection.GetIfExistsAsync(workspaceSettingName);
            SecurityWorkspaceSettingResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SecurityWorkspaceSettingData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create a workspace setting data for subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAWorkspaceSettingDataForSubscription()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2017-08-01-preview/examples/WorkspaceSettings/CreateWorkspaceSetting_example.json
            // this example is just showing the usage of "WorkspaceSettings_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // get the collection of this SecurityWorkspaceSettingResource
            SecurityWorkspaceSettingCollection collection = subscriptionResource.GetSecurityWorkspaceSettings();

            // invoke the operation
            string workspaceSettingName = "default";
            SecurityWorkspaceSettingData data = new SecurityWorkspaceSettingData()
            {
                WorkspaceId = new ResourceIdentifier("/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23/resourceGroups/myRg/providers/Microsoft.OperationalInsights/workspaces/myWorkspace"),
                Scope = "/subscriptions/20ff7fc3-e762-44dd-bd96-b71116dcdc23",
            };
            ArmOperation<SecurityWorkspaceSettingResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workspaceSettingName, data);
            SecurityWorkspaceSettingResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityWorkspaceSettingData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

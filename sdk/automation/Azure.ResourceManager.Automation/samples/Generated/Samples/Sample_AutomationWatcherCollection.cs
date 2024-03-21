// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Automation.Samples
{
    public partial class Sample_AutomationWatcherCollection
    {
        // Create or update watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/createOrUpdateWatcher.json
            // this example is just showing the usage of "Watcher_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationWatcherResource
            AutomationWatcherCollection collection = automationAccount.GetAutomationWatchers();

            // invoke the operation
            string watcherName = "MyTestWatcher";
            AutomationWatcherData data = new AutomationWatcherData(null)
            {
                ETag = null,
                ExecutionFrequencyInSeconds = 60,
                ScriptName = "MyTestWatcherRunbook",
                ScriptParameters =
{
},
                ScriptRunOn = "MyTestHybridWorkerGroup",
                Description = "This is a test watcher.",
                Tags =
{
},
            };
            ArmOperation<AutomationWatcherResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, watcherName, data);
            AutomationWatcherResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationWatcherData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getWatcher.json
            // this example is just showing the usage of "Watcher_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationWatcherResource
            AutomationWatcherCollection collection = automationAccount.GetAutomationWatchers();

            // invoke the operation
            string watcherName = "MyTestWatcher";
            AutomationWatcherResource result = await collection.GetAsync(watcherName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomationWatcherData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getWatcher.json
            // this example is just showing the usage of "Watcher_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationWatcherResource
            AutomationWatcherCollection collection = automationAccount.GetAutomationWatchers();

            // invoke the operation
            string watcherName = "MyTestWatcher";
            bool result = await collection.ExistsAsync(watcherName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get watcher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetWatcher()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/getWatcher.json
            // this example is just showing the usage of "Watcher_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationWatcherResource
            AutomationWatcherCollection collection = automationAccount.GetAutomationWatchers();

            // invoke the operation
            string watcherName = "MyTestWatcher";
            NullableResponse<AutomationWatcherResource> response = await collection.GetIfExistsAsync(watcherName);
            AutomationWatcherResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationWatcherData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List watchers by Automation Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListWatchersByAutomationAccount()
        {
            // Generated from example definition: specification/automation/resource-manager/Microsoft.Automation/preview/2020-01-13-preview/examples/listWatchersByAutomationAccount.json
            // this example is just showing the usage of "Watcher_ListByAutomationAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AutomationAccountResource created on azure
            // for more information of creating AutomationAccountResource, please refer to the document of AutomationAccountResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string automationAccountName = "MyTestAutomationAccount";
            ResourceIdentifier automationAccountResourceId = AutomationAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, automationAccountName);
            AutomationAccountResource automationAccount = client.GetAutomationAccountResource(automationAccountResourceId);

            // get the collection of this AutomationWatcherResource
            AutomationWatcherCollection collection = automationAccount.GetAutomationWatchers();

            // invoke the operation and iterate over the result
            await foreach (AutomationWatcherResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomationWatcherData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

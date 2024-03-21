// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_DataShareTriggerResource
    {
        // Triggers_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_TriggersGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/Triggers_Get.json
            // this example is just showing the usage of "Triggers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareTriggerResource created on azure
            // for more information of creating DataShareTriggerResource, please refer to the document of DataShareTriggerResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string triggerName = "Trigger1";
            ResourceIdentifier dataShareTriggerResourceId = DataShareTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, triggerName);
            DataShareTriggerResource dataShareTrigger = client.GetDataShareTriggerResource(dataShareTriggerResourceId);

            // invoke the operation
            DataShareTriggerResource result = await dataShareTrigger.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Triggers_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_TriggersCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/Triggers_Create.json
            // this example is just showing the usage of "Triggers_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareTriggerResource created on azure
            // for more information of creating DataShareTriggerResource, please refer to the document of DataShareTriggerResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string triggerName = "Trigger1";
            ResourceIdentifier dataShareTriggerResourceId = DataShareTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, triggerName);
            DataShareTriggerResource dataShareTrigger = client.GetDataShareTriggerResource(dataShareTriggerResourceId);

            // invoke the operation
            DataShareTriggerData data = new ScheduledTrigger(DataShareSynchronizationRecurrenceInterval.Day, DateTimeOffset.Parse("2018-11-14T04:47:52.9614956Z"))
            {
                SynchronizationMode = SynchronizationMode.Incremental,
            };
            ArmOperation<DataShareTriggerResource> lro = await dataShareTrigger.UpdateAsync(WaitUntil.Completed, data);
            DataShareTriggerResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataShareTriggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Triggers_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_TriggersDelete()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/Triggers_Delete.json
            // this example is just showing the usage of "Triggers_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareTriggerResource created on azure
            // for more information of creating DataShareTriggerResource, please refer to the document of DataShareTriggerResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareSubscriptionName = "ShareSubscription1";
            string triggerName = "Trigger1";
            ResourceIdentifier dataShareTriggerResourceId = DataShareTriggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, triggerName);
            DataShareTriggerResource dataShareTrigger = client.GetDataShareTriggerResource(dataShareTriggerResourceId);

            // invoke the operation
            ArmOperation<DataShareOperationResult> lro = await dataShareTrigger.DeleteAsync(WaitUntil.Completed);
            DataShareOperationResult result = lro.Value;

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

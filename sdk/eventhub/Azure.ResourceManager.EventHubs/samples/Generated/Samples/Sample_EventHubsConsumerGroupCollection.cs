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
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Samples
{
    public partial class Sample_EventHubsConsumerGroupCollection
    {
        // ConsumerGroupCreate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ConsumerGroupCreate()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-10-01-preview/examples/ConsumerGroup/EHConsumerGroupCreate.json
            // this example is just showing the usage of "ConsumerGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2661";
            string eventHubName = "sdk-EventHub-6681";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubsConsumerGroupResource
            EventHubsConsumerGroupCollection collection = eventHub.GetEventHubsConsumerGroups();

            // invoke the operation
            string consumerGroupName = "sdk-ConsumerGroup-5563";
            EventHubsConsumerGroupData data = new EventHubsConsumerGroupData()
            {
                UserMetadata = "New consumergroup",
            };
            ArmOperation<EventHubsConsumerGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, consumerGroupName, data);
            EventHubsConsumerGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsConsumerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConsumerGroupGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ConsumerGroupGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-10-01-preview/examples/ConsumerGroup/EHConsumerGroupGet.json
            // this example is just showing the usage of "ConsumerGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2661";
            string eventHubName = "sdk-EventHub-6681";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubsConsumerGroupResource
            EventHubsConsumerGroupCollection collection = eventHub.GetEventHubsConsumerGroups();

            // invoke the operation
            string consumerGroupName = "sdk-ConsumerGroup-5563";
            EventHubsConsumerGroupResource result = await collection.GetAsync(consumerGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventHubsConsumerGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ConsumerGroupGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ConsumerGroupGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-10-01-preview/examples/ConsumerGroup/EHConsumerGroupGet.json
            // this example is just showing the usage of "ConsumerGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2661";
            string eventHubName = "sdk-EventHub-6681";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubsConsumerGroupResource
            EventHubsConsumerGroupCollection collection = eventHub.GetEventHubsConsumerGroups();

            // invoke the operation
            string consumerGroupName = "sdk-ConsumerGroup-5563";
            bool result = await collection.ExistsAsync(consumerGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ConsumerGroupGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ConsumerGroupGet()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-10-01-preview/examples/ConsumerGroup/EHConsumerGroupGet.json
            // this example is just showing the usage of "ConsumerGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2661";
            string eventHubName = "sdk-EventHub-6681";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubsConsumerGroupResource
            EventHubsConsumerGroupCollection collection = eventHub.GetEventHubsConsumerGroups();

            // invoke the operation
            string consumerGroupName = "sdk-ConsumerGroup-5563";
            NullableResponse<EventHubsConsumerGroupResource> response = await collection.GetIfExistsAsync(consumerGroupName);
            EventHubsConsumerGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventHubsConsumerGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ConsumerGroupsListAll
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ConsumerGroupsListAll()
        {
            // Generated from example definition: specification/eventhub/resource-manager/Microsoft.EventHub/preview/2022-10-01-preview/examples/ConsumerGroup/EHConsumerGroupListByEventHub.json
            // this example is just showing the usage of "ConsumerGroups_ListByEventHub" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventHubResource created on azure
            // for more information of creating EventHubResource, please refer to the document of EventHubResource
            string subscriptionId = "5f750a97-50d9-4e36-8081-c9ee4c0210d4";
            string resourceGroupName = "ArunMonocle";
            string namespaceName = "sdk-Namespace-2661";
            string eventHubName = "sdk-EventHub-6681";
            ResourceIdentifier eventHubResourceId = EventHubResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName, eventHubName);
            EventHubResource eventHub = client.GetEventHubResource(eventHubResourceId);

            // get the collection of this EventHubsConsumerGroupResource
            EventHubsConsumerGroupCollection collection = eventHub.GetEventHubsConsumerGroups();

            // invoke the operation and iterate over the result
            await foreach (EventHubsConsumerGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventHubsConsumerGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

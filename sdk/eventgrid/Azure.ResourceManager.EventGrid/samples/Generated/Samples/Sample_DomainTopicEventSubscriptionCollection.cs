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
using Azure.ResourceManager.EventGrid;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_DomainTopicEventSubscriptionCollection
    {
        // DomainTopicEventSubscriptions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DomainTopicEventSubscriptionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopicEventSubscriptions_Get.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicResource created on azure
            // for more information of creating DomainTopicResource, please refer to the document of DomainTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            ResourceIdentifier domainTopicResourceId = DomainTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName);
            DomainTopicResource domainTopic = client.GetDomainTopicResource(domainTopicResourceId);

            // get the collection of this DomainTopicEventSubscriptionResource
            DomainTopicEventSubscriptionCollection collection = domainTopic.GetDomainTopicEventSubscriptions();

            // invoke the operation
            string eventSubscriptionName = "examplesubscription1";
            DomainTopicEventSubscriptionResource result = await collection.GetAsync(eventSubscriptionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DomainTopicEventSubscriptions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DomainTopicEventSubscriptionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopicEventSubscriptions_Get.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicResource created on azure
            // for more information of creating DomainTopicResource, please refer to the document of DomainTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            ResourceIdentifier domainTopicResourceId = DomainTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName);
            DomainTopicResource domainTopic = client.GetDomainTopicResource(domainTopicResourceId);

            // get the collection of this DomainTopicEventSubscriptionResource
            DomainTopicEventSubscriptionCollection collection = domainTopic.GetDomainTopicEventSubscriptions();

            // invoke the operation
            string eventSubscriptionName = "examplesubscription1";
            bool result = await collection.ExistsAsync(eventSubscriptionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DomainTopicEventSubscriptions_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_DomainTopicEventSubscriptionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopicEventSubscriptions_Get.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicResource created on azure
            // for more information of creating DomainTopicResource, please refer to the document of DomainTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            ResourceIdentifier domainTopicResourceId = DomainTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName);
            DomainTopicResource domainTopic = client.GetDomainTopicResource(domainTopicResourceId);

            // get the collection of this DomainTopicEventSubscriptionResource
            DomainTopicEventSubscriptionCollection collection = domainTopic.GetDomainTopicEventSubscriptions();

            // invoke the operation
            string eventSubscriptionName = "examplesubscription1";
            NullableResponse<DomainTopicEventSubscriptionResource> response = await collection.GetIfExistsAsync(eventSubscriptionName);
            DomainTopicEventSubscriptionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridSubscriptionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // DomainTopicEventSubscriptions_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DomainTopicEventSubscriptionsCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopicEventSubscriptions_CreateOrUpdate.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicResource created on azure
            // for more information of creating DomainTopicResource, please refer to the document of DomainTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            ResourceIdentifier domainTopicResourceId = DomainTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName);
            DomainTopicResource domainTopic = client.GetDomainTopicResource(domainTopicResourceId);

            // get the collection of this DomainTopicEventSubscriptionResource
            DomainTopicEventSubscriptionCollection collection = domainTopic.GetDomainTopicEventSubscriptions();

            // invoke the operation
            string eventSubscriptionName = "exampleEventSubscriptionName1";
            EventGridSubscriptionData data = new EventGridSubscriptionData()
            {
                Destination = new WebHookEventSubscriptionDestination()
                {
                    Endpoint = new Uri("https://requestb.in/15ksip71"),
                },
                Filter = new EventSubscriptionFilter()
                {
                    SubjectBeginsWith = "ExamplePrefix",
                    SubjectEndsWith = "ExampleSuffix",
                    IsSubjectCaseSensitive = false,
                },
            };
            ArmOperation<DomainTopicEventSubscriptionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, eventSubscriptionName, data);
            DomainTopicEventSubscriptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridSubscriptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DomainTopicEventSubscriptions_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DomainTopicEventSubscriptionsList()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/DomainTopicEventSubscriptions_List.json
            // this example is just showing the usage of "DomainTopicEventSubscriptions_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DomainTopicResource created on azure
            // for more information of creating DomainTopicResource, please refer to the document of DomainTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampleDomain1";
            string topicName = "exampleDomainTopic1";
            ResourceIdentifier domainTopicResourceId = DomainTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName, topicName);
            DomainTopicResource domainTopic = client.GetDomainTopicResource(domainTopicResourceId);

            // get the collection of this DomainTopicEventSubscriptionResource
            DomainTopicEventSubscriptionCollection collection = domainTopic.GetDomainTopicEventSubscriptions();

            // invoke the operation and iterate over the result
            await foreach (DomainTopicEventSubscriptionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridSubscriptionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

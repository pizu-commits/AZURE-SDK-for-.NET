// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_EventGridDomainPrivateLinkResourceCollection
    {
        // PrivateLinkResources_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateLinkResources_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this EventGridDomainPrivateLinkResource
            EventGridDomainPrivateLinkResourceCollection collection = eventGridDomain.GetEventGridDomainPrivateLinkResources();

            // invoke the operation
            string privateLinkResourceName = "topic";
            EventGridDomainPrivateLinkResource result = await collection.GetAsync(privateLinkResourceName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateLinkResources_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateLinkResources_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this EventGridDomainPrivateLinkResource
            EventGridDomainPrivateLinkResourceCollection collection = eventGridDomain.GetEventGridDomainPrivateLinkResources();

            // invoke the operation
            string privateLinkResourceName = "topic";
            bool result = await collection.ExistsAsync(privateLinkResourceName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateLinkResources_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateLinkResourcesGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateLinkResources_Get.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this EventGridDomainPrivateLinkResource
            EventGridDomainPrivateLinkResourceCollection collection = eventGridDomain.GetEventGridDomainPrivateLinkResources();

            // invoke the operation
            string privateLinkResourceName = "topic";
            NullableResponse<EventGridDomainPrivateLinkResource> response = await collection.GetIfExistsAsync(privateLinkResourceName);
            EventGridDomainPrivateLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridPrivateLinkResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateLinkResources_ListByResource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateLinkResourcesListByResource()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateLinkResources_ListByResource.json
            // this example is just showing the usage of "PrivateLinkResources_ListByResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // get the collection of this EventGridDomainPrivateLinkResource
            EventGridDomainPrivateLinkResourceCollection collection = eventGridDomain.GetEventGridDomainPrivateLinkResources();

            // invoke the operation and iterate over the result
            await foreach (EventGridDomainPrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridPrivateLinkResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

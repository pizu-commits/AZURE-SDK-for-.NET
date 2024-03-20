// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_EventGridDomainResource
    {
        // Domains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DomainsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Domains_Get.json
            // this example is just showing the usage of "Domains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain2";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // invoke the operation
            EventGridDomainResource result = await eventGridDomain.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Domains_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DomainsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Domains_Delete.json
            // this example is just showing the usage of "Domains_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain1";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // invoke the operation
            await eventGridDomain.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Domains_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DomainsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Domains_Update.json
            // this example is just showing the usage of "Domains_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain1";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // invoke the operation
            EventGridDomainPatch patch = new EventGridDomainPatch()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
                PublicNetworkAccess = EventGridPublicNetworkAccess.Enabled,
                InboundIPRules =
{
new EventGridInboundIPRule()
{
IPMask = "12.18.30.15",
Action = EventGridIPActionType.Allow,
},new EventGridInboundIPRule()
{
IPMask = "12.18.176.1",
Action = EventGridIPActionType.Allow,
}
},
            };
            await eventGridDomain.UpdateAsync(WaitUntil.Completed, patch);

            Console.WriteLine($"Succeeded");
        }

        // Domains_ListBySubscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEventGridDomains_DomainsListBySubscription()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Domains_ListBySubscription.json
            // this example is just showing the usage of "Domains_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (EventGridDomainResource item in subscriptionResource.GetEventGridDomainsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridDomainData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Domains_ListSharedAccessKeys
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSharedAccessKeys_DomainsListSharedAccessKeys()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Domains_ListSharedAccessKeys.json
            // this example is just showing the usage of "Domains_ListSharedAccessKeys" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain2";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // invoke the operation
            EventGridDomainSharedAccessKeys result = await eventGridDomain.GetSharedAccessKeysAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Domains_RegenerateKey
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task RegenerateKey_DomainsRegenerateKey()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Domains_RegenerateKey.json
            // this example is just showing the usage of "Domains_RegenerateKey" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridDomainResource created on azure
            // for more information of creating EventGridDomainResource, please refer to the document of EventGridDomainResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string domainName = "exampledomain2";
            ResourceIdentifier eventGridDomainResourceId = EventGridDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            EventGridDomainResource eventGridDomain = client.GetEventGridDomainResource(eventGridDomainResourceId);

            // invoke the operation
            EventGridDomainRegenerateKeyContent content = new EventGridDomainRegenerateKeyContent("key1");
            EventGridDomainSharedAccessKeys result = await eventGridDomain.RegenerateKeyAsync(content);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

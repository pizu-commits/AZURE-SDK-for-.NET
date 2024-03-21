// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.ResourceHealth.Samples
{
    public partial class Sample_TenantResourceHealthEventResource
    {
        // ListSecurityAdvisoryImpactedResourcesByTenantId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetSecurityAdvisoryImpactedResourcesByTenantIdAndEventId_ListSecurityAdvisoryImpactedResourcesByTenantId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2023-10-01-preview/examples/SecurityAdvisoryImpactedResources_ListByTenantId_ListByEventId.json
            // this example is just showing the usage of "SecurityAdvisoryImpactedResources_ListByTenantIdAndEventId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResourceHealthEventResource created on azure
            // for more information of creating TenantResourceHealthEventResource, please refer to the document of TenantResourceHealthEventResource
            string eventTrackingId = "BC_1-FXZ";
            ResourceIdentifier tenantResourceHealthEventResourceId = TenantResourceHealthEventResource.CreateResourceIdentifier(eventTrackingId);
            TenantResourceHealthEventResource tenantResourceHealthEvent = client.GetTenantResourceHealthEventResource(tenantResourceHealthEventResourceId);

            // invoke the operation and iterate over the result
            await foreach (ResourceHealthEventImpactedResourceData item in tenantResourceHealthEvent.GetSecurityAdvisoryImpactedResourcesByTenantIdAndEventIdAsync())
            {
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {item.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // EventByTenantIdAndTrackingId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_EventByTenantIdAndTrackingId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2023-10-01-preview/examples/Event_GetByTenantIdAndTrackingId.json
            // this example is just showing the usage of "Event_GetByTenantIdAndTrackingId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResourceHealthEventResource created on azure
            // for more information of creating TenantResourceHealthEventResource, please refer to the document of TenantResourceHealthEventResource
            string eventTrackingId = "eventTrackingId";
            ResourceIdentifier tenantResourceHealthEventResourceId = TenantResourceHealthEventResource.CreateResourceIdentifier(eventTrackingId);
            TenantResourceHealthEventResource tenantResourceHealthEvent = client.GetTenantResourceHealthEventResource(tenantResourceHealthEventResourceId);

            // invoke the operation
            string filter = "properties/status eq 'Active'";
            string queryStartTime = "7/10/2022";
            TenantResourceHealthEventResource result = await tenantResourceHealthEvent.GetAsync(filter: filter, queryStartTime: queryStartTime);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceHealthEventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // EventDetailsByTenantIdAndTrackingId
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task FetchDetailsByTenantIdAndTrackingId_EventDetailsByTenantIdAndTrackingId()
        {
            // Generated from example definition: specification/resourcehealth/resource-manager/Microsoft.ResourceHealth/preview/2023-10-01-preview/examples/Event_fetchDetailsByTenantIdAndTrackingId.json
            // this example is just showing the usage of "Event_fetchDetailsByTenantIdAndTrackingId" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TenantResourceHealthEventResource created on azure
            // for more information of creating TenantResourceHealthEventResource, please refer to the document of TenantResourceHealthEventResource
            string eventTrackingId = "eventTrackingId";
            ResourceIdentifier tenantResourceHealthEventResourceId = TenantResourceHealthEventResource.CreateResourceIdentifier(eventTrackingId);
            TenantResourceHealthEventResource tenantResourceHealthEvent = client.GetTenantResourceHealthEventResource(tenantResourceHealthEventResourceId);

            // invoke the operation
            TenantResourceHealthEventResource result = await tenantResourceHealthEvent.FetchDetailsByTenantIdAndTrackingIdAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceHealthEventData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

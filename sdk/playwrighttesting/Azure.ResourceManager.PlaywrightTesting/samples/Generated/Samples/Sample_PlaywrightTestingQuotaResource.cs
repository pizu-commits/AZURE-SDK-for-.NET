// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.PlaywrightTesting.Models;

namespace Azure.ResourceManager.PlaywrightTesting.Samples
{
    public partial class Sample_PlaywrightTestingQuotaResource
    {
        // Quotas_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_QuotasGet()
        {
            // Generated from example definition: specification/playwrighttesting/resource-manager/Microsoft.AzurePlaywrightService/preview/2023-10-01-preview/examples/Quotas_Get.json
            // this example is just showing the usage of "Quotas_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PlaywrightTestingQuotaResource created on azure
            // for more information of creating PlaywrightTestingQuotaResource, please refer to the document of PlaywrightTestingQuotaResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            AzureLocation location = new AzureLocation("eastus");
            PlaywrightTestingQuotaName name = PlaywrightTestingQuotaName.ScalableExecution;
            ResourceIdentifier playwrightTestingQuotaResourceId = PlaywrightTestingQuotaResource.CreateResourceIdentifier(subscriptionId, location, name);
            PlaywrightTestingQuotaResource playwrightTestingQuota = client.GetPlaywrightTestingQuotaResource(playwrightTestingQuotaResourceId);

            // invoke the operation
            PlaywrightTestingQuotaResource result = await playwrightTestingQuota.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PlaywrightTestingQuotaData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

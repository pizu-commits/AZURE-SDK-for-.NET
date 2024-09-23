// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteInstanceResource
    {
        // Get site instance info
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSiteInstanceInfo()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetSiteInstanceInfo.json
            // this example is just showing the usage of "WebApps_GetInstanceInfo" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteInstanceResource created on azure
            // for more information of creating SiteInstanceResource, please refer to the document of SiteInstanceResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg123";
            string name = "tests346";
            string instanceId = "134987120";
            ResourceIdentifier siteInstanceResourceId = SiteInstanceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, instanceId);
            SiteInstanceResource siteInstance = client.GetSiteInstanceResource(siteInstanceResourceId);

            // invoke the operation
            SiteInstanceResource result = await siteInstance.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteInstanceStatusData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

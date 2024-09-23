// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_StaticSiteCustomDomainOverviewResource
    {
        // Get custom domain for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCustomDomainForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSiteCustomDomain.json
            // this example is just showing the usage of "StaticSites_GetStaticSiteCustomDomain" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteCustomDomainOverviewResource created on azure
            // for more information of creating StaticSiteCustomDomainOverviewResource, please refer to the document of StaticSiteCustomDomainOverviewResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string domainName = "custom.domain.net";
            ResourceIdentifier staticSiteCustomDomainOverviewResourceId = StaticSiteCustomDomainOverviewResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, domainName);
            StaticSiteCustomDomainOverviewResource staticSiteCustomDomainOverview = client.GetStaticSiteCustomDomainOverviewResource(staticSiteCustomDomainOverviewResourceId);

            // invoke the operation
            StaticSiteCustomDomainOverviewResource result = await staticSiteCustomDomainOverview.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteCustomDomainOverviewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update a custom domain for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateACustomDomainForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/CreateOrUpdateStaticSiteCustomDomain.json
            // this example is just showing the usage of "StaticSites_CreateOrUpdateStaticSiteCustomDomain" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteCustomDomainOverviewResource created on azure
            // for more information of creating StaticSiteCustomDomainOverviewResource, please refer to the document of StaticSiteCustomDomainOverviewResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string domainName = "custom.domain.net";
            ResourceIdentifier staticSiteCustomDomainOverviewResourceId = StaticSiteCustomDomainOverviewResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, domainName);
            StaticSiteCustomDomainOverviewResource staticSiteCustomDomainOverview = client.GetStaticSiteCustomDomainOverviewResource(staticSiteCustomDomainOverviewResourceId);

            // invoke the operation
            StaticSiteCustomDomainContent content = new StaticSiteCustomDomainContent();
            ArmOperation<StaticSiteCustomDomainOverviewResource> lro = await staticSiteCustomDomainOverview.UpdateAsync(WaitUntil.Completed, content);
            StaticSiteCustomDomainOverviewResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteCustomDomainOverviewData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a custom domain for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteACustomDomainForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/DeleteStaticSiteCustomDomain.json
            // this example is just showing the usage of "StaticSites_DeleteStaticSiteCustomDomain" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteCustomDomainOverviewResource created on azure
            // for more information of creating StaticSiteCustomDomainOverviewResource, please refer to the document of StaticSiteCustomDomainOverviewResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string domainName = "custom.domain.net";
            ResourceIdentifier staticSiteCustomDomainOverviewResourceId = StaticSiteCustomDomainOverviewResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, domainName);
            StaticSiteCustomDomainOverviewResource staticSiteCustomDomainOverview = client.GetStaticSiteCustomDomainOverviewResource(staticSiteCustomDomainOverviewResourceId);

            // invoke the operation
            await staticSiteCustomDomainOverview.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Validate a custom domain for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task ValidateCustomDomainCanBeAddedToStaticSite_ValidateACustomDomainForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/ValidateStaticSiteCustomDomain.json
            // this example is just showing the usage of "StaticSites_ValidateCustomDomainCanBeAddedToStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteCustomDomainOverviewResource created on azure
            // for more information of creating StaticSiteCustomDomainOverviewResource, please refer to the document of StaticSiteCustomDomainOverviewResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string domainName = "custom.domain.net";
            ResourceIdentifier staticSiteCustomDomainOverviewResourceId = StaticSiteCustomDomainOverviewResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, domainName);
            StaticSiteCustomDomainOverviewResource staticSiteCustomDomainOverview = client.GetStaticSiteCustomDomainOverviewResource(staticSiteCustomDomainOverviewResourceId);

            // invoke the operation
            StaticSiteCustomDomainContent content = new StaticSiteCustomDomainContent();
            await staticSiteCustomDomainOverview.ValidateCustomDomainCanBeAddedToStaticSiteAsync(WaitUntil.Completed, content);

            Console.WriteLine($"Succeeded");
        }
    }
}

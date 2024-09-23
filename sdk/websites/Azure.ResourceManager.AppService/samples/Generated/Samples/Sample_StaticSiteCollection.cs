// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_StaticSiteCollection
    {
        // Get static sites for a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetStaticSitesForAResourceGroup()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSites.json
            // this example is just showing the usage of "StaticSites_GetStaticSitesByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StaticSiteResource
            StaticSiteCollection collection = resourceGroupResource.GetStaticSites();

            // invoke the operation and iterate over the result
            await foreach (StaticSiteResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticSiteData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get details for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetailsForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSite.json
            // this example is just showing the usage of "StaticSites_GetStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StaticSiteResource
            StaticSiteCollection collection = resourceGroupResource.GetStaticSites();

            // invoke the operation
            string name = "testStaticSite0";
            StaticSiteResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get details for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDetailsForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSite.json
            // this example is just showing the usage of "StaticSites_GetStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StaticSiteResource
            StaticSiteCollection collection = resourceGroupResource.GetStaticSites();

            // invoke the operation
            string name = "testStaticSite0";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get details for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetDetailsForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/GetStaticSite.json
            // this example is just showing the usage of "StaticSites_GetStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StaticSiteResource
            StaticSiteCollection collection = resourceGroupResource.GetStaticSites();

            // invoke the operation
            string name = "testStaticSite0";
            NullableResponse<StaticSiteResource> response = await collection.GetIfExistsAsync(name);
            StaticSiteResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticSiteData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/CreateOrUpdateStaticSite.json
            // this example is just showing the usage of "StaticSites_CreateOrUpdateStaticSite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this StaticSiteResource
            StaticSiteCollection collection = resourceGroupResource.GetStaticSites();

            // invoke the operation
            string name = "testStaticSite0";
            StaticSiteData data = new StaticSiteData(new AzureLocation("West US 2"))
            {
                Sku = new AppServiceSkuDescription()
                {
                    Name = "Basic",
                    Tier = "Basic",
                },
                RepositoryUri = new Uri("https://github.com/username/RepoName"),
                Branch = "master",
                RepositoryToken = "repoToken123",
                BuildProperties = new StaticSiteBuildProperties()
                {
                    AppLocation = "app",
                    ApiLocation = "api",
                    AppArtifactLocation = "build",
                },
            };
            ArmOperation<StaticSiteResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            StaticSiteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

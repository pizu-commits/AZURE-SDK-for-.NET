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
    public partial class Sample_StaticSiteBuildCollection
    {
        // Get all builds for a static site
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAllBuildsForAStaticSite()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetStaticSiteBuilds.json
            // this example is just showing the usage of "StaticSites_GetStaticSiteBuilds" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteBuildResource
            StaticSiteBuildCollection collection = staticSite.GetStaticSiteBuilds();

            // invoke the operation and iterate over the result
            await foreach (StaticSiteBuildResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticSiteBuildData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a static site build
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_GetStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteBuildResource
            StaticSiteBuildCollection collection = staticSite.GetStaticSiteBuilds();

            // invoke the operation
            string environmentName = "12";
            StaticSiteBuildResource result = await collection.GetAsync(environmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteBuildData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a static site build
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_GetStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteBuildResource
            StaticSiteBuildCollection collection = staticSite.GetStaticSiteBuilds();

            // invoke the operation
            string environmentName = "12";
            bool result = await collection.ExistsAsync(environmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a static site build
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_GetStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteResource created on azure
            // for more information of creating StaticSiteResource, please refer to the document of StaticSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            ResourceIdentifier staticSiteResourceId = StaticSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name);
            StaticSiteResource staticSite = client.GetStaticSiteResource(staticSiteResourceId);

            // get the collection of this StaticSiteBuildResource
            StaticSiteBuildCollection collection = staticSite.GetStaticSiteBuilds();

            // invoke the operation
            string environmentName = "12";
            NullableResponse<StaticSiteBuildResource> response = await collection.GetIfExistsAsync(environmentName);
            StaticSiteBuildResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                StaticSiteBuildData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

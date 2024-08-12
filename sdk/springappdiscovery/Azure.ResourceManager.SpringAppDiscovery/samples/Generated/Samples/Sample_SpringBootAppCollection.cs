// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.SpringAppDiscovery.Samples
{
    public partial class Sample_SpringBootAppCollection
    {
        // springbootapps_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SpringbootappsGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootapps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation
            string springbootappsName = "ofjeesoahqtnovlbuvflyknpbhcpeqqhekntvqxyemuwbcqnuxjgfhsf";
            SpringBootAppResource result = await collection.GetAsync(springbootappsName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootAppData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // springbootapps_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SpringbootappsGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootapps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation
            string springbootappsName = "ofjeesoahqtnovlbuvflyknpbhcpeqqhekntvqxyemuwbcqnuxjgfhsf";
            bool result = await collection.ExistsAsync(springbootappsName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // springbootapps_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SpringbootappsGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootapps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation
            string springbootappsName = "ofjeesoahqtnovlbuvflyknpbhcpeqqhekntvqxyemuwbcqnuxjgfhsf";
            NullableResponse<SpringBootAppResource> response = await collection.GetIfExistsAsync(springbootappsName);
            SpringBootAppResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootAppData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // springbootapps_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SpringbootappsGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootapps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation
            string springbootappsName = "ofjeesoahqtnovlbuvflyknpbhcpeqqhekntvqxyemuwbcqnuxjgfhsf";
            SpringBootAppResource result = await collection.GetAsync(springbootappsName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootAppData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // springbootapps_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SpringbootappsGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootapps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation
            string springbootappsName = "ofjeesoahqtnovlbuvflyknpbhcpeqqhekntvqxyemuwbcqnuxjgfhsf";
            bool result = await collection.ExistsAsync(springbootappsName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // springbootapps_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SpringbootappsGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootapps_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation
            string springbootappsName = "ofjeesoahqtnovlbuvflyknpbhcpeqqhekntvqxyemuwbcqnuxjgfhsf";
            NullableResponse<SpringBootAppResource> response = await collection.GetIfExistsAsync(springbootappsName);
            SpringBootAppResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootAppData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // springbootapps_ListByResourceGroup_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SpringbootappsListByResourceGroupMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_ListByResourceGroup_MaximumSet_Gen.json
            // this example is just showing the usage of "springbootapps_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation and iterate over the result
            await foreach (SpringBootAppResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootAppData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // springbootapps_ListByResourceGroup_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SpringbootappsListByResourceGroupMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/springbootapps_ListByResourceGroup_MinimumSet_Gen.json
            // this example is just showing the usage of "springbootapps_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "jnetwlorzmxpxmcucorv";
            string resourceGroupName = "rgspringbootapps";
            string siteName = "pdfosfhtemfsaglvwjdyqlyeipucrd";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootAppResource
            SpringBootAppCollection collection = springBootSite.GetSpringBootApps();

            // invoke the operation and iterate over the result
            await foreach (SpringBootAppResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootAppData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

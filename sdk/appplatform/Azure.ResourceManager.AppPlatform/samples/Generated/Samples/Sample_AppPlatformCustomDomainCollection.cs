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
using Azure.ResourceManager.AppPlatform;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform.Samples
{
    public partial class Sample_AppPlatformCustomDomainCollection
    {
        // CustomDomains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_CustomDomainsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_Get.json
            // this example is just showing the usage of "CustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformAppResource created on azure
            // for more information of creating AppPlatformAppResource, please refer to the document of AppPlatformAppResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            ResourceIdentifier appPlatformAppResourceId = AppPlatformAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName);
            AppPlatformAppResource appPlatformApp = client.GetAppPlatformAppResource(appPlatformAppResourceId);

            // get the collection of this AppPlatformCustomDomainResource
            AppPlatformCustomDomainCollection collection = appPlatformApp.GetAppPlatformCustomDomains();

            // invoke the operation
            string domainName = "mydomain.com";
            AppPlatformCustomDomainResource result = await collection.GetAsync(domainName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CustomDomains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_CustomDomainsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_Get.json
            // this example is just showing the usage of "CustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformAppResource created on azure
            // for more information of creating AppPlatformAppResource, please refer to the document of AppPlatformAppResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            ResourceIdentifier appPlatformAppResourceId = AppPlatformAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName);
            AppPlatformAppResource appPlatformApp = client.GetAppPlatformAppResource(appPlatformAppResourceId);

            // get the collection of this AppPlatformCustomDomainResource
            AppPlatformCustomDomainCollection collection = appPlatformApp.GetAppPlatformCustomDomains();

            // invoke the operation
            string domainName = "mydomain.com";
            bool result = await collection.ExistsAsync(domainName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // CustomDomains_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_CustomDomainsGet()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_Get.json
            // this example is just showing the usage of "CustomDomains_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformAppResource created on azure
            // for more information of creating AppPlatformAppResource, please refer to the document of AppPlatformAppResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            ResourceIdentifier appPlatformAppResourceId = AppPlatformAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName);
            AppPlatformAppResource appPlatformApp = client.GetAppPlatformAppResource(appPlatformAppResourceId);

            // get the collection of this AppPlatformCustomDomainResource
            AppPlatformCustomDomainCollection collection = appPlatformApp.GetAppPlatformCustomDomains();

            // invoke the operation
            string domainName = "mydomain.com";
            NullableResponse<AppPlatformCustomDomainResource> response = await collection.GetIfExistsAsync(domainName);
            AppPlatformCustomDomainResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformCustomDomainData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // CustomDomains_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CustomDomainsCreateOrUpdate()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_CreateOrUpdate.json
            // this example is just showing the usage of "CustomDomains_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformAppResource created on azure
            // for more information of creating AppPlatformAppResource, please refer to the document of AppPlatformAppResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            ResourceIdentifier appPlatformAppResourceId = AppPlatformAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName);
            AppPlatformAppResource appPlatformApp = client.GetAppPlatformAppResource(appPlatformAppResourceId);

            // get the collection of this AppPlatformCustomDomainResource
            AppPlatformCustomDomainCollection collection = appPlatformApp.GetAppPlatformCustomDomains();

            // invoke the operation
            string domainName = "mydomain.com";
            AppPlatformCustomDomainData data = new AppPlatformCustomDomainData()
            {
                Properties = new AppPlatformCustomDomainProperties()
                {
                    Thumbprint = "934367bf1c97033f877db0f15cb1b586957d3133",
                    CertName = "mycert",
                },
            };
            ArmOperation<AppPlatformCustomDomainResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, domainName, data);
            AppPlatformCustomDomainResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppPlatformCustomDomainData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // CustomDomains_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_CustomDomainsList()
        {
            // Generated from example definition: specification/appplatform/resource-manager/Microsoft.AppPlatform/stable/2022-12-01/examples/CustomDomains_List.json
            // this example is just showing the usage of "CustomDomains_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppPlatformAppResource created on azure
            // for more information of creating AppPlatformAppResource, please refer to the document of AppPlatformAppResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            string serviceName = "myservice";
            string appName = "myapp";
            ResourceIdentifier appPlatformAppResourceId = AppPlatformAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, appName);
            AppPlatformAppResource appPlatformApp = client.GetAppPlatformAppResource(appPlatformAppResourceId);

            // get the collection of this AppPlatformCustomDomainResource
            AppPlatformCustomDomainCollection collection = appPlatformApp.GetAppPlatformCustomDomains();

            // invoke the operation and iterate over the result
            await foreach (AppPlatformCustomDomainResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppPlatformCustomDomainData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

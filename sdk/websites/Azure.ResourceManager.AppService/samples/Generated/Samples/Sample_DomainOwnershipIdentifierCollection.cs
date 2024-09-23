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
    public partial class Sample_DomainOwnershipIdentifierCollection
    {
        // List Domain Ownership Identifiers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDomainOwnershipIdentifiers()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2023-12-01/examples/ListDomainOwnershipIdentifiers.json
            // this example is just showing the usage of "Domains_ListOwnershipIdentifiers" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceDomainResource created on azure
            // for more information of creating AppServiceDomainResource, please refer to the document of AppServiceDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            ResourceIdentifier appServiceDomainResourceId = AppServiceDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            AppServiceDomainResource appServiceDomain = client.GetAppServiceDomainResource(appServiceDomainResourceId);

            // get the collection of this DomainOwnershipIdentifierResource
            DomainOwnershipIdentifierCollection collection = appServiceDomain.GetDomainOwnershipIdentifiers();

            // invoke the operation and iterate over the result
            await foreach (DomainOwnershipIdentifierResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DomainOwnershipIdentifierData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Domain Ownership Identifier
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDomainOwnershipIdentifier()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2023-12-01/examples/GetDomainOwnershipIdentifier.json
            // this example is just showing the usage of "Domains_GetOwnershipIdentifier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceDomainResource created on azure
            // for more information of creating AppServiceDomainResource, please refer to the document of AppServiceDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            ResourceIdentifier appServiceDomainResourceId = AppServiceDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            AppServiceDomainResource appServiceDomain = client.GetAppServiceDomainResource(appServiceDomainResourceId);

            // get the collection of this DomainOwnershipIdentifierResource
            DomainOwnershipIdentifierCollection collection = appServiceDomain.GetDomainOwnershipIdentifiers();

            // invoke the operation
            string name = "SampleOwnershipId";
            DomainOwnershipIdentifierResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DomainOwnershipIdentifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Domain Ownership Identifier
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDomainOwnershipIdentifier()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2023-12-01/examples/GetDomainOwnershipIdentifier.json
            // this example is just showing the usage of "Domains_GetOwnershipIdentifier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceDomainResource created on azure
            // for more information of creating AppServiceDomainResource, please refer to the document of AppServiceDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            ResourceIdentifier appServiceDomainResourceId = AppServiceDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            AppServiceDomainResource appServiceDomain = client.GetAppServiceDomainResource(appServiceDomainResourceId);

            // get the collection of this DomainOwnershipIdentifierResource
            DomainOwnershipIdentifierCollection collection = appServiceDomain.GetDomainOwnershipIdentifiers();

            // invoke the operation
            string name = "SampleOwnershipId";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Domain Ownership Identifier
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetDomainOwnershipIdentifier()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2023-12-01/examples/GetDomainOwnershipIdentifier.json
            // this example is just showing the usage of "Domains_GetOwnershipIdentifier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceDomainResource created on azure
            // for more information of creating AppServiceDomainResource, please refer to the document of AppServiceDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            ResourceIdentifier appServiceDomainResourceId = AppServiceDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            AppServiceDomainResource appServiceDomain = client.GetAppServiceDomainResource(appServiceDomainResourceId);

            // get the collection of this DomainOwnershipIdentifierResource
            DomainOwnershipIdentifierCollection collection = appServiceDomain.GetDomainOwnershipIdentifiers();

            // invoke the operation
            string name = "SampleOwnershipId";
            NullableResponse<DomainOwnershipIdentifierResource> response = await collection.GetIfExistsAsync(name);
            DomainOwnershipIdentifierResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DomainOwnershipIdentifierData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create App Service Domain OwnershipIdentifier
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAppServiceDomainOwnershipIdentifier()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.DomainRegistration/stable/2023-12-01/examples/CreateAppServiceDomainOwnershipIdentifier.json
            // this example is just showing the usage of "Domains_CreateOrUpdateOwnershipIdentifier" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppServiceDomainResource created on azure
            // for more information of creating AppServiceDomainResource, please refer to the document of AppServiceDomainResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "testrg123";
            string domainName = "example.com";
            ResourceIdentifier appServiceDomainResourceId = AppServiceDomainResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, domainName);
            AppServiceDomainResource appServiceDomain = client.GetAppServiceDomainResource(appServiceDomainResourceId);

            // get the collection of this DomainOwnershipIdentifierResource
            DomainOwnershipIdentifierCollection collection = appServiceDomain.GetDomainOwnershipIdentifiers();

            // invoke the operation
            string name = "SampleOwnershipId";
            DomainOwnershipIdentifierData data = new DomainOwnershipIdentifierData()
            {
                OwnershipId = "SampleOwnershipId",
            };
            ArmOperation<DomainOwnershipIdentifierResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            DomainOwnershipIdentifierResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DomainOwnershipIdentifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

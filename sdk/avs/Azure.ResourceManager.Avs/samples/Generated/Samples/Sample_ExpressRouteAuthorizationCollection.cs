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
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Samples
{
    public partial class Sample_ExpressRouteAuthorizationCollection
    {
        // Authorizations_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AuthorizationsList()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Authorizations_List.json
            // this example is just showing the usage of "Authorizations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this ExpressRouteAuthorizationResource
            ExpressRouteAuthorizationCollection collection = avsPrivateCloud.GetExpressRouteAuthorizations();

            // invoke the operation and iterate over the result
            await foreach (ExpressRouteAuthorizationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteAuthorizationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Authorizations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AuthorizationsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Authorizations_Get.json
            // this example is just showing the usage of "Authorizations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this ExpressRouteAuthorizationResource
            ExpressRouteAuthorizationCollection collection = avsPrivateCloud.GetExpressRouteAuthorizations();

            // invoke the operation
            string authorizationName = "authorization1";
            ExpressRouteAuthorizationResource result = await collection.GetAsync(authorizationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteAuthorizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Authorizations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_AuthorizationsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Authorizations_Get.json
            // this example is just showing the usage of "Authorizations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this ExpressRouteAuthorizationResource
            ExpressRouteAuthorizationCollection collection = avsPrivateCloud.GetExpressRouteAuthorizations();

            // invoke the operation
            string authorizationName = "authorization1";
            bool result = await collection.ExistsAsync(authorizationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Authorizations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_AuthorizationsGet()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Authorizations_Get.json
            // this example is just showing the usage of "Authorizations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this ExpressRouteAuthorizationResource
            ExpressRouteAuthorizationCollection collection = avsPrivateCloud.GetExpressRouteAuthorizations();

            // invoke the operation
            string authorizationName = "authorization1";
            NullableResponse<ExpressRouteAuthorizationResource> response = await collection.GetIfExistsAsync(authorizationName);
            ExpressRouteAuthorizationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteAuthorizationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Authorizations_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_AuthorizationsCreateOrUpdate()
        {
            // Generated from example definition: specification/vmware/resource-manager/Microsoft.AVS/stable/2022-05-01/examples/Authorizations_CreateOrUpdate.json
            // this example is just showing the usage of "Authorizations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AvsPrivateCloudResource created on azure
            // for more information of creating AvsPrivateCloudResource, please refer to the document of AvsPrivateCloudResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "group1";
            string privateCloudName = "cloud1";
            ResourceIdentifier avsPrivateCloudResourceId = AvsPrivateCloudResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, privateCloudName);
            AvsPrivateCloudResource avsPrivateCloud = client.GetAvsPrivateCloudResource(avsPrivateCloudResourceId);

            // get the collection of this ExpressRouteAuthorizationResource
            ExpressRouteAuthorizationCollection collection = avsPrivateCloud.GetExpressRouteAuthorizations();

            // invoke the operation
            string authorizationName = "authorization1";
            ExpressRouteAuthorizationData data = new ExpressRouteAuthorizationData();
            ArmOperation<ExpressRouteAuthorizationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, authorizationName, data);
            ExpressRouteAuthorizationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteAuthorizationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

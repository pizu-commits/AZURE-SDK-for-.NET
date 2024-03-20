// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory.Samples
{
    public partial class Sample_DataFactoryPrivateEndpointConnectionCollection
    {
        // privateEndPointConnections_ListByFactory
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateEndPointConnectionsListByFactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/PrivateEndPointConnections_ListByFactory.json
            // this example is just showing the usage of "privateEndPointConnections_ListByFactory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "12345678-1234-1234-1234-12345678abc";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryPrivateEndpointConnectionResource
            DataFactoryPrivateEndpointConnectionCollection collection = dataFactory.GetDataFactoryPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (DataFactoryPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Approves or rejects a private endpoint connection for a factory.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_ApprovesOrRejectsAPrivateEndpointConnectionForAFactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/ApproveRejectPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryPrivateEndpointConnectionResource
            DataFactoryPrivateEndpointConnectionCollection collection = dataFactory.GetDataFactoryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "connection";
            DataFactoryPrivateEndpointConnectionCreateOrUpdateContent content = new DataFactoryPrivateEndpointConnectionCreateOrUpdateContent()
            {
                Properties = new PrivateLinkConnectionApprovalRequest()
                {
                    PrivateLinkServiceConnectionState = new PrivateLinkConnectionState()
                    {
                        Status = "Approved",
                        Description = "Approved by admin.",
                        ActionsRequired = "",
                    },
                    PrivateEndpointId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-12345678abc/resourceGroups/exampleResourceGroup/providers/Microsoft.DataFactory/factories/exampleFactoryName/privateEndpoints/myPrivateEndpoint"),
                },
            };
            ArmOperation<DataFactoryPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, content);
            DataFactoryPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a private endpoint connection for a datafactory.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPrivateEndpointConnectionForADatafactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryPrivateEndpointConnectionResource
            DataFactoryPrivateEndpointConnectionCollection collection = dataFactory.GetDataFactoryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "connection";
            DataFactoryPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataFactoryPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a private endpoint connection for a datafactory.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAPrivateEndpointConnectionForADatafactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryPrivateEndpointConnectionResource
            DataFactoryPrivateEndpointConnectionCollection collection = dataFactory.GetDataFactoryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "connection";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a private endpoint connection for a datafactory.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAPrivateEndpointConnectionForADatafactory()
        {
            // Generated from example definition: specification/datafactory/resource-manager/Microsoft.DataFactory/stable/2018-06-01/examples/GetPrivateEndpointConnection.json
            // this example is just showing the usage of "PrivateEndpointConnection_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataFactoryResource created on azure
            // for more information of creating DataFactoryResource, please refer to the document of DataFactoryResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "exampleResourceGroup";
            string factoryName = "exampleFactoryName";
            ResourceIdentifier dataFactoryResourceId = DataFactoryResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, factoryName);
            DataFactoryResource dataFactory = client.GetDataFactoryResource(dataFactoryResourceId);

            // get the collection of this DataFactoryPrivateEndpointConnectionResource
            DataFactoryPrivateEndpointConnectionCollection collection = dataFactory.GetDataFactoryPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "connection";
            NullableResponse<DataFactoryPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            DataFactoryPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataFactoryPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

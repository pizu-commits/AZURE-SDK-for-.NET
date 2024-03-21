// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Kusto.Models;

namespace Azure.ResourceManager.Kusto.Samples
{
    public partial class Sample_KustoPrivateEndpointConnectionResource
    {
        // Gets private endpoint connection.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsPrivateEndpointConnection()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoPrivateEndpointConnectionsGet.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoPrivateEndpointConnectionResource created on azure
            // for more information of creating KustoPrivateEndpointConnectionResource, please refer to the document of KustoPrivateEndpointConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string privateEndpointConnectionName = "privateEndpointTest";
            ResourceIdentifier kustoPrivateEndpointConnectionResourceId = KustoPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, privateEndpointConnectionName);
            KustoPrivateEndpointConnectionResource kustoPrivateEndpointConnection = client.GetKustoPrivateEndpointConnectionResource(kustoPrivateEndpointConnectionResourceId);

            // invoke the operation
            KustoPrivateEndpointConnectionResource result = await kustoPrivateEndpointConnection.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Approve or reject a private endpoint connection with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApproveOrRejectAPrivateEndpointConnectionWithAGivenName()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoPrivateEndpointConnectionsCreateOrUpdate.json
            // this example is just showing the usage of "PrivateEndpointConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoPrivateEndpointConnectionResource created on azure
            // for more information of creating KustoPrivateEndpointConnectionResource, please refer to the document of KustoPrivateEndpointConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoclusterrptest4";
            string privateEndpointConnectionName = "privateEndpointTest";
            ResourceIdentifier kustoPrivateEndpointConnectionResourceId = KustoPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, privateEndpointConnectionName);
            KustoPrivateEndpointConnectionResource kustoPrivateEndpointConnection = client.GetKustoPrivateEndpointConnectionResource(kustoPrivateEndpointConnectionResourceId);

            // invoke the operation
            KustoPrivateEndpointConnectionData data = new KustoPrivateEndpointConnectionData()
            {
                ConnectionState = new KustoPrivateLinkServiceConnectionStateProperty()
                {
                    Status = "Approved",
                    Description = "Approved by johndoe@contoso.com",
                },
            };
            ArmOperation<KustoPrivateEndpointConnectionResource> lro = await kustoPrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            KustoPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            KustoPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a private endpoint connection with a given name.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesAPrivateEndpointConnectionWithAGivenName()
        {
            // Generated from example definition: specification/azure-kusto/resource-manager/Microsoft.Kusto/stable/2023-08-15/examples/KustoPrivateEndpointConnectionsDelete.json
            // this example is just showing the usage of "PrivateEndpointConnections_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this KustoPrivateEndpointConnectionResource created on azure
            // for more information of creating KustoPrivateEndpointConnectionResource, please refer to the document of KustoPrivateEndpointConnectionResource
            string subscriptionId = "12345678-1234-1234-1234-123456789098";
            string resourceGroupName = "kustorptest";
            string clusterName = "kustoCluster";
            string privateEndpointConnectionName = "privateEndpointTest";
            ResourceIdentifier kustoPrivateEndpointConnectionResourceId = KustoPrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, privateEndpointConnectionName);
            KustoPrivateEndpointConnectionResource kustoPrivateEndpointConnection = client.GetKustoPrivateEndpointConnectionResource(kustoPrivateEndpointConnectionResourceId);

            // invoke the operation
            await kustoPrivateEndpointConnection.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

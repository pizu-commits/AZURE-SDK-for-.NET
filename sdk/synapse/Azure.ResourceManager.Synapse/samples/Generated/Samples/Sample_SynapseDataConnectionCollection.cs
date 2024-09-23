// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseDataConnectionCollection
    {
        // KustoPoolDataConnectionsListByDatabase
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_KustoPoolDataConnectionsListByDatabase()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsListByDatabase.json
            // this example is just showing the usage of "KustoPoolDataConnections_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabaseResource created on azure
            // for more information of creating SynapseDatabaseResource, please refer to the document of SynapseDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier synapseDatabaseResourceId = SynapseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName);
            SynapseDatabaseResource synapseDatabase = client.GetSynapseDatabaseResource(synapseDatabaseResourceId);

            // get the collection of this SynapseDataConnectionResource
            SynapseDataConnectionCollection collection = synapseDatabase.GetSynapseDataConnections();

            // invoke the operation and iterate over the result
            await foreach (SynapseDataConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseDataConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // KustoPoolDataConnectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_KustoPoolDataConnectionsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsGet.json
            // this example is just showing the usage of "KustoPoolDataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabaseResource created on azure
            // for more information of creating SynapseDatabaseResource, please refer to the document of SynapseDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier synapseDatabaseResourceId = SynapseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName);
            SynapseDatabaseResource synapseDatabase = client.GetSynapseDatabaseResource(synapseDatabaseResourceId);

            // get the collection of this SynapseDataConnectionResource
            SynapseDataConnectionCollection collection = synapseDatabase.GetSynapseDataConnections();

            // invoke the operation
            string dataConnectionName = "DataConnections8";
            SynapseDataConnectionResource result = await collection.GetAsync(dataConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // KustoPoolDataConnectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_KustoPoolDataConnectionsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsGet.json
            // this example is just showing the usage of "KustoPoolDataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabaseResource created on azure
            // for more information of creating SynapseDatabaseResource, please refer to the document of SynapseDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier synapseDatabaseResourceId = SynapseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName);
            SynapseDatabaseResource synapseDatabase = client.GetSynapseDatabaseResource(synapseDatabaseResourceId);

            // get the collection of this SynapseDataConnectionResource
            SynapseDataConnectionCollection collection = synapseDatabase.GetSynapseDataConnections();

            // invoke the operation
            string dataConnectionName = "DataConnections8";
            bool result = await collection.ExistsAsync(dataConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // KustoPoolDataConnectionsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_KustoPoolDataConnectionsGet()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsGet.json
            // this example is just showing the usage of "KustoPoolDataConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabaseResource created on azure
            // for more information of creating SynapseDatabaseResource, please refer to the document of SynapseDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier synapseDatabaseResourceId = SynapseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName);
            SynapseDatabaseResource synapseDatabase = client.GetSynapseDatabaseResource(synapseDatabaseResourceId);

            // get the collection of this SynapseDataConnectionResource
            SynapseDataConnectionCollection collection = synapseDatabase.GetSynapseDataConnections();

            // invoke the operation
            string dataConnectionName = "DataConnections8";
            NullableResponse<SynapseDataConnectionResource> response = await collection.GetIfExistsAsync(dataConnectionName);
            SynapseDataConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseDataConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // KustoPoolDataConnectionsCreateOrUpdate.json
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_KustoPoolDataConnectionsCreateOrUpdateJson()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/preview/2021-06-01-preview/examples/KustoPoolDataConnectionsCreateOrUpdate.json
            // this example is just showing the usage of "KustoPoolDataConnections_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDatabaseResource created on azure
            // for more information of creating SynapseDatabaseResource, please refer to the document of SynapseDatabaseResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "kustorptest";
            string workspaceName = "synapseWorkspaceName";
            string kustoPoolName = "kustoclusterrptest4";
            string databaseName = "KustoDatabase8";
            ResourceIdentifier synapseDatabaseResourceId = SynapseDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, kustoPoolName, databaseName);
            SynapseDatabaseResource synapseDatabase = client.GetSynapseDatabaseResource(synapseDatabaseResourceId);

            // get the collection of this SynapseDataConnectionResource
            SynapseDataConnectionCollection collection = synapseDatabase.GetSynapseDataConnections();

            // invoke the operation
            string dataConnectionName = "DataConnections8";
            SynapseDataConnectionData data = new SynapseEventHubDataConnection()
            {
                EventHubResourceId = new ResourceIdentifier("/subscriptions/12345678-1234-1234-1234-123456789098/resourceGroups/kustorptest/providers/Microsoft.EventHub/namespaces/eventhubTestns1/eventhubs/eventhubTest1"),
                ConsumerGroup = "testConsumerGroup1",
                Location = new AzureLocation("westus"),
            };
            ArmOperation<SynapseDataConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataConnectionName, data);
            SynapseDataConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

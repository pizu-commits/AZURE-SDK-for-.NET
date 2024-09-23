// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseReplicationLinkCollection
    {
        // Lists a Sql Analytic pool's replication links
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsASqlAnalyticPoolSReplicationLinks()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/ListSqlPoolReplicationLinks.json
            // this example is just showing the usage of "SqlPoolReplicationLinks_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-6440";
            string sqlPoolName = "testdb";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseReplicationLinkResource
            SynapseReplicationLinkCollection collection = synapseSqlPool.GetSynapseReplicationLinks();

            // invoke the operation and iterate over the result
            await foreach (SynapseReplicationLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseReplicationLinkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Lists a Sql Analytic pool's replication links
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ListsASqlAnalyticPoolSReplicationLinks()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolReplicationLinks_GetByName.json
            // this example is just showing the usage of "SqlPoolReplicationLinks_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-6440";
            string sqlPoolName = "testdb";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseReplicationLinkResource
            SynapseReplicationLinkCollection collection = synapseSqlPool.GetSynapseReplicationLinks();

            // invoke the operation
            string linkId = "5b301b68-03f6-4b26-b0f4-73ebb8634238";
            SynapseReplicationLinkResource result = await collection.GetAsync(linkId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseReplicationLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Lists a Sql Analytic pool's replication links
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ListsASqlAnalyticPoolSReplicationLinks()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolReplicationLinks_GetByName.json
            // this example is just showing the usage of "SqlPoolReplicationLinks_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-6440";
            string sqlPoolName = "testdb";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseReplicationLinkResource
            SynapseReplicationLinkCollection collection = synapseSqlPool.GetSynapseReplicationLinks();

            // invoke the operation
            string linkId = "5b301b68-03f6-4b26-b0f4-73ebb8634238";
            bool result = await collection.ExistsAsync(linkId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Lists a Sql Analytic pool's replication links
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ListsASqlAnalyticPoolSReplicationLinks()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/SqlPoolReplicationLinks_GetByName.json
            // this example is just showing the usage of "SqlPoolReplicationLinks_GetByName" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sqlcrudtest-4799";
            string workspaceName = "sqlcrudtest-6440";
            string sqlPoolName = "testdb";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseReplicationLinkResource
            SynapseReplicationLinkCollection collection = synapseSqlPool.GetSynapseReplicationLinks();

            // invoke the operation
            string linkId = "5b301b68-03f6-4b26-b0f4-73ebb8634238";
            NullableResponse<SynapseReplicationLinkResource> response = await collection.GetIfExistsAsync(linkId);
            SynapseReplicationLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseReplicationLinkData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

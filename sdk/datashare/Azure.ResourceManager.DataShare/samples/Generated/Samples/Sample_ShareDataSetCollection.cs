// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare.Samples
{
    public partial class Sample_ShareDataSetCollection
    {
        // DataSets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DataSetsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_Get.json
            // this example is just showing the usage of "DataSets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            ShareDataSetResource result = await collection.GetAsync(dataSetName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DataSetsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_Get.json
            // this example is just showing the usage of "DataSets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            bool result = await collection.ExistsAsync(dataSetName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DataSets_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_DataSetsGet()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_Get.json
            // this example is just showing the usage of "DataSets_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            NullableResponse<ShareDataSetResource> response = await collection.GetIfExistsAsync(dataSetName);
            ShareDataSetResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ShareDataSetData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // DataSets_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataSetsCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_Create.json
            // this example is just showing the usage of "DataSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            ShareDataSetData data = new BlobDataSet("C1", "file21", "SampleResourceGroup", "storage2", "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a");
            ArmOperation<ShareDataSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSetName, data);
            ShareDataSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_KustoCluster_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataSetsKustoClusterCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_KustoCluster_Create.json
            // this example is just showing the usage of "DataSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            ShareDataSetData data = new KustoClusterDataSet(new ResourceIdentifier("/subscriptions/433a8dfd-e5d5-4e77-ad86-90acdc75eb1a/resourceGroups/SampleResourceGroup/providers/Microsoft.Kusto/clusters/Cluster1"));
            ArmOperation<ShareDataSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSetName, data);
            ShareDataSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_KustoDatabase_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataSetsKustoDatabaseCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_KustoDatabase_Create.json
            // this example is just showing the usage of "DataSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            ShareDataSetData data = new KustoDatabaseDataSet(new ResourceIdentifier("/subscriptions/433a8dfd-e5d5-4e77-ad86-90acdc75eb1a/resourceGroups/SampleResourceGroup/providers/Microsoft.Kusto/clusters/Cluster1/databases/Database1"));
            ArmOperation<ShareDataSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSetName, data);
            ShareDataSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_KustoTable_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataSetsKustoTableCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_KustoTable_Create.json
            // this example is just showing the usage of "DataSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            ShareDataSetData data = new KustoTableDataSet(new ResourceIdentifier("/subscriptions/433a8dfd-e5d5-4e77-ad86-90acdc75eb1a/resourceGroups/SampleResourceGroup/providers/Microsoft.Kusto/clusters/Cluster1/databases/Database1"), new TableLevelSharingProperties()
            {
                ExternalTablesToExclude =
{
"test11","test12"
},
                ExternalTablesToInclude =
{
"test9","test10"
},
                MaterializedViewsToExclude =
{
"test7","test8"
},
                MaterializedViewsToInclude =
{
"test5","test6"
},
                TablesToExclude =
{
"test3","test4"
},
                TablesToInclude =
{
"test1","test2"
},
            });
            ArmOperation<ShareDataSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSetName, data);
            ShareDataSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_SqlDBTable_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataSetsSqlDBTableCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_SqlDBTable_Create.json
            // this example is just showing the usage of "DataSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            ShareDataSetData data = new SqlDBTableDataSet()
            {
                DatabaseName = "SqlDB1",
                SchemaName = "dbo",
                SqlServerResourceId = new ResourceIdentifier("/subscriptions/433a8dfd-e5d5-4e77-ad86-90acdc75eb1a/resourceGroups/SampleResourceGroup/providers/Microsoft.Sql/servers/Server1"),
                TableName = "Table1",
            };
            ArmOperation<ShareDataSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSetName, data);
            ShareDataSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_SqlDWTable_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataSetsSqlDWTableCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_SqlDWTable_Create.json
            // this example is just showing the usage of "DataSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "Dataset1";
            ShareDataSetData data = new SqlDWTableDataSet()
            {
                DataWarehouseName = "DataWarehouse1",
                SchemaName = "dbo",
                SqlServerResourceId = new ResourceIdentifier("/subscriptions/433a8dfd-e5d5-4e77-ad86-90acdc75eb1a/resourceGroups/SampleResourceGroup/providers/Microsoft.Sql/servers/Server1"),
                TableName = "Table1",
            };
            ArmOperation<ShareDataSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSetName, data);
            ShareDataSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_SynapseWorkspaceSqlPoolTable_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DataSetsSynapseWorkspaceSqlPoolTableCreate()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_SynapseWorkspaceSqlPoolTable_Create.json
            // this example is just showing the usage of "DataSets_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "0f3dcfc3-18f8-4099-b381-8353e19d43a7";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "sourceAccount";
            string shareName = "share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation
            string dataSetName = "dataset1";
            ShareDataSetData data = new SynapseWorkspaceSqlPoolTableDataSet(new ResourceIdentifier("/subscriptions/0f3dcfc3-18f8-4099-b381-8353e19d43a7/resourceGroups/SampleResourceGroup/providers/Microsoft.Synapse/workspaces/ExampleWorkspace/sqlPools/ExampleSqlPool/schemas/dbo/tables/table1"));
            ArmOperation<ShareDataSetResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataSetName, data);
            ShareDataSetResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ShareDataSetData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DataSets_ListByShare
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DataSetsListByShare()
        {
            // Generated from example definition: specification/datashare/resource-manager/Microsoft.DataShare/stable/2021-08-01/examples/DataSets_ListByShare.json
            // this example is just showing the usage of "DataSets_ListByShare" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DataShareResource created on azure
            // for more information of creating DataShareResource, please refer to the document of DataShareResource
            string subscriptionId = "433a8dfd-e5d5-4e77-ad86-90acdc75eb1a";
            string resourceGroupName = "SampleResourceGroup";
            string accountName = "Account1";
            string shareName = "Share1";
            ResourceIdentifier dataShareResourceId = DataShareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, shareName);
            DataShareResource dataShare = client.GetDataShareResource(dataShareResourceId);

            // get the collection of this ShareDataSetResource
            ShareDataSetCollection collection = dataShare.GetShareDataSets();

            // invoke the operation and iterate over the result
            await foreach (ShareDataSetResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ShareDataSetData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

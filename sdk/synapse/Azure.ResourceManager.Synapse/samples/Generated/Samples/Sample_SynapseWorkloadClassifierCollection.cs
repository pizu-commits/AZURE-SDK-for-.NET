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
    public partial class Sample_SynapseWorkloadClassifierCollection
    {
        // Get a workload classifier for SQL Analytics pool's workload group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAWorkloadClassifierForSQLAnalyticsPoolSWorkloadGroup()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolWorkloadGroupWorkloadClassifier.json
            // this example is just showing the usage of "SqlPoolWorkloadClassifier_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "wlm_workloadgroup";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // get the collection of this SynapseWorkloadClassifierResource
            SynapseWorkloadClassifierCollection collection = synapseWorkloadGroup.GetSynapseWorkloadClassifiers();

            // invoke the operation
            string workloadClassifierName = "wlm_classifier";
            SynapseWorkloadClassifierResource result = await collection.GetAsync(workloadClassifierName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkloadClassifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a workload classifier for SQL Analytics pool's workload group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAWorkloadClassifierForSQLAnalyticsPoolSWorkloadGroup()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolWorkloadGroupWorkloadClassifier.json
            // this example is just showing the usage of "SqlPoolWorkloadClassifier_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "wlm_workloadgroup";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // get the collection of this SynapseWorkloadClassifierResource
            SynapseWorkloadClassifierCollection collection = synapseWorkloadGroup.GetSynapseWorkloadClassifiers();

            // invoke the operation
            string workloadClassifierName = "wlm_classifier";
            bool result = await collection.ExistsAsync(workloadClassifierName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a workload classifier for SQL Analytics pool's workload group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAWorkloadClassifierForSQLAnalyticsPoolSWorkloadGroup()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolWorkloadGroupWorkloadClassifier.json
            // this example is just showing the usage of "SqlPoolWorkloadClassifier_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "wlm_workloadgroup";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // get the collection of this SynapseWorkloadClassifierResource
            SynapseWorkloadClassifierCollection collection = synapseWorkloadGroup.GetSynapseWorkloadClassifiers();

            // invoke the operation
            string workloadClassifierName = "wlm_classifier";
            NullableResponse<SynapseWorkloadClassifierResource> response = await collection.GetIfExistsAsync(workloadClassifierName);
            SynapseWorkloadClassifierResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseWorkloadClassifierData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create a workload classifier with all properties specified.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAWorkloadClassifierWithAllPropertiesSpecified()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateSqlPoolWorkloadClassifierMax.json
            // this example is just showing the usage of "SqlPoolWorkloadClassifier_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "wlm_workloadgroup";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // get the collection of this SynapseWorkloadClassifierResource
            SynapseWorkloadClassifierCollection collection = synapseWorkloadGroup.GetSynapseWorkloadClassifiers();

            // invoke the operation
            string workloadClassifierName = "wlm_workloadclassifier";
            SynapseWorkloadClassifierData data = new SynapseWorkloadClassifierData()
            {
                MemberName = "dbo",
                Label = "test_label",
                Context = "test_context",
                StartTime = "12:00",
                EndTime = "14:00",
                Importance = "high",
            };
            ArmOperation<SynapseWorkloadClassifierResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workloadClassifierName, data);
            SynapseWorkloadClassifierResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkloadClassifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create a workload classifier with the required properties specified.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAWorkloadClassifierWithTheRequiredPropertiesSpecified()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateSqlPoolWorkloadClassifierMin.json
            // this example is just showing the usage of "SqlPoolWorkloadClassifier_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "wlm_workloadgroup";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // get the collection of this SynapseWorkloadClassifierResource
            SynapseWorkloadClassifierCollection collection = synapseWorkloadGroup.GetSynapseWorkloadClassifiers();

            // invoke the operation
            string workloadClassifierName = "wlm_workloadclassifier";
            SynapseWorkloadClassifierData data = new SynapseWorkloadClassifierData()
            {
                MemberName = "dbo",
            };
            ArmOperation<SynapseWorkloadClassifierResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, workloadClassifierName, data);
            SynapseWorkloadClassifierResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseWorkloadClassifierData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the list of workload classifiers of a SQL Analytics pool's workload group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetTheListOfWorkloadClassifiersOfASQLAnalyticsPoolSWorkloadGroup()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolWorkloadGroupWorkloadClassifierList.json
            // this example is just showing the usage of "SqlPoolWorkloadClassifier_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkloadGroupResource created on azure
            // for more information of creating SynapseWorkloadGroupResource, please refer to the document of SynapseWorkloadGroupResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            string workloadGroupName = "wlm_workloadgroup";
            ResourceIdentifier synapseWorkloadGroupResourceId = SynapseWorkloadGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, workloadGroupName);
            SynapseWorkloadGroupResource synapseWorkloadGroup = client.GetSynapseWorkloadGroupResource(synapseWorkloadGroupResourceId);

            // get the collection of this SynapseWorkloadClassifierResource
            SynapseWorkloadClassifierCollection collection = synapseWorkloadGroup.GetSynapseWorkloadClassifiers();

            // invoke the operation and iterate over the result
            await foreach (SynapseWorkloadClassifierResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseWorkloadClassifierData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

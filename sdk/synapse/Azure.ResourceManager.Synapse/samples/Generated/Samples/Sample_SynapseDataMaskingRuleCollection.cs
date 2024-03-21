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
    public partial class Sample_SynapseDataMaskingRuleCollection
    {
        // Create/Update data masking rule for default max
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateUpdateDataMaskingRuleForDefaultMax()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleCreateOrUpdateDefaultMax.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            SynapseDataMaskingRuleData data = new SynapseDataMaskingRuleData()
            {
                AliasName = "nickname",
                RuleState = SynapseDataMaskingRuleState.Enabled,
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = SynapseDataMaskingFunction.Default,
            };
            ArmOperation<SynapseDataMaskingRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataMaskingRuleName, data);
            SynapseDataMaskingRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create/Update data masking rule for default min
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateUpdateDataMaskingRuleForDefaultMin()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleCreateOrUpdateDefaultMin.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            SynapseDataMaskingRuleData data = new SynapseDataMaskingRuleData()
            {
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = SynapseDataMaskingFunction.Default,
            };
            ArmOperation<SynapseDataMaskingRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataMaskingRuleName, data);
            SynapseDataMaskingRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create/Update data masking rule for numbers
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateUpdateDataMaskingRuleForNumbers()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleCreateOrUpdateNumber.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            SynapseDataMaskingRuleData data = new SynapseDataMaskingRuleData()
            {
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = SynapseDataMaskingFunction.Number,
                NumberFrom = "0",
                NumberTo = "2",
            };
            ArmOperation<SynapseDataMaskingRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataMaskingRuleName, data);
            SynapseDataMaskingRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create/Update data masking rule for text
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateUpdateDataMaskingRuleForText()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleCreateOrUpdateText.json
            // this example is just showing the usage of "DataMaskingRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            SynapseDataMaskingRuleData data = new SynapseDataMaskingRuleData()
            {
                SchemaName = "dbo",
                TableName = "Table_1",
                ColumnName = "test1",
                MaskingFunction = SynapseDataMaskingFunction.Text,
                PrefixSize = "1",
                SuffixSize = "0",
                ReplacementString = "asdf",
            };
            ArmOperation<SynapseDataMaskingRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, dataMaskingRuleName, data);
            SynapseDataMaskingRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get data masking rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDataMaskingRule()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleGet.json
            // this example is just showing the usage of "DataMaskingRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            SynapseDataMaskingRuleResource result = await collection.GetAsync(dataMaskingRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataMaskingRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get data masking rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetDataMaskingRule()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleGet.json
            // this example is just showing the usage of "DataMaskingRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            bool result = await collection.ExistsAsync(dataMaskingRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get data masking rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetDataMaskingRule()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleGet.json
            // this example is just showing the usage of "DataMaskingRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation
            string dataMaskingRuleName = "rule1";
            NullableResponse<SynapseDataMaskingRuleResource> response = await collection.GetIfExistsAsync(dataMaskingRuleName);
            SynapseDataMaskingRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseDataMaskingRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List data masking rules
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListDataMaskingRules()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/DataMaskingRuleList.json
            // this example is just showing the usage of "DataMaskingRules_ListBySqlPool" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseDataMaskingPolicyResource created on azure
            // for more information of creating SynapseDataMaskingPolicyResource, please refer to the document of SynapseDataMaskingPolicyResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-331";
            ResourceIdentifier synapseDataMaskingPolicyResourceId = SynapseDataMaskingPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseDataMaskingPolicyResource synapseDataMaskingPolicy = client.GetSynapseDataMaskingPolicyResource(synapseDataMaskingPolicyResourceId);

            // get the collection of this SynapseDataMaskingRuleResource
            SynapseDataMaskingRuleCollection collection = synapseDataMaskingPolicy.GetSynapseDataMaskingRules();

            // invoke the operation and iterate over the result
            await foreach (SynapseDataMaskingRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseDataMaskingRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

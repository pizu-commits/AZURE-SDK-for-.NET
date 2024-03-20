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
    public partial class Sample_SynapseServerBlobAuditingPolicyCollection
    {
        // Get blob auditing setting of workspace managed sql Server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetBlobAuditingSettingOfWorkspaceManagedSqlServer()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseServerBlobAuditingPolicyResource
            SynapseServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            SynapseServerBlobAuditingPolicyResource result = await collection.GetAsync(blobAuditingPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get blob auditing setting of workspace managed sql Server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetBlobAuditingSettingOfWorkspaceManagedSqlServer()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseServerBlobAuditingPolicyResource
            SynapseServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            bool result = await collection.ExistsAsync(blobAuditingPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get blob auditing setting of workspace managed sql Server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetBlobAuditingSettingOfWorkspaceManagedSqlServer()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetWorkspaceManagedSqlServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseServerBlobAuditingPolicyResource
            SynapseServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            NullableResponse<SynapseServerBlobAuditingPolicyResource> response = await collection.GetIfExistsAsync(blobAuditingPolicyName);
            SynapseServerBlobAuditingPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseServerBlobAuditingPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update blob auditing policy of workspace SQL Server with all parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateBlobAuditingPolicyOfWorkspaceSQLServerWithAllParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateWorkspaceManagedSqlServerBlobAuditingSettingsWithAllParameters.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseServerBlobAuditingPolicyResource
            SynapseServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            SynapseServerBlobAuditingPolicyData data = new SynapseServerBlobAuditingPolicyData()
            {
                State = SynapseBlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
                RetentionDays = 6,
                AuditActionsAndGroups =
{
"SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP","FAILED_DATABASE_AUTHENTICATION_GROUP","BATCH_COMPLETED_GROUP"
},
                StorageAccountSubscriptionId = Guid.Parse("00000000-1234-0000-5678-000000000000"),
                IsStorageSecondaryKeyInUse = false,
                IsAzureMonitorTargetEnabled = true,
                QueueDelayMs = 4000,
            };
            ArmOperation<SynapseServerBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            SynapseServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update blob auditing policy of workspace managed Sql Server with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateBlobAuditingPolicyOfWorkspaceManagedSqlServerWithMinimalParameters()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateWorkspaceManagedSqlServerBlobAuditingSettingsWithMinParameters.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseServerBlobAuditingPolicyResource
            SynapseServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseServerBlobAuditingPolicies();

            // invoke the operation
            SynapseBlobAuditingPolicyName blobAuditingPolicyName = SynapseBlobAuditingPolicyName.Default;
            SynapseServerBlobAuditingPolicyData data = new SynapseServerBlobAuditingPolicyData()
            {
                State = SynapseBlobAuditingPolicyState.Enabled,
                StorageEndpoint = "https://mystorage.blob.core.windows.net",
                StorageAccountAccessKey = "sdlfkjabc+sdlfkjsdlkfsjdfLDKFTERLKFDFKLjsdfksjdflsdkfD2342309432849328476458/3RSD==",
            };
            ArmOperation<SynapseServerBlobAuditingPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, blobAuditingPolicyName, data);
            SynapseServerBlobAuditingPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseServerBlobAuditingPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get blob auditing policy of workspace manged sql Server
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetBlobAuditingPolicyOfWorkspaceMangedSqlServer()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/ListWorkspaceManagedSqlServerBlobAuditingSettings.json
            // this example is just showing the usage of "WorkspaceManagedSqlServerBlobAuditingPolicies_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseWorkspaceResource created on azure
            // for more information of creating SynapseWorkspaceResource, please refer to the document of SynapseWorkspaceResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "wsg-7398";
            string workspaceName = "testWorkspace";
            ResourceIdentifier synapseWorkspaceResourceId = SynapseWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            SynapseWorkspaceResource synapseWorkspace = client.GetSynapseWorkspaceResource(synapseWorkspaceResourceId);

            // get the collection of this SynapseServerBlobAuditingPolicyResource
            SynapseServerBlobAuditingPolicyCollection collection = synapseWorkspace.GetSynapseServerBlobAuditingPolicies();

            // invoke the operation and iterate over the result
            await foreach (SynapseServerBlobAuditingPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseServerBlobAuditingPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

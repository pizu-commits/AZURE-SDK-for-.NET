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
    public partial class Sample_SynapseTransparentDataEncryptionResource
    {
        // Get transparent data encryption configuration of a SQL Analytics pool
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTransparentDataEncryptionConfigurationOfASQLAnalyticsPool()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolTransparentDataEncryption.json
            // this example is just showing the usage of "SqlPoolTransparentDataEncryptions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseTransparentDataEncryptionResource created on azure
            // for more information of creating SynapseTransparentDataEncryptionResource, please refer to the document of SynapseTransparentDataEncryptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            SynapseTransparentDataEncryptionName transparentDataEncryptionName = SynapseTransparentDataEncryptionName.Current;
            ResourceIdentifier synapseTransparentDataEncryptionResourceId = SynapseTransparentDataEncryptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, transparentDataEncryptionName);
            SynapseTransparentDataEncryptionResource synapseTransparentDataEncryption = client.GetSynapseTransparentDataEncryptionResource(synapseTransparentDataEncryptionResourceId);

            // invoke the operation
            SynapseTransparentDataEncryptionResource result = await synapseTransparentDataEncryption.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseTransparentDataEncryptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update a Sql pool's transparent data encryption configuration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateASqlPoolSTransparentDataEncryptionConfiguration()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/CreateOrUpdateSqlPoolTransparentDataEncryption.json
            // this example is just showing the usage of "SqlPoolTransparentDataEncryptions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseTransparentDataEncryptionResource created on azure
            // for more information of creating SynapseTransparentDataEncryptionResource, please refer to the document of SynapseTransparentDataEncryptionResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "sqlcrudtest-6852";
            string workspaceName = "sqlcrudtest-2080";
            string sqlPoolName = "sqlcrudtest-9187";
            SynapseTransparentDataEncryptionName transparentDataEncryptionName = SynapseTransparentDataEncryptionName.Current;
            ResourceIdentifier synapseTransparentDataEncryptionResourceId = SynapseTransparentDataEncryptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName, transparentDataEncryptionName);
            SynapseTransparentDataEncryptionResource synapseTransparentDataEncryption = client.GetSynapseTransparentDataEncryptionResource(synapseTransparentDataEncryptionResourceId);

            // invoke the operation
            SynapseTransparentDataEncryptionData data = new SynapseTransparentDataEncryptionData()
            {
                Status = SynapseTransparentDataEncryptionStatus.Enabled,
            };
            ArmOperation<SynapseTransparentDataEncryptionResource> lro = await synapseTransparentDataEncryption.UpdateAsync(WaitUntil.Completed, data);
            SynapseTransparentDataEncryptionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseTransparentDataEncryptionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

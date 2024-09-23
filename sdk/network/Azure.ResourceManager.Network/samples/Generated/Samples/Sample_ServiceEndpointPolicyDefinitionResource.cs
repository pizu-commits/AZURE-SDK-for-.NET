// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ServiceEndpointPolicyDefinitionResource
    {
        // Delete service endpoint policy definitions from service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteServiceEndpointPolicyDefinitionsFromServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ServiceEndpointPolicyDefinitionDelete.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyDefinitionResource created on azure
            // for more information of creating ServiceEndpointPolicyDefinitionResource, please refer to the document of ServiceEndpointPolicyDefinitionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            string serviceEndpointPolicyDefinitionName = "testDefinition";
            ResourceIdentifier serviceEndpointPolicyDefinitionResourceId = ServiceEndpointPolicyDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            ServiceEndpointPolicyDefinitionResource serviceEndpointPolicyDefinition = client.GetServiceEndpointPolicyDefinitionResource(serviceEndpointPolicyDefinitionResourceId);

            // invoke the operation
            await serviceEndpointPolicyDefinition.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get service endpoint definition in service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetServiceEndpointDefinitionInServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ServiceEndpointPolicyDefinitionGet.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyDefinitionResource created on azure
            // for more information of creating ServiceEndpointPolicyDefinitionResource, please refer to the document of ServiceEndpointPolicyDefinitionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            string serviceEndpointPolicyDefinitionName = "testDefinition";
            ResourceIdentifier serviceEndpointPolicyDefinitionResourceId = ServiceEndpointPolicyDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            ServiceEndpointPolicyDefinitionResource serviceEndpointPolicyDefinition = client.GetServiceEndpointPolicyDefinitionResource(serviceEndpointPolicyDefinitionResourceId);

            // invoke the operation
            ServiceEndpointPolicyDefinitionResource result = await serviceEndpointPolicyDefinition.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create service endpoint policy definition
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateServiceEndpointPolicyDefinition()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ServiceEndpointPolicyDefinitionCreate.json
            // this example is just showing the usage of "ServiceEndpointPolicyDefinitions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyDefinitionResource created on azure
            // for more information of creating ServiceEndpointPolicyDefinitionResource, please refer to the document of ServiceEndpointPolicyDefinitionResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testPolicy";
            string serviceEndpointPolicyDefinitionName = "testDefinition";
            ResourceIdentifier serviceEndpointPolicyDefinitionResourceId = ServiceEndpointPolicyDefinitionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            ServiceEndpointPolicyDefinitionResource serviceEndpointPolicyDefinition = client.GetServiceEndpointPolicyDefinitionResource(serviceEndpointPolicyDefinitionResourceId);

            // invoke the operation
            ServiceEndpointPolicyDefinitionData data = new ServiceEndpointPolicyDefinitionData()
            {
                Description = "Storage Service EndpointPolicy Definition",
                Service = "Microsoft.Storage",
                ServiceResources =
{
new ResourceIdentifier("/subscriptions/subid1"),new ResourceIdentifier("/subscriptions/subid1/resourceGroups/storageRg"),new ResourceIdentifier("/subscriptions/subid1/resourceGroups/storageRg/providers/Microsoft.Storage/storageAccounts/stAccount")
},
            };
            ArmOperation<ServiceEndpointPolicyDefinitionResource> lro = await serviceEndpointPolicyDefinition.UpdateAsync(WaitUntil.Completed, data);
            ServiceEndpointPolicyDefinitionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

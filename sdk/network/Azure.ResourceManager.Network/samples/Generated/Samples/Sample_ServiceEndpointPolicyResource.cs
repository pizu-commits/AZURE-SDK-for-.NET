// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_ServiceEndpointPolicyResource
    {
        // Delete service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ServiceEndpointPolicyDelete.json
            // this example is just showing the usage of "ServiceEndpointPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "serviceEndpointPolicy1";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // invoke the operation
            await serviceEndpointPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get service endPoint Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetServiceEndPointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ServiceEndpointPolicyGet.json
            // this example is just showing the usage of "ServiceEndpointPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testServiceEndpointPolicy";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // invoke the operation
            ServiceEndpointPolicyResource result = await serviceEndpointPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update service endpoint policy tags
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_UpdateServiceEndpointPolicyTags()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ServiceEndpointPolicyUpdateTags.json
            // this example is just showing the usage of "ServiceEndpointPolicies_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceEndpointPolicyResource created on azure
            // for more information of creating ServiceEndpointPolicyResource, please refer to the document of ServiceEndpointPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string serviceEndpointPolicyName = "testServiceEndpointPolicy";
            ResourceIdentifier serviceEndpointPolicyResourceId = ServiceEndpointPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceEndpointPolicyName);
            ServiceEndpointPolicyResource serviceEndpointPolicy = client.GetServiceEndpointPolicyResource(serviceEndpointPolicyResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ServiceEndpointPolicyResource result = await serviceEndpointPolicy.UpdateAsync(networkTagsObject);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceEndpointPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all service endpoint policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetServiceEndpointPoliciesByServiceEndpointPolicy_ListAllServiceEndpointPolicy()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-03-01/examples/ServiceEndpointPolicyListAll.json
            // this example is just showing the usage of "ServiceEndpointPolicies_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ServiceEndpointPolicyResource item in subscriptionResource.GetServiceEndpointPoliciesByServiceEndpointPolicyAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceEndpointPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

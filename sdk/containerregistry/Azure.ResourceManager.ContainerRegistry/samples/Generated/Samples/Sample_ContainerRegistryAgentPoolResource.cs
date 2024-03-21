// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry.Samples
{
    public partial class Sample_ContainerRegistryAgentPoolResource
    {
        // AgentPools_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AgentPoolsGet()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/AgentPoolsGet.json
            // this example is just showing the usage of "AgentPools_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryAgentPoolResource created on azure
            // for more information of creating ContainerRegistryAgentPoolResource, please refer to the document of ContainerRegistryAgentPoolResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string agentPoolName = "myAgentPool";
            ResourceIdentifier containerRegistryAgentPoolResourceId = ContainerRegistryAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, agentPoolName);
            ContainerRegistryAgentPoolResource containerRegistryAgentPool = client.GetContainerRegistryAgentPoolResource(containerRegistryAgentPoolResourceId);

            // invoke the operation
            ContainerRegistryAgentPoolResource result = await containerRegistryAgentPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AgentPools_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_AgentPoolsDelete()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/AgentPoolsDelete.json
            // this example is just showing the usage of "AgentPools_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryAgentPoolResource created on azure
            // for more information of creating ContainerRegistryAgentPoolResource, please refer to the document of ContainerRegistryAgentPoolResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string agentPoolName = "myAgentPool";
            ResourceIdentifier containerRegistryAgentPoolResourceId = ContainerRegistryAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, agentPoolName);
            ContainerRegistryAgentPoolResource containerRegistryAgentPool = client.GetContainerRegistryAgentPoolResource(containerRegistryAgentPoolResourceId);

            // invoke the operation
            await containerRegistryAgentPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // AgentPools_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_AgentPoolsUpdate()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/AgentPoolsUpdate.json
            // this example is just showing the usage of "AgentPools_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryAgentPoolResource created on azure
            // for more information of creating ContainerRegistryAgentPoolResource, please refer to the document of ContainerRegistryAgentPoolResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string agentPoolName = "myAgentPool";
            ResourceIdentifier containerRegistryAgentPoolResourceId = ContainerRegistryAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, agentPoolName);
            ContainerRegistryAgentPoolResource containerRegistryAgentPool = client.GetContainerRegistryAgentPoolResource(containerRegistryAgentPoolResourceId);

            // invoke the operation
            ContainerRegistryAgentPoolPatch patch = new ContainerRegistryAgentPoolPatch()
            {
                Count = 1,
            };
            ArmOperation<ContainerRegistryAgentPoolResource> lro = await containerRegistryAgentPool.UpdateAsync(WaitUntil.Completed, patch);
            ContainerRegistryAgentPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ContainerRegistryAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AgentPools_GetQueueStatus
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetQueueStatus_AgentPoolsGetQueueStatus()
        {
            // Generated from example definition: specification/containerregistry/resource-manager/Microsoft.ContainerRegistry/preview/2019-06-01-preview/examples/AgentPoolsGetQueueStatus.json
            // this example is just showing the usage of "AgentPools_GetQueueStatus" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ContainerRegistryAgentPoolResource created on azure
            // for more information of creating ContainerRegistryAgentPoolResource, please refer to the document of ContainerRegistryAgentPoolResource
            string subscriptionId = "4385cf00-2d3a-425a-832f-f4285b1c9dce";
            string resourceGroupName = "myResourceGroup";
            string registryName = "myRegistry";
            string agentPoolName = "myAgentPool";
            ResourceIdentifier containerRegistryAgentPoolResourceId = ContainerRegistryAgentPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, registryName, agentPoolName);
            ContainerRegistryAgentPoolResource containerRegistryAgentPool = client.GetContainerRegistryAgentPoolResource(containerRegistryAgentPoolResourceId);

            // invoke the operation
            ContainerRegistryAgentPoolQueueStatus result = await containerRegistryAgentPool.GetQueueStatusAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

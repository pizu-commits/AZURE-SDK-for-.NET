// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.SecurityCenter.Samples
{
    public partial class Sample_ResourceGroupSecurityTaskResource
    {
        // Get security recommendation task in a resource group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetSecurityRecommendationTaskInAResourceGroup()
        {
            // Generated from example definition: specification/security/resource-manager/Microsoft.Security/preview/2015-06-01-preview/examples/Tasks/GetTaskResourceGroupLocation_example.json
            // this example is just showing the usage of "Tasks_GetResourceGroupLevelTask" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupSecurityTaskResource created on azure
            // for more information of creating ResourceGroupSecurityTaskResource, please refer to the document of ResourceGroupSecurityTaskResource
            string subscriptionId = "20ff7fc3-e762-44dd-bd96-b71116dcdc23";
            string resourceGroupName = "myRg";
            AzureLocation ascLocation = new AzureLocation("westeurope");
            string taskName = "d55b4dc0-779c-c66c-33e5-d7bce24c4222";
            ResourceIdentifier resourceGroupSecurityTaskResourceId = ResourceGroupSecurityTaskResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, ascLocation, taskName);
            ResourceGroupSecurityTaskResource resourceGroupSecurityTask = client.GetResourceGroupSecurityTaskResource(resourceGroupSecurityTaskResourceId);

            // invoke the operation
            ResourceGroupSecurityTaskResource result = await resourceGroupSecurityTask.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SecurityTaskData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

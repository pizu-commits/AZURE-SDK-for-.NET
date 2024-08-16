// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Hci.Samples
{
    public partial class Sample_HciClusterPublisherResource
    {
        // Get Publisher
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetPublisher()
        {
            // Generated from example definition: specification/azurestackhci/resource-manager/Microsoft.AzureStackHCI/StackHCI/stable/2024-04-01/examples/GetPublisher.json
            // this example is just showing the usage of "Publishers_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HciClusterPublisherResource created on azure
            // for more information of creating HciClusterPublisherResource, please refer to the document of HciClusterPublisherResource
            string subscriptionId = "fd3c3665-1729-4b7b-9a38-238e83b0f98b";
            string resourceGroupName = "test-rg";
            string clusterName = "myCluster";
            string publisherName = "publisher1";
            ResourceIdentifier hciClusterPublisherResourceId = HciClusterPublisherResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName, publisherName);
            HciClusterPublisherResource hciClusterPublisher = client.GetHciClusterPublisherResource(hciClusterPublisherResourceId);

            // invoke the operation
            HciClusterPublisherResource result = await hciClusterPublisher.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HciClusterPublisherData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

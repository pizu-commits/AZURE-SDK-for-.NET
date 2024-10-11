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
    public partial class Sample_ExpressRouteLinkCollection
    {
        // ExpressRouteLinkGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ExpressRouteLinkGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteLinkGet.json
            // this example is just showing the usage of "ExpressRouteLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRouteLinkResource
            ExpressRouteLinkCollection collection = expressRoutePort.GetExpressRouteLinks();

            // invoke the operation
            string linkName = "linkName";
            ExpressRouteLinkResource result = await collection.GetAsync(linkName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ExpressRouteLinkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ExpressRouteLinkGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_ExpressRouteLinkGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteLinkGet.json
            // this example is just showing the usage of "ExpressRouteLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRouteLinkResource
            ExpressRouteLinkCollection collection = expressRoutePort.GetExpressRouteLinks();

            // invoke the operation
            string linkName = "linkName";
            bool result = await collection.ExistsAsync(linkName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // ExpressRouteLinkGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_ExpressRouteLinkGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteLinkGet.json
            // this example is just showing the usage of "ExpressRouteLinks_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRouteLinkResource
            ExpressRouteLinkCollection collection = expressRoutePort.GetExpressRouteLinks();

            // invoke the operation
            string linkName = "linkName";
            NullableResponse<ExpressRouteLinkResource> response = await collection.GetIfExistsAsync(linkName);
            ExpressRouteLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteLinkData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // ExpressRouteLinkGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ExpressRouteLinkGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/ExpressRouteLinkList.json
            // this example is just showing the usage of "ExpressRouteLinks_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ExpressRoutePortResource created on azure
            // for more information of creating ExpressRoutePortResource, please refer to the document of ExpressRoutePortResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string expressRoutePortName = "portName";
            ResourceIdentifier expressRoutePortResourceId = ExpressRoutePortResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, expressRoutePortName);
            ExpressRoutePortResource expressRoutePort = client.GetExpressRoutePortResource(expressRoutePortResourceId);

            // get the collection of this ExpressRouteLinkResource
            ExpressRouteLinkCollection collection = expressRoutePort.GetExpressRouteLinks();

            // invoke the operation and iterate over the result
            await foreach (ExpressRouteLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ExpressRouteLinkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

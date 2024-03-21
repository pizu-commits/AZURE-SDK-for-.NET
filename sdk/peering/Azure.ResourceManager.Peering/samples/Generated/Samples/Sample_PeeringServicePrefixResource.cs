// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Peering.Samples
{
    public partial class Sample_PeeringServicePrefixResource
    {
        // Get a prefix associated with the peering service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAPrefixAssociatedWithThePeeringService()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/GetPeeringServicePrefix.json
            // this example is just showing the usage of "Prefixes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PeeringServicePrefixResource created on azure
            // for more information of creating PeeringServicePrefixResource, please refer to the document of PeeringServicePrefixResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            string peeringServiceName = "peeringServiceName";
            string prefixName = "peeringServicePrefixName";
            ResourceIdentifier peeringServicePrefixResourceId = PeeringServicePrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, peeringServiceName, prefixName);
            PeeringServicePrefixResource peeringServicePrefix = client.GetPeeringServicePrefixResource(peeringServicePrefixResourceId);

            // invoke the operation
            PeeringServicePrefixResource result = await peeringServicePrefix.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringServicePrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update a prefix for the peering service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateAPrefixForThePeeringService()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/CreatePeeringServicePrefix.json
            // this example is just showing the usage of "Prefixes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PeeringServicePrefixResource created on azure
            // for more information of creating PeeringServicePrefixResource, please refer to the document of PeeringServicePrefixResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            string peeringServiceName = "peeringServiceName";
            string prefixName = "peeringServicePrefixName";
            ResourceIdentifier peeringServicePrefixResourceId = PeeringServicePrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, peeringServiceName, prefixName);
            PeeringServicePrefixResource peeringServicePrefix = client.GetPeeringServicePrefixResource(peeringServicePrefixResourceId);

            // invoke the operation
            PeeringServicePrefixData data = new PeeringServicePrefixData()
            {
                Prefix = "192.168.1.0/24",
                PeeringServicePrefixKey = "00000000-0000-0000-0000-000000000000",
            };
            ArmOperation<PeeringServicePrefixResource> lro = await peeringServicePrefix.UpdateAsync(WaitUntil.Completed, data);
            PeeringServicePrefixResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringServicePrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete a prefix associated with the peering service
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAPrefixAssociatedWithThePeeringService()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/DeletePeeringServicePrefix.json
            // this example is just showing the usage of "Prefixes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PeeringServicePrefixResource created on azure
            // for more information of creating PeeringServicePrefixResource, please refer to the document of PeeringServicePrefixResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            string peeringServiceName = "peeringServiceName";
            string prefixName = "peeringServicePrefixName";
            ResourceIdentifier peeringServicePrefixResourceId = PeeringServicePrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, peeringServiceName, prefixName);
            PeeringServicePrefixResource peeringServicePrefix = client.GetPeeringServicePrefixResource(peeringServicePrefixResourceId);

            // invoke the operation
            await peeringServicePrefix.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

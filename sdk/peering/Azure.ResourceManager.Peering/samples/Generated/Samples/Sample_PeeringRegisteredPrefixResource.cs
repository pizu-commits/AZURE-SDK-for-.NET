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
    public partial class Sample_PeeringRegisteredPrefixResource
    {
        // Get a registered prefix associated with the peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetARegisteredPrefixAssociatedWithThePeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/GetRegisteredPrefix.json
            // this example is just showing the usage of "RegisteredPrefixes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PeeringRegisteredPrefixResource created on azure
            // for more information of creating PeeringRegisteredPrefixResource, please refer to the document of PeeringRegisteredPrefixResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            string peeringName = "peeringName";
            string registeredPrefixName = "registeredPrefixName";
            ResourceIdentifier peeringRegisteredPrefixResourceId = PeeringRegisteredPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, peeringName, registeredPrefixName);
            PeeringRegisteredPrefixResource peeringRegisteredPrefix = client.GetPeeringRegisteredPrefixResource(peeringRegisteredPrefixResourceId);

            // invoke the operation
            PeeringRegisteredPrefixResource result = await peeringRegisteredPrefix.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringRegisteredPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create or update a registered prefix for the peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateOrUpdateARegisteredPrefixForThePeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/CreateRegisteredPrefix.json
            // this example is just showing the usage of "RegisteredPrefixes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PeeringRegisteredPrefixResource created on azure
            // for more information of creating PeeringRegisteredPrefixResource, please refer to the document of PeeringRegisteredPrefixResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            string peeringName = "peeringName";
            string registeredPrefixName = "registeredPrefixName";
            ResourceIdentifier peeringRegisteredPrefixResourceId = PeeringRegisteredPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, peeringName, registeredPrefixName);
            PeeringRegisteredPrefixResource peeringRegisteredPrefix = client.GetPeeringRegisteredPrefixResource(peeringRegisteredPrefixResourceId);

            // invoke the operation
            PeeringRegisteredPrefixData data = new PeeringRegisteredPrefixData()
            {
                Prefix = "10.22.20.0/24",
            };
            ArmOperation<PeeringRegisteredPrefixResource> lro = await peeringRegisteredPrefix.UpdateAsync(WaitUntil.Completed, data);
            PeeringRegisteredPrefixResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringRegisteredPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Deletes a registered prefix associated with the peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeletesARegisteredPrefixAssociatedWithThePeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/DeleteRegisteredPrefix.json
            // this example is just showing the usage of "RegisteredPrefixes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PeeringRegisteredPrefixResource created on azure
            // for more information of creating PeeringRegisteredPrefixResource, please refer to the document of PeeringRegisteredPrefixResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            string peeringName = "peeringName";
            string registeredPrefixName = "registeredPrefixName";
            ResourceIdentifier peeringRegisteredPrefixResourceId = PeeringRegisteredPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, peeringName, registeredPrefixName);
            PeeringRegisteredPrefixResource peeringRegisteredPrefix = client.GetPeeringRegisteredPrefixResource(peeringRegisteredPrefixResourceId);

            // invoke the operation
            await peeringRegisteredPrefix.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Validate a registered prefix associated with the peering
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Validate_ValidateARegisteredPrefixAssociatedWithThePeering()
        {
            // Generated from example definition: specification/peering/resource-manager/Microsoft.Peering/stable/2022-10-01/examples/ValidateRegisteredPrefix.json
            // this example is just showing the usage of "RegisteredPrefixes_Validate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PeeringRegisteredPrefixResource created on azure
            // for more information of creating PeeringRegisteredPrefixResource, please refer to the document of PeeringRegisteredPrefixResource
            string subscriptionId = "subId";
            string resourceGroupName = "rgName";
            string peeringName = "peeringName";
            string registeredPrefixName = "registeredPrefixName";
            ResourceIdentifier peeringRegisteredPrefixResourceId = PeeringRegisteredPrefixResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, peeringName, registeredPrefixName);
            PeeringRegisteredPrefixResource peeringRegisteredPrefix = client.GetPeeringRegisteredPrefixResource(peeringRegisteredPrefixResourceId);

            // invoke the operation
            PeeringRegisteredPrefixResource result = await peeringRegisteredPrefix.ValidateAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PeeringRegisteredPrefixData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

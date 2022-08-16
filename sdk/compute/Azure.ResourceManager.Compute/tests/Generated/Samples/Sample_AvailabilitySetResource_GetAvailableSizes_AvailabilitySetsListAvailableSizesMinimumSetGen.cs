// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_AvailabilitySetResource_GetAvailableSizes_AvailabilitySetsListAvailableSizesMinimumSetGen
    {
        // AvailabilitySets_ListAvailableSizes_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAvailableSizes()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/availabilitySetExamples/AvailabilitySets_ListAvailableSizes_MinimumSet_Gen.json
            // this example is just showing the usage of "AvailabilitySets_ListAvailableSizes" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this AvailabilitySetResource created on azure
            // for more information of creating AvailabilitySetResource, please refer to the document of AvailabilitySetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string availabilitySetName = "aa";
            ResourceIdentifier availabilitySetResourceId = Compute.AvailabilitySetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, availabilitySetName);
            Compute.AvailabilitySetResource availabilitySet = client.GetAvailabilitySetResource(availabilitySetResourceId);

            // invoke the operation and iterate over the result
            await foreach (Compute.Models.VirtualMachineSize item in availabilitySet.GetAvailableSizesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

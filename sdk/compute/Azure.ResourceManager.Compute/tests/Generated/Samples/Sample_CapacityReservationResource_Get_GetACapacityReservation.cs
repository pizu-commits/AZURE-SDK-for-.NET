// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_CapacityReservationResource_Get_GetACapacityReservation
    {
        // Get a capacity reservation.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/capacityReservationExamples/CapacityReservation_Get.json
            // this example is just showing the usage of "CapacityReservations_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this CapacityReservationResource created on azure
            // for more information of creating CapacityReservationResource, please refer to the document of CapacityReservationResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string capacityReservationGroupName = "myCapacityReservationGroup";
            string capacityReservationName = "myCapacityReservation";
            ResourceIdentifier capacityReservationResourceId = Compute.CapacityReservationResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, capacityReservationGroupName, capacityReservationName);
            Compute.CapacityReservationResource capacityReservation = client.GetCapacityReservationResource(capacityReservationResourceId);

            // invoke the operation
            Compute.CapacityReservationResource result = await capacityReservation.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.CapacityReservationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

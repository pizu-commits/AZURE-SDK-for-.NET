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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_SubscriptionResourceExtensions_GetVirtualMachineImage_VirtualMachineImagesGetMinimumSetGen
    {
        // VirtualMachineImages_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetVirtualMachineImage()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/virtualMachineImageExamples/VirtualMachineImages_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineImages_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "{subscription-id}";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation
            AzureLocation location = new AzureLocation("aaaaaaaaaaaa");
            string publisherName = "aaaaaaaaaaa";
            string offer = "aa";
            string skus = "aaaaaaaaa";
            string version = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Compute.Models.VirtualMachineImage result = await subscriptionResource.GetVirtualMachineImageAsync(location, publisherName, offer, skus, version);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

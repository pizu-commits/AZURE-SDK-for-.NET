// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_DedicatedHostResource_Update_DedicatedHostsUpdateMaximumSetGen
    {
        // DedicatedHosts_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/dedicatedHostExamples/DedicatedHosts_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "DedicatedHosts_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostResource created on azure
            // for more information of creating DedicatedHostResource, please refer to the document of DedicatedHostResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaaaaaaa";
            string hostName = "aaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier dedicatedHostResourceId = Compute.DedicatedHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName, hostName);
            Compute.DedicatedHostResource dedicatedHost = client.GetDedicatedHostResource(dedicatedHostResourceId);

            // invoke the operation
            Compute.Models.DedicatedHostPatch patch = new DedicatedHostPatch()
            {
                PlatformFaultDomain = 1,
                AutoReplaceOnFailure = true,
                LicenseType = DedicatedHostLicenseType.WindowsServerHybrid,
                Tags =
{
["key8813"] = "aaaaaaaaaaaaaaaaaaaaaaaaaaa",
},
            };
            ArmOperation<Compute.DedicatedHostResource> lro = await dedicatedHost.UpdateAsync(WaitUntil.Completed, patch);
            Compute.DedicatedHostResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.DedicatedHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

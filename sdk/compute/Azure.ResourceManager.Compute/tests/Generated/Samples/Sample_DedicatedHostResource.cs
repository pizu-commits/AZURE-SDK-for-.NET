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
    public partial class Sample_DedicatedHostResource
    {
        // DedicatedHosts_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DedicatedHostsUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHosts_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "DedicatedHosts_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostResource created on azure
            // for more information of creating DedicatedHostResource, please refer to the document of DedicatedHostResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaaaaaaa";
            string hostName = "aaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier dedicatedHostResourceId = DedicatedHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName, hostName);
            DedicatedHostResource dedicatedHost = client.GetDedicatedHostResource(dedicatedHostResourceId);

            // invoke the operation
            DedicatedHostPatch patch = new DedicatedHostPatch()
            {
                PlatformFaultDomain = 1,
                AutoReplaceOnFailure = true,
                LicenseType = DedicatedHostLicenseType.WindowsServerHybrid,
                Tags =
{
["key8813"] = "aaaaaaaaaaaaaaaaaaaaaaaaaaa",
},
            };
            ArmOperation<DedicatedHostResource> lro = await dedicatedHost.UpdateAsync(WaitUntil.Completed, patch);
            DedicatedHostResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DedicatedHosts_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_DedicatedHostsUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHosts_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "DedicatedHosts_Update" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostResource created on azure
            // for more information of creating DedicatedHostResource, please refer to the document of DedicatedHostResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aa";
            string hostName = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier dedicatedHostResourceId = DedicatedHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName, hostName);
            DedicatedHostResource dedicatedHost = client.GetDedicatedHostResource(dedicatedHostResourceId);

            // invoke the operation
            DedicatedHostPatch patch = new DedicatedHostPatch();
            ArmOperation<DedicatedHostResource> lro = await dedicatedHost.UpdateAsync(WaitUntil.Completed, patch);
            DedicatedHostResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DedicatedHosts_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DedicatedHostsDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHosts_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "DedicatedHosts_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostResource created on azure
            // for more information of creating DedicatedHostResource, please refer to the document of DedicatedHostResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaaaa";
            string hostName = "aaaaaaaaaaaaaaa";
            ResourceIdentifier dedicatedHostResourceId = DedicatedHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName, hostName);
            DedicatedHostResource dedicatedHost = client.GetDedicatedHostResource(dedicatedHostResourceId);

            // invoke the operation
            await dedicatedHost.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // DedicatedHosts_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DedicatedHostsDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHosts_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "DedicatedHosts_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostResource created on azure
            // for more information of creating DedicatedHostResource, please refer to the document of DedicatedHostResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string hostGroupName = "aaaaaaaaaaaaaaa";
            string hostName = "aaaaa";
            ResourceIdentifier dedicatedHostResourceId = DedicatedHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName, hostName);
            DedicatedHostResource dedicatedHost = client.GetDedicatedHostResource(dedicatedHostResourceId);

            // invoke the operation
            await dedicatedHost.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get a dedicated host.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADedicatedHost()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHost_Get.json
            // this example is just showing the usage of "DedicatedHosts_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostResource created on azure
            // for more information of creating DedicatedHostResource, please refer to the document of DedicatedHostResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            string hostName = "myHost";
            ResourceIdentifier dedicatedHostResourceId = DedicatedHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName, hostName);
            DedicatedHostResource dedicatedHost = client.GetDedicatedHostResource(dedicatedHostResourceId);

            // invoke the operation
            DedicatedHostResource result = await dedicatedHost.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DedicatedHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Restart Dedicated Host.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Restart_RestartDedicatedHost()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-08-01/examples/dedicatedHostExamples/DedicatedHost_Restart.json
            // this example is just showing the usage of "DedicatedHosts_Restart" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DedicatedHostResource created on azure
            // for more information of creating DedicatedHostResource, please refer to the document of DedicatedHostResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string hostGroupName = "myDedicatedHostGroup";
            string hostName = "myHost";
            ResourceIdentifier dedicatedHostResourceId = DedicatedHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostGroupName, hostName);
            DedicatedHostResource dedicatedHost = client.GetDedicatedHostResource(dedicatedHostResourceId);

            // invoke the operation
            await dedicatedHost.RestartAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

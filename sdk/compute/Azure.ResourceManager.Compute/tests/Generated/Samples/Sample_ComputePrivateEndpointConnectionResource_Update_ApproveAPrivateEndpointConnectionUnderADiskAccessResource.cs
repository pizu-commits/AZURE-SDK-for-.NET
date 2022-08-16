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
    public partial class Sample_ComputePrivateEndpointConnectionResource_Update_ApproveAPrivateEndpointConnectionUnderADiskAccessResource
    {
        // Approve a Private Endpoint Connection under a disk access resource.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-02/DiskRP/examples/diskAccessExamples/DiskAccessPrivateEndpointConnection_Approve.json
            // this example is just showing the usage of "DiskAccesses_UpdateAPrivateEndpointConnection" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ComputePrivateEndpointConnectionResource created on azure
            // for more information of creating ComputePrivateEndpointConnectionResource, please refer to the document of ComputePrivateEndpointConnectionResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string diskAccessName = "myDiskAccess";
            string privateEndpointConnectionName = "myPrivateEndpointConnection";
            ResourceIdentifier computePrivateEndpointConnectionResourceId = Compute.ComputePrivateEndpointConnectionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, diskAccessName, privateEndpointConnectionName);
            Compute.ComputePrivateEndpointConnectionResource computePrivateEndpointConnection = client.GetComputePrivateEndpointConnectionResource(computePrivateEndpointConnectionResourceId);

            // invoke the operation
            Compute.ComputePrivateEndpointConnectionData data = new ComputePrivateEndpointConnectionData()
            {
                ConnectionState = new ComputePrivateLinkServiceConnectionState()
                {
                    Status = ComputePrivateEndpointServiceConnectionStatus.Approved,
                    Description = "Approving myPrivateEndpointConnection",
                },
            };
            ArmOperation<Compute.ComputePrivateEndpointConnectionResource> lro = await computePrivateEndpointConnection.UpdateAsync(WaitUntil.Completed, data);
            Compute.ComputePrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.ComputePrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

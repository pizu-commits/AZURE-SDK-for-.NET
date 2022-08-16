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

namespace Azure.ResourceManager.Compute
{
    public partial class Sample_RestorePointCollection_CreateOrUpdate_CopyARestorePointToADifferentRegion
    {
        // Copy a restore point to a different region
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoint_Copy_BetweenRegions.json
            // this example is just showing the usage of "RestorePoints_Create" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this RestorePointGroupResource created on azure
            // for more information of creating RestorePointGroupResource, please refer to the document of RestorePointGroupResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string restorePointGroupName = "rpcName";
            ResourceIdentifier restorePointGroupResourceId = Compute.RestorePointGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, restorePointGroupName);
            Compute.RestorePointGroupResource restorePointGroup = client.GetRestorePointGroupResource(restorePointGroupResourceId);

            // get the collection of this RestorePointResource
            Compute.RestorePointCollection collection = restorePointGroup.GetRestorePoints();

            // invoke the operation
            string restorePointName = "rpName";
            Compute.RestorePointData data = new RestorePointData()
            {
                SourceRestorePointId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/restorePointCollections/sourceRpcName/restorePoints/sourceRpName"),
            };
            ArmOperation<Compute.RestorePointResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, restorePointName, data);
            Compute.RestorePointResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.RestorePointData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

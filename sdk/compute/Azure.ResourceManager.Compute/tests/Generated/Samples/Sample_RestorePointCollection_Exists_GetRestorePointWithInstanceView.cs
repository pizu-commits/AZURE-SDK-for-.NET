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
    public partial class Sample_RestorePointCollection_Exists_GetRestorePointWithInstanceView
    {
        // Get restore point with instance view
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/restorePointExamples/RestorePoint_Get_WithInstanceView.json
            // this example is just showing the usage of "RestorePoints_Get" operation, for the dependent resources, they will have to be created separately.

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
            bool result = await collection.ExistsAsync(restorePointName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

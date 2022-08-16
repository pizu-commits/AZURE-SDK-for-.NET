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
    public partial class Sample_SshPublicKeyResource_Get_GetAnSshPublicKey
    {
        // Get an ssh public key.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/stable/2022-03-01/ComputeRP/examples/sshPublicKeyExamples/SshPublicKey_Get.json
            // this example is just showing the usage of "SshPublicKeys_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SshPublicKeyResource created on azure
            // for more information of creating SshPublicKeyResource, please refer to the document of SshPublicKeyResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "myResourceGroup";
            string sshPublicKeyName = "mySshPublicKeyName";
            ResourceIdentifier sshPublicKeyResourceId = Compute.SshPublicKeyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, sshPublicKeyName);
            Compute.SshPublicKeyResource sshPublicKey = client.GetSshPublicKeyResource(sshPublicKeyResourceId);

            // invoke the operation
            Compute.SshPublicKeyResource result = await sshPublicKey.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            Compute.SshPublicKeyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

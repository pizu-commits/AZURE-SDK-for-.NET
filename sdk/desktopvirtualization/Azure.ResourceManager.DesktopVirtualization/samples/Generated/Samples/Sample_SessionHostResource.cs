// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Samples
{
    public partial class Sample_SessionHostResource
    {
        // SessionHost_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SessionHostGet()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/SessionHost_Get.json
            // this example is just showing the usage of "SessionHosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SessionHostResource created on azure
            // for more information of creating SessionHostResource, please refer to the document of SessionHostResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            string sessionHostName = "sessionHost1.microsoft.com";
            ResourceIdentifier sessionHostResourceId = SessionHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName, sessionHostName);
            SessionHostResource sessionHost = client.GetSessionHostResource(sessionHostResourceId);

            // invoke the operation
            SessionHostResource result = await sessionHost.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SessionHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // SessionHost_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SessionHostDelete()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/SessionHost_Delete.json
            // this example is just showing the usage of "SessionHosts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SessionHostResource created on azure
            // for more information of creating SessionHostResource, please refer to the document of SessionHostResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            string sessionHostName = "sessionHost1.microsoft.com";
            ResourceIdentifier sessionHostResourceId = SessionHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName, sessionHostName);
            SessionHostResource sessionHost = client.GetSessionHostResource(sessionHostResourceId);

            // invoke the operation
            bool? force = true;
            await sessionHost.DeleteAsync(WaitUntil.Completed, force: force);

            Console.WriteLine($"Succeeded");
        }

        // SessionHost_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SessionHostUpdate()
        {
            // Generated from example definition: specification/desktopvirtualization/resource-manager/Microsoft.DesktopVirtualization/stable/2023-09-05/examples/SessionHost_Update.json
            // this example is just showing the usage of "SessionHosts_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SessionHostResource created on azure
            // for more information of creating SessionHostResource, please refer to the document of SessionHostResource
            string subscriptionId = "daefabc0-95b4-48b3-b645-8a753a63c4fa";
            string resourceGroupName = "resourceGroup1";
            string hostPoolName = "hostPool1";
            string sessionHostName = "sessionHost1.microsoft.com";
            ResourceIdentifier sessionHostResourceId = SessionHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, hostPoolName, sessionHostName);
            SessionHostResource sessionHost = client.GetSessionHostResource(sessionHostResourceId);

            // invoke the operation
            SessionHostPatch patch = new SessionHostPatch()
            {
                AllowNewSession = true,
                AssignedUser = "user1@microsoft.com",
                FriendlyName = "friendly",
            };
            bool? force = true;
            SessionHostResource result = await sessionHost.UpdateAsync(patch, force: force);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SessionHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

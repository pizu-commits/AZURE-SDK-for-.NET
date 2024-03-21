// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.Support.Samples
{
    public partial class Sample_SupportTicketNoSubCommunicationResource
    {
        // Get communication details for a no-subscription support ticket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetCommunicationDetailsForANoSubscriptionSupportTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/GetCommunicationDetailsForSupportTicket.json
            // this example is just showing the usage of "CommunicationsNoSubscription_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketNoSubCommunicationResource created on azure
            // for more information of creating SupportTicketNoSubCommunicationResource, please refer to the document of SupportTicketNoSubCommunicationResource
            string supportTicketName = "testticket";
            string communicationName = "testmessage";
            ResourceIdentifier supportTicketNoSubCommunicationResourceId = SupportTicketNoSubCommunicationResource.CreateResourceIdentifier(supportTicketName, communicationName);
            SupportTicketNoSubCommunicationResource supportTicketNoSubCommunication = client.GetSupportTicketNoSubCommunicationResource(supportTicketNoSubCommunicationResourceId);

            // invoke the operation
            SupportTicketNoSubCommunicationResource result = await supportTicketNoSubCommunication.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketCommunicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AddCommunicationToNoSubscriptionTicket
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_AddCommunicationToNoSubscriptionTicket()
        {
            // Generated from example definition: specification/support/resource-manager/Microsoft.Support/preview/2023-06-01-preview/examples/CreateNoSubscriptionSupportTicketCommunication.json
            // this example is just showing the usage of "CommunicationsNoSubscription_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SupportTicketNoSubCommunicationResource created on azure
            // for more information of creating SupportTicketNoSubCommunicationResource, please refer to the document of SupportTicketNoSubCommunicationResource
            string supportTicketName = "testticket";
            string communicationName = "testcommunication";
            ResourceIdentifier supportTicketNoSubCommunicationResourceId = SupportTicketNoSubCommunicationResource.CreateResourceIdentifier(supportTicketName, communicationName);
            SupportTicketNoSubCommunicationResource supportTicketNoSubCommunication = client.GetSupportTicketNoSubCommunicationResource(supportTicketNoSubCommunicationResourceId);

            // invoke the operation
            SupportTicketCommunicationData data = new SupportTicketCommunicationData()
            {
                Sender = "user@contoso.com",
                Subject = "This is a test message from a customer!",
                Body = "This is a test message from a customer!",
            };
            ArmOperation<SupportTicketNoSubCommunicationResource> lro = await supportTicketNoSubCommunication.UpdateAsync(WaitUntil.Completed, data);
            SupportTicketNoSubCommunicationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SupportTicketCommunicationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

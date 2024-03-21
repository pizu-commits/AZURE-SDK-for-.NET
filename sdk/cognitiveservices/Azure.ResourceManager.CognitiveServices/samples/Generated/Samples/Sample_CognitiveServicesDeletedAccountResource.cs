// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CognitiveServices.Samples
{
    public partial class Sample_CognitiveServicesDeletedAccountResource
    {
        // Get Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAccount()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/GetDeletedAccount.json
            // this example is just showing the usage of "DeletedAccounts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesDeletedAccountResource created on azure
            // for more information of creating CognitiveServicesDeletedAccountResource, please refer to the document of CognitiveServicesDeletedAccountResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            AzureLocation location = new AzureLocation("westus");
            string resourceGroupName = "myResourceGroup";
            string accountName = "myAccount";
            ResourceIdentifier cognitiveServicesDeletedAccountResourceId = CognitiveServicesDeletedAccountResource.CreateResourceIdentifier(subscriptionId, location, resourceGroupName, accountName);
            CognitiveServicesDeletedAccountResource cognitiveServicesDeletedAccount = client.GetCognitiveServicesDeletedAccountResource(cognitiveServicesDeletedAccountResourceId);

            // invoke the operation
            CognitiveServicesDeletedAccountResource result = await cognitiveServicesDeletedAccount.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CognitiveServicesAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Delete Account
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteAccount()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/PurgeDeletedAccount.json
            // this example is just showing the usage of "DeletedAccounts_Purge" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CognitiveServicesDeletedAccountResource created on azure
            // for more information of creating CognitiveServicesDeletedAccountResource, please refer to the document of CognitiveServicesDeletedAccountResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            AzureLocation location = new AzureLocation("westus");
            string resourceGroupName = "myResourceGroup";
            string accountName = "PropTest01";
            ResourceIdentifier cognitiveServicesDeletedAccountResourceId = CognitiveServicesDeletedAccountResource.CreateResourceIdentifier(subscriptionId, location, resourceGroupName, accountName);
            CognitiveServicesDeletedAccountResource cognitiveServicesDeletedAccount = client.GetCognitiveServicesDeletedAccountResource(cognitiveServicesDeletedAccountResourceId);

            // invoke the operation
            await cognitiveServicesDeletedAccount.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // List Deleted Accounts by Subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetDeletedAccounts_ListDeletedAccountsBySubscription()
        {
            // Generated from example definition: specification/cognitiveservices/resource-manager/Microsoft.CognitiveServices/stable/2023-05-01/examples/ListDeletedAccountsBySubscription.json
            // this example is just showing the usage of "DeletedAccounts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (CognitiveServicesDeletedAccountResource item in subscriptionResource.GetDeletedAccountsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CognitiveServicesAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing.Samples
{
    public partial class Sample_BillingProfileCollection
    {
        // BillingProfilesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_BillingProfilesGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesGet.json
            // this example is just showing the usage of "BillingProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingProfileResource
            BillingProfileCollection collection = billingAccount.GetBillingProfiles();

            // invoke the operation
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            BillingProfileResource result = await collection.GetAsync(billingProfileName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BillingProfilesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_BillingProfilesGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesGet.json
            // this example is just showing the usage of "BillingProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingProfileResource
            BillingProfileCollection collection = billingAccount.GetBillingProfiles();

            // invoke the operation
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            bool result = await collection.ExistsAsync(billingProfileName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // BillingProfilesGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_BillingProfilesGet()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesGet.json
            // this example is just showing the usage of "BillingProfiles_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingProfileResource
            BillingProfileCollection collection = billingAccount.GetBillingProfiles();

            // invoke the operation
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            NullableResponse<BillingProfileResource> response = await collection.GetIfExistsAsync(billingProfileName);
            BillingProfileResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingProfileData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // BillingProfilesCreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_BillingProfilesCreateOrUpdate()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesCreateOrUpdate.json
            // this example is just showing the usage of "BillingProfiles_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingProfileResource
            BillingProfileCollection collection = billingAccount.GetBillingProfiles();

            // invoke the operation
            string billingProfileName = "xxxx-xxxx-xxx-xxx";
            BillingProfileData data = new BillingProfileData()
            {
                Properties = new BillingProfileProperties()
                {
                    BillTo = new BillingAddressDetails("Test Address1", "US")
                    {
                        AddressLine2 = "Test Address2",
                        AddressLine3 = "Test Address3",
                        City = "City",
                        CompanyName = "Contoso",
                        Email = "abc@contoso.com",
                        FirstName = "Test",
                        LastName = "User",
                        PhoneNumber = "000-000-0000",
                        PostalCode = "00000",
                        Region = "WA",
                        IsValidAddress = true,
                    },
                    DisplayName = "Billing Profile 1",
                    EnabledAzurePlans =
{
new BillingAzurePlan()
{
SkuId = "0001",
},new BillingAzurePlan()
{
SkuId = "0002",
}
},
                    IsInvoiceEmailOptIn = true,
                    PoNumber = "ABC12345",
                    ShipTo = new BillingAddressDetails("Test Address1", "US")
                    {
                        AddressLine2 = "Test Address2",
                        AddressLine3 = "Test Address3",
                        City = "City",
                        CompanyName = "Contoso",
                        Email = "abc@contoso.com",
                        FirstName = "Test",
                        LastName = "User",
                        PhoneNumber = "000-000-0000",
                        PostalCode = "00000",
                        Region = "WA",
                        IsValidAddress = true,
                    },
                },
            };
            ArmOperation<BillingProfileResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, billingProfileName, data);
            BillingProfileResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BillingProfileData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // BillingProfilesListByBillingAccount
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_BillingProfilesListByBillingAccount()
        {
            // Generated from example definition: specification/billing/resource-manager/Microsoft.Billing/stable/2024-04-01/examples/billingProfilesListByBillingAccount.json
            // this example is just showing the usage of "BillingProfiles_ListByBillingAccount" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BillingAccountResource created on azure
            // for more information of creating BillingAccountResource, please refer to the document of BillingAccountResource
            string billingAccountName = "00000000-0000-0000-0000-000000000000:00000000-0000-0000-0000-000000000000_2019-05-31";
            ResourceIdentifier billingAccountResourceId = BillingAccountResource.CreateResourceIdentifier(billingAccountName);
            BillingAccountResource billingAccount = client.GetBillingAccountResource(billingAccountResourceId);

            // get the collection of this BillingProfileResource
            BillingProfileCollection collection = billingAccount.GetBillingProfiles();

            // invoke the operation and iterate over the result
            BillingProfileCollectionGetAllOptions options = new BillingProfileCollectionGetAllOptions() { };
            await foreach (BillingProfileResource item in collection.GetAllAsync(options))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BillingProfileData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}

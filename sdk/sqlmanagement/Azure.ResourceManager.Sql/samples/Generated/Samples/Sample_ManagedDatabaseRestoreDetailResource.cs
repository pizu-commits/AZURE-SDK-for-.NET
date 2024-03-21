// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_ManagedDatabaseRestoreDetailResource
    {
        // Managed database restore details.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ManagedDatabaseRestoreDetails()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2022-05-01-preview/examples/ManagedDatabaseRestoreDetails.json
            // this example is just showing the usage of "ManagedDatabaseRestoreDetails_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ManagedDatabaseRestoreDetailResource created on azure
            // for more information of creating ManagedDatabaseRestoreDetailResource, please refer to the document of ManagedDatabaseRestoreDetailResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string managedInstanceName = "managedInstance";
            string databaseName = "testdb";
            RestoreDetailsName restoreDetailsName = RestoreDetailsName.Default;
            ResourceIdentifier managedDatabaseRestoreDetailResourceId = ManagedDatabaseRestoreDetailResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, managedInstanceName, databaseName, restoreDetailsName);
            ManagedDatabaseRestoreDetailResource managedDatabaseRestoreDetail = client.GetManagedDatabaseRestoreDetailResource(managedDatabaseRestoreDetailResourceId);

            // invoke the operation
            ManagedDatabaseRestoreDetailResource result = await managedDatabaseRestoreDetail.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ManagedDatabaseRestoreDetailData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

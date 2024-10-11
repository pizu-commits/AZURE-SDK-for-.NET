// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppConfiguration.Samples
{
    public partial class Sample_DeletedAppConfigurationStoreResource
    {
        // DeletedConfigurationStores_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DeletedConfigurationStoresGet()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2024-05-01/examples/DeletedConfigurationStoresGet.json
            // this example is just showing the usage of "ConfigurationStores_GetDeleted" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeletedAppConfigurationStoreResource created on azure
            // for more information of creating DeletedAppConfigurationStoreResource, please refer to the document of DeletedAppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            AzureLocation location = new AzureLocation("westus");
            string configStoreName = "contoso";
            ResourceIdentifier deletedAppConfigurationStoreResourceId = DeletedAppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, location, configStoreName);
            DeletedAppConfigurationStoreResource deletedAppConfigurationStore = client.GetDeletedAppConfigurationStoreResource(deletedAppConfigurationStoreResourceId);

            // invoke the operation
            DeletedAppConfigurationStoreResource result = await deletedAppConfigurationStore.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DeletedAppConfigurationStoreData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Purge a deleted configuration store
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task PurgeDeleted_PurgeADeletedConfigurationStore()
        {
            // Generated from example definition: specification/appconfiguration/resource-manager/Microsoft.AppConfiguration/stable/2024-05-01/examples/DeletedConfigurationStoresPurge.json
            // this example is just showing the usage of "ConfigurationStores_PurgeDeleted" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DeletedAppConfigurationStoreResource created on azure
            // for more information of creating DeletedAppConfigurationStoreResource, please refer to the document of DeletedAppConfigurationStoreResource
            string subscriptionId = "c80fb759-c965-4c6a-9110-9b2b2d038882";
            AzureLocation location = new AzureLocation("westus");
            string configStoreName = "contoso";
            ResourceIdentifier deletedAppConfigurationStoreResourceId = DeletedAppConfigurationStoreResource.CreateResourceIdentifier(subscriptionId, location, configStoreName);
            DeletedAppConfigurationStoreResource deletedAppConfigurationStore = client.GetDeletedAppConfigurationStoreResource(deletedAppConfigurationStoreResourceId);

            // invoke the operation
            await deletedAppConfigurationStore.PurgeDeletedAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

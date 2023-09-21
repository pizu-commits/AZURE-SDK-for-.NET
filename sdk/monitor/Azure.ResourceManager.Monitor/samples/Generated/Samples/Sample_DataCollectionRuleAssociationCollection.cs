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
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Samples
{
    public partial class Sample_DataCollectionRuleAssociationCollection
    {
        // List associations for specified resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAssociationsForSpecifiedResource()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsListByResource.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_ListByResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            DataCollectionRuleAssociationCollection collection = client.GetDataCollectionRuleAssociations(scopeId);

            // invoke the operation and iterate over the result
            await foreach (DataCollectionRuleAssociationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataCollectionRuleAssociationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAssociation()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsGet.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            DataCollectionRuleAssociationCollection collection = client.GetDataCollectionRuleAssociations(scopeId);

            // invoke the operation
            string associationName = "myAssociation";
            DataCollectionRuleAssociationResource result = await collection.GetAsync(associationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataCollectionRuleAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAssociation()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsGet.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            DataCollectionRuleAssociationCollection collection = client.GetDataCollectionRuleAssociations(scopeId);

            // invoke the operation
            string associationName = "myAssociation";
            bool result = await collection.ExistsAsync(associationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAssociation()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsGet.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            DataCollectionRuleAssociationCollection collection = client.GetDataCollectionRuleAssociations(scopeId);

            // invoke the operation
            string associationName = "myAssociation";
            NullableResponse<DataCollectionRuleAssociationResource> response = await collection.GetIfExistsAsync(associationName);
            DataCollectionRuleAssociationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DataCollectionRuleAssociationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Create or update association
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateAssociation()
        {
            // Generated from example definition: specification/monitor/resource-manager/Microsoft.Insights/stable/2022-06-01/examples/DataCollectionRuleAssociationsCreate.json
            // this example is just showing the usage of "DataCollectionRuleAssociations_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this DataCollectionRuleAssociationResource
            string resourceUri = "subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachines/myVm";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/{0}", resourceUri));
            DataCollectionRuleAssociationCollection collection = client.GetDataCollectionRuleAssociations(scopeId);

            // invoke the operation
            string associationName = "myAssociation";
            DataCollectionRuleAssociationData data = new DataCollectionRuleAssociationData()
            {
                DataCollectionRuleId = new ResourceIdentifier("/subscriptions/703362b3-f278-4e4b-9179-c76eaf41ffc2/resourceGroups/myResourceGroup/providers/Microsoft.Insights/dataCollectionRules/myCollectionRule"),
            };
            ArmOperation<DataCollectionRuleAssociationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, associationName, data);
            DataCollectionRuleAssociationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DataCollectionRuleAssociationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

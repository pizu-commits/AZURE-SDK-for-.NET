// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.MachineLearning.Samples
{
    public partial class Sample_MachineLearningFeatureCollection
    {
        // List Feature.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListFeature()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Feature/list.json
            // this example is just showing the usage of "Features_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string featuresetName = "string";
            string featuresetVersion = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // get the collection of this MachineLearningFeatureResource
            MachineLearningFeatureCollection collection = machineLearningFeatureSetVersion.GetMachineLearningFeatures();

            // invoke the operation and iterate over the result
            string tags = "string";
            string featureName = "string";
            string description = "string";
            await foreach (MachineLearningFeatureResource item in collection.GetAllAsync(tags: tags, featureName: featureName, description: description))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningFeatureData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get Feature.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetFeature()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Feature/get.json
            // this example is just showing the usage of "Features_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string featuresetName = "string";
            string featuresetVersion = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // get the collection of this MachineLearningFeatureResource
            MachineLearningFeatureCollection collection = machineLearningFeatureSetVersion.GetMachineLearningFeatures();

            // invoke the operation
            string featureName = "string";
            MachineLearningFeatureResource result = await collection.GetAsync(featureName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MachineLearningFeatureData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Feature.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetFeature()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Feature/get.json
            // this example is just showing the usage of "Features_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string featuresetName = "string";
            string featuresetVersion = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // get the collection of this MachineLearningFeatureResource
            MachineLearningFeatureCollection collection = machineLearningFeatureSetVersion.GetMachineLearningFeatures();

            // invoke the operation
            string featureName = "string";
            bool result = await collection.ExistsAsync(featureName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Feature.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetFeature()
        {
            // Generated from example definition: specification/machinelearningservices/resource-manager/Microsoft.MachineLearningServices/preview/2023-06-01-preview/examples/Feature/get.json
            // this example is just showing the usage of "Features_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MachineLearningFeatureSetVersionResource created on azure
            // for more information of creating MachineLearningFeatureSetVersionResource, please refer to the document of MachineLearningFeatureSetVersionResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "test-rg";
            string workspaceName = "my-aml-workspace";
            string featuresetName = "string";
            string featuresetVersion = "string";
            ResourceIdentifier machineLearningFeatureSetVersionResourceId = MachineLearningFeatureSetVersionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion);
            MachineLearningFeatureSetVersionResource machineLearningFeatureSetVersion = client.GetMachineLearningFeatureSetVersionResource(machineLearningFeatureSetVersionResourceId);

            // get the collection of this MachineLearningFeatureResource
            MachineLearningFeatureCollection collection = machineLearningFeatureSetVersion.GetMachineLearningFeatures();

            // invoke the operation
            string featureName = "string";
            NullableResponse<MachineLearningFeatureResource> response = await collection.GetIfExistsAsync(featureName);
            MachineLearningFeatureResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MachineLearningFeatureData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

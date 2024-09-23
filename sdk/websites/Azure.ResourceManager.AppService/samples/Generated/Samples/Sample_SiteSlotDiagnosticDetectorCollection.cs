// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteSlotDiagnosticDetectorCollection
    {
        // List App Detectors
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAppDetectors()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_ListSiteDetectors.json
            // this example is just showing the usage of "Diagnostics_ListSiteDetectorsSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation and iterate over the result
            await foreach (SiteSlotDiagnosticDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DetectorDefinitionResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // List App Slot Detectors
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAppSlotDetectors()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_ListSiteDetectorsSlot.json
            // this example is just showing the usage of "Diagnostics_ListSiteDetectorsSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation and iterate over the result
            await foreach (SiteSlotDiagnosticDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DetectorDefinitionResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get App Detector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppDetector()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetector.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation
            string detectorName = "sitecrashes";
            SiteSlotDiagnosticDetectorResource result = await collection.GetAsync(detectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DetectorDefinitionResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Detector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAppDetector()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetector.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation
            string detectorName = "sitecrashes";
            bool result = await collection.ExistsAsync(detectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get App Detector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAppDetector()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetector.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "Production";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation
            string detectorName = "sitecrashes";
            NullableResponse<SiteSlotDiagnosticDetectorResource> response = await collection.GetIfExistsAsync(detectorName);
            SiteSlotDiagnosticDetectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DetectorDefinitionResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get App Slot Detector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppSlotDetector()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetectorSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation
            string detectorName = "sitecrashes";
            SiteSlotDiagnosticDetectorResource result = await collection.GetAsync(detectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DetectorDefinitionResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Slot Detector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAppSlotDetector()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetectorSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation
            string detectorName = "sitecrashes";
            bool result = await collection.ExistsAsync(detectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get App Slot Detector
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAppSlotDetector()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDetectorSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorSlot" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteSlotDiagnosticResource created on azure
            // for more information of creating SiteSlotDiagnosticResource, please refer to the document of SiteSlotDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string slot = "staging";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteSlotDiagnosticResourceId = SiteSlotDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, slot, diagnosticCategory);
            SiteSlotDiagnosticResource siteSlotDiagnostic = client.GetSiteSlotDiagnosticResource(siteSlotDiagnosticResourceId);

            // get the collection of this SiteSlotDiagnosticDetectorResource
            SiteSlotDiagnosticDetectorCollection collection = siteSlotDiagnostic.GetSiteSlotDiagnosticDetectors();

            // invoke the operation
            string detectorName = "sitecrashes";
            NullableResponse<SiteSlotDiagnosticDetectorResource> response = await collection.GetIfExistsAsync(detectorName);
            SiteSlotDiagnosticDetectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DetectorDefinitionResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}

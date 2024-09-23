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
    public partial class Sample_SiteDiagnosticResource
    {
        // Get App Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDiagnosticCategory.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteDiagnosticResource created on azure
            // for more information of creating SiteDiagnosticResource, please refer to the document of SiteDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteDiagnosticResourceId = SiteDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, diagnosticCategory);
            SiteDiagnosticResource siteDiagnostic = client.GetSiteDiagnosticResource(siteDiagnosticResourceId);

            // invoke the operation
            SiteDiagnosticResource result = await siteDiagnostic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticCategoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Slot Diagnostic Category
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppSlotDiagnosticCategory()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteDiagnosticCategorySlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDiagnosticCategory" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteDiagnosticResource created on azure
            // for more information of creating SiteDiagnosticResource, please refer to the document of SiteDiagnosticResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string diagnosticCategory = "availability";
            ResourceIdentifier siteDiagnosticResourceId = SiteDiagnosticResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, diagnosticCategory);
            SiteDiagnosticResource siteDiagnostic = client.GetSiteDiagnosticResource(siteDiagnosticResourceId);

            // invoke the operation
            SiteDiagnosticResource result = await siteDiagnostic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DiagnosticCategoryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

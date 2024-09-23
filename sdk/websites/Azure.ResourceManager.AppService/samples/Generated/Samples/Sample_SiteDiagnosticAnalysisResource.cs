// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteDiagnosticAnalysisResource
    {
        // Get App Analysis
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppAnalysis()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteAnalysis.json
            // this example is just showing the usage of "Diagnostics_GetSiteAnalysis" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteDiagnosticAnalysisResource created on azure
            // for more information of creating SiteDiagnosticAnalysisResource, please refer to the document of SiteDiagnosticAnalysisResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string diagnosticCategory = "availability";
            string analysisName = "appanalysis";
            ResourceIdentifier siteDiagnosticAnalysisResourceId = SiteDiagnosticAnalysisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, diagnosticCategory, analysisName);
            SiteDiagnosticAnalysisResource siteDiagnosticAnalysis = client.GetSiteDiagnosticAnalysisResource(siteDiagnosticAnalysisResourceId);

            // invoke the operation
            SiteDiagnosticAnalysisResource result = await siteDiagnosticAnalysis.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteAnalysisDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Slot Analysis
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppSlotAnalysis()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_GetSiteAnalysisSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteAnalysis" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteDiagnosticAnalysisResource created on azure
            // for more information of creating SiteDiagnosticAnalysisResource, please refer to the document of SiteDiagnosticAnalysisResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string diagnosticCategory = "availability";
            string analysisName = "appanalysis";
            ResourceIdentifier siteDiagnosticAnalysisResourceId = SiteDiagnosticAnalysisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, diagnosticCategory, analysisName);
            SiteDiagnosticAnalysisResource siteDiagnosticAnalysis = client.GetSiteDiagnosticAnalysisResource(siteDiagnosticAnalysisResourceId);

            // invoke the operation
            SiteDiagnosticAnalysisResource result = await siteDiagnosticAnalysis.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            WebSiteAnalysisDefinitionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Execute site analysis
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Execute_ExecuteSiteAnalysis()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_ExecuteSiteAnalysis.json
            // this example is just showing the usage of "Diagnostics_ExecuteSiteAnalysis" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteDiagnosticAnalysisResource created on azure
            // for more information of creating SiteDiagnosticAnalysisResource, please refer to the document of SiteDiagnosticAnalysisResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string diagnosticCategory = "availability";
            string analysisName = "apprestartanalyses";
            ResourceIdentifier siteDiagnosticAnalysisResourceId = SiteDiagnosticAnalysisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, diagnosticCategory, analysisName);
            SiteDiagnosticAnalysisResource siteDiagnosticAnalysis = client.GetSiteDiagnosticAnalysisResource(siteDiagnosticAnalysisResourceId);

            // invoke the operation
            DiagnosticAnalysis result = await siteDiagnosticAnalysis.ExecuteAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // Execute site slot analysis
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Execute_ExecuteSiteSlotAnalysis()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2023-12-01/examples/Diagnostics_ExecuteSiteAnalysisSlot.json
            // this example is just showing the usage of "Diagnostics_ExecuteSiteAnalysis" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SiteDiagnosticAnalysisResource created on azure
            // for more information of creating SiteDiagnosticAnalysisResource, please refer to the document of SiteDiagnosticAnalysisResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            string diagnosticCategory = "availability";
            string analysisName = "apprestartanalyses";
            ResourceIdentifier siteDiagnosticAnalysisResourceId = SiteDiagnosticAnalysisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName, diagnosticCategory, analysisName);
            SiteDiagnosticAnalysisResource siteDiagnosticAnalysis = client.GetSiteDiagnosticAnalysisResource(siteDiagnosticAnalysisResourceId);

            // invoke the operation
            DiagnosticAnalysis result = await siteDiagnosticAnalysis.ExecuteAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}

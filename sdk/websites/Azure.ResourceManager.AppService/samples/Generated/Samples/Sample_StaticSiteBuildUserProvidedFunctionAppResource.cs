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
    public partial class Sample_StaticSiteBuildUserProvidedFunctionAppResource
    {
        // Get details of the user provided function app registered with a static site build.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetDetailsOfTheUserProvidedFunctionAppRegisteredWithAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/GetUserProvidedFunctionAppForStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_GetUserProvidedFunctionAppForStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildUserProvidedFunctionAppResource created on azure
            // for more information of creating StaticSiteBuildUserProvidedFunctionAppResource, please refer to the document of StaticSiteBuildUserProvidedFunctionAppResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            string functionAppName = "testFunctionApp";
            ResourceIdentifier staticSiteBuildUserProvidedFunctionAppResourceId = StaticSiteBuildUserProvidedFunctionAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName, functionAppName);
            StaticSiteBuildUserProvidedFunctionAppResource staticSiteBuildUserProvidedFunctionApp = client.GetStaticSiteBuildUserProvidedFunctionAppResource(staticSiteBuildUserProvidedFunctionAppResourceId);

            // invoke the operation
            StaticSiteBuildUserProvidedFunctionAppResource result = await staticSiteBuildUserProvidedFunctionApp.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteUserProvidedFunctionAppData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Register a user provided function app with a static site build
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RegisterAUserProvidedFunctionAppWithAStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/RegisterUserProvidedFunctionAppWithStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_RegisterUserProvidedFunctionAppWithStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildUserProvidedFunctionAppResource created on azure
            // for more information of creating StaticSiteBuildUserProvidedFunctionAppResource, please refer to the document of StaticSiteBuildUserProvidedFunctionAppResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "default";
            string functionAppName = "testFunctionApp";
            ResourceIdentifier staticSiteBuildUserProvidedFunctionAppResourceId = StaticSiteBuildUserProvidedFunctionAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName, functionAppName);
            StaticSiteBuildUserProvidedFunctionAppResource staticSiteBuildUserProvidedFunctionApp = client.GetStaticSiteBuildUserProvidedFunctionAppResource(staticSiteBuildUserProvidedFunctionAppResourceId);

            // invoke the operation
            StaticSiteUserProvidedFunctionAppData data = new StaticSiteUserProvidedFunctionAppData()
            {
                FunctionAppResourceId = new ResourceIdentifier("/subscription/34adfa4f-cedf-4dc0-ba29-b6d1a69ab345/resourceGroups/functionRG/providers/Microsoft.Web/sites/testFunctionApp"),
                FunctionAppRegion = "West US 2",
            };
            bool? isForced = true;
            ArmOperation<StaticSiteBuildUserProvidedFunctionAppResource> lro = await staticSiteBuildUserProvidedFunctionApp.UpdateAsync(WaitUntil.Completed, data, isForced: isForced);
            StaticSiteBuildUserProvidedFunctionAppResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            StaticSiteUserProvidedFunctionAppData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Detach the user provided function app from the static site build.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DetachTheUserProvidedFunctionAppFromTheStaticSiteBuild()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/DetachUserProvidedFunctionAppFromStaticSiteBuild.json
            // this example is just showing the usage of "StaticSites_DetachUserProvidedFunctionAppFromStaticSiteBuild" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this StaticSiteBuildUserProvidedFunctionAppResource created on azure
            // for more information of creating StaticSiteBuildUserProvidedFunctionAppResource, please refer to the document of StaticSiteBuildUserProvidedFunctionAppResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "rg";
            string name = "testStaticSite0";
            string environmentName = "12";
            string functionAppName = "testFunctionApp";
            ResourceIdentifier staticSiteBuildUserProvidedFunctionAppResourceId = StaticSiteBuildUserProvidedFunctionAppResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, name, environmentName, functionAppName);
            StaticSiteBuildUserProvidedFunctionAppResource staticSiteBuildUserProvidedFunctionApp = client.GetStaticSiteBuildUserProvidedFunctionAppResource(staticSiteBuildUserProvidedFunctionAppResourceId);

            // invoke the operation
            await staticSiteBuildUserProvidedFunctionApp.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

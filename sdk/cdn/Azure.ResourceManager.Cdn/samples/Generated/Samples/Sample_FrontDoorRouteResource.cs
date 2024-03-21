// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Samples
{
    public partial class Sample_FrontDoorRouteResource
    {
        // Routes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_RoutesGet()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Routes_Get.json
            // this example is just showing the usage of "FrontDoorRoutes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRouteResource created on azure
            // for more information of creating FrontDoorRouteResource, please refer to the document of FrontDoorRouteResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            string routeName = "route1";
            ResourceIdentifier frontDoorRouteResourceId = FrontDoorRouteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName, routeName);
            FrontDoorRouteResource frontDoorRoute = client.GetFrontDoorRouteResource(frontDoorRouteResourceId);

            // invoke the operation
            FrontDoorRouteResource result = await frontDoorRoute.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRouteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Routes_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_RoutesUpdate()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Routes_Update.json
            // this example is just showing the usage of "FrontDoorRoutes_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRouteResource created on azure
            // for more information of creating FrontDoorRouteResource, please refer to the document of FrontDoorRouteResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            string routeName = "route1";
            ResourceIdentifier frontDoorRouteResourceId = FrontDoorRouteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName, routeName);
            FrontDoorRouteResource frontDoorRoute = client.GetFrontDoorRouteResource(frontDoorRouteResourceId);

            // invoke the operation
            FrontDoorRoutePatch patch = new FrontDoorRoutePatch()
            {
                CustomDomains =
{
new FrontDoorActivatedResourceInfo()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1/customDomains/domain1"),
}
},
                OriginGroupId = new ResourceIdentifier("/subscriptions/subid/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1/originGroups/originGroup1"),
                OriginPath = null,
                RuleSets =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/RG/providers/Microsoft.Cdn/profiles/profile1/ruleSets/ruleSet1"),
}
},
                SupportedProtocols =
{
FrontDoorEndpointProtocol.Https,FrontDoorEndpointProtocol.Http
},
                PatternsToMatch =
{
"/*"
},
                CacheConfiguration = new FrontDoorRouteCacheConfiguration()
                {
                    QueryStringCachingBehavior = FrontDoorQueryStringCachingBehavior.IgnoreQueryString,
                    CompressionSettings = new RouteCacheCompressionSettings()
                    {
                        ContentTypesToCompress =
{
"text/html","application/octet-stream"
},
                        IsCompressionEnabled = true,
                    },
                },
                ForwardingProtocol = ForwardingProtocol.MatchRequest,
                LinkToDefaultDomain = LinkToDefaultDomain.Enabled,
                HttpsRedirect = HttpsRedirect.Enabled,
                EnabledState = EnabledState.Enabled,
            };
            ArmOperation<FrontDoorRouteResource> lro = await frontDoorRoute.UpdateAsync(WaitUntil.Completed, patch);
            FrontDoorRouteResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FrontDoorRouteData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Routes_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_RoutesDelete()
        {
            // Generated from example definition: specification/cdn/resource-manager/Microsoft.Cdn/stable/2021-06-01/examples/Routes_Delete.json
            // this example is just showing the usage of "FrontDoorRoutes_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FrontDoorRouteResource created on azure
            // for more information of creating FrontDoorRouteResource, please refer to the document of FrontDoorRouteResource
            string subscriptionId = "subid";
            string resourceGroupName = "RG";
            string profileName = "profile1";
            string endpointName = "endpoint1";
            string routeName = "route1";
            ResourceIdentifier frontDoorRouteResourceId = FrontDoorRouteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, endpointName, routeName);
            FrontDoorRouteResource frontDoorRoute = client.GetFrontDoorRouteResource(frontDoorRouteResourceId);

            // invoke the operation
            await frontDoorRoute.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager.Samples
{
    public partial class Sample_TrafficManagerHeatMapResource
    {
        // HeatMap-GET
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HeatMapGET()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerHeatMapResource created on azure
            // for more information of creating TrafficManagerHeatMapResource, please refer to the document of TrafficManagerHeatMapResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            ResourceIdentifier trafficManagerHeatMapResourceId = TrafficManagerHeatMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, heatMapType);
            TrafficManagerHeatMapResource trafficManagerHeatMap = client.GetTrafficManagerHeatMapResource(trafficManagerHeatMapResourceId);

            // invoke the operation
            TrafficManagerHeatMapResource result = await trafficManagerHeatMap.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerHeatMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HeatMap-GET-With-Null-Values
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HeatMapGETWithNullValues()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-Null-Values.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerHeatMapResource created on azure
            // for more information of creating TrafficManagerHeatMapResource, please refer to the document of TrafficManagerHeatMapResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            ResourceIdentifier trafficManagerHeatMapResourceId = TrafficManagerHeatMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, heatMapType);
            TrafficManagerHeatMapResource trafficManagerHeatMap = client.GetTrafficManagerHeatMapResource(trafficManagerHeatMapResourceId);

            // invoke the operation
            TrafficManagerHeatMapResource result = await trafficManagerHeatMap.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerHeatMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // HeatMap-GET-With-TopLeft-BotRight
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_HeatMapGETWithTopLeftBotRight()
        {
            // Generated from example definition: specification/trafficmanager/resource-manager/Microsoft.Network/stable/2022-04-01/examples/HeatMap-GET-With-TopLeft-BotRight.json
            // this example is just showing the usage of "HeatMap_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this TrafficManagerHeatMapResource created on azure
            // for more information of creating TrafficManagerHeatMapResource, please refer to the document of TrafficManagerHeatMapResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "azuresdkfornetautoresttrafficmanager1323";
            string profileName = "azuresdkfornetautoresttrafficmanager3880";
            TrafficManagerHeatMapType heatMapType = TrafficManagerHeatMapType.Default;
            ResourceIdentifier trafficManagerHeatMapResourceId = TrafficManagerHeatMapResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, profileName, heatMapType);
            TrafficManagerHeatMapResource trafficManagerHeatMap = client.GetTrafficManagerHeatMapResource(trafficManagerHeatMapResourceId);

            // invoke the operation
            IEnumerable<double> topLeft = new double[]
            {
10,50.001
            };
            IEnumerable<double> botRight = new double[]
            {
-50.001,80
            };
            TrafficManagerHeatMapResource result = await trafficManagerHeatMap.GetAsync(topLeft: topLeft, botRight: botRight);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            TrafficManagerHeatMapData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformGatewayRouteConfig data model.
    /// Spring Cloud Gateway route config resource
    /// </summary>
    public partial class AppPlatformGatewayRouteConfigData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayRouteConfigData"/>. </summary>
        public AppPlatformGatewayRouteConfigData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayRouteConfigData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> API route config of the Spring Cloud Gateway. </param>
        internal AppPlatformGatewayRouteConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformGatewayRouteConfigProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> API route config of the Spring Cloud Gateway. </summary>
        public AppPlatformGatewayRouteConfigProperties Properties { get; set; }
    }
}

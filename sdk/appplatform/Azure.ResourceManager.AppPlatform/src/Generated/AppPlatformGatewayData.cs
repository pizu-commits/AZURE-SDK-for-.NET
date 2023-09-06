// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A class representing the AppPlatformGateway data model.
    /// Spring Cloud Gateway resource
    /// </summary>
    public partial class AppPlatformGatewayData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayData"/>. </summary>
        public AppPlatformGatewayData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Spring Cloud Gateway properties payload. </param>
        /// <param name="sku"> Sku of the Spring Cloud Gateway resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformGatewayData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformGatewayProperties properties, AppPlatformSku sku, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Sku = sku;
            _rawData = rawData;
        }

        /// <summary> Spring Cloud Gateway properties payload. </summary>
        public AppPlatformGatewayProperties Properties { get; set; }
        /// <summary> Sku of the Spring Cloud Gateway resource. </summary>
        public AppPlatformSku Sku { get; set; }
    }
}

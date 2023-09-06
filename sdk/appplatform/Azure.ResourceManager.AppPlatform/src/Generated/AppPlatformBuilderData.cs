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
    /// A class representing the AppPlatformBuilder data model.
    /// KPack Builder resource
    /// </summary>
    public partial class AppPlatformBuilderData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuilderData"/>. </summary>
        public AppPlatformBuilderData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformBuilderData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Property of the Builder resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformBuilderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AppPlatformBuilderProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Property of the Builder resource. </summary>
        public AppPlatformBuilderProperties Properties { get; set; }
    }
}

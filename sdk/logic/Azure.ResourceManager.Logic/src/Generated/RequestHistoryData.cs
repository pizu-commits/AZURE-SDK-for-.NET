// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary> A class representing the RequestHistory data model. </summary>
    public partial class RequestHistoryData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of RequestHistoryData. </summary>
        /// <param name="location"> The location. </param>
        public RequestHistoryData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of RequestHistoryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// The request history properties.
        /// Serialized Name: RequestHistory.properties
        /// </param>
        internal RequestHistoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, RequestHistoryProperties properties) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
        }

        /// <summary>
        /// The request history properties.
        /// Serialized Name: RequestHistory.properties
        /// </summary>
        public RequestHistoryProperties Properties { get; set; }
    }
}

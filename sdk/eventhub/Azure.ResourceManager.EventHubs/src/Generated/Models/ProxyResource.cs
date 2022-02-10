// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Common fields that are returned in the response for all Azure Resource Manager resources. </summary>
    public partial class ProxyResource : ResourceData
    {
        /// <summary> Initializes a new instance of ProxyResource. </summary>
        public ProxyResource()
        {
        }

        /// <summary> Initializes a new instance of ProxyResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal ProxyResource(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string location) : base(id, name, type, systemData)
        {
            Location = location;
        }

        /// <summary> The geo-location where the resource lives. </summary>
        public string Location { get; }
    }
}

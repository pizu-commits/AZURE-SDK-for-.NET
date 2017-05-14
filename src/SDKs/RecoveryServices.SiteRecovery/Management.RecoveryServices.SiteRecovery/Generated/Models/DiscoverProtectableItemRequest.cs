// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Request to add a physical machine as a protectable item in a container.
    /// </summary>
    public partial class DiscoverProtectableItemRequest
    {
        /// <summary>
        /// Initializes a new instance of the DiscoverProtectableItemRequest
        /// class.
        /// </summary>
        public DiscoverProtectableItemRequest() { }

        /// <summary>
        /// Initializes a new instance of the DiscoverProtectableItemRequest
        /// class.
        /// </summary>
        public DiscoverProtectableItemRequest(DiscoverProtectableItemRequestProperties properties = default(DiscoverProtectableItemRequestProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// The properties of a discover protectable item request.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DiscoverProtectableItemRequestProperties Properties { get; set; }

    }
}

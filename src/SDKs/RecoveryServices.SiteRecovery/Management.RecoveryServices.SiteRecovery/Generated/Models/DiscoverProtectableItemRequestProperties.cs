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
    /// Discover protectable item properties.
    /// </summary>
    public partial class DiscoverProtectableItemRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DiscoverProtectableItemRequestProperties class.
        /// </summary>
        public DiscoverProtectableItemRequestProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DiscoverProtectableItemRequestProperties class.
        /// </summary>
        public DiscoverProtectableItemRequestProperties(string friendlyName = default(string), string ipAddress = default(string), string osType = default(string))
        {
            FriendlyName = friendlyName;
            IpAddress = ipAddress;
            OsType = osType;
        }

        /// <summary>
        /// The friendly name of the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// The IP address of the physical machine to be discovered.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// The OS type on the physical machine.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

    }
}

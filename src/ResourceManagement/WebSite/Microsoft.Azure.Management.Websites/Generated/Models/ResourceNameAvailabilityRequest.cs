// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Resource name availability request content
    /// </summary>
    public partial class ResourceNameAvailabilityRequest
    {
        /// <summary>
        /// Initializes a new instance of the ResourceNameAvailabilityRequest
        /// class.
        /// </summary>
        public ResourceNameAvailabilityRequest() { }

        /// <summary>
        /// Initializes a new instance of the ResourceNameAvailabilityRequest
        /// class.
        /// </summary>
        public ResourceNameAvailabilityRequest(string name = default(string), string type = default(string), bool? isFqdn = default(bool?))
        {
            Name = name;
            Type = type;
            IsFqdn = isFqdn;
        }

        /// <summary>
        /// Resource name to verify
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Resource type used for verification
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Is fully qualified domain name
        /// </summary>
        [JsonProperty(PropertyName = "isFqdn")]
        public bool? IsFqdn { get; set; }

    }
}

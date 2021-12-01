// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Properties required to create or update an endpoint. </summary>
    public partial class AfdEndpointUpdateOptions
    {
        /// <summary> Initializes a new instance of AfdEndpointUpdateOptions. </summary>
        public AfdEndpointUpdateOptions()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Endpoint tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns. </summary>
        public int? OriginResponseTimeoutSeconds { get; set; }
        /// <summary> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? EnabledState { get; set; }
    }
}

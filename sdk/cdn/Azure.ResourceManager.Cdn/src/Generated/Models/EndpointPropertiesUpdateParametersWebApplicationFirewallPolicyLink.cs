// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the Web Application Firewall policy for the endpoint (if applicable). </summary>
    internal partial class EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink"/>. </summary>
        public EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(ResourceIdentifier id, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource ID. </summary>
        public ResourceIdentifier Id { get; set; }
    }
}

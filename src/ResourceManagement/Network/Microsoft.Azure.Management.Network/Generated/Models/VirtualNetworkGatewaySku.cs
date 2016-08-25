// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// VirtualNetworkGatewaySku details
    /// </summary>
    public partial class VirtualNetworkGatewaySku
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewaySku class.
        /// </summary>
        public VirtualNetworkGatewaySku() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewaySku class.
        /// </summary>
        public VirtualNetworkGatewaySku(string name = default(string), string tier = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
        }

        /// <summary>
        /// Gateway sku name -Basic/HighPerformance/Standard. Possible values
        /// include: 'Basic', 'HighPerformance', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gateway sku tier -Basic/HighPerformance/Standard. Possible values
        /// include: 'Basic', 'HighPerformance', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// The capacity
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}

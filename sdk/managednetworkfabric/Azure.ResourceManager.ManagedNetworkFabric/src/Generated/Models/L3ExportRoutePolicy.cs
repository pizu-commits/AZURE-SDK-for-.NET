// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Array of ARM Resource ID of the RoutePolicies. </summary>
    public partial class L3ExportRoutePolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="L3ExportRoutePolicy"/>. </summary>
        public L3ExportRoutePolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="L3ExportRoutePolicy"/>. </summary>
        /// <param name="exportIPv4RoutePolicyId"> ARM Resource ID of the RoutePolicy. </param>
        /// <param name="exportIPv6RoutePolicyId"> ARM Resource ID of the RoutePolicy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal L3ExportRoutePolicy(ResourceIdentifier exportIPv4RoutePolicyId, ResourceIdentifier exportIPv6RoutePolicyId, Dictionary<string, BinaryData> rawData)
        {
            ExportIPv4RoutePolicyId = exportIPv4RoutePolicyId;
            ExportIPv6RoutePolicyId = exportIPv6RoutePolicyId;
            _rawData = rawData;
        }

        /// <summary> ARM Resource ID of the RoutePolicy. </summary>
        public ResourceIdentifier ExportIPv4RoutePolicyId { get; set; }
        /// <summary> ARM Resource ID of the RoutePolicy. </summary>
        public ResourceIdentifier ExportIPv6RoutePolicyId { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> BGP configuration properties. </summary>
    public partial class InternalNetworkBgpConfiguration : BgpConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="InternalNetworkBgpConfiguration"/>. </summary>
        public InternalNetworkBgpConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InternalNetworkBgpConfiguration"/>. </summary>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="bfdConfiguration"> BFD configuration properties. </param>
        /// <param name="defaultRouteOriginate"> Originate a defaultRoute. Ex: "True" | "False". </param>
        /// <param name="allowAS"> Allows for routes to be received and processed even if the router detects its own ASN in the AS-Path. 0 is disable, Possible values are 1-10, default is 2. </param>
        /// <param name="allowASOverride"> Enable Or Disable state. </param>
        /// <param name="fabricAsn"> ASN of Network Fabric. Example: 65048. </param>
        /// <param name="peerAsn"> Peer ASN. Example: 65047. </param>
        /// <param name="ipv4ListenRangePrefixes"> List of BGP IPv4 Listen Range prefixes. </param>
        /// <param name="ipv6ListenRangePrefixes"> List of BGP IPv6 Listen Ranges prefixes. </param>
        /// <param name="ipv4NeighborAddress"> List with stringified IPv4 Neighbor Addresses. </param>
        /// <param name="ipv6NeighborAddress"> List with stringified IPv6 Neighbor Address. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InternalNetworkBgpConfiguration(string annotation, BfdConfiguration bfdConfiguration, NetworkFabricBooleanValue? defaultRouteOriginate, int? allowAS, AllowASOverride? allowASOverride, long? fabricAsn, long? peerAsn, IList<string> ipv4ListenRangePrefixes, IList<string> ipv6ListenRangePrefixes, IList<NeighborAddress> ipv4NeighborAddress, IList<NeighborAddress> ipv6NeighborAddress, Dictionary<string, BinaryData> rawData) : base(annotation, bfdConfiguration, defaultRouteOriginate, allowAS, allowASOverride, fabricAsn, peerAsn, ipv4ListenRangePrefixes, ipv6ListenRangePrefixes, ipv4NeighborAddress, ipv6NeighborAddress, rawData)
        {
        }
    }
}

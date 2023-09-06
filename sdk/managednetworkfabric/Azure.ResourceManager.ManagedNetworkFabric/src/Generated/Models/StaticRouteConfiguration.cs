// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Static Route Configuration properties. </summary>
    public partial class StaticRouteConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StaticRouteConfiguration"/>. </summary>
        public StaticRouteConfiguration()
        {
            IPv4Routes = new ChangeTrackingList<StaticRouteProperties>();
            IPv6Routes = new ChangeTrackingList<StaticRouteProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="StaticRouteConfiguration"/>. </summary>
        /// <param name="bfdConfiguration"> BFD configuration properties. </param>
        /// <param name="ipv4Routes"> List of IPv4 Routes. </param>
        /// <param name="ipv6Routes"> List of IPv6 Routes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticRouteConfiguration(BfdConfiguration bfdConfiguration, IList<StaticRouteProperties> ipv4Routes, IList<StaticRouteProperties> ipv6Routes, Dictionary<string, BinaryData> rawData)
        {
            BfdConfiguration = bfdConfiguration;
            IPv4Routes = ipv4Routes;
            IPv6Routes = ipv6Routes;
            _rawData = rawData;
        }

        /// <summary> BFD configuration properties. </summary>
        public BfdConfiguration BfdConfiguration { get; set; }
        /// <summary> List of IPv4 Routes. </summary>
        public IList<StaticRouteProperties> IPv4Routes { get; }
        /// <summary> List of IPv6 Routes. </summary>
        public IList<StaticRouteProperties> IPv6Routes { get; }
    }
}

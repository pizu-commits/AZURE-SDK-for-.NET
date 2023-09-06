// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Required inbound or outbound traffic for Azure Spring Apps resource. </summary>
    public partial class AppPlatformServiceRequiredTraffic
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformServiceRequiredTraffic"/>. </summary>
        internal AppPlatformServiceRequiredTraffic()
        {
            IPs = new ChangeTrackingList<IPAddress>();
            Fqdns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformServiceRequiredTraffic"/>. </summary>
        /// <param name="protocol"> The protocol of required traffic. </param>
        /// <param name="port"> The port of required traffic. </param>
        /// <param name="ips"> The ip list of required traffic. </param>
        /// <param name="fqdns"> The FQDN list of required traffic. </param>
        /// <param name="direction"> The direction of required traffic. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformServiceRequiredTraffic(string protocol, int? port, IReadOnlyList<IPAddress> ips, IReadOnlyList<string> fqdns, AppPlatformServiceTrafficDirection? direction, Dictionary<string, BinaryData> rawData)
        {
            Protocol = protocol;
            Port = port;
            IPs = ips;
            Fqdns = fqdns;
            Direction = direction;
            _rawData = rawData;
        }

        /// <summary> The protocol of required traffic. </summary>
        public string Protocol { get; }
        /// <summary> The port of required traffic. </summary>
        public int? Port { get; }
        /// <summary> The ip list of required traffic. </summary>
        public IReadOnlyList<IPAddress> IPs { get; }
        /// <summary> The FQDN list of required traffic. </summary>
        public IReadOnlyList<string> Fqdns { get; }
        /// <summary> The direction of required traffic. </summary>
        public AppPlatformServiceTrafficDirection? Direction { get; }
    }
}

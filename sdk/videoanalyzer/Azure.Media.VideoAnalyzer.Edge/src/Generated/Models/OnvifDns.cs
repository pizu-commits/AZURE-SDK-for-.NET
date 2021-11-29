// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The ONVIF device DNS properties. </summary>
    public partial class OnvifDns
    {
        /// <summary> Initializes a new instance of OnvifDns. </summary>
        public OnvifDns()
        {
            Ipv4Address = new ChangeTrackingList<string>();
            Ipv6Address = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of OnvifDns. </summary>
        /// <param name="fromDhcp"> Result value showing if the ONVIF device is configured to use DHCP. </param>
        /// <param name="ipv4Address"> An array of IPv4 address for the discovered ONVIF device. </param>
        /// <param name="ipv6Address"> An array of IPv6 address for the discovered ONVIF device. </param>
        internal OnvifDns(bool? fromDhcp, IList<string> ipv4Address, IList<string> ipv6Address)
        {
            FromDhcp = fromDhcp;
            Ipv4Address = ipv4Address;
            Ipv6Address = ipv6Address;
        }

        /// <summary> Result value showing if the ONVIF device is configured to use DHCP. </summary>
        public bool? FromDhcp { get; set; }
        /// <summary> An array of IPv4 address for the discovered ONVIF device. </summary>
        public IList<string> Ipv4Address { get; }
        /// <summary> An array of IPv6 address for the discovered ONVIF device. </summary>
        public IList<string> Ipv6Address { get; }
    }
}

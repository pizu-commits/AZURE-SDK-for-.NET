// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A list of NSX dhcp entities. </summary>
    internal partial class WorkloadNetworkDhcpList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpList"/>. </summary>
        internal WorkloadNetworkDhcpList()
        {
            Value = new ChangeTrackingList<WorkloadNetworkDhcpData>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkDhcpList"/>. </summary>
        /// <param name="value"> The items on the page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadNetworkDhcpList(IReadOnlyList<WorkloadNetworkDhcpData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The items on the page. </summary>
        public IReadOnlyList<WorkloadNetworkDhcpData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}

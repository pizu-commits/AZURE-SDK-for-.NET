// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of Neighbor Group. </summary>
    internal partial class NeighborGroupsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NeighborGroupsListResult"/>. </summary>
        internal NeighborGroupsListResult()
        {
            Value = new ChangeTrackingList<NetworkFabricNeighborGroupData>();
        }

        /// <summary> Initializes a new instance of <see cref="NeighborGroupsListResult"/>. </summary>
        /// <param name="value"> List of Neighbor Group resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NeighborGroupsListResult(IReadOnlyList<NetworkFabricNeighborGroupData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Neighbor Group resources. </summary>
        public IReadOnlyList<NetworkFabricNeighborGroupData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}

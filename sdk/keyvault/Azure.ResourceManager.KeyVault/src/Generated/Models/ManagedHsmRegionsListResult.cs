// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of regions associated with a managed HSM Pools. </summary>
    internal partial class ManagedHsmRegionsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedHsmRegionsListResult"/>. </summary>
        internal ManagedHsmRegionsListResult()
        {
            Value = new ChangeTrackingList<ManagedHsmGeoReplicatedRegion>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedHsmRegionsListResult"/>. </summary>
        /// <param name="value"> The region associated with a managed HSM Pools. </param>
        /// <param name="nextLink"> The URL to get the next set of managed HSM Pools. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedHsmRegionsListResult(IReadOnlyList<ManagedHsmGeoReplicatedRegion> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The region associated with a managed HSM Pools. </summary>
        public IReadOnlyList<ManagedHsmGeoReplicatedRegion> Value { get; }
        /// <summary> The URL to get the next set of managed HSM Pools. </summary>
        public string NextLink { get; }
    }
}

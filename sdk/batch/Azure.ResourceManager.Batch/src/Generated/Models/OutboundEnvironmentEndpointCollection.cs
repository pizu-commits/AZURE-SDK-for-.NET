// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class OutboundEnvironmentEndpointCollection
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpointCollection"/>. </summary>
        internal OutboundEnvironmentEndpointCollection()
        {
            Value = new ChangeTrackingList<BatchAccountOutboundEnvironmentEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="OutboundEnvironmentEndpointCollection"/>. </summary>
        /// <param name="value"> The collection of outbound network dependency endpoints returned by the listing operation. </param>
        /// <param name="nextLink"> The continuation token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundEnvironmentEndpointCollection(IReadOnlyList<BatchAccountOutboundEnvironmentEndpoint> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The collection of outbound network dependency endpoints returned by the listing operation. </summary>
        public IReadOnlyList<BatchAccountOutboundEnvironmentEndpoint> Value { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}

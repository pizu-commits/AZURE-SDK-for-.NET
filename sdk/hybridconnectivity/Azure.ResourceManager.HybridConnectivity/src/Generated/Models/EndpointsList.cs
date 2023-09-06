// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridConnectivity;

namespace Azure.ResourceManager.HybridConnectivity.Models
{
    /// <summary> The list of endpoints. </summary>
    internal partial class EndpointsList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EndpointsList"/>. </summary>
        internal EndpointsList()
        {
            Value = new ChangeTrackingList<EndpointResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="EndpointsList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of endpoints list. </param>
        /// <param name="value"> The list of endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EndpointsList(string nextLink, IReadOnlyList<EndpointResourceData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of endpoints list. </summary>
        public string NextLink { get; }
        /// <summary> The list of endpoint. </summary>
        public IReadOnlyList<EndpointResourceData> Value { get; }
    }
}

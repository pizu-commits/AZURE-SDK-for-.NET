// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> A list of private endpoint connections. </summary>
    internal partial class CognitiveServicesPrivateEndpointConnectionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesPrivateEndpointConnectionListResult"/>. </summary>
        internal CognitiveServicesPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<CognitiveServicesPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> Array of private endpoint connections. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesPrivateEndpointConnectionListResult(IReadOnlyList<CognitiveServicesPrivateEndpointConnectionData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Array of private endpoint connections. </summary>
        public IReadOnlyList<CognitiveServicesPrivateEndpointConnectionData> Value { get; }
    }
}

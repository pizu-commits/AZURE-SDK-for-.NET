// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class CognitiveServicesPrivateLinkResourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesPrivateLinkResourceListResult"/>. </summary>
        internal CognitiveServicesPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<CognitiveServicesPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CognitiveServicesPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CognitiveServicesPrivateLinkResourceListResult(IReadOnlyList<CognitiveServicesPrivateLinkResource> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<CognitiveServicesPrivateLinkResource> Value { get; }
    }
}

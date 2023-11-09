// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Descriptions of APIM policies. </summary>
    internal partial class PolicyDescriptionListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PolicyDescriptionListResult"/>. </summary>
        internal PolicyDescriptionListResult()
        {
            Value = new ChangeTrackingList<PolicyDescriptionContractData>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicyDescriptionListResult"/>. </summary>
        /// <param name="value"> Descriptions of APIM policies. </param>
        /// <param name="count"> Total record count number. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyDescriptionListResult(IReadOnlyList<PolicyDescriptionContractData> value, long? count, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            Count = count;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Descriptions of APIM policies. </summary>
        public IReadOnlyList<PolicyDescriptionContractData> Value { get; }
        /// <summary> Total record count number. </summary>
        public long? Count { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Cognitive Services account commitment quota. </summary>
    public partial class CommitmentQuota
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CommitmentQuota"/>. </summary>
        internal CommitmentQuota()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CommitmentQuota"/>. </summary>
        /// <param name="quantity"> Commitment quota quantity. </param>
        /// <param name="unit"> Commitment quota unit. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CommitmentQuota(long? quantity, string unit, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Quantity = quantity;
            Unit = unit;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Commitment quota quantity. </summary>
        public long? Quantity { get; }
        /// <summary> Commitment quota unit. </summary>
        public string Unit { get; }
    }
}

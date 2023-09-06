// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The list of cognitive services accounts operation response. </summary>
    internal partial class CommitmentTierListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommitmentTierListResult"/>. </summary>
        internal CommitmentTierListResult()
        {
            Value = new ChangeTrackingList<CommitmentTier>();
        }

        /// <summary> Initializes a new instance of <see cref="CommitmentTierListResult"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of CommitmentTier. </param>
        /// <param name="value"> Gets the list of Cognitive Services accounts CommitmentTier and their properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommitmentTierListResult(string nextLink, IReadOnlyList<CommitmentTier> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of CommitmentTier. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of Cognitive Services accounts CommitmentTier and their properties. </summary>
        public IReadOnlyList<CommitmentTier> Value { get; }
    }
}

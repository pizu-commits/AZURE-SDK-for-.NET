// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The abuse penalty. </summary>
    public partial class AbusePenalty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AbusePenalty"/>. </summary>
        internal AbusePenalty()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AbusePenalty"/>. </summary>
        /// <param name="action"> The action of AbusePenalty. </param>
        /// <param name="rateLimitPercentage"> The percentage of rate limit. </param>
        /// <param name="expiration"> The datetime of expiration of the AbusePenalty. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AbusePenalty(AbusePenaltyAction? action, float? rateLimitPercentage, DateTimeOffset? expiration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Action = action;
            RateLimitPercentage = rateLimitPercentage;
            Expiration = expiration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The action of AbusePenalty. </summary>
        public AbusePenaltyAction? Action { get; }
        /// <summary> The percentage of rate limit. </summary>
        public float? RateLimitPercentage { get; }
        /// <summary> The datetime of expiration of the AbusePenalty. </summary>
        public DateTimeOffset? Expiration { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The ServiceAccountThrottlingRule. </summary>
    public partial class ServiceAccountThrottlingRule
    {
        /// <summary> Initializes a new instance of ServiceAccountThrottlingRule. </summary>
        internal ServiceAccountThrottlingRule()
        {
            MatchPatterns = new ChangeTrackingList<ServiceAccountThrottlingMatchPattern>();
        }

        /// <summary> Initializes a new instance of ServiceAccountThrottlingRule. </summary>
        /// <param name="key"></param>
        /// <param name="renewalPeriod"></param>
        /// <param name="count"></param>
        /// <param name="minCount"></param>
        /// <param name="isDynamicThrottlingEnabled"></param>
        /// <param name="matchPatterns"></param>
        internal ServiceAccountThrottlingRule(string key, float? renewalPeriod, float? count, float? minCount, bool? isDynamicThrottlingEnabled, IReadOnlyList<ServiceAccountThrottlingMatchPattern> matchPatterns)
        {
            Key = key;
            RenewalPeriod = renewalPeriod;
            Count = count;
            MinCount = minCount;
            IsDynamicThrottlingEnabled = isDynamicThrottlingEnabled;
            MatchPatterns = matchPatterns;
        }

        /// <summary> Gets the key. </summary>
        public string Key { get; }
        /// <summary> Gets the renewal period. </summary>
        public float? RenewalPeriod { get; }
        /// <summary> Gets the count. </summary>
        public float? Count { get; }
        /// <summary> Gets the min count. </summary>
        public float? MinCount { get; }
        /// <summary> Gets the is dynamic throttling enabled. </summary>
        public bool? IsDynamicThrottlingEnabled { get; }
        /// <summary> Gets the match patterns. </summary>
        public IReadOnlyList<ServiceAccountThrottlingMatchPattern> MatchPatterns { get; }
    }
}

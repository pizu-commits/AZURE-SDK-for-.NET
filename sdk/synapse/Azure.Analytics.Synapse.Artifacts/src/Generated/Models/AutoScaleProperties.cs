// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Auto-scaling properties of a Big Data pool powered by Apache Spark. </summary>
    public partial class AutoScaleProperties
    {
        /// <summary> Initializes a new instance of <see cref="AutoScaleProperties"/>. </summary>
        public AutoScaleProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutoScaleProperties"/>. </summary>
        /// <param name="minNodeCount"> The minimum number of nodes the Big Data pool can support. </param>
        /// <param name="enabled"> Whether automatic scaling is enabled for the Big Data pool. </param>
        /// <param name="maxNodeCount"> The maximum number of nodes the Big Data pool can support. </param>
        internal AutoScaleProperties(int? minNodeCount, bool? enabled, int? maxNodeCount)
        {
            MinNodeCount = minNodeCount;
            Enabled = enabled;
            MaxNodeCount = maxNodeCount;
        }

        /// <summary> The minimum number of nodes the Big Data pool can support. </summary>
        public int? MinNodeCount { get; set; }
        /// <summary> Whether automatic scaling is enabled for the Big Data pool. </summary>
        public bool? Enabled { get; set; }
        /// <summary> The maximum number of nodes the Big Data pool can support. </summary>
        public int? MaxNodeCount { get; set; }
    }
}

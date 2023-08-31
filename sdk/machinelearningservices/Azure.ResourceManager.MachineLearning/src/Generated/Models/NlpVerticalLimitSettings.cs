// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job execution constraints. </summary>
    public partial class NlpVerticalLimitSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NlpVerticalLimitSettings"/>. </summary>
        public NlpVerticalLimitSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NlpVerticalLimitSettings"/>. </summary>
        /// <param name="maxConcurrentTrials"> Maximum Concurrent AutoML iterations. </param>
        /// <param name="maxTrials"> Number of AutoML iterations. </param>
        /// <param name="timeout"> AutoML job timeout. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NlpVerticalLimitSettings(int? maxConcurrentTrials, int? maxTrials, TimeSpan? timeout, Dictionary<string, BinaryData> rawData)
        {
            MaxConcurrentTrials = maxConcurrentTrials;
            MaxTrials = maxTrials;
            Timeout = timeout;
            _rawData = rawData;
        }

        /// <summary> Maximum Concurrent AutoML iterations. </summary>
        public int? MaxConcurrentTrials { get; set; }
        /// <summary> Number of AutoML iterations. </summary>
        public int? MaxTrials { get; set; }
        /// <summary> AutoML job timeout. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}

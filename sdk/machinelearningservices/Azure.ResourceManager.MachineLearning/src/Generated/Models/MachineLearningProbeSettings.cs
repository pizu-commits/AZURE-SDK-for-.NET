// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Deployment container liveness/readiness probe configuration. </summary>
    public partial class MachineLearningProbeSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningProbeSettings"/>. </summary>
        public MachineLearningProbeSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningProbeSettings"/>. </summary>
        /// <param name="failureThreshold"> The number of failures to allow before returning an unhealthy status. </param>
        /// <param name="initialDelay"> The delay before the first probe in ISO 8601 format. </param>
        /// <param name="period"> The length of time between probes in ISO 8601 format. </param>
        /// <param name="successThreshold"> The number of successful probes before returning a healthy status. </param>
        /// <param name="timeout"> The probe timeout in ISO 8601 format. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningProbeSettings(int? failureThreshold, TimeSpan? initialDelay, TimeSpan? period, int? successThreshold, TimeSpan? timeout, Dictionary<string, BinaryData> rawData)
        {
            FailureThreshold = failureThreshold;
            InitialDelay = initialDelay;
            Period = period;
            SuccessThreshold = successThreshold;
            Timeout = timeout;
            _rawData = rawData;
        }

        /// <summary> The number of failures to allow before returning an unhealthy status. </summary>
        public int? FailureThreshold { get; set; }
        /// <summary> The delay before the first probe in ISO 8601 format. </summary>
        public TimeSpan? InitialDelay { get; set; }
        /// <summary> The length of time between probes in ISO 8601 format. </summary>
        public TimeSpan? Period { get; set; }
        /// <summary> The number of successful probes before returning a healthy status. </summary>
        public int? SuccessThreshold { get; set; }
        /// <summary> The probe timeout in ISO 8601 format. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}

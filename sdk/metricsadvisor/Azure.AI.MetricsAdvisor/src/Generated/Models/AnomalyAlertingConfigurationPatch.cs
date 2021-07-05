// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyAlertingConfigurationPatch. </summary>
    internal partial class AnomalyAlertingConfigurationPatch
    {
        /// <summary> Initializes a new instance of AnomalyAlertingConfigurationPatch. </summary>
        public AnomalyAlertingConfigurationPatch()
        {
            SplitAlertByDimensions = new ChangeTrackingList<string>();
            HookIds = new ChangeTrackingList<Guid>();
            MetricAlertingConfigurations = new ChangeTrackingList<MetricAlertConfiguration>();
        }

        /// <summary> Anomaly alerting configuration name. </summary>
        public string Name { get; set; }
        /// <summary> anomaly alerting configuration description. </summary>
        public string Description { get; set; }
        /// <summary> cross metrics operator. </summary>
        public DetectionConditionOperator? CrossMetricsOperator { get; set; }
        /// <summary> dimensions used to split alert. </summary>
        public IList<string> SplitAlertByDimensions { get; }
    }
}

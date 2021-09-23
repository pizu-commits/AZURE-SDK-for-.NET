// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The WholeMetricConfigurationPatch. </summary>
    internal partial class WholeMetricConfigurationPatch
    {
        /// <summary> Initializes a new instance of WholeMetricConfigurationPatch. </summary>
        public WholeMetricConfigurationPatch()
        {
        }

        /// <summary>
        /// condition operator
        /// 
        /// should be specified when combining multiple detection conditions
        /// </summary>
        public DetectionConditionOperator? ConditionOperator { get; set; }
        /// <summary> Gets or sets the smart detection condition. </summary>
        public SmartDetectionConditionPatch SmartDetectionCondition { get; set; }
        /// <summary> Gets or sets the hard threshold condition. </summary>
        public HardThresholdConditionPatch HardThresholdCondition { get; set; }
        /// <summary> Gets or sets the change threshold condition. </summary>
        public ChangeThresholdConditionPatch ChangeThresholdCondition { get; set; }
    }
}

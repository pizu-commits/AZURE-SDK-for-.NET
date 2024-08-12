// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DimensionGroupConfiguration. </summary>
    public partial class MetricSeriesGroupDetectionCondition : MetricWholeSeriesDetectionCondition
    {
        /// <summary> Initializes a new instance of <see cref="MetricSeriesGroupDetectionCondition"/>. </summary>
        /// <param name="conditionOperator">
        /// condition operator
        ///
        /// should be specified when combining multiple detection conditions
        /// </param>
        /// <param name="smartDetectionCondition"></param>
        /// <param name="hardThresholdCondition"></param>
        /// <param name="changeThresholdCondition"></param>
        /// <param name="seriesGroupKey"></param>
        internal MetricSeriesGroupDetectionCondition(DetectionConditionOperator? conditionOperator, SmartDetectionCondition smartDetectionCondition, HardThresholdCondition hardThresholdCondition, ChangeThresholdCondition changeThresholdCondition, DimensionKey seriesGroupKey) : base(conditionOperator, smartDetectionCondition, hardThresholdCondition, changeThresholdCondition)
        {
            SeriesGroupKey = seriesGroupKey;
        }
    }
}

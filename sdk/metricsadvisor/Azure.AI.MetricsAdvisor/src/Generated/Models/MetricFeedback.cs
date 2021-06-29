// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor.Models;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> The MetricFeedback. </summary>
    public partial class MetricFeedback
    {
        /// <summary> Initializes a new instance of MetricFeedback. </summary>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricId"/> or <paramref name="dimensionFilter"/> is null. </exception>
        public MetricFeedback(string metricId, FeedbackDimensionFilter dimensionFilter)
        {
            if (metricId == null)
            {
                throw new ArgumentNullException(nameof(metricId));
            }
            if (dimensionFilter == null)
            {
                throw new ArgumentNullException(nameof(dimensionFilter));
            }

            MetricId = metricId;
            DimensionFilter = dimensionFilter;
        }
    }
}

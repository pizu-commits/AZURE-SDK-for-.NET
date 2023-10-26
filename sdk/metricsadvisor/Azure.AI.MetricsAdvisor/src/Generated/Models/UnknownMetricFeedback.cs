// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> Unknown version of MetricFeedback. </summary>
    internal partial class UnknownMetricFeedback : MetricFeedback
    {
        /// <summary> Initializes a new instance of UnknownMetricFeedback. </summary>
        /// <param name="feedbackKind"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdOn"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"></param>
        internal UnknownMetricFeedback(MetricFeedbackKind feedbackKind, string id, DateTimeOffset? createdOn, string userPrincipal, string metricId, FeedbackFilter dimensionFilter) : base(feedbackKind, id, createdOn, userPrincipal, metricId, dimensionFilter)
        {
            FeedbackKind = feedbackKind;
        }
    }
}

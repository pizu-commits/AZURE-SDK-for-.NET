// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Criterion for dynamic threshold.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DynamicThresholdCriterion")]
    public partial class DynamicMetricCriteria : MultiMetricCriteria
    {
        /// <summary>
        /// Initializes a new instance of the DynamicMetricCriteria class.
        /// </summary>
        public DynamicMetricCriteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicMetricCriteria class.
        /// </summary>
        /// <param name="name">Name of the criteria.</param>
        /// <param name="metricName">Name of the metric.</param>
        /// <param name="timeAggregation">the criteria time aggregation
        /// types.</param>
        /// <param name="operatorProperty">The operator used to compare the
        /// metric value against the threshold.</param>
        /// <param name="alertSensitivity">The extent of deviation required to
        /// trigger an alert. This will affect how tight the threshold is to
        /// the metric series pattern.</param>
        /// <param name="failingPeriods">The minimum number of violations
        /// required within the selected lookback time window required to raise
        /// an alert.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="metricNamespace">Namespace of the metric.</param>
        /// <param name="dimensions">List of dimension conditions.</param>
        /// <param name="ignoreDataBefore">Use this option to set the date from
        /// which to start learning the metric historical data and calculate
        /// the dynamic thresholds (in ISO8601 format)</param>
        public DynamicMetricCriteria(string name, string metricName, object timeAggregation, object operatorProperty, object alertSensitivity, DynamicThresholdFailingPeriods failingPeriods, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string metricNamespace = default(string), IList<MetricDimension> dimensions = default(IList<MetricDimension>), System.DateTime? ignoreDataBefore = default(System.DateTime?))
            : base(name, metricName, timeAggregation, additionalProperties, metricNamespace, dimensions)
        {
            OperatorProperty = operatorProperty;
            AlertSensitivity = alertSensitivity;
            FailingPeriods = failingPeriods;
            IgnoreDataBefore = ignoreDataBefore;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operator used to compare the metric value against
        /// the threshold.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public object OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets the extent of deviation required to trigger an alert.
        /// This will affect how tight the threshold is to the metric series
        /// pattern.
        /// </summary>
        [JsonProperty(PropertyName = "alertSensitivity")]
        public object AlertSensitivity { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of violations required within the
        /// selected lookback time window required to raise an alert.
        /// </summary>
        [JsonProperty(PropertyName = "failingPeriods")]
        public DynamicThresholdFailingPeriods FailingPeriods { get; set; }

        /// <summary>
        /// Gets or sets use this option to set the date from which to start
        /// learning the metric historical data and calculate the dynamic
        /// thresholds (in ISO8601 format)
        /// </summary>
        [JsonProperty(PropertyName = "ignoreDataBefore")]
        public System.DateTime? IgnoreDataBefore { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (OperatorProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatorProperty");
            }
            if (AlertSensitivity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AlertSensitivity");
            }
            if (FailingPeriods == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FailingPeriods");
            }
            if (FailingPeriods != null)
            {
                FailingPeriods.Validate();
            }
        }
    }
}

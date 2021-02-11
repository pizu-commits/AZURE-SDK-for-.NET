// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MixedReality.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifications of the Metrics for Azure Monitoring
    /// </summary>
    public partial class MetricSpecification
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        public MetricSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        /// <param name="name">Name of the metric</param>
        /// <param name="displayName">Localized friendly display name of the
        /// metric</param>
        /// <param name="displayDescription">Localized friendly description of
        /// the metric</param>
        /// <param name="unit">Unit that makes sense for the metric</param>
        /// <param name="aggregationType">Only provide one value for this
        /// field. Valid values: Average, Minimum, Maximum, Total,
        /// Count.</param>
        /// <param name="internalMetricName">Internal metric name.</param>
        /// <param name="dimensions">Dimensions of the metric</param>
        public MetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), string internalMetricName = default(string), IList<MetricDimension> dimensions = default(IList<MetricDimension>))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            InternalMetricName = internalMetricName;
            Dimensions = dimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the metric
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets localized friendly display name of the metric
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized friendly description of the metric
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets unit that makes sense for the metric
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets only provide one value for this field. Valid values:
        /// Average, Minimum, Maximum, Total, Count.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets internal metric name.
        /// </summary>
        [JsonProperty(PropertyName = "internalMetricName")]
        public string InternalMetricName { get; set; }

        /// <summary>
        /// Gets or sets dimensions of the metric
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<MetricDimension> Dimensions { get; set; }

    }
}

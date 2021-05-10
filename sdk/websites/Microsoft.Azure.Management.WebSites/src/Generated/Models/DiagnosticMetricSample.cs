// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing Diagnostic Metric
    /// </summary>
    public partial class DiagnosticMetricSample
    {
        /// <summary>
        /// Initializes a new instance of the DiagnosticMetricSample class.
        /// </summary>
        public DiagnosticMetricSample()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiagnosticMetricSample class.
        /// </summary>
        /// <param name="timestamp">Time at which metric is measured</param>
        /// <param name="roleInstance">Role Instance. Null if this counter is
        /// not per instance
        /// This is returned and should be whichever instance name we desire to
        /// be returned
        /// i.e. CPU and Memory return RDWORKERNAME (LargeDed..._IN_0)
        /// where RDWORKERNAME is Machine name below and RoleInstance name in
        /// parenthesis</param>
        /// <param name="total">Total value of the metric. If multiple
        /// measurements are made this will have sum of all.</param>
        /// <param name="maximum">Maximum of the metric sampled during the time
        /// period</param>
        /// <param name="minimum">Minimum of the metric sampled during the time
        /// period</param>
        /// <param name="isAggregated">Whether the values are aggregates across
        /// all workers or not</param>
        public DiagnosticMetricSample(System.DateTime? timestamp = default(System.DateTime?), string roleInstance = default(string), double? total = default(double?), double? maximum = default(double?), double? minimum = default(double?), bool? isAggregated = default(bool?))
        {
            Timestamp = timestamp;
            RoleInstance = roleInstance;
            Total = total;
            Maximum = maximum;
            Minimum = minimum;
            IsAggregated = isAggregated;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time at which metric is measured
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or sets role Instance. Null if this counter is not per
        /// instance
        /// This is returned and should be whichever instance name we desire to
        /// be returned
        /// i.e. CPU and Memory return RDWORKERNAME (LargeDed..._IN_0)
        /// where RDWORKERNAME is Machine name below and RoleInstance name in
        /// parenthesis
        /// </summary>
        [JsonProperty(PropertyName = "roleInstance")]
        public string RoleInstance { get; set; }

        /// <summary>
        /// Gets or sets total value of the metric. If multiple measurements
        /// are made this will have sum of all.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public double? Total { get; set; }

        /// <summary>
        /// Gets or sets maximum of the metric sampled during the time period
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public double? Maximum { get; set; }

        /// <summary>
        /// Gets or sets minimum of the metric sampled during the time period
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        /// Gets or sets whether the values are aggregates across all workers
        /// or not
        /// </summary>
        [JsonProperty(PropertyName = "isAggregated")]
        public bool? IsAggregated { get; set; }

    }
}

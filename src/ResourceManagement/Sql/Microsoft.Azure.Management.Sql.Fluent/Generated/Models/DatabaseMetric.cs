// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Azure.Management.Sql.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents Azure SQL Database metrics.
    /// </summary>
    public partial class DatabaseMetric
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseMetric class.
        /// </summary>
        public DatabaseMetric()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseMetric class.
        /// </summary>
        /// <param name="resourceName">The name of the resource.</param>
        /// <param name="displayName">The metric display name.</param>
        /// <param name="currentValue">The current value of the metric.</param>
        /// <param name="limit">The current limit of the metric.</param>
        /// <param name="unit">The units of the metric.</param>
        /// <param name="nextResetTime">The next reset time for the metric
        /// (ISO8601 format).</param>
        public DatabaseMetric(string resourceName = default(string), string displayName = default(string), double? currentValue = default(double?), double? limit = default(double?), string unit = default(string), System.DateTime? nextResetTime = default(System.DateTime?))
        {
            ResourceName = resourceName;
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            NextResetTime = nextResetTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourceName")]
        public string ResourceName { get; private set; }

        /// <summary>
        /// Gets the metric display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the current value of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public double? CurrentValue { get; private set; }

        /// <summary>
        /// Gets the current limit of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public double? Limit { get; private set; }

        /// <summary>
        /// Gets the units of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; private set; }

        /// <summary>
        /// Gets the next reset time for the metric (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "nextResetTime")]
        public System.DateTime? NextResetTime { get; private set; }

    }
}

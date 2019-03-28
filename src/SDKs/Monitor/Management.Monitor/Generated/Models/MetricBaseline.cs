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
    /// The baseline results of a specific metric.
    /// </summary>
    public partial class MetricBaseline
    {
        /// <summary>
        /// Initializes a new instance of the MetricBaseline class.
        /// </summary>
        public MetricBaseline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricBaseline class.
        /// </summary>
        /// <param name="id">the metric baseline Id.</param>
        /// <param name="type">the resource type of the metric baseline
        /// resource.</param>
        /// <param name="metricName">the name of the metric.</param>
        /// <param name="baselines">the baseline for each time series that was
        /// queried.</param>
        public MetricBaseline(string id, string type, string metricName, IList<TimeSeriesBaseline> baselines)
        {
            Id = id;
            Type = type;
            MetricName = metricName;
            Baselines = baselines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the metric baseline Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets the resource type of the metric baseline resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; private set; }

        /// <summary>
        /// Gets or sets the baseline for each time series that was queried.
        /// </summary>
        [JsonProperty(PropertyName = "baselines")]
        public IList<TimeSeriesBaseline> Baselines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Baselines == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Baselines");
            }
            if (Baselines != null)
            {
                foreach (var element in Baselines)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}

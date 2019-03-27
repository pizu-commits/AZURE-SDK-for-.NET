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
    /// Specifies the criteria for converting log to metric.
    /// </summary>
    public partial class Criteria
    {
        /// <summary>
        /// Initializes a new instance of the Criteria class.
        /// </summary>
        public Criteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Criteria class.
        /// </summary>
        /// <param name="metricName">Name of the metric</param>
        /// <param name="dimensions">List of Dimensions for creating
        /// metric</param>
        public Criteria(string metricName, IList<Dimension> dimensions = default(IList<Dimension>))
        {
            MetricName = metricName;
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
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }

        /// <summary>
        /// Gets or sets list of Dimensions for creating metric
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MetricName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetricName");
            }
            if (Dimensions != null)
            {
                foreach (var element in Dimensions)
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

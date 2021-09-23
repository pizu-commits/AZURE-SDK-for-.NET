// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metric configuration.
    /// </summary>
    public partial class MetricConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the MetricConfiguration class.
        /// </summary>
        public MetricConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricConfiguration class.
        /// </summary>
        /// <param name="resourceId">The Resource ID on which the metrics
        /// should be pushed.</param>
        /// <param name="counterSets">Host name for the IoT hub associated to
        /// the device.</param>
        /// <param name="mdmAccount">The MDM account to which the counters
        /// should be pushed.</param>
        /// <param name="metricNameSpace">The MDM namespace to which the
        /// counters should be pushed. This is required if MDMAccount is
        /// specified</param>
        public MetricConfiguration(string resourceId, IList<MetricCounterSet> counterSets, string mdmAccount = default(string), string metricNameSpace = default(string))
        {
            ResourceId = resourceId;
            MdmAccount = mdmAccount;
            MetricNameSpace = metricNameSpace;
            CounterSets = counterSets;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Resource ID on which the metrics should be pushed.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the MDM account to which the counters should be
        /// pushed.
        /// </summary>
        [JsonProperty(PropertyName = "mdmAccount")]
        public string MdmAccount { get; set; }

        /// <summary>
        /// Gets or sets the MDM namespace to which the counters should be
        /// pushed. This is required if MDMAccount is specified
        /// </summary>
        [JsonProperty(PropertyName = "metricNameSpace")]
        public string MetricNameSpace { get; set; }

        /// <summary>
        /// Gets or sets host name for the IoT hub associated to the device.
        /// </summary>
        [JsonProperty(PropertyName = "counterSets")]
        public IList<MetricCounterSet> CounterSets { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceId");
            }
            if (CounterSets == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CounterSets");
            }
            if (CounterSets != null)
            {
                foreach (var element in CounterSets)
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

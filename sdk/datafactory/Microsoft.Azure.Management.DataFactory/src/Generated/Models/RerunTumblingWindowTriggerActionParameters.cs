// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Rerun tumbling window trigger Parameters.
    /// </summary>
    public partial class RerunTumblingWindowTriggerActionParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RerunTumblingWindowTriggerActionParameters class.
        /// </summary>
        public RerunTumblingWindowTriggerActionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RerunTumblingWindowTriggerActionParameters class.
        /// </summary>
        /// <param name="startTime">The start time for the time period for
        /// which restatement is initiated. Only UTC time is currently
        /// supported.</param>
        /// <param name="endTime">The end time for the time period for which
        /// restatement is initiated. Only UTC time is currently
        /// supported.</param>
        /// <param name="maxConcurrency">The max number of parallel time
        /// windows (ready for execution) for which a rerun is
        /// triggered.</param>
        public RerunTumblingWindowTriggerActionParameters(System.DateTime startTime, System.DateTime endTime, int maxConcurrency)
        {
            StartTime = startTime;
            EndTime = endTime;
            MaxConcurrency = maxConcurrency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start time for the time period for which
        /// restatement is initiated. Only UTC time is currently supported.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the time period for which restatement
        /// is initiated. Only UTC time is currently supported.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the max number of parallel time windows (ready for
        /// execution) for which a rerun is triggered.
        /// </summary>
        [JsonProperty(PropertyName = "maxConcurrency")]
        public int MaxConcurrency { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxConcurrency > 50)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxConcurrency", 50);
            }
            if (MaxConcurrency < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxConcurrency", 1);
            }
        }
    }
}

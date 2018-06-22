// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.4.36.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A list activity runs.
    /// </summary>
    public partial class ActivityRunsQueryResponse
    {
        /// <summary>
        /// Initializes a new instance of the ActivityRunsQueryResponse class.
        /// </summary>
        public ActivityRunsQueryResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityRunsQueryResponse class.
        /// </summary>
        /// <param name="value">List of activity runs.</param>
        /// <param name="continuationToken">The continuation token for getting
        /// the next page of results, if any remaining results exist, null
        /// otherwise.</param>
        public ActivityRunsQueryResponse(IList<ActivityRun> value, string continuationToken = default(string))
        {
            Value = value;
            ContinuationToken = continuationToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of activity runs.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ActivityRun> Value { get; set; }

        /// <summary>
        /// Gets or sets the continuation token for getting the next page of
        /// results, if any remaining results exist, null otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}

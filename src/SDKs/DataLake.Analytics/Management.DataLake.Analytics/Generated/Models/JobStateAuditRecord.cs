// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Data Lake Analytics job state audit records for tracking the
    /// lifecycle of a job.
    /// </summary>
    public partial class JobStateAuditRecord
    {
        /// <summary>
        /// Initializes a new instance of the JobStateAuditRecord class.
        /// </summary>
        public JobStateAuditRecord()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStateAuditRecord class.
        /// </summary>
        /// <param name="newState">the new state the job is in.</param>
        /// <param name="timeStamp">the time stamp that the state change took
        /// place.</param>
        /// <param name="requestedByUser">the user who requests the
        /// change.</param>
        /// <param name="details">the details of the audit log.</param>
        public JobStateAuditRecord(string newState = default(string), System.DateTimeOffset? timeStamp = default(System.DateTimeOffset?), string requestedByUser = default(string), string details = default(string))
        {
            NewState = newState;
            TimeStamp = timeStamp;
            RequestedByUser = requestedByUser;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the new state the job is in.
        /// </summary>
        [JsonProperty(PropertyName = "newState")]
        public string NewState { get; private set; }

        /// <summary>
        /// Gets the time stamp that the state change took place.
        /// </summary>
        [JsonProperty(PropertyName = "timeStamp")]
        public System.DateTimeOffset? TimeStamp { get; private set; }

        /// <summary>
        /// Gets the user who requests the change.
        /// </summary>
        [JsonProperty(PropertyName = "requestedByUser")]
        public string RequestedByUser { get; private set; }

        /// <summary>
        /// Gets the details of the audit log.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; private set; }

    }
}

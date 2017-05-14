// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Model class for event details of a job status event.
    /// </summary>
    [JsonObject("JobStatus")]
    public partial class JobStatusEventDetails : EventSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobStatusEventDetails class.
        /// </summary>
        public JobStatusEventDetails() { }

        /// <summary>
        /// Initializes a new instance of the JobStatusEventDetails class.
        /// </summary>
        public JobStatusEventDetails(string jobId = default(string), string jobFriendlyName = default(string), string jobStatus = default(string), string affectedObjectType = default(string))
        {
            JobId = jobId;
            JobFriendlyName = jobFriendlyName;
            JobStatus = jobStatus;
            AffectedObjectType = affectedObjectType;
        }

        /// <summary>
        /// Job arm id for the event.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// JobName for the Event.
        /// </summary>
        [JsonProperty(PropertyName = "jobFriendlyName")]
        public string JobFriendlyName { get; set; }

        /// <summary>
        /// JobStatus for the  Event.
        /// </summary>
        [JsonProperty(PropertyName = "jobStatus")]
        public string JobStatus { get; set; }

        /// <summary>
        /// AffectedObjectType for the event.
        /// </summary>
        [JsonProperty(PropertyName = "affectedObjectType")]
        public string AffectedObjectType { get; set; }

    }
}

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
    /// This class contains the error details per object.
    /// </summary>
    public partial class JobErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        public JobErrorDetails() { }

        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        public JobErrorDetails(ServiceError serviceErrorDetails = default(ServiceError), ProviderError providerErrorDetails = default(ProviderError), string errorLevel = default(string), DateTime? creationTime = default(DateTime?), string taskId = default(string))
        {
            ServiceErrorDetails = serviceErrorDetails;
            ProviderErrorDetails = providerErrorDetails;
            ErrorLevel = errorLevel;
            CreationTime = creationTime;
            TaskId = taskId;
        }

        /// <summary>
        /// The Service error details.
        /// </summary>
        [JsonProperty(PropertyName = "serviceErrorDetails")]
        public ServiceError ServiceErrorDetails { get; set; }

        /// <summary>
        /// The Provider error details.
        /// </summary>
        [JsonProperty(PropertyName = "providerErrorDetails")]
        public ProviderError ProviderErrorDetails { get; set; }

        /// <summary>
        /// Error level of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorLevel")]
        public string ErrorLevel { get; set; }

        /// <summary>
        /// The creation time of job error.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// The Id of the task.
        /// </summary>
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

    }
}

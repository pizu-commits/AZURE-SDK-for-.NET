// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class contains the error details per object. </summary>
    public partial class JobErrorDetails
    {
        /// <summary> Initializes a new instance of JobErrorDetails. </summary>
        internal JobErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of JobErrorDetails. </summary>
        /// <param name="serviceErrorDetails"> The Service error details. </param>
        /// <param name="providerErrorDetails"> The Provider error details. </param>
        /// <param name="errorLevel"> Error level of error. </param>
        /// <param name="createdOn"> The creation time of job error. </param>
        /// <param name="taskId"> The Id of the task. </param>
        internal JobErrorDetails(ServiceError serviceErrorDetails, ProviderError providerErrorDetails, string errorLevel, DateTimeOffset? createdOn, string taskId)
        {
            ServiceErrorDetails = serviceErrorDetails;
            ProviderErrorDetails = providerErrorDetails;
            ErrorLevel = errorLevel;
            CreatedOn = createdOn;
            TaskId = taskId;
        }

        /// <summary> The Service error details. </summary>
        public ServiceError ServiceErrorDetails { get; }
        /// <summary> The Provider error details. </summary>
        public ProviderError ProviderErrorDetails { get; }
        /// <summary> Error level of error. </summary>
        public string ErrorLevel { get; }
        /// <summary> The creation time of job error. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The Id of the task. </summary>
        public string TaskId { get; }
    }
}

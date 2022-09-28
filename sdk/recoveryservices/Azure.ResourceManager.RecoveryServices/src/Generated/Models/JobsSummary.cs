// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Summary of the replication job data for this vault. </summary>
    public partial class JobsSummary
    {
        /// <summary> Initializes a new instance of JobsSummary. </summary>
        internal JobsSummary()
        {
        }

        /// <summary> Initializes a new instance of JobsSummary. </summary>
        /// <param name="failedJobs"> Count of failed jobs. </param>
        /// <param name="suspendedJobs"> Count of suspended jobs. </param>
        /// <param name="inProgressJobs"> Count of in-progress jobs. </param>
        internal JobsSummary(int? failedJobs, int? suspendedJobs, int? inProgressJobs)
        {
            FailedJobs = failedJobs;
            SuspendedJobs = suspendedJobs;
            InProgressJobs = inProgressJobs;
        }

        /// <summary> Count of failed jobs. </summary>
        public int? FailedJobs { get; }
        /// <summary> Count of suspended jobs. </summary>
        public int? SuspendedJobs { get; }
        /// <summary> Count of in-progress jobs. </summary>
        public int? InProgressJobs { get; }
    }
}

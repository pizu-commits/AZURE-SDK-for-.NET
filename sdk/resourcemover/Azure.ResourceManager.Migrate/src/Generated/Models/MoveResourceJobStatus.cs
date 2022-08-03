// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary>
    /// Defines the job status.
    /// Serialized Name: JobStatus
    /// </summary>
    public partial class MoveResourceJobStatus
    {
        /// <summary> Initializes a new instance of MoveResourceJobStatus. </summary>
        internal MoveResourceJobStatus()
        {
        }

        /// <summary> Initializes a new instance of MoveResourceJobStatus. </summary>
        /// <param name="jobName">
        /// Defines the job name.
        /// Serialized Name: JobStatus.jobName
        /// </param>
        /// <param name="jobProgress">
        /// Gets or sets the monitoring job percentage.
        /// Serialized Name: JobStatus.jobProgress
        /// </param>
        internal MoveResourceJobStatus(MoveResourceJobName? jobName, string jobProgress)
        {
            JobName = jobName;
            JobProgress = jobProgress;
        }

        /// <summary>
        /// Defines the job name.
        /// Serialized Name: JobStatus.jobName
        /// </summary>
        public MoveResourceJobName? JobName { get; }
        /// <summary>
        /// Gets or sets the monitoring job percentage.
        /// Serialized Name: JobStatus.jobProgress
        /// </summary>
        public string JobProgress { get; }
    }
}

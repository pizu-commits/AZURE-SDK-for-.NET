// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> A unit of work to be routed. </summary>
    public partial class RouterJob
    {
        /// <summary> Initializes a new instance of RouterJob. </summary>
        public RouterJob()
        {
            RequestedWorkerSelectors = new ChangeTrackingList<WorkerSelector>();
            AttachedWorkerSelectors = new ChangeTrackingList<WorkerSelector>();
            _labels = new ChangeTrackingDictionary<string, object>();
            Assignments = new ChangeTrackingDictionary<string, JobAssignment>();
            _tags = new ChangeTrackingDictionary<string, object>();
            _notes = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of RouterJob. </summary>
        /// <param name="id"> The id of the job. </param>
        /// <param name="channelReference"> Reference to an external parent context, eg. call ID. </param>
        /// <param name="jobStatus"> The state of the Job. </param>
        /// <param name="enqueueTimeUtc"> The time a job was queued. </param>
        /// <param name="channelId"> The channel identifier. eg. voice, chat, etc. </param>
        /// <param name="classificationPolicyId"> The Id of the Classification policy used for classifying a job. </param>
        /// <param name="queueId"> The Id of the Queue that this job is queued to. </param>
        /// <param name="priority"> The priority of this job. </param>
        /// <param name="dispositionCode"> Reason code for cancelled or closed jobs. </param>
        /// <param name="requestedWorkerSelectors"> A collection of manually specified label selectors, which a worker must satisfy in order to process this job. </param>
        /// <param name="attachedWorkerSelectors"> A collection of label selectors attached by a classification policy, which a worker must satisfy in order to process this job. </param>
        /// <param name="labels"> A set of key/value pairs that are identifying attributes used by the rules engines to make decisions. </param>
        /// <param name="assignments">
        /// A collection of the assignments of the job.
        /// Key is AssignmentId.
        /// </param>
        /// <param name="tags"> A set of non-identifying attributes attached to this job. </param>
        /// <param name="notes"> Notes attached to a job, sorted by timestamp. </param>
        internal RouterJob(string id, string channelReference, JobStatus? jobStatus, DateTimeOffset? enqueueTimeUtc, string channelId, string classificationPolicyId, string queueId, int? priority, string dispositionCode, IList<WorkerSelector> requestedWorkerSelectors, IReadOnlyList<WorkerSelector> attachedWorkerSelectors, IDictionary<string, object> labels, IReadOnlyDictionary<string, JobAssignment> assignments, IDictionary<string, object> tags, IDictionary<string, string> notes)
        {
            Id = id;
            ChannelReference = channelReference;
            JobStatus = jobStatus;
            EnqueueTimeUtc = enqueueTimeUtc;
            ChannelId = channelId;
            ClassificationPolicyId = classificationPolicyId;
            QueueId = queueId;
            Priority = priority;
            DispositionCode = dispositionCode;
            RequestedWorkerSelectors = requestedWorkerSelectors;
            AttachedWorkerSelectors = attachedWorkerSelectors;
            _labels = labels;
            Assignments = assignments;
            _tags = tags;
            _notes = notes;
        }

        /// <summary> The id of the job. </summary>
        public string Id { get; }
        /// <summary> Reference to an external parent context, eg. call ID. </summary>
        public string ChannelReference { get; set; }
        /// <summary> The state of the Job. </summary>
        public JobStatus? JobStatus { get; }
        /// <summary> The time a job was queued. </summary>
        public DateTimeOffset? EnqueueTimeUtc { get; }
        /// <summary> The channel identifier. eg. voice, chat, etc. </summary>
        public string ChannelId { get; set; }
        /// <summary> The Id of the Classification policy used for classifying a job. </summary>
        public string ClassificationPolicyId { get; set; }
        /// <summary> The Id of the Queue that this job is queued to. </summary>
        public string QueueId { get; set; }
        /// <summary> The priority of this job. </summary>
        public int? Priority { get; set; }
        /// <summary> Reason code for cancelled or closed jobs. </summary>
        public string DispositionCode { get; set; }
        /// <summary> A collection of label selectors attached by a classification policy, which a worker must satisfy in order to process this job. </summary>
        public IReadOnlyList<WorkerSelector> AttachedWorkerSelectors { get; }
        /// <summary>
        /// A collection of the assignments of the job.
        /// Key is AssignmentId.
        /// </summary>
        public IReadOnlyDictionary<string, JobAssignment> Assignments { get; }
    }
}

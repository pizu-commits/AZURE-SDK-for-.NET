// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;
using System.Collections.Generic;
using Azure;

namespace Azure.Communication.JobRouter
{
    /// <summary> A unit of work to be routed. </summary>
    public partial class RouterJob
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouterJob"/>. </summary>
        internal RouterJob()
        {
            RequestedWorkerSelectors = new ChangeTrackingList<RouterWorkerSelector>();
            AttachedWorkerSelectors = new ChangeTrackingList<RouterWorkerSelector>();
            _labels = new OptionalDictionary<string, BinaryData>();
            Assignments = new OptionalDictionary<string, RouterJobAssignment>();
            _tags = new OptionalDictionary<string, BinaryData>();
            Notes = new ChangeTrackingList<RouterJobNote>();
        }

        /// <summary> Initializes a new instance of <see cref="RouterJob"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a job. </param>
        /// <param name="channelReference"> Reference to an external parent context, eg. call ID. </param>
        /// <param name="status"> The status of the job. </param>
        /// <param name="enqueuedAt"> Timestamp a job was queued in UTC. </param>
        /// <param name="channelId"> The channel identifier. eg. voice, chat, etc. </param>
        /// <param name="classificationPolicyId"> Id of a classification policy used for classifying this job. </param>
        /// <param name="queueId"> Id of a queue that this job is queued to. </param>
        /// <param name="priority"> Priority of this job. </param>
        /// <param name="dispositionCode"> Reason code for cancelled or closed jobs. </param>
        /// <param name="requestedWorkerSelectors"> A collection of manually specified worker selectors, which a worker must satisfy in order to process this job. </param>
        /// <param name="attachedWorkerSelectors"> A collection of worker selectors attached by a classification policy, which a worker must satisfy in order to process this job. </param>
        /// <param name="labels"> A set of key/value pairs that are identifying attributes used by the rules engines to make decisions. Values must be primitive values - number, string, boolean. </param>
        /// <param name="assignments"> A collection of the assignments of the job. Key is AssignmentId. </param>
        /// <param name="tags"> A set of non-identifying attributes attached to this job. Values must be primitive values - number, string, boolean. </param>
        /// <param name="notes"> Notes attached to a job, sorted by timestamp. </param>
        /// <param name="scheduledAt"> If set, job will be scheduled to be enqueued at a given time. </param>
        /// <param name="matchingMode"> If provided, will determine how job matching will be carried out. Default mode: QueueAndMatchMode. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterJob(ETag eTag, string id, string channelReference, RouterJobStatus? status, DateTimeOffset? enqueuedAt, string channelId, string classificationPolicyId, string queueId, int? priority, string dispositionCode, IList<RouterWorkerSelector> requestedWorkerSelectors, IReadOnlyList<RouterWorkerSelector> attachedWorkerSelectors, IDictionary<string, BinaryData> labels, IReadOnlyDictionary<string, RouterJobAssignment> assignments, IDictionary<string, BinaryData> tags, IList<RouterJobNote> notes, DateTimeOffset? scheduledAt, JobMatchingMode matchingMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ETag = eTag;
            Id = id;
            ChannelReference = channelReference;
            Status = status;
            EnqueuedAt = enqueuedAt;
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
            Notes = notes;
            ScheduledAt = scheduledAt;
            MatchingMode = matchingMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
        /// <summary> Id of a job. </summary>
        public string Id { get; }
        /// <summary> The status of the job. </summary>
        public RouterJobStatus? Status { get; }
        /// <summary> Timestamp a job was queued in UTC. </summary>
        public DateTimeOffset? EnqueuedAt { get; }
        /// <summary> A collection of worker selectors attached by a classification policy, which a worker must satisfy in order to process this job. </summary>
        public IReadOnlyList<RouterWorkerSelector> AttachedWorkerSelectors { get; }
        /// <summary> A collection of the assignments of the job. Key is AssignmentId. </summary>
        public IReadOnlyDictionary<string, RouterJobAssignment> Assignments { get; }
        /// <summary> If set, job will be scheduled to be enqueued at a given time. </summary>
        public DateTimeOffset? ScheduledAt { get; }
    }
}

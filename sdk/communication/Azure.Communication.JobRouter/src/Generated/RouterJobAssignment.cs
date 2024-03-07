// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> Assignment details of a job to a worker. </summary>
    public partial class RouterJobAssignment
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

        /// <summary> Initializes a new instance of <see cref="RouterJobAssignment"/>. </summary>
        /// <param name="assignedAt"> Timestamp when the job was assigned to a worker in UTC. </param>
        internal RouterJobAssignment(DateTimeOffset assignedAt)
        {
            AssignedAt = assignedAt;
        }

        /// <summary> Initializes a new instance of <see cref="RouterJobAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of a job assignment. </param>
        /// <param name="workerId"> Id of the Worker assigned to the job. </param>
        /// <param name="assignedAt"> Timestamp when the job was assigned to a worker in UTC. </param>
        /// <param name="completedAt"> Timestamp when the job was marked as completed after being assigned in UTC. </param>
        /// <param name="closedAt"> Timestamp when the job was marked as closed after being completed in UTC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterJobAssignment(string assignmentId, string workerId, DateTimeOffset assignedAt, DateTimeOffset? completedAt, DateTimeOffset? closedAt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AssignmentId = assignmentId;
            WorkerId = workerId;
            AssignedAt = assignedAt;
            CompletedAt = completedAt;
            ClosedAt = closedAt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RouterJobAssignment"/> for deserialization. </summary>
        internal RouterJobAssignment()
        {
        }

        /// <summary> Id of a job assignment. </summary>
        public string AssignmentId { get; }
        /// <summary> Id of the Worker assigned to the job. </summary>
        public string WorkerId { get; }
        /// <summary> Timestamp when the job was assigned to a worker in UTC. </summary>
        public DateTimeOffset AssignedAt { get; }
        /// <summary> Timestamp when the job was marked as completed after being assigned in UTC. </summary>
        public DateTimeOffset? CompletedAt { get; }
        /// <summary> Timestamp when the job was marked as closed after being completed in UTC. </summary>
        public DateTimeOffset? ClosedAt { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Task model. </summary>
    public partial class DataReplicationTask
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

        /// <summary> Initializes a new instance of <see cref="DataReplicationTask"/>. </summary>
        internal DataReplicationTask()
        {
            ChildrenWorkflows = new ChangeTrackingList<DataReplicationWorkflowData>();
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationTask"/>. </summary>
        /// <param name="taskName"> Gets or sets the task name. </param>
        /// <param name="state"> Gets or sets the task state. </param>
        /// <param name="startOn"> Gets or sets the start time. </param>
        /// <param name="endOn"> Gets or sets the end time. </param>
        /// <param name="customProperties"> Task model custom properties. </param>
        /// <param name="childrenWorkflows"> Gets or sets the list of children workflow models. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationTask(string taskName, DataReplicationTaskState? state, DateTimeOffset? startOn, DateTimeOffset? endOn, TaskModelCustomProperties customProperties, IReadOnlyList<DataReplicationWorkflowData> childrenWorkflows, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TaskName = taskName;
            State = state;
            StartOn = startOn;
            EndOn = endOn;
            CustomProperties = customProperties;
            ChildrenWorkflows = childrenWorkflows;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the task name. </summary>
        public string TaskName { get; }
        /// <summary> Gets or sets the task state. </summary>
        public DataReplicationTaskState? State { get; }
        /// <summary> Gets or sets the start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets or sets the end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Task model custom properties. </summary>
        internal TaskModelCustomProperties CustomProperties { get; }
        /// <summary> Gets or sets the instance type. </summary>
        public string CustomInstanceType
        {
            get => CustomProperties?.InstanceType;
        }

        /// <summary> Gets or sets the list of children workflow models. </summary>
        public IReadOnlyList<DataReplicationWorkflowData> ChildrenWorkflows { get; }
    }
}

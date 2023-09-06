// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing the LogicWorkflowRun data model.
    /// The workflow run.
    /// </summary>
    public partial class LogicWorkflowRunData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRunData"/>. </summary>
        internal LogicWorkflowRunData()
        {
            Outputs = new ChangeTrackingDictionary<string, LogicWorkflowOutputParameterInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="LogicWorkflowRunData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="waitEndOn"> Gets the wait end time. </param>
        /// <param name="startOn"> Gets the start time. </param>
        /// <param name="endOn"> Gets the end time. </param>
        /// <param name="status"> Gets the status. </param>
        /// <param name="code"> Gets the code. </param>
        /// <param name="error"> Gets the error. </param>
        /// <param name="correlationId"> Gets the correlation id. </param>
        /// <param name="correlation"> The run correlation. </param>
        /// <param name="workflow"> Gets the reference to workflow version. </param>
        /// <param name="trigger"> Gets the fired trigger. </param>
        /// <param name="outputs"> Gets the outputs. </param>
        /// <param name="response"> Gets the response of the flow run. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicWorkflowRunData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? waitEndOn, DateTimeOffset? startOn, DateTimeOffset? endOn, LogicWorkflowStatus? status, string code, BinaryData error, string correlationId, Correlation correlation, LogicResourceReference workflow, LogicWorkflowRunTrigger trigger, IReadOnlyDictionary<string, LogicWorkflowOutputParameterInfo> outputs, LogicWorkflowRunTrigger response, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            WaitEndOn = waitEndOn;
            StartOn = startOn;
            EndOn = endOn;
            Status = status;
            Code = code;
            Error = error;
            CorrelationId = correlationId;
            Correlation = correlation;
            Workflow = workflow;
            Trigger = trigger;
            Outputs = outputs;
            Response = response;
            _rawData = rawData;
        }

        /// <summary> Gets the wait end time. </summary>
        public DateTimeOffset? WaitEndOn { get; }
        /// <summary> Gets the start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets the end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Gets the status. </summary>
        public LogicWorkflowStatus? Status { get; }
        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary>
        /// Gets the error.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Error { get; }
        /// <summary> Gets the correlation id. </summary>
        public string CorrelationId { get; }
        /// <summary> The run correlation. </summary>
        internal Correlation Correlation { get; }
        /// <summary> The client tracking id. </summary>
        public string CorrelationClientTrackingId
        {
            get => Correlation?.ClientTrackingId;
        }

        /// <summary> Gets the reference to workflow version. </summary>
        public LogicResourceReference Workflow { get; }
        /// <summary> Gets the fired trigger. </summary>
        public LogicWorkflowRunTrigger Trigger { get; }
        /// <summary> Gets the outputs. </summary>
        public IReadOnlyDictionary<string, LogicWorkflowOutputParameterInfo> Outputs { get; }
        /// <summary> Gets the response of the flow run. </summary>
        public LogicWorkflowRunTrigger Response { get; }
    }
}

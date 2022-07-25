// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Logic.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Logic
{
    /// <summary> A class representing the LogicAppWorkflowTriggerHistory data model. </summary>
    public partial class LogicAppWorkflowTriggerHistoryData : ResourceData
    {
        /// <summary> Initializes a new instance of LogicAppWorkflowTriggerHistoryData. </summary>
        internal LogicAppWorkflowTriggerHistoryData()
        {
        }

        /// <summary> Initializes a new instance of LogicAppWorkflowTriggerHistoryData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn">
        /// Gets the start time.
        /// Serialized Name: WorkflowTriggerHistory.properties.startTime
        /// </param>
        /// <param name="endOn">
        /// Gets the end time.
        /// Serialized Name: WorkflowTriggerHistory.properties.endTime
        /// </param>
        /// <param name="scheduledOn">
        /// The scheduled time.
        /// Serialized Name: WorkflowTriggerHistory.properties.scheduledTime
        /// </param>
        /// <param name="status">
        /// Gets the status.
        /// Serialized Name: WorkflowTriggerHistory.properties.status
        /// </param>
        /// <param name="code">
        /// Gets the code.
        /// Serialized Name: WorkflowTriggerHistory.properties.code
        /// </param>
        /// <param name="error">
        /// Gets the error.
        /// Serialized Name: WorkflowTriggerHistory.properties.error
        /// </param>
        /// <param name="trackingId">
        /// Gets the tracking id.
        /// Serialized Name: WorkflowTriggerHistory.properties.trackingId
        /// </param>
        /// <param name="correlation">
        /// The run correlation.
        /// Serialized Name: WorkflowTriggerHistory.properties.correlation
        /// </param>
        /// <param name="inputsLink">
        /// Gets the link to input parameters.
        /// Serialized Name: WorkflowTriggerHistory.properties.inputsLink
        /// </param>
        /// <param name="outputsLink">
        /// Gets the link to output parameters.
        /// Serialized Name: WorkflowTriggerHistory.properties.outputsLink
        /// </param>
        /// <param name="fired">
        /// The value indicating whether trigger was fired.
        /// Serialized Name: WorkflowTriggerHistory.properties.fired
        /// </param>
        /// <param name="run">
        /// Gets the reference to workflow run.
        /// Serialized Name: WorkflowTriggerHistory.properties.run
        /// </param>
        internal LogicAppWorkflowTriggerHistoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? scheduledOn, LogicAppWorkflowStatus? status, string code, BinaryData error, string trackingId, Correlation correlation, ContentLink inputsLink, ContentLink outputsLink, bool? fired, ResourceReference run) : base(id, name, resourceType, systemData)
        {
            StartOn = startOn;
            EndOn = endOn;
            ScheduledOn = scheduledOn;
            Status = status;
            Code = code;
            Error = error;
            TrackingId = trackingId;
            Correlation = correlation;
            InputsLink = inputsLink;
            OutputsLink = outputsLink;
            Fired = fired;
            Run = run;
        }

        /// <summary>
        /// Gets the start time.
        /// Serialized Name: WorkflowTriggerHistory.properties.startTime
        /// </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary>
        /// Gets the end time.
        /// Serialized Name: WorkflowTriggerHistory.properties.endTime
        /// </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary>
        /// The scheduled time.
        /// Serialized Name: WorkflowTriggerHistory.properties.scheduledTime
        /// </summary>
        public DateTimeOffset? ScheduledOn { get; }
        /// <summary>
        /// Gets the status.
        /// Serialized Name: WorkflowTriggerHistory.properties.status
        /// </summary>
        public LogicAppWorkflowStatus? Status { get; }
        /// <summary>
        /// Gets the code.
        /// Serialized Name: WorkflowTriggerHistory.properties.code
        /// </summary>
        public string Code { get; }
        /// <summary>
        /// Gets the error.
        /// Serialized Name: WorkflowTriggerHistory.properties.error
        /// </summary>
        public BinaryData Error { get; }
        /// <summary>
        /// Gets the tracking id.
        /// Serialized Name: WorkflowTriggerHistory.properties.trackingId
        /// </summary>
        public string TrackingId { get; }
        /// <summary>
        /// The run correlation.
        /// Serialized Name: WorkflowTriggerHistory.properties.correlation
        /// </summary>
        internal Correlation Correlation { get; }
        /// <summary>
        /// The client tracking id.
        /// Serialized Name: Correlation.clientTrackingId
        /// </summary>
        public string CorrelationClientTrackingId
        {
            get => Correlation?.ClientTrackingId;
        }

        /// <summary>
        /// Gets the link to input parameters.
        /// Serialized Name: WorkflowTriggerHistory.properties.inputsLink
        /// </summary>
        public ContentLink InputsLink { get; }
        /// <summary>
        /// Gets the link to output parameters.
        /// Serialized Name: WorkflowTriggerHistory.properties.outputsLink
        /// </summary>
        public ContentLink OutputsLink { get; }
        /// <summary>
        /// The value indicating whether trigger was fired.
        /// Serialized Name: WorkflowTriggerHistory.properties.fired
        /// </summary>
        public bool? Fired { get; }
        /// <summary>
        /// Gets the reference to workflow run.
        /// Serialized Name: WorkflowTriggerHistory.properties.run
        /// </summary>
        public ResourceReference Run { get; }
    }
}

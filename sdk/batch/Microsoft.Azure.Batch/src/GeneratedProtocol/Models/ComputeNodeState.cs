// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ComputeNodeState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ComputeNodeState
    {
        /// <summary>
        /// The Compute Node is not currently running a Task.
        /// </summary>
        [EnumMember(Value = "idle")]
        Idle,
        /// <summary>
        /// The Compute Node is rebooting.
        /// </summary>
        [EnumMember(Value = "rebooting")]
        Rebooting,
        /// <summary>
        /// The Compute Node is reimaging.
        /// </summary>
        [EnumMember(Value = "reimaging")]
        Reimaging,
        /// <summary>
        /// The Compute Node is running one or more Tasks (other than a
        /// StartTask).
        /// </summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>
        /// The Compute Node cannot be used for Task execution due to errors.
        /// </summary>
        [EnumMember(Value = "unusable")]
        Unusable,
        /// <summary>
        /// The Batch service has obtained the underlying virtual machine from
        /// Azure Compute, but it has not yet started to join the Pool.
        /// </summary>
        [EnumMember(Value = "creating")]
        Creating,
        /// <summary>
        /// The Batch service is starting on the underlying virtual machine.
        /// </summary>
        [EnumMember(Value = "starting")]
        Starting,
        /// <summary>
        /// The StartTask has started running on the Compute Node, but
        /// waitForSuccess is set and the StartTask has not yet completed.
        /// </summary>
        [EnumMember(Value = "waitingforstarttask")]
        WaitingForStartTask,
        /// <summary>
        /// The StartTask has failed on the Compute Node (and exhausted all
        /// retries), and waitForSuccess is set. The Compute Node is not usable
        /// for running Tasks.
        /// </summary>
        [EnumMember(Value = "starttaskfailed")]
        StartTaskFailed,
        /// <summary>
        /// The Batch service has lost contact with the Compute Node, and does
        /// not know its true state.
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>
        /// The Compute Node is leaving the Pool, either because the user
        /// explicitly removed it or because the Pool is resizing or
        /// autoscaling down.
        /// </summary>
        [EnumMember(Value = "leavingpool")]
        LeavingPool,
        /// <summary>
        /// The Compute Node is not currently running a Task, and scheduling of
        /// new Tasks to the Compute Node is disabled.
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline,
        /// <summary>
        /// The low-priority Compute Node has been preempted. Tasks which were
        /// running on the Compute Node when it was preempted will be
        /// rescheduled when another Compute Node becomes available.
        /// </summary>
        [EnumMember(Value = "preempted")]
        Preempted
    }
    internal static class ComputeNodeStateEnumExtension
    {
        internal static string ToSerializedValue(this ComputeNodeState? value)
        {
            return value == null ? null : ((ComputeNodeState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ComputeNodeState value)
        {
            switch( value )
            {
                case ComputeNodeState.Idle:
                    return "idle";
                case ComputeNodeState.Rebooting:
                    return "rebooting";
                case ComputeNodeState.Reimaging:
                    return "reimaging";
                case ComputeNodeState.Running:
                    return "running";
                case ComputeNodeState.Unusable:
                    return "unusable";
                case ComputeNodeState.Creating:
                    return "creating";
                case ComputeNodeState.Starting:
                    return "starting";
                case ComputeNodeState.WaitingForStartTask:
                    return "waitingforstarttask";
                case ComputeNodeState.StartTaskFailed:
                    return "starttaskfailed";
                case ComputeNodeState.Unknown:
                    return "unknown";
                case ComputeNodeState.LeavingPool:
                    return "leavingpool";
                case ComputeNodeState.Offline:
                    return "offline";
                case ComputeNodeState.Preempted:
                    return "preempted";
            }
            return null;
        }

        internal static ComputeNodeState? ParseComputeNodeState(this string value)
        {
            switch( value )
            {
                case "idle":
                    return ComputeNodeState.Idle;
                case "rebooting":
                    return ComputeNodeState.Rebooting;
                case "reimaging":
                    return ComputeNodeState.Reimaging;
                case "running":
                    return ComputeNodeState.Running;
                case "unusable":
                    return ComputeNodeState.Unusable;
                case "creating":
                    return ComputeNodeState.Creating;
                case "starting":
                    return ComputeNodeState.Starting;
                case "waitingforstarttask":
                    return ComputeNodeState.WaitingForStartTask;
                case "starttaskfailed":
                    return ComputeNodeState.StartTaskFailed;
                case "unknown":
                    return ComputeNodeState.Unknown;
                case "leavingpool":
                    return ComputeNodeState.LeavingPool;
                case "offline":
                    return ComputeNodeState.Offline;
                case "preempted":
                    return ComputeNodeState.Preempted;
            }
            return null;
        }
    }
}

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
    /// Defines values for TaskState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaskState
    {
        /// <summary>
        /// The Task is queued and able to run, but is not currently assigned
        /// to a Compute Node. A Task enters this state when it is created,
        /// when it is enabled after being disabled, or when it is awaiting a
        /// retry after a failed run.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>
        /// The Task has been assigned to a Compute Node, but is waiting for a
        /// required Job Preparation Task to complete on the Compute Node. If
        /// the Job Preparation Task succeeds, the Task will move to running.
        /// If the Job Preparation Task fails, the Task will return to active
        /// and will be eligible to be assigned to a different Compute Node.
        /// </summary>
        [EnumMember(Value = "preparing")]
        Preparing,
        /// <summary>
        /// The Task is running on a Compute Node. This includes task-level
        /// preparation such as downloading resource files or deploying
        /// Packages specified on the Task - it does not necessarily mean that
        /// the Task command line has started executing.
        /// </summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>
        /// The Task is no longer eligible to run, usually because the Task has
        /// finished successfully, or the Task has finished unsuccessfully and
        /// has exhausted its retry limit. A Task is also marked as completed
        /// if an error occurred launching the Task, or when the Task has been
        /// terminated.
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed
    }
    internal static class TaskStateEnumExtension
    {
        internal static string ToSerializedValue(this TaskState? value)
        {
            return value == null ? null : ((TaskState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TaskState value)
        {
            switch( value )
            {
                case TaskState.Active:
                    return "active";
                case TaskState.Preparing:
                    return "preparing";
                case TaskState.Running:
                    return "running";
                case TaskState.Completed:
                    return "completed";
            }
            return null;
        }

        internal static TaskState? ParseTaskState(this string value)
        {
            switch( value )
            {
                case "active":
                    return TaskState.Active;
                case "preparing":
                    return TaskState.Preparing;
                case "running":
                    return TaskState.Running;
                case "completed":
                    return TaskState.Completed;
            }
            return null;
        }
    }
}

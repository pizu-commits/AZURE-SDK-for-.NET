// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Information about an Azure Batch subtask.
    /// </summary>
    public partial class SubtaskInformation
    {
        /// <summary>
        /// Initializes a new instance of the SubtaskInformation class.
        /// </summary>
        public SubtaskInformation() { }

        /// <summary>
        /// Initializes a new instance of the SubtaskInformation class.
        /// </summary>
        /// <param name="id">The id of the subtask.</param>
        /// <param name="nodeInfo">Information about the compute node on which the subtask ran.</param>
        /// <param name="startTime">The time at which the subtask started running. If the subtask has been restarted or retried, this is the most recent time at which the subtask started running.</param>
        /// <param name="endTime">The time at which the subtask completed.</param>
        /// <param name="exitCode">The exit code of the program specified on the subtask command line.</param>
        /// <param name="schedulingError">Details of any error encountered scheduling the subtask.</param>
        /// <param name="state">The current state of the subtask.</param>
        /// <param name="stateTransitionTime">The time at which the subtask entered its current state.</param>
        /// <param name="previousState">The previous state of the subtask.</param>
        /// <param name="previousStateTransitionTime">The time at which the subtask entered its previous state.</param>
        public SubtaskInformation(int? id = default(int?), ComputeNodeInformation nodeInfo = default(ComputeNodeInformation), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? exitCode = default(int?), TaskSchedulingError schedulingError = default(TaskSchedulingError), TaskState? state = default(TaskState?), DateTime? stateTransitionTime = default(DateTime?), TaskState? previousState = default(TaskState?), DateTime? previousStateTransitionTime = default(DateTime?))
        {
            Id = id;
            NodeInfo = nodeInfo;
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            SchedulingError = schedulingError;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
        }

        /// <summary>
        /// Gets or sets the id of the subtask.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets information about the compute node on which the
        /// subtask ran.
        /// </summary>
        [JsonProperty(PropertyName = "nodeInfo")]
        public ComputeNodeInformation NodeInfo { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask started running. If the
        /// subtask has been restarted or retried, this is the most recent
        /// time at which the subtask started running.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask completed.
        /// </summary>
        /// <remarks>
        /// This property is set only if the subtask is in the Completed state.
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the program specified on the subtask
        /// command line.
        /// </summary>
        /// <remarks>
        /// This parameter is returned only if the subtask is in the completed
        /// state. The exit code for a process reflects the specific
        /// convention implemented by the application developer for that
        /// process. If you use the exit code value to make decisions in your
        /// code, be sure that you know the exit code convention used by the
        /// application process. Note that the exit code may also be
        /// generated by the compute node operating system, such as when a
        /// process is forcibly terminated.
        /// </remarks>
        [JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets details of any error encountered scheduling the
        /// subtask.
        /// </summary>
        [JsonProperty(PropertyName = "schedulingError")]
        public TaskSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets the current state of the subtask.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public TaskState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask entered its current
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the subtask.
        /// </summary>
        /// <remarks>
        /// This property is not set if the subtask is in its initial Active
        /// state. Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "previousState")]
        public TaskState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the subtask entered its previous
        /// state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the subtask is in its initial Active
        /// state.
        /// </remarks>
        [JsonProperty(PropertyName = "previousStateTransitionTime")]
        public DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SchedulingError != null)
            {
                this.SchedulingError.Validate();
            }
        }
    }
}

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
    /// An Azure Batch task.
    /// </summary>
    public partial class CloudTask
    {
        /// <summary>
        /// Initializes a new instance of the CloudTask class.
        /// </summary>
        public CloudTask() { }

        /// <summary>
        /// Initializes a new instance of the CloudTask class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the task within the job.</param>
        /// <param name="displayName">A display name for the task.</param>
        /// <param name="url">The URL of the task.</param>
        /// <param name="eTag">The ETag of the task.</param>
        /// <param name="lastModified">The last modified time of the task.</param>
        /// <param name="creationTime">The creation time of the task.</param>
        /// <param name="exitConditions">How the Batch service should respond when the task completes.</param>
        /// <param name="state">The current state of the task.</param>
        /// <param name="stateTransitionTime">The time at which the task entered its current state.</param>
        /// <param name="previousState">The previous state of the task.</param>
        /// <param name="previousStateTransitionTime">The time at which the task entered its previous state.</param>
        /// <param name="commandLine">The command line of the task.</param>
        /// <param name="resourceFiles">A list of files that the Batch service will download to the compute node before running the command line.</param>
        /// <param name="environmentSettings">A list of environment variable settings for the task.</param>
        /// <param name="affinityInfo">A locality hint that can be used by the Batch service to select a compute node on which to start the new task.</param>
        /// <param name="constraints">The execution constraints that apply to this task.</param>
        /// <param name="runElevated">Whether to run the task in elevated mode.</param>
        /// <param name="executionInfo">Information about the execution of the task.</param>
        /// <param name="nodeInfo">Information about the compute node on which the task ran.</param>
        /// <param name="multiInstanceSettings">Information about how to run the multi-instance task.</param>
        /// <param name="stats">Resource usage statistics for the task.</param>
        /// <param name="dependsOn">Any dependencies this task has.</param>
        /// <param name="applicationPackageReferences">A list of application packages that the Batch service will deploy to the compute node before running the command line.</param>
        public CloudTask(string id = default(string), string displayName = default(string), string url = default(string), string eTag = default(string), DateTime? lastModified = default(DateTime?), DateTime? creationTime = default(DateTime?), ExitConditions exitConditions = default(ExitConditions), TaskState? state = default(TaskState?), DateTime? stateTransitionTime = default(DateTime?), TaskState? previousState = default(TaskState?), DateTime? previousStateTransitionTime = default(DateTime?), string commandLine = default(string), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), AffinityInformation affinityInfo = default(AffinityInformation), TaskConstraints constraints = default(TaskConstraints), bool? runElevated = default(bool?), TaskExecutionInformation executionInfo = default(TaskExecutionInformation), ComputeNodeInformation nodeInfo = default(ComputeNodeInformation), MultiInstanceSettings multiInstanceSettings = default(MultiInstanceSettings), TaskStatistics stats = default(TaskStatistics), TaskDependencies dependsOn = default(TaskDependencies), IList<ApplicationPackageReference> applicationPackageReferences = default(IList<ApplicationPackageReference>))
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            ExitConditions = exitConditions;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            CommandLine = commandLine;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            AffinityInfo = affinityInfo;
            Constraints = constraints;
            RunElevated = runElevated;
            ExecutionInfo = executionInfo;
            NodeInfo = nodeInfo;
            MultiInstanceSettings = multiInstanceSettings;
            Stats = stats;
            DependsOn = dependsOn;
            ApplicationPackageReferences = applicationPackageReferences;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the task within the
        /// job.
        /// </summary>
        /// <remarks>
        /// The id can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than
        /// 64 characters. It is common to use a GUID for the id.
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a display name for the task.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the task.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the task.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the task.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the task.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond when the task
        /// completes.
        /// </summary>
        [JsonProperty(PropertyName = "exitConditions")]
        public ExitConditions ExitConditions { get; set; }

        /// <summary>
        /// Gets or sets the current state of the task.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "state")]
        public TaskState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the task entered its current state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the task.
        /// </summary>
        /// <remarks>
        /// This property is not set if the task is in its initial Active
        /// state. Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [JsonProperty(PropertyName = "previousState")]
        public TaskState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the task entered its previous state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the task is in its initial Active
        /// state.
        /// </remarks>
        [JsonProperty(PropertyName = "previousStateTransitionTime")]
        public DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the command line is executed on the
        /// primary subtask after all the subtasks have finished executing
        /// the coordianation command line. The command line does not run
        /// under a shell, and therefore cannot take advantage of shell
        /// features such as environment variable expansion. If you want to
        /// take advantage of such features, you should invoke the shell in
        /// the command line, for example using "cmd /c MyCommand" in Windows
        /// or "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the resource files will only be
        /// downloaded to the compute node on which the primary subtask is
        /// executed.
        /// </remarks>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets a locality hint that can be used by the Batch service
        /// to select a compute node on which to start the new task.
        /// </summary>
        [JsonProperty(PropertyName = "affinityInfo")]
        public AffinityInformation AffinityInfo { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints that apply to this task.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets whether to run the task in elevated mode.
        /// </summary>
        [JsonProperty(PropertyName = "runElevated")]
        public bool? RunElevated { get; set; }

        /// <summary>
        /// Gets or sets information about the execution of the task.
        /// </summary>
        [JsonProperty(PropertyName = "executionInfo")]
        public TaskExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets information about the compute node on which the task
        /// ran.
        /// </summary>
        [JsonProperty(PropertyName = "nodeInfo")]
        public ComputeNodeInformation NodeInfo { get; set; }

        /// <summary>
        /// Gets or sets information about how to run the multi-instance task.
        /// </summary>
        [JsonProperty(PropertyName = "multiInstanceSettings")]
        public MultiInstanceSettings MultiInstanceSettings { get; set; }

        /// <summary>
        /// Gets or sets resource usage statistics for the task.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public TaskStatistics Stats { get; set; }

        /// <summary>
        /// Gets or sets any dependencies this task has.
        /// </summary>
        [JsonProperty(PropertyName = "dependsOn")]
        public TaskDependencies DependsOn { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service
        /// will deploy to the compute node before running the command line.
        /// </summary>
        [JsonProperty(PropertyName = "applicationPackageReferences")]
        public IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ResourceFiles != null)
            {
                foreach (var element in this.ResourceFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.EnvironmentSettings != null)
            {
                foreach (var element1 in this.EnvironmentSettings)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.AffinityInfo != null)
            {
                this.AffinityInfo.Validate();
            }
            if (this.ExecutionInfo != null)
            {
                this.ExecutionInfo.Validate();
            }
            if (this.MultiInstanceSettings != null)
            {
                this.MultiInstanceSettings.Validate();
            }
            if (this.Stats != null)
            {
                this.Stats.Validate();
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element2 in this.ApplicationPackageReferences)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}

// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Compute.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Disk migration job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DiskMigrationJob : Resource
    {
        /// <summary>
        /// Initializes a new instance of the DiskMigrationJob class.
        /// </summary>
        public DiskMigrationJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskMigrationJob class.
        /// </summary>
        /// <param name="id">ID of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of Resource.</param>
        /// <param name="location">Location of the resource.</param>
        /// <param name="migrationId">The disk migration id.</param>
        /// <param name="status">The current status of disk migration job.
        /// Possible values include: 'Undefined', 'Running', 'Succeeded',
        /// 'Failed', 'Canceled', 'Pending'</param>
        /// <param name="subtasks">The list of child migration tasks.</param>
        /// <param name="creationTime">The job creation time.</param>
        /// <param name="startTime">The job start time.</param>
        /// <param name="endTime">The job end time.</param>
        /// <param name="targetShare">The target share of migration
        /// job.</param>
        public DiskMigrationJob(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string migrationId = default(string), string status = default(string), IList<MigrationSubTask> subtasks = default(IList<MigrationSubTask>), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string targetShare = default(string))
            : base(id, name, type, location)
        {
            MigrationId = migrationId;
            Status = status;
            Subtasks = subtasks;
            CreationTime = creationTime;
            StartTime = startTime;
            EndTime = endTime;
            TargetShare = targetShare;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk migration id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.migrationId")]
        public string MigrationId { get; set; }

        /// <summary>
        /// Gets the current status of disk migration job. Possible values
        /// include: 'Undefined', 'Running', 'Succeeded', 'Failed', 'Canceled',
        /// 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the list of child migration tasks.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subtasks")]
        public IList<MigrationSubTask> Subtasks { get; private set; }

        /// <summary>
        /// Gets the job creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the job start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the job end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the target share of migration job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetShare")]
        public string TargetShare { get; private set; }

    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Job collection item properties. </summary>
    public partial class AutomationJobCollectionItemData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationJobCollectionItemData"/>. </summary>
        public AutomationJobCollectionItemData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationJobCollectionItemData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="runbook"> The runbook association. </param>
        /// <param name="jobId"> The id of the job. </param>
        /// <param name="createdOn"> The creation time of the job. </param>
        /// <param name="status"> The status of the job. </param>
        /// <param name="startOn"> The start time of the job. </param>
        /// <param name="endOn"> The end time of the job. </param>
        /// <param name="lastModifiedOn"> The last modified time of the job. </param>
        /// <param name="provisioningState"> The provisioning state of a resource. </param>
        /// <param name="runOn"> Specifies the runOn group name where the job was executed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationJobCollectionItemData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RunbookAssociationProperty runbook, Guid? jobId, DateTimeOffset? createdOn, AutomationJobStatus? status, DateTimeOffset? startOn, DateTimeOffset? endOn, DateTimeOffset? lastModifiedOn, string provisioningState, string runOn, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Runbook = runbook;
            JobId = jobId;
            CreatedOn = createdOn;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            LastModifiedOn = lastModifiedOn;
            ProvisioningState = provisioningState;
            RunOn = runOn;
            _rawData = rawData;
        }

        /// <summary> The runbook association. </summary>
        internal RunbookAssociationProperty Runbook { get; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string RunbookName
        {
            get => Runbook?.Name;
        }

        /// <summary> The id of the job. </summary>
        public Guid? JobId { get; }
        /// <summary> The creation time of the job. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The status of the job. </summary>
        public AutomationJobStatus? Status { get; }
        /// <summary> The start time of the job. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the job. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The last modified time of the job. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> The provisioning state of a resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies the runOn group name where the job was executed. </summary>
        public string RunOn { get; set; }
    }
}

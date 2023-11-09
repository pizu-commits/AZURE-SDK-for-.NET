// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the DscCompilationJob data model.
    /// Definition of the Dsc Compilation job.
    /// </summary>
    public partial class DscCompilationJobData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DscCompilationJobData"/>. </summary>
        public DscCompilationJobData()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DscCompilationJobData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="configuration"> Gets or sets the configuration. </param>
        /// <param name="startedBy"> Gets the compilation job started by. </param>
        /// <param name="jobId"> Gets the id of the job. </param>
        /// <param name="createdOn"> Gets the creation time of the job. </param>
        /// <param name="provisioningState"> The current provisioning state of the job. </param>
        /// <param name="runOn"> Gets or sets the runOn which specifies the group name where the job is to be executed. </param>
        /// <param name="status"> Gets or sets the status of the job. </param>
        /// <param name="statusDetails"> Gets or sets the status details of the job. </param>
        /// <param name="startOn"> Gets the start time of the job. </param>
        /// <param name="endOn"> Gets the end time of the job. </param>
        /// <param name="exception"> Gets the exception of the job. </param>
        /// <param name="lastModifiedOn"> Gets the last modified time of the job. </param>
        /// <param name="lastStatusModifiedOn"> Gets the last status modified time of the job. </param>
        /// <param name="parameters"> Gets or sets the parameters of the job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DscCompilationJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DscConfigurationAssociationProperty configuration, string startedBy, Guid? jobId, DateTimeOffset? createdOn, JobProvisioningState? provisioningState, string runOn, AutomationJobStatus? status, string statusDetails, DateTimeOffset? startOn, DateTimeOffset? endOn, string exception, DateTimeOffset? lastModifiedOn, DateTimeOffset? lastStatusModifiedOn, IDictionary<string, string> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Configuration = configuration;
            StartedBy = startedBy;
            JobId = jobId;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            RunOn = runOn;
            Status = status;
            StatusDetails = statusDetails;
            StartOn = startOn;
            EndOn = endOn;
            Exception = exception;
            LastModifiedOn = lastModifiedOn;
            LastStatusModifiedOn = lastStatusModifiedOn;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the configuration. </summary>
        internal DscConfigurationAssociationProperty Configuration { get; set; }
        /// <summary> Gets or sets the name of the Dsc configuration. </summary>
        public string ConfigurationName
        {
            get => Configuration is null ? default : Configuration.ConfigurationName;
            set
            {
                if (Configuration is null)
                    Configuration = new DscConfigurationAssociationProperty();
                Configuration.ConfigurationName = value;
            }
        }

        /// <summary> Gets the compilation job started by. </summary>
        public string StartedBy { get; }
        /// <summary> Gets the id of the job. </summary>
        public Guid? JobId { get; }
        /// <summary> Gets the creation time of the job. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The current provisioning state of the job. </summary>
        public JobProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets the runOn which specifies the group name where the job is to be executed. </summary>
        public string RunOn { get; set; }
        /// <summary> Gets or sets the status of the job. </summary>
        public AutomationJobStatus? Status { get; set; }
        /// <summary> Gets or sets the status details of the job. </summary>
        public string StatusDetails { get; set; }
        /// <summary> Gets the start time of the job. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Gets the end time of the job. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> Gets the exception of the job. </summary>
        public string Exception { get; }
        /// <summary> Gets the last modified time of the job. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Gets the last status modified time of the job. </summary>
        public DateTimeOffset? LastStatusModifiedOn { get; }
        /// <summary> Gets or sets the parameters of the job. </summary>
        public IDictionary<string, string> Parameters { get; }
    }
}

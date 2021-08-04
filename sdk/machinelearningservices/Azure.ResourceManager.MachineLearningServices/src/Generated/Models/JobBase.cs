// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Base definition for a job. </summary>
    public partial class JobBase
    {
        /// <summary> Initializes a new instance of JobBase. </summary>
        public JobBase()
        {
            InteractionEndpoints = new ChangeTrackingDictionary<string, JobEndpoint>();
            Properties = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of JobBase. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="interactionEndpoints">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="jobType"> Specifies the type of job. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="provisioningState"> Specifies the job provisioning state. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        internal JobBase(string description, IReadOnlyDictionary<string, JobEndpoint> interactionEndpoints, JobType jobType, IDictionary<string, string> properties, JobProvisioningState? provisioningState, IDictionary<string, string> tags)
        {
            Description = description;
            InteractionEndpoints = interactionEndpoints;
            JobType = jobType;
            Properties = properties;
            ProvisioningState = provisioningState;
            Tags = tags;
        }

        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
        /// <summary>
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </summary>
        public IReadOnlyDictionary<string, JobEndpoint> InteractionEndpoints { get; }
        /// <summary> Specifies the type of job. </summary>
        internal JobType JobType { get; set; }
        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Specifies the job provisioning state. </summary>
        public JobProvisioningState? ProvisioningState { get; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}

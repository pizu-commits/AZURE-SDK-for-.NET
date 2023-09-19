// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Result of each individual deployment in a blueprint assignment. </summary>
    public partial class AssignmentDeploymentJobResult
    {
        /// <summary> Initializes a new instance of AssignmentDeploymentJobResult. </summary>
        public AssignmentDeploymentJobResult()
        {
            Resources = new ChangeTrackingList<AssignmentJobCreatedResult>();
        }

        /// <summary> Initializes a new instance of AssignmentDeploymentJobResult. </summary>
        /// <param name="error"> Contains error details if deployment job failed. </param>
        /// <param name="resources"> Resources created as result of the deployment job. </param>
        internal AssignmentDeploymentJobResult(AzureResourceManagerError error, IList<AssignmentJobCreatedResult> resources)
        {
            Error = error;
            Resources = resources;
        }

        /// <summary> Contains error details if deployment job failed. </summary>
        public AzureResourceManagerError Error { get; set; }
        /// <summary> Resources created as result of the deployment job. </summary>
        public IList<AssignmentJobCreatedResult> Resources { get; }
    }
}

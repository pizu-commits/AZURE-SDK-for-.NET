// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of an artifact deployment.
    /// </summary>
    public partial class ArtifactDeploymentStatusProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ArtifactDeploymentStatusProperties class.
        /// </summary>
        public ArtifactDeploymentStatusProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ArtifactDeploymentStatusProperties class.
        /// </summary>
        /// <param name="deploymentStatus">The deployment status of the
        /// artifact.</param>
        /// <param name="artifactsApplied">The total count of the artifacts
        /// that were successfully applied.</param>
        /// <param name="totalArtifacts">The total count of the artifacts that
        /// were tentatively applied.</param>
        public ArtifactDeploymentStatusProperties(string deploymentStatus = default(string), int? artifactsApplied = default(int?), int? totalArtifacts = default(int?))
        {
            DeploymentStatus = deploymentStatus;
            ArtifactsApplied = artifactsApplied;
            TotalArtifacts = totalArtifacts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the deployment status of the artifact.
        /// </summary>
        [JsonProperty(PropertyName = "deploymentStatus")]
        public string DeploymentStatus { get; set; }

        /// <summary>
        /// Gets or sets the total count of the artifacts that were
        /// successfully applied.
        /// </summary>
        [JsonProperty(PropertyName = "artifactsApplied")]
        public int? ArtifactsApplied { get; set; }

        /// <summary>
        /// Gets or sets the total count of the artifacts that were tentatively
        /// applied.
        /// </summary>
        [JsonProperty(PropertyName = "totalArtifacts")]
        public int? TotalArtifacts { get; set; }

    }
}

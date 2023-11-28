// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of an artifact deployment. </summary>
    public partial class DevTestLabArtifactDeploymentStatus
    {
        /// <summary> Initializes a new instance of <see cref="DevTestLabArtifactDeploymentStatus"/>. </summary>
        internal DevTestLabArtifactDeploymentStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabArtifactDeploymentStatus"/>. </summary>
        /// <param name="deploymentStatus"> The deployment status of the artifact. </param>
        /// <param name="artifactsApplied"> The total count of the artifacts that were successfully applied. </param>
        /// <param name="totalArtifacts"> The total count of the artifacts that were tentatively applied. </param>
        internal DevTestLabArtifactDeploymentStatus(string deploymentStatus, int? artifactsApplied, int? totalArtifacts)
        {
            DeploymentStatus = deploymentStatus;
            ArtifactsApplied = artifactsApplied;
            TotalArtifacts = totalArtifacts;
        }

        /// <summary> The deployment status of the artifact. </summary>
        public string DeploymentStatus { get; }
        /// <summary> The total count of the artifacts that were successfully applied. </summary>
        public int? ArtifactsApplied { get; }
        /// <summary> The total count of the artifacts that were tentatively applied. </summary>
        public int? TotalArtifacts { get; }
    }
}

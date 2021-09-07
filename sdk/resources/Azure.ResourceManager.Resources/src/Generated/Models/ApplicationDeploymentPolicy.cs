// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application deployment policy. </summary>
    public partial class ApplicationDeploymentPolicy
    {
        /// <summary> Initializes a new instance of ApplicationDeploymentPolicy. </summary>
        /// <param name="deploymentMode"> The managed application deployment mode. </param>
        public ApplicationDeploymentPolicy(DeploymentMode deploymentMode)
        {
            DeploymentMode = deploymentMode;
        }

        /// <summary> The managed application deployment mode. </summary>
        public DeploymentMode DeploymentMode { get; set; }
    }
}

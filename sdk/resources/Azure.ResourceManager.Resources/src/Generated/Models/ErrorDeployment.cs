// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment on error behavior. </summary>
    public partial class ErrorDeployment
    {
        /// <summary> Initializes a new instance of <see cref="ErrorDeployment"/>. </summary>
        public ErrorDeployment()
        {
        }

        /// <summary> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </summary>
        public ErrorDeploymentType? DeploymentType { get; set; }
        /// <summary> The deployment to be used on error case. </summary>
        public string DeploymentName { get; set; }
    }
}

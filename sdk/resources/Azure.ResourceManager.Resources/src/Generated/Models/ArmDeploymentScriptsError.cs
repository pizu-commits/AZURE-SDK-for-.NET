// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment scripts error response. </summary>
    internal partial class ArmDeploymentScriptsError
    {
        /// <summary> Initializes a new instance of ArmDeploymentScriptsError. </summary>
        internal ArmDeploymentScriptsError()
        {
        }

        /// <summary> Initializes a new instance of ArmDeploymentScriptsError. </summary>
        /// <param name="error"> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </param>
        internal ArmDeploymentScriptsError(ErrorDetail error)
        {
            Error = error;
        }

        /// <summary> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </summary>
        public ErrorDetail Error { get; }
    }
}

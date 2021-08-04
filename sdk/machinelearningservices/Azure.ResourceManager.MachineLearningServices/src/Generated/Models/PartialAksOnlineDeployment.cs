// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The PartialAksOnlineDeployment. </summary>
    public partial class PartialAksOnlineDeployment : PartialOnlineDeployment
    {
        /// <summary> Initializes a new instance of PartialAksOnlineDeployment. </summary>
        public PartialAksOnlineDeployment()
        {
            EndpointComputeType = EndpointComputeType.K8S;
        }

        /// <summary> Resource requirements for each container instance within an online deployment. </summary>
        public ContainerResourceRequirements ContainerResourceRequirements { get; set; }
    }
}

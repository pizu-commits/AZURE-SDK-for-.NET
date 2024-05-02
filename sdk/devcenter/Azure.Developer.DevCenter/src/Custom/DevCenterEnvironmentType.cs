// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class DevCenterEnvironmentType
    {
        /// <summary>
        /// Id of a subscription or management group that the environment type will be
        /// mapped to. The environment's resources will be deployed into this subscription
        /// or management group.
        /// </summary>
        public ResourceIdentifier DeploymentTargetId { get; }

        /// <summary> Initializes a new instance of <see cref="DevCenterEnvironmentType"/>. </summary>
        /// <param name="name"> Name of the environment type. </param>
        /// <param name="deploymentTargetId">
        /// Id of a subscription or management group that the environment type will be
        /// mapped to. The environment's resources will be deployed into this subscription
        /// or management group.
        /// </param>
        /// <param name="status"> Indicates whether this environment type is enabled for use in this project. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="deploymentTargetId"/> is null. </exception>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DevCenterEnvironmentType(string name, ResourceIdentifier deploymentTargetId, EnvironmentTypeStatus status)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(deploymentTargetId, nameof(deploymentTargetId));

            Name = name;
            DeploymentTargetId = deploymentTargetId;
            Status = status;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment operation parameters. </summary>
    public partial class ArmDeploymentContent
    {
        /// <summary> Initializes a new instance of <see cref="ArmDeploymentContent"/>. </summary>
        /// <param name="properties"> The deployment properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ArmDeploymentContent(ArmDeploymentProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The location to store the deployment data. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The deployment properties. </summary>
        public ArmDeploymentProperties Properties { get; }
        /// <summary> Deployment tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}

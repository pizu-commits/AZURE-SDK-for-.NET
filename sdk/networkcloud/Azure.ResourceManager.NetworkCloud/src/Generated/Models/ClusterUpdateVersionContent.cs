// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterUpdateVersionParameters represents the body of the request to update cluster version. </summary>
    public partial class ClusterUpdateVersionContent
    {
        /// <summary> Initializes a new instance of <see cref="ClusterUpdateVersionContent"/>. </summary>
        /// <param name="targetClusterVersion"> The version to be applied to the cluster during update. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetClusterVersion"/> is null. </exception>
        public ClusterUpdateVersionContent(string targetClusterVersion)
        {
            Argument.AssertNotNull(targetClusterVersion, nameof(targetClusterVersion));

            TargetClusterVersion = targetClusterVersion;
        }

        /// <summary> The version to be applied to the cluster during update. </summary>
        public string TargetClusterVersion { get; }
    }
}

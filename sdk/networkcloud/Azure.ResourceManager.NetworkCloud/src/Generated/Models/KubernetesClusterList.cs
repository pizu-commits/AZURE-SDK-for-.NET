// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> KubernetesClusterList represents a list of Kubernetes clusters. </summary>
    internal partial class KubernetesClusterList
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesClusterList"/>. </summary>
        internal KubernetesClusterList()
        {
            Value = new ChangeTrackingList<NetworkCloudKubernetesClusterData>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="value"> The list of additional details related to Kubernetes clusters. </param>
        internal KubernetesClusterList(string nextLink, IReadOnlyList<NetworkCloudKubernetesClusterData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
        /// <summary> The list of additional details related to Kubernetes clusters. </summary>
        public IReadOnlyList<NetworkCloudKubernetesClusterData> Value { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The upgrade properties. </summary>
    public partial class ProvisionedClusterPoolUpgradeProfileProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterPoolUpgradeProfileProperties"/>. </summary>
        public ProvisionedClusterPoolUpgradeProfileProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProvisionedClusterPoolUpgradeProfileProperties"/>. </summary>
        /// <param name="kubernetesVersion"> The Kubernetes version (major.minor.patch). </param>
        /// <param name="isPreview"> Whether the Kubernetes version is currently in preview. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProvisionedClusterPoolUpgradeProfileProperties(string kubernetesVersion, bool? isPreview, Dictionary<string, BinaryData> rawData)
        {
            KubernetesVersion = kubernetesVersion;
            IsPreview = isPreview;
            _rawData = rawData;
        }

        /// <summary> The Kubernetes version (major.minor.patch). </summary>
        public string KubernetesVersion { get; }
        /// <summary> Whether the Kubernetes version is currently in preview. </summary>
        public bool? IsPreview { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> The Extension Patch Request object. </summary>
    public partial class KubernetesClusterExtensionPatch
    {
        /// <summary> Initializes a new instance of KubernetesClusterExtensionPatch. </summary>
        public KubernetesClusterExtensionPatch()
        {
            ConfigurationSettings = new Core.ChangeTrackingDictionary<string, string>();
            ConfigurationProtectedSettings = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Flag to note if this extension participates in auto upgrade of minor version, or not. </summary>
        public bool? AutoUpgradeMinorVersion { get; set; }
        /// <summary> ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'. </summary>
        public string ReleaseTrain { get; set; }
        /// <summary> Version of the extension for this extension, if it is 'pinned' to a specific version. autoUpgradeMinorVersion must be 'false'. </summary>
        public string Version { get; set; }
        /// <summary> Configuration settings, as name-value pairs for configuring this extension. </summary>
        public IDictionary<string, string> ConfigurationSettings { get; set; }
        /// <summary> Configuration settings that are sensitive, as name-value pairs for configuring this extension. </summary>
        public IDictionary<string, string> ConfigurationProtectedSettings { get; set; }
    }
}

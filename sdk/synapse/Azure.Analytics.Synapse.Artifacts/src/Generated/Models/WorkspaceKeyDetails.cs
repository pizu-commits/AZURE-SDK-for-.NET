// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Details of the customer managed key associated with the workspace. </summary>
    public partial class WorkspaceKeyDetails
    {
        /// <summary> Initializes a new instance of WorkspaceKeyDetails. </summary>
        public WorkspaceKeyDetails()
        {
        }

        /// <summary> Initializes a new instance of WorkspaceKeyDetails. </summary>
        /// <param name="name"> Workspace Key sub-resource name. </param>
        /// <param name="keyVaultUrl"> Workspace Key sub-resource key vault url. </param>
        internal WorkspaceKeyDetails(string name, string keyVaultUrl)
        {
            Name = name;
            KeyVaultUrl = keyVaultUrl;
        }

        /// <summary> Workspace Key sub-resource name. </summary>
        public string Name { get; set; }
        /// <summary> Workspace Key sub-resource key vault url. </summary>
        public string KeyVaultUrl { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Parameters for creating or updating a vault. </summary>
    public partial class KeyVaultPatch
    {
        /// <summary> Initializes a new instance of KeyVaultPatch. </summary>
        public KeyVaultPatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The tags that will be assigned to the key vault. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties of the vault. </summary>
        public KeyVaultPatchProperties Properties { get; set; }
    }
}

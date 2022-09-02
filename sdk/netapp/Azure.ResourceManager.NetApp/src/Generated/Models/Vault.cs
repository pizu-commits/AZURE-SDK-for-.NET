// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Vault information. </summary>
    public partial class Vault : ResourceData
    {
        /// <summary> Initializes a new instance of Vault. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        internal Vault(string location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Location = location;
        }

        /// <summary> Initializes a new instance of Vault. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="vaultName"> Vault Name. </param>
        internal Vault(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string location, string vaultName) : base(id, name, resourceType, systemData)
        {
            Location = location;
            VaultName = vaultName;
        }

        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> Vault Name. </summary>
        public string VaultName { get; }
    }
}

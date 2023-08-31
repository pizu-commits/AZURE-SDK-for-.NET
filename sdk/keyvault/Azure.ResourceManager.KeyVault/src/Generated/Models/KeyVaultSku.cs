// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> SKU details. </summary>
    public partial class KeyVaultSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultSku"/>. </summary>
        /// <param name="family"> SKU family name. </param>
        /// <param name="name"> SKU name to specify whether the key vault is a standard vault or a premium vault. </param>
        public KeyVaultSku(KeyVaultSkuFamily family, KeyVaultSkuName name)
        {
            Family = family;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultSku"/>. </summary>
        /// <param name="family"> SKU family name. </param>
        /// <param name="name"> SKU name to specify whether the key vault is a standard vault or a premium vault. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultSku(KeyVaultSkuFamily family, KeyVaultSkuName name, Dictionary<string, BinaryData> rawData)
        {
            Family = family;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultSku"/> for deserialization. </summary>
        internal KeyVaultSku()
        {
        }

        /// <summary> SKU family name. </summary>
        public KeyVaultSkuFamily Family { get; set; }
        /// <summary> SKU name to specify whether the key vault is a standard vault or a premium vault. </summary>
        public KeyVaultSkuName Name { get; set; }
    }
}

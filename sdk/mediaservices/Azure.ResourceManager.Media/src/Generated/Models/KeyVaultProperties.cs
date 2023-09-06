// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The KeyVaultProperties. </summary>
    public partial class KeyVaultProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultProperties"/>. </summary>
        public KeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultProperties"/>. </summary>
        /// <param name="keyIdentifier"> The URL of the Key Vault key used to encrypt the account. The key may either be versioned (for example https://vault/keys/mykey/version1) or reference a key without a version (for example https://vault/keys/mykey). </param>
        /// <param name="currentKeyIdentifier"> The current key used to encrypt the Media Services account, including the key version. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultProperties(string keyIdentifier, string currentKeyIdentifier, Dictionary<string, BinaryData> rawData)
        {
            KeyIdentifier = keyIdentifier;
            CurrentKeyIdentifier = currentKeyIdentifier;
            _rawData = rawData;
        }

        /// <summary> The URL of the Key Vault key used to encrypt the account. The key may either be versioned (for example https://vault/keys/mykey/version1) or reference a key without a version (for example https://vault/keys/mykey). </summary>
        public string KeyIdentifier { get; set; }
        /// <summary> The current key used to encrypt the Media Services account, including the key version. </summary>
        public string CurrentKeyIdentifier { get; }
    }
}

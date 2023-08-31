// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.KeyVault;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> List of secrets. </summary>
    internal partial class SecretListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecretListResult"/>. </summary>
        internal SecretListResult()
        {
            Value = new ChangeTrackingList<KeyVaultSecretData>();
        }

        /// <summary> Initializes a new instance of <see cref="SecretListResult"/>. </summary>
        /// <param name="value"> The list of secrets. </param>
        /// <param name="nextLink"> The URL to get the next set of secrets. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecretListResult(IReadOnlyList<KeyVaultSecretData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of secrets. </summary>
        public IReadOnlyList<KeyVaultSecretData> Value { get; }
        /// <summary> The URL to get the next set of secrets. </summary>
        public string NextLink { get; }
    }
}

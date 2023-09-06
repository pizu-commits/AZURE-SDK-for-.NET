// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The secret restore parameters. </summary>
    internal partial class StorageRestoreParameters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageRestoreParameters"/>. </summary>
        /// <param name="storageBundleBackup"> The backup blob associated with a storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageBundleBackup"/> is null. </exception>
        public StorageRestoreParameters(byte[] storageBundleBackup)
        {
            Argument.AssertNotNull(storageBundleBackup, nameof(storageBundleBackup));

            StorageBundleBackup = storageBundleBackup;
        }

        /// <summary> Initializes a new instance of <see cref="StorageRestoreParameters"/>. </summary>
        /// <param name="storageBundleBackup"> The backup blob associated with a storage account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageRestoreParameters(byte[] storageBundleBackup, Dictionary<string, BinaryData> rawData)
        {
            StorageBundleBackup = storageBundleBackup;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageRestoreParameters"/> for deserialization. </summary>
        internal StorageRestoreParameters()
        {
        }

        /// <summary> The backup blob associated with a storage account. </summary>
        public byte[] StorageBundleBackup { get; }
    }
}

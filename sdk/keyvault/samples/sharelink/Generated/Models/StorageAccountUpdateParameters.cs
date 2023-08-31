// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The storage account update parameters. </summary>
    internal partial class StorageAccountUpdateParameters
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountUpdateParameters"/>. </summary>
        public StorageAccountUpdateParameters()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountUpdateParameters"/>. </summary>
        /// <param name="activeKeyName"> The current active storage account key name. </param>
        /// <param name="autoRegenerateKey"> whether keyvault should manage the storage account for the user. </param>
        /// <param name="regenerationPeriod"> The key regeneration time duration specified in ISO-8601 format. </param>
        /// <param name="storageAccountAttributes"> The attributes of the storage account. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountUpdateParameters(string activeKeyName, bool? autoRegenerateKey, string regenerationPeriod, StorageAccountAttributes storageAccountAttributes, IDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            ActiveKeyName = activeKeyName;
            AutoRegenerateKey = autoRegenerateKey;
            RegenerationPeriod = regenerationPeriod;
            StorageAccountAttributes = storageAccountAttributes;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> The current active storage account key name. </summary>
        public string ActiveKeyName { get; set; }
        /// <summary> whether keyvault should manage the storage account for the user. </summary>
        public bool? AutoRegenerateKey { get; set; }
        /// <summary> The key regeneration time duration specified in ISO-8601 format. </summary>
        public string RegenerationPeriod { get; set; }
        /// <summary> The attributes of the storage account. </summary>
        public StorageAccountAttributes StorageAccountAttributes { get; set; }
        /// <summary> Application specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}

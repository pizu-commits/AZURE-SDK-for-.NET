// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> A Storage account bundle consists of key vault storage account details plus its attributes. </summary>
    public partial class StorageBundle
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageBundle"/>. </summary>
        internal StorageBundle()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageBundle"/>. </summary>
        /// <param name="id"> The storage account id. </param>
        /// <param name="resourceId"> The storage account resource id. </param>
        /// <param name="activeKeyName"> The current active storage account key name. </param>
        /// <param name="autoRegenerateKey"> whether keyvault should manage the storage account for the user. </param>
        /// <param name="regenerationPeriod"> The key regeneration time duration specified in ISO-8601 format. </param>
        /// <param name="attributes"> The storage account attributes. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageBundle(string id, string resourceId, string activeKeyName, bool? autoRegenerateKey, string regenerationPeriod, StorageAccountAttributes attributes, IReadOnlyDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ResourceId = resourceId;
            ActiveKeyName = activeKeyName;
            AutoRegenerateKey = autoRegenerateKey;
            RegenerationPeriod = regenerationPeriod;
            Attributes = attributes;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> The storage account id. </summary>
        public string Id { get; }
        /// <summary> The storage account resource id. </summary>
        public string ResourceId { get; }
        /// <summary> The current active storage account key name. </summary>
        public string ActiveKeyName { get; }
        /// <summary> whether keyvault should manage the storage account for the user. </summary>
        public bool? AutoRegenerateKey { get; }
        /// <summary> The key regeneration time duration specified in ISO-8601 format. </summary>
        public string RegenerationPeriod { get; }
        /// <summary> The storage account attributes. </summary>
        public StorageAccountAttributes Attributes { get; }
        /// <summary> Application specific metadata in the form of key-value pairs. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}

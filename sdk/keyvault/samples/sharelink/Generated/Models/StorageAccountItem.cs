// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The storage account item containing storage account metadata. </summary>
    public partial class StorageAccountItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountItem"/>. </summary>
        internal StorageAccountItem()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountItem"/>. </summary>
        /// <param name="id"> Storage identifier. </param>
        /// <param name="resourceId"> Storage account resource Id. </param>
        /// <param name="attributes"> The storage account management attributes. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountItem(string id, string resourceId, StorageAccountAttributes attributes, IReadOnlyDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            ResourceId = resourceId;
            Attributes = attributes;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Storage identifier. </summary>
        public string Id { get; }
        /// <summary> Storage account resource Id. </summary>
        public string ResourceId { get; }
        /// <summary> The storage account management attributes. </summary>
        public StorageAccountAttributes Attributes { get; }
        /// <summary> Application specific metadata in the form of key-value pairs. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}

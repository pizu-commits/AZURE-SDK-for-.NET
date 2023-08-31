// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The deleted storage account item containing metadata about the deleted storage account. </summary>
    public partial class DeletedStorageAccountItem : StorageAccountItem
    {
        /// <summary> Initializes a new instance of <see cref="DeletedStorageAccountItem"/>. </summary>
        internal DeletedStorageAccountItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeletedStorageAccountItem"/>. </summary>
        /// <param name="id"> Storage identifier. </param>
        /// <param name="resourceId"> Storage account resource Id. </param>
        /// <param name="attributes"> The storage account management attributes. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        /// <param name="recoveryId"> The url of the recovery object, used to identify and recover the deleted storage account. </param>
        /// <param name="scheduledPurgeDate"> The time when the storage account is scheduled to be purged, in UTC. </param>
        /// <param name="deletedDate"> The time when the storage account was deleted, in UTC. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedStorageAccountItem(string id, string resourceId, StorageAccountAttributes attributes, IReadOnlyDictionary<string, string> tags, string recoveryId, DateTimeOffset? scheduledPurgeDate, DateTimeOffset? deletedDate, Dictionary<string, BinaryData> rawData) : base(id, resourceId, attributes, tags, rawData)
        {
            RecoveryId = recoveryId;
            ScheduledPurgeDate = scheduledPurgeDate;
            DeletedDate = deletedDate;
        }

        /// <summary> The url of the recovery object, used to identify and recover the deleted storage account. </summary>
        public string RecoveryId { get; }
        /// <summary> The time when the storage account is scheduled to be purged, in UTC. </summary>
        public DateTimeOffset? ScheduledPurgeDate { get; }
        /// <summary> The time when the storage account was deleted, in UTC. </summary>
        public DateTimeOffset? DeletedDate { get; }
    }
}

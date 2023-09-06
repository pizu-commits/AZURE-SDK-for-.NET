// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The storage account management attributes. </summary>
    public partial class StorageAccountAttributes
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountAttributes"/>. </summary>
        public StorageAccountAttributes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountAttributes"/>. </summary>
        /// <param name="enabled"> the enabled state of the object. </param>
        /// <param name="created"> Creation time in UTC. </param>
        /// <param name="updated"> Last updated time in UTC. </param>
        /// <param name="recoverableDays"> softDelete data retention days. Value should be &gt;=7 and &lt;=90 when softDelete enabled, otherwise 0. </param>
        /// <param name="recoveryLevel"> Reflects the deletion recovery level currently in effect for storage accounts in the current vault. If it contains 'Purgeable' the storage account can be permanently deleted by a privileged user; otherwise, only the system can purge the storage account, at the end of the retention interval. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountAttributes(bool? enabled, DateTimeOffset? created, DateTimeOffset? updated, int? recoverableDays, DeletionRecoveryLevel? recoveryLevel, Dictionary<string, BinaryData> rawData)
        {
            Enabled = enabled;
            Created = created;
            Updated = updated;
            RecoverableDays = recoverableDays;
            RecoveryLevel = recoveryLevel;
            _rawData = rawData;
        }

        /// <summary> the enabled state of the object. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Creation time in UTC. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> Last updated time in UTC. </summary>
        public DateTimeOffset? Updated { get; }
        /// <summary> softDelete data retention days. Value should be &gt;=7 and &lt;=90 when softDelete enabled, otherwise 0. </summary>
        public int? RecoverableDays { get; }
        /// <summary> Reflects the deletion recovery level currently in effect for storage accounts in the current vault. If it contains 'Purgeable' the storage account can be permanently deleted by a privileged user; otherwise, only the system can purge the storage account, at the end of the retention interval. </summary>
        public DeletionRecoveryLevel? RecoveryLevel { get; }
    }
}

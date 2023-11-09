// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to the Backup/Restore of an API Management service operation. </summary>
    public partial class ApiManagementServiceBackupRestoreContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceBackupRestoreContent"/>. </summary>
        /// <param name="storageAccount"> The name of the Azure storage account (used to place/retrieve the backup). </param>
        /// <param name="containerName"> The name of the blob container (used to place/retrieve the backup). </param>
        /// <param name="backupName"> The name of the backup file to create/retrieve. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageAccount"/>, <paramref name="containerName"/> or <paramref name="backupName"/> is null. </exception>
        public ApiManagementServiceBackupRestoreContent(string storageAccount, string containerName, string backupName)
        {
            Argument.AssertNotNull(storageAccount, nameof(storageAccount));
            Argument.AssertNotNull(containerName, nameof(containerName));
            Argument.AssertNotNull(backupName, nameof(backupName));

            StorageAccount = storageAccount;
            ContainerName = containerName;
            BackupName = backupName;
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceBackupRestoreContent"/>. </summary>
        /// <param name="storageAccount"> The name of the Azure storage account (used to place/retrieve the backup). </param>
        /// <param name="containerName"> The name of the blob container (used to place/retrieve the backup). </param>
        /// <param name="backupName"> The name of the backup file to create/retrieve. </param>
        /// <param name="accessType"> The type of access to be used for the storage account. </param>
        /// <param name="accessKey"> Storage account access key. Required only if `accessType` is set to `AccessKey`. </param>
        /// <param name="clientId"> The Client ID of user assigned managed identity. Required only if `accessType` is set to `UserAssignedManagedIdentity`. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementServiceBackupRestoreContent(string storageAccount, string containerName, string backupName, StorageAccountAccessType? accessType, string accessKey, string clientId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StorageAccount = storageAccount;
            ContainerName = containerName;
            BackupName = backupName;
            AccessType = accessType;
            AccessKey = accessKey;
            ClientId = clientId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementServiceBackupRestoreContent"/> for deserialization. </summary>
        internal ApiManagementServiceBackupRestoreContent()
        {
        }

        /// <summary> The name of the Azure storage account (used to place/retrieve the backup). </summary>
        public string StorageAccount { get; }
        /// <summary> The name of the blob container (used to place/retrieve the backup). </summary>
        public string ContainerName { get; }
        /// <summary> The name of the backup file to create/retrieve. </summary>
        public string BackupName { get; }
        /// <summary> The type of access to be used for the storage account. </summary>
        public StorageAccountAccessType? AccessType { get; set; }
        /// <summary> Storage account access key. Required only if `accessType` is set to `AccessKey`. </summary>
        public string AccessKey { get; set; }
        /// <summary> The Client ID of user assigned managed identity. Required only if `accessType` is set to `UserAssignedManagedIdentity`. </summary>
        public string ClientId { get; set; }
    }
}

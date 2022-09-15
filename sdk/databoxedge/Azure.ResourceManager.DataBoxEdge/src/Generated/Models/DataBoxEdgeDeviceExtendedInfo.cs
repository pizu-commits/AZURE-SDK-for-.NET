// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The extended Info of the Data Box Edge/Gateway device. </summary>
    public partial class DataBoxEdgeDeviceExtendedInfo : ResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeDeviceExtendedInfo. </summary>
        public DataBoxEdgeDeviceExtendedInfo()
        {
            DeviceSecrets = new ChangeTrackingDictionary<string, DataBoxEdgeDeviceSecret>();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeDeviceExtendedInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="encryptionKeyThumbprint"> The digital signature of encrypted certificate. </param>
        /// <param name="encryptionKey"> The public part of the encryption certificate. Client uses this to encrypt any secret. </param>
        /// <param name="resourceKey"> The Resource ID of the Resource. </param>
        /// <param name="clientSecretStoreId"> The Key Vault ARM Id for client secrets. </param>
        /// <param name="clientSecretStoreUri"> The url to access the Client Key Vault. </param>
        /// <param name="channelIntegrityKeyName"> The name of Channel Integrity Key stored in the Client Key Vault. </param>
        /// <param name="channelIntegrityKeyVersion"> The version of Channel Integrity Key stored in the Client Key Vault. </param>
        /// <param name="keyVaultSyncStatus"> Key vault sync status. </param>
        /// <param name="deviceSecrets"> Device secrets, will be returned only with ODataFilter $expand=deviceSecrets. </param>
        /// <param name="clusterWitnessType"> Cluster Witness Type. </param>
        /// <param name="fileShareWitnessLocation"> The witness location of file share. </param>
        /// <param name="fileShareWitnessUsername"> The username of file share. </param>
        /// <param name="cloudWitnessStorageAccountName"> The Cloud Witness Storage account name. </param>
        /// <param name="cloudWitnessContainerName"> The Container for cloud witness in the storage account. </param>
        /// <param name="cloudWitnessStorageEndpoint"> The Azure service endpoint of the cloud witness storage account. </param>
        internal DataBoxEdgeDeviceExtendedInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string encryptionKeyThumbprint, string encryptionKey, string resourceKey, ResourceIdentifier clientSecretStoreId, Uri clientSecretStoreUri, string channelIntegrityKeyName, string channelIntegrityKeyVersion, KeyVaultSyncStatus? keyVaultSyncStatus, IReadOnlyDictionary<string, DataBoxEdgeDeviceSecret> deviceSecrets, ClusterWitnessType? clusterWitnessType, string fileShareWitnessLocation, string fileShareWitnessUsername, string cloudWitnessStorageAccountName, string cloudWitnessContainerName, string cloudWitnessStorageEndpoint) : base(id, name, resourceType, systemData)
        {
            EncryptionKeyThumbprint = encryptionKeyThumbprint;
            EncryptionKey = encryptionKey;
            ResourceKey = resourceKey;
            ClientSecretStoreId = clientSecretStoreId;
            ClientSecretStoreUri = clientSecretStoreUri;
            ChannelIntegrityKeyName = channelIntegrityKeyName;
            ChannelIntegrityKeyVersion = channelIntegrityKeyVersion;
            KeyVaultSyncStatus = keyVaultSyncStatus;
            DeviceSecrets = deviceSecrets;
            ClusterWitnessType = clusterWitnessType;
            FileShareWitnessLocation = fileShareWitnessLocation;
            FileShareWitnessUsername = fileShareWitnessUsername;
            CloudWitnessStorageAccountName = cloudWitnessStorageAccountName;
            CloudWitnessContainerName = cloudWitnessContainerName;
            CloudWitnessStorageEndpoint = cloudWitnessStorageEndpoint;
        }

        /// <summary> The digital signature of encrypted certificate. </summary>
        public string EncryptionKeyThumbprint { get; set; }
        /// <summary> The public part of the encryption certificate. Client uses this to encrypt any secret. </summary>
        public string EncryptionKey { get; set; }
        /// <summary> The Resource ID of the Resource. </summary>
        public string ResourceKey { get; }
        /// <summary> The Key Vault ARM Id for client secrets. </summary>
        public ResourceIdentifier ClientSecretStoreId { get; set; }
        /// <summary> The url to access the Client Key Vault. </summary>
        public Uri ClientSecretStoreUri { get; set; }
        /// <summary> The name of Channel Integrity Key stored in the Client Key Vault. </summary>
        public string ChannelIntegrityKeyName { get; set; }
        /// <summary> The version of Channel Integrity Key stored in the Client Key Vault. </summary>
        public string ChannelIntegrityKeyVersion { get; set; }
        /// <summary> Key vault sync status. </summary>
        public KeyVaultSyncStatus? KeyVaultSyncStatus { get; set; }
        /// <summary> Device secrets, will be returned only with ODataFilter $expand=deviceSecrets. </summary>
        public IReadOnlyDictionary<string, DataBoxEdgeDeviceSecret> DeviceSecrets { get; }
        /// <summary> Cluster Witness Type. </summary>
        public ClusterWitnessType? ClusterWitnessType { get; }
        /// <summary> The witness location of file share. </summary>
        public string FileShareWitnessLocation { get; }
        /// <summary> The username of file share. </summary>
        public string FileShareWitnessUsername { get; }
        /// <summary> The Cloud Witness Storage account name. </summary>
        public string CloudWitnessStorageAccountName { get; }
        /// <summary> The Container for cloud witness in the storage account. </summary>
        public string CloudWitnessContainerName { get; }
        /// <summary> The Azure service endpoint of the cloud witness storage account. </summary>
        public string CloudWitnessStorageEndpoint { get; }
    }
}

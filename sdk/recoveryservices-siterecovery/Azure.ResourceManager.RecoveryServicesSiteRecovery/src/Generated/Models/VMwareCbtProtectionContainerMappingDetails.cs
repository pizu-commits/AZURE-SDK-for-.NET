// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt provider specific container mapping details. </summary>
    public partial class VMwareCbtProtectionContainerMappingDetails : ProtectionContainerMappingProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of VMwareCbtProtectionContainerMappingDetails. </summary>
        internal VMwareCbtProtectionContainerMappingDetails()
        {
            RoleSizeToNicCountMap = new ChangeTrackingDictionary<string, int>();
            InstanceType = "VMwareCbt";
        }

        /// <summary> Initializes a new instance of VMwareCbtProtectionContainerMappingDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="keyVaultId"> The target key vault ARM Id. </param>
        /// <param name="keyVaultUri"> The target key vault URI. </param>
        /// <param name="storageAccountId"> The storage account ARM Id. </param>
        /// <param name="storageAccountSasSecretName"> The secret name of the storage account. </param>
        /// <param name="serviceBusConnectionStringSecretName"> The secret name of the service bus connection string. </param>
        /// <param name="targetLocation"> The target location. </param>
        /// <param name="roleSizeToNicCountMap"> The role size to NIC count map. </param>
        internal VMwareCbtProtectionContainerMappingDetails(string instanceType, string keyVaultId, Uri keyVaultUri, string storageAccountId, string storageAccountSasSecretName, string serviceBusConnectionStringSecretName, string targetLocation, IReadOnlyDictionary<string, int> roleSizeToNicCountMap) : base(instanceType)
        {
            KeyVaultId = keyVaultId;
            KeyVaultUri = keyVaultUri;
            StorageAccountId = storageAccountId;
            StorageAccountSasSecretName = storageAccountSasSecretName;
            ServiceBusConnectionStringSecretName = serviceBusConnectionStringSecretName;
            TargetLocation = targetLocation;
            RoleSizeToNicCountMap = roleSizeToNicCountMap;
            InstanceType = instanceType ?? "VMwareCbt";
        }

        /// <summary> The target key vault ARM Id. </summary>
        public string KeyVaultId { get; }
        /// <summary> The target key vault URI. </summary>
        public Uri KeyVaultUri { get; }
        /// <summary> The storage account ARM Id. </summary>
        public string StorageAccountId { get; }
        /// <summary> The secret name of the storage account. </summary>
        public string StorageAccountSasSecretName { get; }
        /// <summary> The secret name of the service bus connection string. </summary>
        public string ServiceBusConnectionStringSecretName { get; }
        /// <summary> The target location. </summary>
        public string TargetLocation { get; }
        /// <summary> The role size to NIC count map. </summary>
        public IReadOnlyDictionary<string, int> RoleSizeToNicCountMap { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The SystemCreatedStorageAccount. </summary>
    public partial class SystemCreatedStorageAccount
    {
        /// <summary> Initializes a new instance of <see cref="SystemCreatedStorageAccount"/>. </summary>
        public SystemCreatedStorageAccount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SystemCreatedStorageAccount"/>. </summary>
        /// <param name="allowBlobPublicAccess"> Public blob access allowed. </param>
        /// <param name="armResourceIdentifier"> This is populated once the storage account is created. </param>
        /// <param name="storageAccountHnsEnabled"> HNS enabled for storage account. </param>
        /// <param name="storageAccountName"> Name of the storage account. </param>
        /// <param name="storageAccountType">
        /// Allowed values:
        /// "Standard_LRS",
        /// "Standard_GRS",
        /// "Standard_RAGRS",
        /// "Standard_ZRS",
        /// "Standard_GZRS",
        /// "Standard_RAGZRS",
        /// "Premium_LRS",
        /// "Premium_ZRS"
        /// </param>
        internal SystemCreatedStorageAccount(bool? allowBlobPublicAccess, ArmResourceId armResourceIdentifier, bool? storageAccountHnsEnabled, string storageAccountName, string storageAccountType)
        {
            AllowBlobPublicAccess = allowBlobPublicAccess;
            ArmResourceIdentifier = armResourceIdentifier;
            StorageAccountHnsEnabled = storageAccountHnsEnabled;
            StorageAccountName = storageAccountName;
            StorageAccountType = storageAccountType;
        }

        /// <summary> Public blob access allowed. </summary>
        public bool? AllowBlobPublicAccess { get; set; }
        /// <summary> This is populated once the storage account is created. </summary>
        internal ArmResourceId ArmResourceIdentifier { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        public ResourceIdentifier ArmResourceId
        {
            get => ArmResourceIdentifier is null ? default : ArmResourceIdentifier.ResourceId;
            set
            {
                if (ArmResourceIdentifier is null)
                    ArmResourceIdentifier = new ArmResourceId();
                ArmResourceIdentifier.ResourceId = value;
            }
        }

        /// <summary> HNS enabled for storage account. </summary>
        public bool? StorageAccountHnsEnabled { get; set; }
        /// <summary> Name of the storage account. </summary>
        public string StorageAccountName { get; set; }
        /// <summary>
        /// Allowed values:
        /// "Standard_LRS",
        /// "Standard_GRS",
        /// "Standard_RAGRS",
        /// "Standard_ZRS",
        /// "Standard_GZRS",
        /// "Standard_RAGZRS",
        /// "Premium_LRS",
        /// "Premium_ZRS"
        /// </summary>
        public string StorageAccountType { get; set; }
    }
}

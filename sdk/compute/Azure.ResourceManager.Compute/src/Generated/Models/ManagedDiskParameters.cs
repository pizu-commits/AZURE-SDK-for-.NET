// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The parameters of a managed disk. </summary>
    public partial class ManagedDiskParameters : SubResource
    {
        /// <summary> Initializes a new instance of ManagedDiskParameters. </summary>
        public ManagedDiskParameters()
        {
        }

        /// <summary> Initializes a new instance of ManagedDiskParameters. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="storageAccountType"> Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk. </param>
        /// <param name="diskEncryptionSet"> Specifies the customer managed disk encryption set resource id for the managed disk. </param>
        internal ManagedDiskParameters(string id, StorageAccountTypes? storageAccountType, DiskEncryptionSetParameters diskEncryptionSet) : base(id)
        {
            StorageAccountType = storageAccountType;
            DiskEncryptionSet = diskEncryptionSet;
        }

        /// <summary> Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk. </summary>
        public StorageAccountTypes? StorageAccountType { get; set; }
        /// <summary> Specifies the customer managed disk encryption set resource id for the managed disk. </summary>
        public DiskEncryptionSetParameters DiskEncryptionSet { get; set; }
    }
}

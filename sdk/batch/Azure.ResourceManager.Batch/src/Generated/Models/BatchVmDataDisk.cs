// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Settings which will be used by the data disks associated to Compute Nodes in the Pool. When using attached data disks, you need to mount and format the disks from within a VM to use them. </summary>
    public partial class BatchVmDataDisk
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchVmDataDisk"/>. </summary>
        /// <param name="lun"> The lun is used to uniquely identify each data disk. If attaching multiple disks, each should have a distinct lun. The value must be between 0 and 63, inclusive. </param>
        /// <param name="diskSizeInGB"> The initial disk size in GB when creating new data disk. </param>
        public BatchVmDataDisk(int lun, int diskSizeInGB)
        {
            Lun = lun;
            DiskSizeInGB = diskSizeInGB;
        }

        /// <summary> Initializes a new instance of <see cref="BatchVmDataDisk"/>. </summary>
        /// <param name="lun"> The lun is used to uniquely identify each data disk. If attaching multiple disks, each should have a distinct lun. The value must be between 0 and 63, inclusive. </param>
        /// <param name="caching">
        /// Values are:
        ///
        ///  none - The caching mode for the disk is not enabled.
        ///  readOnly - The caching mode for the disk is read only.
        ///  readWrite - The caching mode for the disk is read and write.
        ///
        ///  The default value for caching is none. For information about the caching options see: https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/.
        /// </param>
        /// <param name="diskSizeInGB"> The initial disk size in GB when creating new data disk. </param>
        /// <param name="storageAccountType">
        /// If omitted, the default is "Standard_LRS". Values are:
        ///
        ///  Standard_LRS - The data disk should use standard locally redundant storage.
        ///  Premium_LRS - The data disk should use premium locally redundant storage.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchVmDataDisk(int lun, BatchDiskCachingType? caching, int diskSizeInGB, BatchStorageAccountType? storageAccountType, Dictionary<string, BinaryData> rawData)
        {
            Lun = lun;
            Caching = caching;
            DiskSizeInGB = diskSizeInGB;
            StorageAccountType = storageAccountType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchVmDataDisk"/> for deserialization. </summary>
        internal BatchVmDataDisk()
        {
        }

        /// <summary> The lun is used to uniquely identify each data disk. If attaching multiple disks, each should have a distinct lun. The value must be between 0 and 63, inclusive. </summary>
        public int Lun { get; set; }
        /// <summary>
        /// Values are:
        ///
        ///  none - The caching mode for the disk is not enabled.
        ///  readOnly - The caching mode for the disk is read only.
        ///  readWrite - The caching mode for the disk is read and write.
        ///
        ///  The default value for caching is none. For information about the caching options see: https://blogs.msdn.microsoft.com/windowsazurestorage/2012/06/27/exploring-windows-azure-drives-disks-and-images/.
        /// </summary>
        public BatchDiskCachingType? Caching { get; set; }
        /// <summary> The initial disk size in GB when creating new data disk. </summary>
        public int DiskSizeInGB { get; set; }
        /// <summary>
        /// If omitted, the default is "Standard_LRS". Values are:
        ///
        ///  Standard_LRS - The data disk should use standard locally redundant storage.
        ///  Premium_LRS - The data disk should use premium locally redundant storage.
        /// </summary>
        public BatchStorageAccountType? StorageAccountType { get; set; }
    }
}

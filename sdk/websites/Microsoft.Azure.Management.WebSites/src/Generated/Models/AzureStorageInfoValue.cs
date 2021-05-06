// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> Azure Files or Blob Storage access information value for dictionary storage. </summary>
    public partial class AzureStorageInfoValue
    {
        /// <summary> Initializes a new instance of AzureStorageInfoValue. </summary>
        public AzureStorageInfoValue()
        {
        }

        /// <summary> Initializes a new instance of AzureStorageInfoValue. </summary>
        /// <param name="type"> Type of storage. </param>
        /// <param name="accountName"> Name of the storage account. </param>
        /// <param name="shareName"> Name of the file share (container name, for Blob storage). </param>
        /// <param name="accessKey"> Access key for the storage account. </param>
        /// <param name="mountPath"> Path to mount the storage within the site&apos;s runtime environment. </param>
        /// <param name="state"> State of the storage account. </param>
        internal AzureStorageInfoValue(AzureStorageType? type, string accountName, string shareName, string accessKey, string mountPath, AzureStorageState? state)
        {
            Type = type;
            AccountName = accountName;
            ShareName = shareName;
            AccessKey = accessKey;
            MountPath = mountPath;
            State = state;
        }

        /// <summary> Type of storage. </summary>
        public AzureStorageType? Type { get; set; }
        /// <summary> Name of the storage account. </summary>
        public string AccountName { get; set; }
        /// <summary> Name of the file share (container name, for Blob storage). </summary>
        public string ShareName { get; set; }
        /// <summary> Access key for the storage account. </summary>
        public string AccessKey { get; set; }
        /// <summary> Path to mount the storage within the site&apos;s runtime environment. </summary>
        public string MountPath { get; set; }
        /// <summary> State of the storage account. </summary>
        public AzureStorageState? State { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Information used to connect to an Azure Fileshare. </summary>
    public partial class BatchFileShareConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchFileShareConfiguration"/>. </summary>
        /// <param name="accountName"> The Azure Storage account name. </param>
        /// <param name="fileUri"> This is of the form 'https://{account}.file.core.windows.net/'. </param>
        /// <param name="accountKey"> The Azure Storage account key. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="fileUri"/>, <paramref name="accountKey"/> or <paramref name="relativeMountPath"/> is null. </exception>
        public BatchFileShareConfiguration(string accountName, Uri fileUri, string accountKey, string relativeMountPath)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(fileUri, nameof(fileUri));
            Argument.AssertNotNull(accountKey, nameof(accountKey));
            Argument.AssertNotNull(relativeMountPath, nameof(relativeMountPath));

            AccountName = accountName;
            FileUri = fileUri;
            AccountKey = accountKey;
            RelativeMountPath = relativeMountPath;
        }

        /// <summary> Initializes a new instance of <see cref="BatchFileShareConfiguration"/>. </summary>
        /// <param name="accountName"> The Azure Storage account name. </param>
        /// <param name="fileUri"> This is of the form 'https://{account}.file.core.windows.net/'. </param>
        /// <param name="accountKey"> The Azure Storage account key. </param>
        /// <param name="relativeMountPath"> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </param>
        /// <param name="mountOptions"> These are 'net use' options in Windows and 'mount' options in Linux. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchFileShareConfiguration(string accountName, Uri fileUri, string accountKey, string relativeMountPath, string mountOptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountName = accountName;
            FileUri = fileUri;
            AccountKey = accountKey;
            RelativeMountPath = relativeMountPath;
            MountOptions = mountOptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchFileShareConfiguration"/> for deserialization. </summary>
        internal BatchFileShareConfiguration()
        {
        }

        /// <summary> The Azure Storage account name. </summary>
        public string AccountName { get; set; }
        /// <summary> This is of the form 'https://{account}.file.core.windows.net/'. </summary>
        public Uri FileUri { get; set; }
        /// <summary> The Azure Storage account key. </summary>
        public string AccountKey { get; set; }
        /// <summary> All file systems are mounted relative to the Batch mounts directory, accessible via the AZ_BATCH_NODE_MOUNTS_DIR environment variable. </summary>
        public string RelativeMountPath { get; set; }
        /// <summary> These are 'net use' options in Windows and 'mount' options in Linux. </summary>
        public string MountOptions { get; set; }
    }
}

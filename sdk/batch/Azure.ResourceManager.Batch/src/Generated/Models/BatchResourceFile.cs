// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> A single file or multiple files to be downloaded to a compute node. </summary>
    public partial class BatchResourceFile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BatchResourceFile"/>. </summary>
        public BatchResourceFile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchResourceFile"/>. </summary>
        /// <param name="autoBlobContainerName"> The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. </param>
        /// <param name="blobContainerUri"> The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. This URL must be readable and listable from compute nodes. There are three ways to get such a URL for a container in Azure storage: include a Shared Access Signature (SAS) granting read and list permissions on the container, use a managed identity with read and list permissions, or set the ACL for the container to allow public access. </param>
        /// <param name="httpUri"> The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. If the URL points to Azure Blob Storage, it must be readable from compute nodes. There are three ways to get such a URL for a blob in Azure storage: include a Shared Access Signature (SAS) granting read permissions on the blob, use a managed identity with read permission, or set the ACL for the blob or its container to allow public access. </param>
        /// <param name="blobPrefix"> The property is valid only when autoStorageContainerName or storageContainerUrl is used. This prefix can be a partial filename or a subdirectory. If a prefix is not specified, all the files in the container will be downloaded. </param>
        /// <param name="filePath"> If the httpUrl property is specified, the filePath is required and describes the path which the file will be downloaded to, including the filename. Otherwise, if the autoStorageContainerName or storageContainerUrl property is specified, filePath is optional and is the directory to download the files to. In the case where filePath is used as a directory, any directory structure already associated with the input data will be retained in full and appended to the specified filePath directory. The specified relative path cannot break out of the task's working directory (for example by using '..'). </param>
        /// <param name="fileMode"> This property applies only to files being downloaded to Linux compute nodes. It will be ignored if it is specified for a resourceFile which will be downloaded to a Windows node. If this property is not specified for a Linux node, then a default value of 0770 is applied to the file. </param>
        /// <param name="identity"> The reference to a user assigned identity associated with the Batch pool which a compute node will use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchResourceFile(string autoBlobContainerName, Uri blobContainerUri, Uri httpUri, string blobPrefix, string filePath, string fileMode, ComputeNodeIdentityReference identity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AutoBlobContainerName = autoBlobContainerName;
            BlobContainerUri = blobContainerUri;
            HttpUri = httpUri;
            BlobPrefix = blobPrefix;
            FilePath = filePath;
            FileMode = fileMode;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. </summary>
        public string AutoBlobContainerName { get; set; }
        /// <summary> The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. This URL must be readable and listable from compute nodes. There are three ways to get such a URL for a container in Azure storage: include a Shared Access Signature (SAS) granting read and list permissions on the container, use a managed identity with read and list permissions, or set the ACL for the container to allow public access. </summary>
        public Uri BlobContainerUri { get; set; }
        /// <summary> The autoStorageContainerName, storageContainerUrl and httpUrl properties are mutually exclusive and one of them must be specified. If the URL points to Azure Blob Storage, it must be readable from compute nodes. There are three ways to get such a URL for a blob in Azure storage: include a Shared Access Signature (SAS) granting read permissions on the blob, use a managed identity with read permission, or set the ACL for the blob or its container to allow public access. </summary>
        public Uri HttpUri { get; set; }
        /// <summary> The property is valid only when autoStorageContainerName or storageContainerUrl is used. This prefix can be a partial filename or a subdirectory. If a prefix is not specified, all the files in the container will be downloaded. </summary>
        public string BlobPrefix { get; set; }
        /// <summary> If the httpUrl property is specified, the filePath is required and describes the path which the file will be downloaded to, including the filename. Otherwise, if the autoStorageContainerName or storageContainerUrl property is specified, filePath is optional and is the directory to download the files to. In the case where filePath is used as a directory, any directory structure already associated with the input data will be retained in full and appended to the specified filePath directory. The specified relative path cannot break out of the task's working directory (for example by using '..'). </summary>
        public string FilePath { get; set; }
        /// <summary> This property applies only to files being downloaded to Linux compute nodes. It will be ignored if it is specified for a resourceFile which will be downloaded to a Windows node. If this property is not specified for a Linux node, then a default value of 0770 is applied to the file. </summary>
        public string FileMode { get; set; }
        /// <summary> The reference to a user assigned identity associated with the Batch pool which a compute node will use. </summary>
        internal ComputeNodeIdentityReference Identity { get; set; }
        /// <summary> The ARM resource id of the user assigned identity. </summary>
        public ResourceIdentifier IdentityResourceId
        {
            get => Identity is null ? default : Identity.ResourceId;
            set
            {
                if (Identity is null)
                    Identity = new ComputeNodeIdentityReference();
                Identity.ResourceId = value;
            }
        }
    }
}

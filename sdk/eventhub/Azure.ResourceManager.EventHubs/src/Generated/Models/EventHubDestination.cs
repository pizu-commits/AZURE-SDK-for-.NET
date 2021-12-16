// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Capture storage details for capture description. </summary>
    public partial class EventHubDestination
    {
        /// <summary> Initializes a new instance of EventHubDestination. </summary>
        public EventHubDestination()
        {
        }

        /// <summary> Initializes a new instance of EventHubDestination. </summary>
        /// <param name="name"> Name for capture destination. </param>
        /// <param name="storageAccountResourceId"> Resource id of the storage account to be used to create the blobs. </param>
        /// <param name="blobContainer"> Blob container Name. </param>
        /// <param name="archiveNameFormat"> Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order. </param>
        /// <param name="dataLakeSubscriptionId"> Subscription Id of Azure Data Lake Store. </param>
        /// <param name="dataLakeAccountName"> The Azure Data Lake Store name for the captured events. </param>
        /// <param name="dataLakeFolderPath"> The destination folder path for the captured events. </param>
        internal EventHubDestination(string name, string storageAccountResourceId, string blobContainer, string archiveNameFormat, Guid? dataLakeSubscriptionId, string dataLakeAccountName, string dataLakeFolderPath)
        {
            Name = name;
            StorageAccountResourceId = storageAccountResourceId;
            BlobContainer = blobContainer;
            ArchiveNameFormat = archiveNameFormat;
            DataLakeSubscriptionId = dataLakeSubscriptionId;
            DataLakeAccountName = dataLakeAccountName;
            DataLakeFolderPath = dataLakeFolderPath;
        }

        /// <summary> Name for capture destination. </summary>
        public string Name { get; set; }
        /// <summary> Resource id of the storage account to be used to create the blobs. </summary>
        public string StorageAccountResourceId { get; set; }
        /// <summary> Blob container Name. </summary>
        public string BlobContainer { get; set; }
        /// <summary> Blob naming convention for archive, e.g. {Namespace}/{EventHub}/{PartitionId}/{Year}/{Month}/{Day}/{Hour}/{Minute}/{Second}. Here all the parameters (Namespace,EventHub .. etc) are mandatory irrespective of order. </summary>
        public string ArchiveNameFormat { get; set; }
        /// <summary> Subscription Id of Azure Data Lake Store. </summary>
        public Guid? DataLakeSubscriptionId { get; set; }
        /// <summary> The Azure Data Lake Store name for the captured events. </summary>
        public string DataLakeAccountName { get; set; }
        /// <summary> The destination folder path for the captured events. </summary>
        public string DataLakeFolderPath { get; set; }
    }
}

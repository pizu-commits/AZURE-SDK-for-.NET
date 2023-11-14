// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Application logs configuration. </summary>
    public partial class ApplicationLogsConfig
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationLogsConfig"/>. </summary>
        public ApplicationLogsConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationLogsConfig"/>. </summary>
        /// <param name="fileSystem"> Application logs to file system configuration. </param>
        /// <param name="azureTableStorage"> Application logs to azure table storage configuration. </param>
        /// <param name="azureBlobStorage"> Application logs to blob storage configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationLogsConfig(FileSystemApplicationLogsConfig fileSystem, AppServiceTableStorageApplicationLogsConfig azureTableStorage, AppServiceBlobStorageApplicationLogsConfig azureBlobStorage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileSystem = fileSystem;
            AzureTableStorage = azureTableStorage;
            AzureBlobStorage = azureBlobStorage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Application logs to file system configuration. </summary>
        internal FileSystemApplicationLogsConfig FileSystem { get; set; }
        /// <summary> Log level. </summary>
        public WebAppLogLevel? FileSystemLevel
        {
            get => FileSystem is null ? default : FileSystem.Level;
            set
            {
                if (FileSystem is null)
                    FileSystem = new FileSystemApplicationLogsConfig();
                FileSystem.Level = value;
            }
        }

        /// <summary> Application logs to azure table storage configuration. </summary>
        public AppServiceTableStorageApplicationLogsConfig AzureTableStorage { get; set; }
        /// <summary> Application logs to blob storage configuration. </summary>
        public AppServiceBlobStorageApplicationLogsConfig AzureBlobStorage { get; set; }
    }
}

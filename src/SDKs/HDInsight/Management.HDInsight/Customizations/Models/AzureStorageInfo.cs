﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System;

    /// <summary>
    /// Gets or sets the StorageAccountName, StorageAccountKey and StorageContainer for the Azure Blob Storage Account.
    /// </summary>
    public class AzureStorageInfo : StorageInfo
    {
        private readonly string _storageContainer;
        private readonly string _storageAccountKey;
        private static string _defaultAzureStorageSuffix = ".blob.core.windows.net";

        /// <summary>
        /// Gets Azure Blob Storage Container.
        /// </summary>
        public string StorageContainer 
        {
            get { return _storageContainer; }
        }

        /// <summary>
        /// Gets Azure Blob Storage Account Key.
        /// </summary>
        public string StorageAccountKey 
        {
            get { return _storageAccountKey; }
        }

        /// <summary>
        /// Initializes a new instance of the AzureStorageInfo class.
        /// </summary>
        /// <param name="storageAccountName">Fully Qualified StorageAccountName for the Azure Blob Storage Account.</param>
        /// <param name="storageAccountKey">StorageKey for the Azure Blob Storage Account.</param>
        /// <param name="storageContainer">StorageContainer for the Azure Blob Storage Account. The cluster will leverage to store some cluster level files.</param>
        public AzureStorageInfo(string storageAccountName, string storageAccountKey, string storageContainer="")
            : base(storageAccountName)
        {
            if (string.IsNullOrWhiteSpace(storageAccountKey))
            {
                throw new ArgumentException(Constants.Errors.ERROR_INPUT_CANNOT_BE_EMPTY, "storageAccountKey");
            }

            if (!storageAccountName.Contains("."))
            {
                this.StorageAccountName = storageAccountName + _defaultAzureStorageSuffix;
            }

            this._storageAccountKey = storageAccountKey;
            this._storageContainer = storageContainer;
        }

        public string StorageAccountUri 
        {
            get
            {
                return string.Format("wasb://{0}@{1}", StorageContainer, StorageAccountName);
            }
        }
    }
}

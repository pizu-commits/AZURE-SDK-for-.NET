// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> Full backup operation. </summary>
    internal partial class FullBackupDetailsInternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="FullBackupDetailsInternal"/>. </summary>
        internal FullBackupDetailsInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FullBackupDetailsInternal"/>. </summary>
        /// <param name="status"> Status of the backup operation. </param>
        /// <param name="statusDetails"> The status details of backup operation. </param>
        /// <param name="error"> Error encountered, if any, during the full backup operation. </param>
        /// <param name="startTime"> The start time of the backup operation in UTC. </param>
        /// <param name="endTime"> The end time of the backup operation in UTC. </param>
        /// <param name="jobId"> Identifier for the full backup operation. </param>
        /// <param name="azureStorageBlobContainerUri"> The Azure blob storage container Uri which contains the full backup. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal FullBackupDetailsInternal(string status, string statusDetails, KeyVaultServiceError error, DateTimeOffset? startTime, DateTimeOffset? endTime, string jobId, string azureStorageBlobContainerUri, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            StatusDetails = statusDetails;
            Error = error;
            StartTime = startTime;
            EndTime = endTime;
            JobId = jobId;
            AzureStorageBlobContainerUri = azureStorageBlobContainerUri;
            _rawData = rawData;
        }

        /// <summary> Status of the backup operation. </summary>
        public string Status { get; }
        /// <summary> The status details of backup operation. </summary>
        public string StatusDetails { get; }
        /// <summary> Error encountered, if any, during the full backup operation. </summary>
        public KeyVaultServiceError Error { get; }
        /// <summary> The start time of the backup operation in UTC. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time of the backup operation in UTC. </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> Identifier for the full backup operation. </summary>
        public string JobId { get; }
        /// <summary> The Azure blob storage container Uri which contains the full backup. </summary>
        public string AzureStorageBlobContainerUri { get; }
    }
}

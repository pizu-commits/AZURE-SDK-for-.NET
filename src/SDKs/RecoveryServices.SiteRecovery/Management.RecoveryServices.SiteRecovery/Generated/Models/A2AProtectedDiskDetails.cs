// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A2A protected disk details.
    /// </summary>
    public partial class A2AProtectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AProtectedDiskDetails class.
        /// </summary>
        public A2AProtectedDiskDetails() { }

        /// <summary>
        /// Initializes a new instance of the A2AProtectedDiskDetails class.
        /// </summary>
        public A2AProtectedDiskDetails(string diskUri = default(string), string diskName = default(string), long? diskCapacityInBytes = default(long?), string recoveryAzureStorageAccountId = default(string), string primaryStagingAzureStorageAccountId = default(string), string primaryDiskAzureStorageAccountId = default(string), string recoveryDiskUri = default(string), string diskType = default(string), bool? resyncRequired = default(bool?), int? monitoringPercentageCompletion = default(int?), string monitoringJobType = default(string), double? dataPendingInStagingStorageAccountInMB = default(double?), double? dataPendingAtSourceAgentInMB = default(double?))
        {
            DiskUri = diskUri;
            DiskName = diskName;
            DiskCapacityInBytes = diskCapacityInBytes;
            RecoveryAzureStorageAccountId = recoveryAzureStorageAccountId;
            PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
            PrimaryDiskAzureStorageAccountId = primaryDiskAzureStorageAccountId;
            RecoveryDiskUri = recoveryDiskUri;
            DiskType = diskType;
            ResyncRequired = resyncRequired;
            MonitoringPercentageCompletion = monitoringPercentageCompletion;
            MonitoringJobType = monitoringJobType;
            DataPendingInStagingStorageAccountInMB = dataPendingInStagingStorageAccountInMB;
            DataPendingAtSourceAgentInMB = dataPendingAtSourceAgentInMB;
        }

        /// <summary>
        /// The disk uri.
        /// </summary>
        [JsonProperty(PropertyName = "diskUri")]
        public string DiskUri { get; set; }

        /// <summary>
        /// The disk name.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// The disk capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "diskCapacityInBytes")]
        public long? DiskCapacityInBytes { get; set; }

        /// <summary>
        /// The recovery disk storage account.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureStorageAccountId")]
        public string RecoveryAzureStorageAccountId { get; set; }

        /// <summary>
        /// The primary staging storage account.
        /// </summary>
        [JsonProperty(PropertyName = "primaryStagingAzureStorageAccountId")]
        public string PrimaryStagingAzureStorageAccountId { get; set; }

        /// <summary>
        /// The primary disk storage account.
        /// </summary>
        [JsonProperty(PropertyName = "primaryDiskAzureStorageAccountId")]
        public string PrimaryDiskAzureStorageAccountId { get; set; }

        /// <summary>
        /// Recovery disk uri.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryDiskUri")]
        public string RecoveryDiskUri { get; set; }

        /// <summary>
        /// The type of disk.
        /// </summary>
        [JsonProperty(PropertyName = "diskType")]
        public string DiskType { get; set; }

        /// <summary>
        /// A value indicating whether resync is required for this disk.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRequired")]
        public bool? ResyncRequired { get; set; }

        /// <summary>
        /// The percentage of the monitoring job. The type of the monitoring
        /// job
        /// is defined by MonitoringJobType property.
        /// </summary>
        [JsonProperty(PropertyName = "monitoringPercentageCompletion")]
        public int? MonitoringPercentageCompletion { get; set; }

        /// <summary>
        /// The type of the monitoring job. The progress is contained in
        /// MonitoringPercentageCompletion property.
        /// </summary>
        [JsonProperty(PropertyName = "monitoringJobType")]
        public string MonitoringJobType { get; set; }

        /// <summary>
        /// The data pending for replication in MB at staging account.
        /// </summary>
        [JsonProperty(PropertyName = "dataPendingInStagingStorageAccountInMB")]
        public double? DataPendingInStagingStorageAccountInMB { get; set; }

        /// <summary>
        /// The data pending at source virtual machine in MB.
        /// </summary>
        [JsonProperty(PropertyName = "dataPendingAtSourceAgentInMB")]
        public double? DataPendingAtSourceAgentInMB { get; set; }

    }
}

// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
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
    /// InMageAzureV2 protected disk details.
    /// </summary>
    public partial class InMageAzureV2ProtectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2ProtectedDiskDetails class.
        /// </summary>
        public InMageAzureV2ProtectedDiskDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2ProtectedDiskDetails class.
        /// </summary>
        public InMageAzureV2ProtectedDiskDetails(string diskId = default(string), string diskName = default(string), string protectionStage = default(string), string healthErrorCode = default(string), long? rpoInSeconds = default(long?), string resyncRequired = default(string), int? resyncProgressPercentage = default(int?), long? resyncDurationInSeconds = default(long?), long? diskCapacityInBytes = default(long?), long? fileSystemCapacityInBytes = default(long?), double? sourceDataInMegaBytes = default(double?), double? psDataInMegaBytes = default(double?), double? targetDataInMegaBytes = default(double?), string diskResized = default(string))
        {
            DiskId = diskId;
            DiskName = diskName;
            ProtectionStage = protectionStage;
            HealthErrorCode = healthErrorCode;
            RpoInSeconds = rpoInSeconds;
            ResyncRequired = resyncRequired;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncDurationInSeconds = resyncDurationInSeconds;
            DiskCapacityInBytes = diskCapacityInBytes;
            FileSystemCapacityInBytes = fileSystemCapacityInBytes;
            SourceDataInMegaBytes = sourceDataInMegaBytes;
            PsDataInMegaBytes = psDataInMegaBytes;
            TargetDataInMegaBytes = targetDataInMegaBytes;
            DiskResized = diskResized;
        }

        /// <summary>
        /// The disk id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// The disk name.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// The protection stage.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStage")]
        public string ProtectionStage { get; set; }

        /// <summary>
        /// The health error code for the disk.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrorCode")]
        public string HealthErrorCode { get; set; }

        /// <summary>
        /// The RPO in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds { get; set; }

        /// <summary>
        /// A value indicating whether resync is required for this disk.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRequired")]
        public string ResyncRequired { get; set; }

        /// <summary>
        /// The resync progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressPercentage")]
        public int? ResyncProgressPercentage { get; set; }

        /// <summary>
        /// The resync duration in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "resyncDurationInSeconds")]
        public long? ResyncDurationInSeconds { get; set; }

        /// <summary>
        /// The disk capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "diskCapacityInBytes")]
        public long? DiskCapacityInBytes { get; set; }

        /// <summary>
        /// The disk file system capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "fileSystemCapacityInBytes")]
        public long? FileSystemCapacityInBytes { get; set; }

        /// <summary>
        /// The source data transit in MB.
        /// </summary>
        [JsonProperty(PropertyName = "sourceDataInMegaBytes")]
        public double? SourceDataInMegaBytes { get; set; }

        /// <summary>
        /// The PS data transit in MB.
        /// </summary>
        [JsonProperty(PropertyName = "psDataInMegaBytes")]
        public double? PsDataInMegaBytes { get; set; }

        /// <summary>
        /// The target data transit in MB.
        /// </summary>
        [JsonProperty(PropertyName = "targetDataInMegaBytes")]
        public double? TargetDataInMegaBytes { get; set; }

        /// <summary>
        /// A value indicating whether disk is resized.
        /// </summary>
        [JsonProperty(PropertyName = "diskResized")]
        public string DiskResized { get; set; }

    }
}

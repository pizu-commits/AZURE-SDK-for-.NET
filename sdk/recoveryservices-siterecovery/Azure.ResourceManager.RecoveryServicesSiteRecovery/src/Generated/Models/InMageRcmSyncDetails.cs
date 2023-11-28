// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm disk level sync details. </summary>
    public partial class InMageRcmSyncDetails
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmSyncDetails"/>. </summary>
        internal InMageRcmSyncDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmSyncDetails"/>. </summary>
        /// <param name="progressHealth"> The progress health. </param>
        /// <param name="transferredBytes"> The transferred bytes from source VM to azure for the disk. </param>
        /// <param name="last15MinutesTransferredBytes"> The bytes transferred in last 15 minutes from source VM to azure. </param>
        /// <param name="lastDataTransferTimeUtc"> The time of the last data transfer from source VM to azure. </param>
        /// <param name="processedBytes"> The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes. </param>
        /// <param name="staStartOn"> The start time. </param>
        /// <param name="lastRefreshedOn"> The last refresh time. </param>
        /// <param name="progressPercentage"> Progress in percentage. Progress percentage is calculated based on processed bytes. </param>
        internal InMageRcmSyncDetails(SiteRecoveryDiskReplicationProgressHealth? progressHealth, long? transferredBytes, long? last15MinutesTransferredBytes, string lastDataTransferTimeUtc, long? processedBytes, DateTimeOffset? staStartOn, DateTimeOffset? lastRefreshedOn, int? progressPercentage)
        {
            ProgressHealth = progressHealth;
            TransferredBytes = transferredBytes;
            Last15MinutesTransferredBytes = last15MinutesTransferredBytes;
            LastDataTransferTimeUtc = lastDataTransferTimeUtc;
            ProcessedBytes = processedBytes;
            StaStartOn = staStartOn;
            LastRefreshedOn = lastRefreshedOn;
            ProgressPercentage = progressPercentage;
        }

        /// <summary> The progress health. </summary>
        public SiteRecoveryDiskReplicationProgressHealth? ProgressHealth { get; }
        /// <summary> The transferred bytes from source VM to azure for the disk. </summary>
        public long? TransferredBytes { get; }
        /// <summary> The bytes transferred in last 15 minutes from source VM to azure. </summary>
        public long? Last15MinutesTransferredBytes { get; }
        /// <summary> The time of the last data transfer from source VM to azure. </summary>
        public string LastDataTransferTimeUtc { get; }
        /// <summary> The total processed bytes. This includes bytes that are transferred from source VM to azure and matched bytes. </summary>
        public long? ProcessedBytes { get; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StaStartOn { get; }
        /// <summary> The last refresh time. </summary>
        public DateTimeOffset? LastRefreshedOn { get; }
        /// <summary> Progress in percentage. Progress percentage is calculated based on processed bytes. </summary>
        public int? ProgressPercentage { get; }
    }
}

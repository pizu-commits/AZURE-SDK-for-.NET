// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information of DPM Protected item. </summary>
    public partial class DpmProtectedItemExtendedInfo
    {
        /// <summary> Initializes a new instance of DpmProtectedItemExtendedInfo. </summary>
        public DpmProtectedItemExtendedInfo()
        {
            ProtectableObjectLoadPath = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DpmProtectedItemExtendedInfo. </summary>
        /// <param name="protectableObjectLoadPath"> Attribute to provide information on various DBs. </param>
        /// <param name="protected"> To check if backup item is disk protected. </param>
        /// <param name="isPresentOnCloud"> To check if backup item is cloud protected. </param>
        /// <param name="lastBackupStatus"> Last backup status information on backup item. </param>
        /// <param name="lastRefreshedOn"> Last refresh time on backup item. </param>
        /// <param name="oldestRecoveryPoint"> Oldest cloud recovery point time. </param>
        /// <param name="recoveryPointCount"> cloud recovery point count. </param>
        /// <param name="onPremiseOldestRecoveryPoint"> Oldest disk recovery point time. </param>
        /// <param name="onPremiseLatestRecoveryPoint"> latest disk recovery point time. </param>
        /// <param name="onPremiseRecoveryPointCount"> disk recovery point count. </param>
        /// <param name="isCollocated"> To check if backup item is collocated. </param>
        /// <param name="protectionGroupName"> Protection group name of the backup item. </param>
        /// <param name="diskStorageUsedInBytes"> Used Disk storage in bytes. </param>
        /// <param name="totalDiskStorageSizeInBytes"> total Disk storage in bytes. </param>
        internal DpmProtectedItemExtendedInfo(IDictionary<string, string> protectableObjectLoadPath, bool? @protected, bool? isPresentOnCloud, string lastBackupStatus, DateTimeOffset? lastRefreshedOn, DateTimeOffset? oldestRecoveryPoint, int? recoveryPointCount, DateTimeOffset? onPremiseOldestRecoveryPoint, DateTimeOffset? onPremiseLatestRecoveryPoint, int? onPremiseRecoveryPointCount, bool? isCollocated, string protectionGroupName, string diskStorageUsedInBytes, string totalDiskStorageSizeInBytes)
        {
            ProtectableObjectLoadPath = protectableObjectLoadPath;
            Protected = @protected;
            IsPresentOnCloud = isPresentOnCloud;
            LastBackupStatus = lastBackupStatus;
            LastRefreshedOn = lastRefreshedOn;
            OldestRecoveryPoint = oldestRecoveryPoint;
            RecoveryPointCount = recoveryPointCount;
            OnPremiseOldestRecoveryPoint = onPremiseOldestRecoveryPoint;
            OnPremiseLatestRecoveryPoint = onPremiseLatestRecoveryPoint;
            OnPremiseRecoveryPointCount = onPremiseRecoveryPointCount;
            IsCollocated = isCollocated;
            ProtectionGroupName = protectionGroupName;
            DiskStorageUsedInBytes = diskStorageUsedInBytes;
            TotalDiskStorageSizeInBytes = totalDiskStorageSizeInBytes;
        }

        /// <summary> Attribute to provide information on various DBs. </summary>
        public IDictionary<string, string> ProtectableObjectLoadPath { get; }
        /// <summary> To check if backup item is disk protected. </summary>
        public bool? Protected { get; set; }
        /// <summary> To check if backup item is cloud protected. </summary>
        public bool? IsPresentOnCloud { get; set; }
        /// <summary> Last backup status information on backup item. </summary>
        public string LastBackupStatus { get; set; }
        /// <summary> Last refresh time on backup item. </summary>
        public DateTimeOffset? LastRefreshedOn { get; set; }
        /// <summary> Oldest cloud recovery point time. </summary>
        public DateTimeOffset? OldestRecoveryPoint { get; set; }
        /// <summary> cloud recovery point count. </summary>
        public int? RecoveryPointCount { get; set; }
        /// <summary> Oldest disk recovery point time. </summary>
        public DateTimeOffset? OnPremiseOldestRecoveryPoint { get; set; }
        /// <summary> latest disk recovery point time. </summary>
        public DateTimeOffset? OnPremiseLatestRecoveryPoint { get; set; }
        /// <summary> disk recovery point count. </summary>
        public int? OnPremiseRecoveryPointCount { get; set; }
        /// <summary> To check if backup item is collocated. </summary>
        public bool? IsCollocated { get; set; }
        /// <summary> Protection group name of the backup item. </summary>
        public string ProtectionGroupName { get; set; }
        /// <summary> Used Disk storage in bytes. </summary>
        public string DiskStorageUsedInBytes { get; set; }
        /// <summary> total Disk storage in bytes. </summary>
        public string TotalDiskStorageSizeInBytes { get; set; }
    }
}

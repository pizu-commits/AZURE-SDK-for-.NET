// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// AzureWorkload SQL -specific restore. Specifically for full/diff restore
    /// Please note <see cref="WorkloadSqlRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadSqlPointInTimeRestoreContent"/>, <see cref="WorkloadSqlPointInTimeRestoreWithRehydrateContent"/> and <see cref="WorkloadSqlRestoreWithRehydrateContent"/>.
    /// </summary>
    public partial class WorkloadSqlRestoreContent : WorkloadRestoreContent
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadSqlRestoreContent"/>. </summary>
        public WorkloadSqlRestoreContent()
        {
            AlternateDirectoryPaths = new ChangeTrackingList<SqlDataDirectoryMapping>();
            ObjectType = "AzureWorkloadSQLRestoreRequest";
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadSqlRestoreContent"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryType"> Type of this recovery. </param>
        /// <param name="sourceResourceId"> Fully qualified ARM ID of the VM on which workload that was running is being recovered. </param>
        /// <param name="propertyBag"> Workload specific property bag. </param>
        /// <param name="targetInfo"> Details of target database. </param>
        /// <param name="recoveryMode"> Defines whether the current recovery mode is file restore or database restore. </param>
        /// <param name="targetResourceGroupName"> Defines the Resource group of the Target VM. </param>
        /// <param name="userAssignedManagedIdentityDetails">
        /// User Assigned managed identity details
        /// Currently used for snapshot.
        /// </param>
        /// <param name="snapshotRestoreParameters">
        /// Additional details for snapshot recovery
        /// Currently used for snapshot for SAP Hana.
        /// </param>
        /// <param name="targetVirtualMachineId">
        /// This is the complete ARM Id of the target VM
        /// For e.g. /subscriptions/{subId}/resourcegroups/{rg}/provider/Microsoft.Compute/virtualmachines/{vm}
        /// </param>
        /// <param name="shouldUseAlternateTargetLocation"> Default option set to true. If this is set to false, alternate data directory must be provided. </param>
        /// <param name="isNonRecoverable"> SQL specific property where user can chose to set no-recovery when restore operation is tried. </param>
        /// <param name="alternateDirectoryPaths"> Data directory details. </param>
        internal WorkloadSqlRestoreContent(string objectType, FileShareRecoveryType? recoveryType, ResourceIdentifier sourceResourceId, IDictionary<string, string> propertyBag, TargetRestoreInfo targetInfo, RecoveryMode? recoveryMode, string targetResourceGroupName, UserAssignedManagedIdentityDetails userAssignedManagedIdentityDetails, SnapshotRestoreContent snapshotRestoreParameters, ResourceIdentifier targetVirtualMachineId, bool? shouldUseAlternateTargetLocation, bool? isNonRecoverable, IList<SqlDataDirectoryMapping> alternateDirectoryPaths) : base(objectType, recoveryType, sourceResourceId, propertyBag, targetInfo, recoveryMode, targetResourceGroupName, userAssignedManagedIdentityDetails, snapshotRestoreParameters, targetVirtualMachineId)
        {
            ShouldUseAlternateTargetLocation = shouldUseAlternateTargetLocation;
            IsNonRecoverable = isNonRecoverable;
            AlternateDirectoryPaths = alternateDirectoryPaths;
            ObjectType = objectType ?? "AzureWorkloadSQLRestoreRequest";
        }

        /// <summary> Default option set to true. If this is set to false, alternate data directory must be provided. </summary>
        public bool? ShouldUseAlternateTargetLocation { get; set; }
        /// <summary> SQL specific property where user can chose to set no-recovery when restore operation is tried. </summary>
        public bool? IsNonRecoverable { get; set; }
        /// <summary> Data directory details. </summary>
        public IList<SqlDataDirectoryMapping> AlternateDirectoryPaths { get; }
    }
}

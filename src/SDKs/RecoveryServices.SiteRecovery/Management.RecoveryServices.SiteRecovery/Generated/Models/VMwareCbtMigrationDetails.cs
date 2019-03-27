// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VMwareCbt provider specific settings
    /// </summary>
    [Newtonsoft.Json.JsonObject("VMwareCbt")]
    public partial class VMwareCbtMigrationDetails : MigrationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the VMwareCbtMigrationDetails class.
        /// </summary>
        public VMwareCbtMigrationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMwareCbtMigrationDetails class.
        /// </summary>
        /// <param name="vmwareMachineId">The ARM Id of the VM discovered in
        /// VMware.</param>
        /// <param name="osType">The type of the OS on the VM.</param>
        /// <param name="licenseType">License Type of the VM to be
        /// used.</param>
        /// <param name="dataMoverRunAsAccountId">The data mover RunAs account
        /// Id.</param>
        /// <param name="snapshotRunAsAccountId">The snapshot RunAs account
        /// Id.</param>
        /// <param name="targetVmName">Target VM name.</param>
        /// <param name="targetVmSize">The target VM size.</param>
        /// <param name="targetLocation">The target location.</param>
        /// <param name="targetResourceGroupId">The target resource group
        /// Id.</param>
        /// <param name="targetAvailabilitySetId">The target availability set
        /// Id.</param>
        /// <param name="targetBootDiagnosticsStorageAccountId">The target boot
        /// diagnostics storage account ARM Id.</param>
        /// <param name="protectedDisks">The list of protected disks.</param>
        /// <param name="targetNetworkId">The target network Id.</param>
        /// <param name="vmNics">The network details.</param>
        /// <param name="migrationRecoveryPointId">The recovery point Id to
        /// which the VM was migrated.</param>
        /// <param name="lastRecoveryPointReceived">The last recovery point
        /// received time.</param>
        public VMwareCbtMigrationDetails(string vmwareMachineId = default(string), string osType = default(string), string licenseType = default(string), string dataMoverRunAsAccountId = default(string), string snapshotRunAsAccountId = default(string), string targetVmName = default(string), string targetVmSize = default(string), string targetLocation = default(string), string targetResourceGroupId = default(string), string targetAvailabilitySetId = default(string), string targetBootDiagnosticsStorageAccountId = default(string), IList<VMwareCbtProtectedDiskDetails> protectedDisks = default(IList<VMwareCbtProtectedDiskDetails>), string targetNetworkId = default(string), IList<VMwareCbtNicDetails> vmNics = default(IList<VMwareCbtNicDetails>), string migrationRecoveryPointId = default(string), System.DateTime? lastRecoveryPointReceived = default(System.DateTime?))
        {
            VmwareMachineId = vmwareMachineId;
            OsType = osType;
            LicenseType = licenseType;
            DataMoverRunAsAccountId = dataMoverRunAsAccountId;
            SnapshotRunAsAccountId = snapshotRunAsAccountId;
            TargetVmName = targetVmName;
            TargetVmSize = targetVmSize;
            TargetLocation = targetLocation;
            TargetResourceGroupId = targetResourceGroupId;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetBootDiagnosticsStorageAccountId = targetBootDiagnosticsStorageAccountId;
            ProtectedDisks = protectedDisks;
            TargetNetworkId = targetNetworkId;
            VmNics = vmNics;
            MigrationRecoveryPointId = migrationRecoveryPointId;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ARM Id of the VM discovered in VMware.
        /// </summary>
        [JsonProperty(PropertyName = "vmwareMachineId")]
        public string VmwareMachineId { get; private set; }

        /// <summary>
        /// Gets the type of the OS on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; private set; }

        /// <summary>
        /// Gets or sets license Type of the VM to be used.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets the data mover RunAs account Id.
        /// </summary>
        [JsonProperty(PropertyName = "dataMoverRunAsAccountId")]
        public string DataMoverRunAsAccountId { get; private set; }

        /// <summary>
        /// Gets the snapshot RunAs account Id.
        /// </summary>
        [JsonProperty(PropertyName = "snapshotRunAsAccountId")]
        public string SnapshotRunAsAccountId { get; private set; }

        /// <summary>
        /// Gets or sets target VM name.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmName")]
        public string TargetVmName { get; set; }

        /// <summary>
        /// Gets or sets the target VM size.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmSize")]
        public string TargetVmSize { get; set; }

        /// <summary>
        /// Gets the target location.
        /// </summary>
        [JsonProperty(PropertyName = "targetLocation")]
        public string TargetLocation { get; private set; }

        /// <summary>
        /// Gets or sets the target resource group Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroupId")]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the target availability set Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilitySetId")]
        public string TargetAvailabilitySetId { get; set; }

        /// <summary>
        /// Gets or sets the target boot diagnostics storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetBootDiagnosticsStorageAccountId")]
        public string TargetBootDiagnosticsStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<VMwareCbtProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets or sets the target network Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetNetworkId")]
        public string TargetNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMwareCbtNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets the recovery point Id to which the VM was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "migrationRecoveryPointId")]
        public string MigrationRecoveryPointId { get; private set; }

        /// <summary>
        /// Gets the last recovery point received time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRecoveryPointReceived")]
        public System.DateTime? LastRecoveryPointReceived { get; private set; }

    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DPM workload-specific protection container.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DPMContainer")]
    public partial class DpmContainer : ProtectionContainer
    {
        /// <summary>
        /// Initializes a new instance of the DpmContainer class.
        /// </summary>
        public DpmContainer()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DpmContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup managemenent for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        /// <param name="registrationStatus">Status of registration of the
        /// container with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="containerType">Type of the container. The value of
        /// this property for: 1. Compute Azure VM is
        /// Microsoft.Compute/virtualMachines 2. Classic Compute Azure VM is
        /// Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like
        /// MAB, DPM etc) is Windows 4. Azure SQL instance is
        /// AzureSqlContainer. Possible values include: 'Invalid', 'Unknown',
        /// 'IaasVMContainer', 'IaasVMServiceContainer', 'DPMContainer',
        /// 'AzureBackupServerContainer', 'MABContainer', 'Cluster',
        /// 'AzureSqlContainer', 'Windows', 'VCenter'</param>
        /// <param name="canReRegister">Specifies whether the container is
        /// re-registrable.</param>
        /// <param name="containerId">ID of container.</param>
        /// <param name="protectedItemCount">Number of protected items in the
        /// BackupEngine</param>
        /// <param name="dpmAgentVersion">Backup engine Agent version</param>
        /// <param name="dPMServers">List of BackupEngines protecting the
        /// container</param>
        /// <param name="upgradeAvailable">To check if upgrade
        /// available</param>
        /// <param name="protectionStatus">Protection status of the
        /// container.</param>
        /// <param name="extendedInfo">Extended Info of the container.</param>
        public DpmContainer(string friendlyName = default(string), string backupManagementType = default(string), string registrationStatus = default(string), string healthStatus = default(string), string containerType = default(string), bool? canReRegister = default(bool?), string containerId = default(string), long? protectedItemCount = default(long?), string dpmAgentVersion = default(string), IList<string> dPMServers = default(IList<string>), bool? upgradeAvailable = default(bool?), string protectionStatus = default(string), DPMContainerExtendedInfo extendedInfo = default(DPMContainerExtendedInfo))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType)
        {
            CanReRegister = canReRegister;
            ContainerId = containerId;
            ProtectedItemCount = protectedItemCount;
            DpmAgentVersion = dpmAgentVersion;
            DPMServers = dPMServers;
            UpgradeAvailable = upgradeAvailable;
            ProtectionStatus = protectionStatus;
            ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether the container is re-registrable.
        /// </summary>
        [JsonProperty(PropertyName = "canReRegister")]
        public bool? CanReRegister { get; set; }

        /// <summary>
        /// Gets or sets ID of container.
        /// </summary>
        [JsonProperty(PropertyName = "containerId")]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or sets number of protected items in the BackupEngine
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemCount")]
        public long? ProtectedItemCount { get; set; }

        /// <summary>
        /// Gets or sets backup engine Agent version
        /// </summary>
        [JsonProperty(PropertyName = "dpmAgentVersion")]
        public string DpmAgentVersion { get; set; }

        /// <summary>
        /// Gets or sets list of BackupEngines protecting the container
        /// </summary>
        [JsonProperty(PropertyName = "DPMServers")]
        public IList<string> DPMServers { get; set; }

        /// <summary>
        /// Gets or sets to check if upgrade available
        /// </summary>
        [JsonProperty(PropertyName = "UpgradeAvailable")]
        public bool? UpgradeAvailable { get; set; }

        /// <summary>
        /// Gets or sets protection status of the container.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStatus")]
        public string ProtectionStatus { get; set; }

        /// <summary>
        /// Gets or sets extended Info of the container.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public DPMContainerExtendedInfo ExtendedInfo { get; set; }

    }
}

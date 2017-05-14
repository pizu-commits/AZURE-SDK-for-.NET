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
    /// A2A provider specific settings.
    /// </summary>
    [JsonObject("A2A")]
    public partial class A2AReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the A2AReplicationDetails class.
        /// </summary>
        public A2AReplicationDetails() { }

        /// <summary>
        /// Initializes a new instance of the A2AReplicationDetails class.
        /// </summary>
        public A2AReplicationDetails(string fabricObjectId = default(string), string multiVmGroupId = default(string), string multiVmGroupName = default(string), string managementId = default(string), IList<A2AProtectedDiskDetails> protectedDisks = default(IList<A2AProtectedDiskDetails>), string primaryFabricLocation = default(string), string recoveryFabricLocation = default(string), string osType = default(string), string recoveryAzureVMSize = default(string), string recoveryAzureVMName = default(string), string recoveryAzureResourceGroupId = default(string), string recoveryCloudService = default(string), string recoveryAvailabilitySet = default(string), string selectedRecoveryAzureNetworkId = default(string), IList<VMNicDetails> vmNics = default(IList<VMNicDetails>), AzureToAzureVmSyncedConfigDetails vmSyncedConfigDetails = default(AzureToAzureVmSyncedConfigDetails), int? monitoringPercentageCompletion = default(int?), string monitoringJobType = default(string), DateTime? lastHeartbeat = default(DateTime?), string agentVersion = default(string), bool? isReplicationAgentUpdateRequired = default(bool?), string recoveryFabricObjectId = default(string), string vmProtectionState = default(string), string vmProtectionStateDescription = default(string), string lifecycleId = default(string))
        {
            FabricObjectId = fabricObjectId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            ManagementId = managementId;
            ProtectedDisks = protectedDisks;
            PrimaryFabricLocation = primaryFabricLocation;
            RecoveryFabricLocation = recoveryFabricLocation;
            OsType = osType;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            RecoveryAzureVMName = recoveryAzureVMName;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryCloudService = recoveryCloudService;
            RecoveryAvailabilitySet = recoveryAvailabilitySet;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            VmNics = vmNics;
            VmSyncedConfigDetails = vmSyncedConfigDetails;
            MonitoringPercentageCompletion = monitoringPercentageCompletion;
            MonitoringJobType = monitoringJobType;
            LastHeartbeat = lastHeartbeat;
            AgentVersion = agentVersion;
            IsReplicationAgentUpdateRequired = isReplicationAgentUpdateRequired;
            RecoveryFabricObjectId = recoveryFabricObjectId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            LifecycleId = lifecycleId;
        }

        /// <summary>
        /// The fabric specific object Id of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId { get; set; }

        /// <summary>
        /// The multi vm group Id.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// The multi vm group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// The management Id.
        /// </summary>
        [JsonProperty(PropertyName = "managementId")]
        public string ManagementId { get; set; }

        /// <summary>
        /// The list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<A2AProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Primary fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricLocation")]
        public string PrimaryFabricLocation { get; set; }

        /// <summary>
        /// The recovery fabric location.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricLocation")]
        public string RecoveryFabricLocation { get; set; }

        /// <summary>
        /// The type of operating system.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; set; }

        /// <summary>
        /// The size of recovery virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMSize")]
        public string RecoveryAzureVMSize { get; set; }

        /// <summary>
        /// The name of recovery virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureVMName")]
        public string RecoveryAzureVMName { get; set; }

        /// <summary>
        /// The recovery resource group.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAzureResourceGroupId")]
        public string RecoveryAzureResourceGroupId { get; set; }

        /// <summary>
        /// The recovery cloud service.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryCloudService")]
        public string RecoveryCloudService { get; set; }

        /// <summary>
        /// The recovery availability set.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryAvailabilitySet")]
        public string RecoveryAvailabilitySet { get; set; }

        /// <summary>
        /// The recovery virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "selectedRecoveryAzureNetworkId")]
        public string SelectedRecoveryAzureNetworkId { get; set; }

        /// <summary>
        /// The virtual machine nic details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicDetails> VmNics { get; set; }

        /// <summary>
        /// The synced configuration details.
        /// </summary>
        [JsonProperty(PropertyName = "vmSyncedConfigDetails")]
        public AzureToAzureVmSyncedConfigDetails VmSyncedConfigDetails { get; set; }

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
        /// The last heartbeat received from the source server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// The agent version.
        /// </summary>
        [JsonProperty(PropertyName = "agentVersion")]
        public string AgentVersion { get; set; }

        /// <summary>
        /// A value indicating whether replication agent update is required.
        /// </summary>
        [JsonProperty(PropertyName = "isReplicationAgentUpdateRequired")]
        public bool? IsReplicationAgentUpdateRequired { get; set; }

        /// <summary>
        /// The recovery fabric object Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricObjectId")]
        public string RecoveryFabricObjectId { get; set; }

        /// <summary>
        /// The protection state for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionState")]
        public string VmProtectionState { get; set; }

        /// <summary>
        /// The protection state description for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionStateDescription")]
        public string VmProtectionStateDescription { get; set; }

        /// <summary>
        /// An id associated with the PE that survives actions like switch
        /// protection
        /// which change the backing PE/CPE objects internally.The
        /// lifecycle id gets carried
        /// forward to have a link/continuity in being able to
        /// have an Id that denotes the "same"
        /// protected item even though other internal Ids/ARM Id
        /// might be changing.
        /// </summary>
        [JsonProperty(PropertyName = "lifecycleId")]
        public string LifecycleId { get; set; }

    }
}

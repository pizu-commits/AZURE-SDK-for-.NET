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
    /// HyperV replica 2012 R2 (Blue) replication details.
    /// </summary>
    [JsonObject("HyperVReplica2012R2")]
    public partial class HyperVReplicaBlueReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaBlueReplicationDetails class.
        /// </summary>
        public HyperVReplicaBlueReplicationDetails() { }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaBlueReplicationDetails class.
        /// </summary>
        public HyperVReplicaBlueReplicationDetails(DateTime? lastReplicatedTime = default(DateTime?), IList<VMNicDetails> vmNics = default(IList<VMNicDetails>), string vmId = default(string), string vmProtectionState = default(string), string vmProtectionStateDescription = default(string), InitialReplicationDetails initialReplicationDetails = default(InitialReplicationDetails), IList<DiskDetails> vMDiskDetails = default(IList<DiskDetails>))
        {
            LastReplicatedTime = lastReplicatedTime;
            VmNics = vmNics;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            InitialReplicationDetails = initialReplicationDetails;
            VMDiskDetails = vMDiskDetails;
        }

        /// <summary>
        /// The Last replication time.
        /// </summary>
        [JsonProperty(PropertyName = "lastReplicatedTime")]
        public DateTime? LastReplicatedTime { get; set; }

        /// <summary>
        /// The PE Network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicDetails> VmNics { get; set; }

        /// <summary>
        /// The virtual machine Id.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

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
        /// Initial replication details.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationDetails")]
        public InitialReplicationDetails InitialReplicationDetails { get; set; }

        /// <summary>
        /// VM disk details.
        /// </summary>
        [JsonProperty(PropertyName = "vMDiskDetails")]
        public IList<DiskDetails> VMDiskDetails { get; set; }

    }
}

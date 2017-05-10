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
    /// Hyper-V Replica Azure specific protection profile details.
    /// </summary>
    [JsonObject("HyperVReplicaAzure")]
    public partial class HyperVReplicaAzurePolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzurePolicyDetails
        /// class.
        /// </summary>
        public HyperVReplicaAzurePolicyDetails() { }

        /// <summary>
        /// Initializes a new instance of the HyperVReplicaAzurePolicyDetails
        /// class.
        /// </summary>
        public HyperVReplicaAzurePolicyDetails(int? recoveryPointHistoryDurationInHours = default(int?), int? applicationConsistentSnapshotFrequencyInHours = default(int?), int? replicationInterval = default(int?), string onlineReplicationStartTime = default(string), string encryption = default(string), string activeStorageAccountId = default(string))
        {
            RecoveryPointHistoryDurationInHours = recoveryPointHistoryDurationInHours;
            ApplicationConsistentSnapshotFrequencyInHours = applicationConsistentSnapshotFrequencyInHours;
            ReplicationInterval = replicationInterval;
            OnlineReplicationStartTime = onlineReplicationStartTime;
            Encryption = encryption;
            ActiveStorageAccountId = activeStorageAccountId;
        }

        /// <summary>
        /// The duration (in hours) to which point the recovery history needs
        /// to be
        /// maintained.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointHistoryDurationInHours")]
        public int? RecoveryPointHistoryDurationInHours { get; set; }

        /// <summary>
        /// The interval (in hours) at which Hyper-V Replica should create an
        /// application consistent snapshot within the VM.
        /// </summary>
        [JsonProperty(PropertyName = "applicationConsistentSnapshotFrequencyInHours")]
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; set; }

        /// <summary>
        /// The replication interval.
        /// </summary>
        [JsonProperty(PropertyName = "replicationInterval")]
        public int? ReplicationInterval { get; set; }

        /// <summary>
        /// The scheduled start time for the initial replication. If this
        /// parameter
        /// is Null, the initial replication starts immediately.
        /// </summary>
        [JsonProperty(PropertyName = "onlineReplicationStartTime")]
        public string OnlineReplicationStartTime { get; set; }

        /// <summary>
        /// A value indicating whether encryption is enabled for virtual
        /// machines
        /// in this cloud.
        /// </summary>
        [JsonProperty(PropertyName = "encryption")]
        public string Encryption { get; set; }

        /// <summary>
        /// The active storage account Id.
        /// </summary>
        [JsonProperty(PropertyName = "activeStorageAccountId")]
        public string ActiveStorageAccountId { get; set; }

    }
}

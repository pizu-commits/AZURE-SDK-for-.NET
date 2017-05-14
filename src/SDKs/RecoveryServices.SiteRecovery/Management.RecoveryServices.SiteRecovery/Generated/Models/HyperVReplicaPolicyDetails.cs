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
    /// Hyper-V Replica Blue specific protection profile details.
    /// </summary>
    [JsonObject("HyperVReplica2012")]
    public partial class HyperVReplicaPolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the HyperVReplicaPolicyDetails class.
        /// </summary>
        public HyperVReplicaPolicyDetails() { }

        /// <summary>
        /// Initializes a new instance of the HyperVReplicaPolicyDetails class.
        /// </summary>
        public HyperVReplicaPolicyDetails(int? recoveryPoints = default(int?), int? applicationConsistentSnapshotFrequencyInHours = default(int?), string compression = default(string), string initialReplicationMethod = default(string), string onlineReplicationStartTime = default(string), string offlineReplicationImportPath = default(string), string offlineReplicationExportPath = default(string), int? replicationPort = default(int?), int? allowedAuthenticationType = default(int?), string replicaDeletionOption = default(string))
        {
            RecoveryPoints = recoveryPoints;
            ApplicationConsistentSnapshotFrequencyInHours = applicationConsistentSnapshotFrequencyInHours;
            Compression = compression;
            InitialReplicationMethod = initialReplicationMethod;
            OnlineReplicationStartTime = onlineReplicationStartTime;
            OfflineReplicationImportPath = offlineReplicationImportPath;
            OfflineReplicationExportPath = offlineReplicationExportPath;
            ReplicationPort = replicationPort;
            AllowedAuthenticationType = allowedAuthenticationType;
            ReplicaDeletionOption = replicaDeletionOption;
        }

        /// <summary>
        /// A value indicating the number of recovery points.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPoints")]
        public int? RecoveryPoints { get; set; }

        /// <summary>
        /// A value indicating the application consistent frequency.
        /// </summary>
        [JsonProperty(PropertyName = "applicationConsistentSnapshotFrequencyInHours")]
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; set; }

        /// <summary>
        /// A value indicating whether compression has to be enabled.
        /// </summary>
        [JsonProperty(PropertyName = "compression")]
        public string Compression { get; set; }

        /// <summary>
        /// A value indicating whether IR is online.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationMethod")]
        public string InitialReplicationMethod { get; set; }

        /// <summary>
        /// A value indicating the online IR start time.
        /// </summary>
        [JsonProperty(PropertyName = "onlineReplicationStartTime")]
        public string OnlineReplicationStartTime { get; set; }

        /// <summary>
        /// A value indicating the offline IR import path.
        /// </summary>
        [JsonProperty(PropertyName = "offlineReplicationImportPath")]
        public string OfflineReplicationImportPath { get; set; }

        /// <summary>
        /// A value indicating the offline IR export path.
        /// </summary>
        [JsonProperty(PropertyName = "offlineReplicationExportPath")]
        public string OfflineReplicationExportPath { get; set; }

        /// <summary>
        /// A value indicating the recovery HTTPS port.
        /// </summary>
        [JsonProperty(PropertyName = "replicationPort")]
        public int? ReplicationPort { get; set; }

        /// <summary>
        /// A value indicating the authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "allowedAuthenticationType")]
        public int? AllowedAuthenticationType { get; set; }

        /// <summary>
        /// A value indicating whether the VM has to be auto deleted.
        /// Supported Values: String.Empty, None, OnRecoveryCloud
        /// </summary>
        [JsonProperty(PropertyName = "replicaDeletionOption")]
        public string ReplicaDeletionOption { get; set; }

    }
}

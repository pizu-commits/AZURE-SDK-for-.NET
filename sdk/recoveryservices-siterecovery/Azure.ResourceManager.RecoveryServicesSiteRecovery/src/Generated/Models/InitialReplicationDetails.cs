// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Initial replication details. </summary>
    public partial class InitialReplicationDetails
    {
        /// <summary> Initializes a new instance of InitialReplicationDetails. </summary>
        internal InitialReplicationDetails()
        {
        }

        /// <summary> Initializes a new instance of InitialReplicationDetails. </summary>
        /// <param name="initialReplicationType"> Initial replication type. </param>
        /// <param name="initialReplicationProgressPercentage"> The initial replication progress percentage. </param>
        internal InitialReplicationDetails(string initialReplicationType, string initialReplicationProgressPercentage)
        {
            InitialReplicationType = initialReplicationType;
            InitialReplicationProgressPercentage = initialReplicationProgressPercentage;
        }

        /// <summary> Initial replication type. </summary>
        public string InitialReplicationType { get; }
        /// <summary> The initial replication progress percentage. </summary>
        public string InitialReplicationProgressPercentage { get; }
    }
}

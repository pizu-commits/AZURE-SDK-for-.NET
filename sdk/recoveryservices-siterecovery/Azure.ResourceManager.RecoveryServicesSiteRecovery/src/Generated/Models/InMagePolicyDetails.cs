// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMage specific protection profile details. </summary>
    public partial class InMagePolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of InMagePolicyDetails. </summary>
        internal InMagePolicyDetails()
        {
            InstanceType = "InMage";
        }

        /// <summary> Initializes a new instance of InMagePolicyDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="recoveryPointThresholdInMinutes"> The recovery point threshold in minutes. </param>
        /// <param name="recoveryPointHistory"> The duration in minutes until which the recovery points need to be stored. </param>
        /// <param name="appConsistentFrequencyInMinutes"> The app consistent snapshot frequency in minutes. </param>
        /// <param name="multiVmSyncStatus"> A value indicating whether multi-VM sync has to be enabled. </param>
        internal InMagePolicyDetails(string instanceType, int? recoveryPointThresholdInMinutes, int? recoveryPointHistory, int? appConsistentFrequencyInMinutes, string multiVmSyncStatus) : base(instanceType)
        {
            RecoveryPointThresholdInMinutes = recoveryPointThresholdInMinutes;
            RecoveryPointHistory = recoveryPointHistory;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            MultiVmSyncStatus = multiVmSyncStatus;
            InstanceType = instanceType ?? "InMage";
        }

        /// <summary> The recovery point threshold in minutes. </summary>
        public int? RecoveryPointThresholdInMinutes { get; }
        /// <summary> The duration in minutes until which the recovery points need to be stored. </summary>
        public int? RecoveryPointHistory { get; }
        /// <summary> The app consistent snapshot frequency in minutes. </summary>
        public int? AppConsistentFrequencyInMinutes { get; }
        /// <summary> A value indicating whether multi-VM sync has to be enabled. </summary>
        public string MultiVmSyncStatus { get; }
    }
}

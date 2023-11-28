// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownRecoveryPlanProviderSpecificDetails. </summary>
    internal partial class UnknownRecoveryPlanProviderSpecificDetails : RecoveryPlanProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryPlanProviderSpecificDetails"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        internal UnknownRecoveryPlanProviderSpecificDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}

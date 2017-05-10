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
    /// InMage disable protection provider specific input.
    /// </summary>
    [JsonObject("InMage")]
    public partial class InMageDisableProtectionProviderSpecificInput : DisableProtectionProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InMageDisableProtectionProviderSpecificInput class.
        /// </summary>
        public InMageDisableProtectionProviderSpecificInput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// InMageDisableProtectionProviderSpecificInput class.
        /// </summary>
        public InMageDisableProtectionProviderSpecificInput(string replicaVmDeletionStatus = default(string))
        {
            ReplicaVmDeletionStatus = replicaVmDeletionStatus;
        }

        /// <summary>
        /// A value indicating whether the replica VM should be destroyed or
        /// retained.
        /// Values from Delete and Retain.
        /// </summary>
        [JsonProperty(PropertyName = "replicaVmDeletionStatus")]
        public string ReplicaVmDeletionStatus { get; set; }

    }
}

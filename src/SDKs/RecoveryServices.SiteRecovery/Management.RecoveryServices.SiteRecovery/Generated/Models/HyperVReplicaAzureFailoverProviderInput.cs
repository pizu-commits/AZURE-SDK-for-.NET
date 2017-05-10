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
    /// HvrA provider specific input for failover.
    /// </summary>
    [JsonObject("HyperVReplicaAzure")]
    public partial class HyperVReplicaAzureFailoverProviderInput : ProviderSpecificFailoverInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureFailoverProviderInput class.
        /// </summary>
        public HyperVReplicaAzureFailoverProviderInput() { }

        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplicaAzureFailoverProviderInput class.
        /// </summary>
        public HyperVReplicaAzureFailoverProviderInput(string vaultLocation = default(string), string primaryKekCertificatePfx = default(string), string secondaryKekCertificatePfx = default(string), string recoveryPointId = default(string))
        {
            VaultLocation = vaultLocation;
            PrimaryKekCertificatePfx = primaryKekCertificatePfx;
            SecondaryKekCertificatePfx = secondaryKekCertificatePfx;
            RecoveryPointId = recoveryPointId;
        }

        /// <summary>
        /// Location of the vault.
        /// </summary>
        [JsonProperty(PropertyName = "vaultLocation")]
        public string VaultLocation { get; set; }

        /// <summary>
        /// Primary kek certificate pfx.
        /// </summary>
        [JsonProperty(PropertyName = "primaryKekCertificatePfx")]
        public string PrimaryKekCertificatePfx { get; set; }

        /// <summary>
        /// Secondary kek certificate pfx.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryKekCertificatePfx")]
        public string SecondaryKekCertificatePfx { get; set; }

        /// <summary>
        /// The recovery point id to be passed to failover to a particular
        /// recovery
        /// point. In case of latest recovery point, null should
        /// be passed.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId { get; set; }

    }
}

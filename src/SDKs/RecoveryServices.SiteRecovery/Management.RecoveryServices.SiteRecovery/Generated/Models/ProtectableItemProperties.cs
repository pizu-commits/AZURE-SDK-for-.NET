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
    /// Replication protected item custom data details.
    /// </summary>
    public partial class ProtectableItemProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProtectableItemProperties class.
        /// </summary>
        public ProtectableItemProperties() { }

        /// <summary>
        /// Initializes a new instance of the ProtectableItemProperties class.
        /// </summary>
        public ProtectableItemProperties(string friendlyName = default(string), string protectionStatus = default(string), string replicationProtectedItemId = default(string), string recoveryServicesProviderId = default(string), IList<string> protectionReadinessErrors = default(IList<string>), IList<string> supportedReplicationProviders = default(IList<string>), ConfigurationSettings customDetails = default(ConfigurationSettings))
        {
            FriendlyName = friendlyName;
            ProtectionStatus = protectionStatus;
            ReplicationProtectedItemId = replicationProtectedItemId;
            RecoveryServicesProviderId = recoveryServicesProviderId;
            ProtectionReadinessErrors = protectionReadinessErrors;
            SupportedReplicationProviders = supportedReplicationProviders;
            CustomDetails = customDetails;
        }

        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// The protection status.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStatus")]
        public string ProtectionStatus { get; set; }

        /// <summary>
        /// The ARM resource of protected items.
        /// </summary>
        [JsonProperty(PropertyName = "replicationProtectedItemId")]
        public string ReplicationProtectedItemId { get; set; }

        /// <summary>
        /// The recovery provider ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryServicesProviderId")]
        public string RecoveryServicesProviderId { get; set; }

        /// <summary>
        /// The Current protection readiness errors.
        /// </summary>
        [JsonProperty(PropertyName = "protectionReadinessErrors")]
        public IList<string> ProtectionReadinessErrors { get; set; }

        /// <summary>
        /// The list of replication providers supported for the protectable
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "supportedReplicationProviders")]
        public IList<string> SupportedReplicationProviders { get; set; }

        /// <summary>
        /// The Replication provider custom settings.
        /// </summary>
        [JsonProperty(PropertyName = "customDetails")]
        public ConfigurationSettings CustomDetails { get; set; }

    }
}

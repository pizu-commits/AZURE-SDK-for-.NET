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
    /// Replication protected item custom data details.
    /// </summary>
    public partial class ReplicationProtectedItemProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectedItemProperties class.
        /// </summary>
        public ReplicationProtectedItemProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ReplicationProtectedItemProperties class.
        /// </summary>
        public ReplicationProtectedItemProperties(string friendlyName = default(string), string protectedItemType = default(string), string protectableItemId = default(string), string recoveryServicesProviderId = default(string), string primaryFabricFriendlyName = default(string), string recoveryFabricFriendlyName = default(string), string recoveryFabricId = default(string), string primaryProtectionContainerFriendlyName = default(string), string recoveryProtectionContainerFriendlyName = default(string), string protectionState = default(string), string protectionStateDescription = default(string), string activeLocation = default(string), string testFailoverState = default(string), string testFailoverStateDescription = default(string), IList<string> allowedOperations = default(IList<string>), string replicationHealth = default(string), IList<HealthError> replicationHealthErrors = default(IList<HealthError>), string policyId = default(string), string policyFriendlyName = default(string), DateTime? lastSuccessfulFailoverTime = default(DateTime?), DateTime? lastSuccessfulTestFailoverTime = default(DateTime?), CurrentScenarioDetails currentScenario = default(CurrentScenarioDetails), string failoverRecoveryPointId = default(string), ReplicationProviderSpecificSettings providerSpecificDetails = default(ReplicationProviderSpecificSettings), string recoveryContainerId = default(string))
        {
            FriendlyName = friendlyName;
            ProtectedItemType = protectedItemType;
            ProtectableItemId = protectableItemId;
            RecoveryServicesProviderId = recoveryServicesProviderId;
            PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            RecoveryFabricId = recoveryFabricId;
            PrimaryProtectionContainerFriendlyName = primaryProtectionContainerFriendlyName;
            RecoveryProtectionContainerFriendlyName = recoveryProtectionContainerFriendlyName;
            ProtectionState = protectionState;
            ProtectionStateDescription = protectionStateDescription;
            ActiveLocation = activeLocation;
            TestFailoverState = testFailoverState;
            TestFailoverStateDescription = testFailoverStateDescription;
            AllowedOperations = allowedOperations;
            ReplicationHealth = replicationHealth;
            ReplicationHealthErrors = replicationHealthErrors;
            PolicyId = policyId;
            PolicyFriendlyName = policyFriendlyName;
            LastSuccessfulFailoverTime = lastSuccessfulFailoverTime;
            LastSuccessfulTestFailoverTime = lastSuccessfulTestFailoverTime;
            CurrentScenario = currentScenario;
            FailoverRecoveryPointId = failoverRecoveryPointId;
            ProviderSpecificDetails = providerSpecificDetails;
            RecoveryContainerId = recoveryContainerId;
        }

        /// <summary>
        /// The name.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// The type of protected item type.
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemType")]
        public string ProtectedItemType { get; set; }

        /// <summary>
        /// The protected item ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "protectableItemId")]
        public string ProtectableItemId { get; set; }

        /// <summary>
        /// The recovery provider ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryServicesProviderId")]
        public string RecoveryServicesProviderId { get; set; }

        /// <summary>
        /// The friendly name of the primary fabric.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricFriendlyName")]
        public string PrimaryFabricFriendlyName { get; set; }

        /// <summary>
        /// The friendly name of recovery fabric.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricFriendlyName")]
        public string RecoveryFabricFriendlyName { get; set; }

        /// <summary>
        /// The Arm Id of recovery fabric.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricId")]
        public string RecoveryFabricId { get; set; }

        /// <summary>
        /// The name of primary protection container friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "primaryProtectionContainerFriendlyName")]
        public string PrimaryProtectionContainerFriendlyName { get; set; }

        /// <summary>
        /// The name of recovery container friendly name.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryProtectionContainerFriendlyName")]
        public string RecoveryProtectionContainerFriendlyName { get; set; }

        /// <summary>
        /// The protection status.
        /// </summary>
        [JsonProperty(PropertyName = "protectionState")]
        public string ProtectionState { get; set; }

        /// <summary>
        /// The protection state description.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStateDescription")]
        public string ProtectionStateDescription { get; set; }

        /// <summary>
        /// The Current active location of the PE.
        /// </summary>
        [JsonProperty(PropertyName = "activeLocation")]
        public string ActiveLocation { get; set; }

        /// <summary>
        /// The Test failover state.
        /// </summary>
        [JsonProperty(PropertyName = "testFailoverState")]
        public string TestFailoverState { get; set; }

        /// <summary>
        /// The Test failover state description.
        /// </summary>
        [JsonProperty(PropertyName = "testFailoverStateDescription")]
        public string TestFailoverStateDescription { get; set; }

        /// <summary>
        /// The allowed operations on the Replication protected item.
        /// </summary>
        [JsonProperty(PropertyName = "allowedOperations")]
        public IList<string> AllowedOperations { get; set; }

        /// <summary>
        /// The consolidated protection health for the VM taking any issues
        /// with SRS
        /// as well as all the replication units associated with
        /// the VM's replication group into
        /// account. This is a string representation of the
        /// ProtectionHealth enumeration.
        /// </summary>
        [JsonProperty(PropertyName = "replicationHealth")]
        public string ReplicationHealth { get; set; }

        /// <summary>
        /// List of replication health errors.
        /// </summary>
        [JsonProperty(PropertyName = "replicationHealthErrors")]
        public IList<HealthError> ReplicationHealthErrors { get; set; }

        /// <summary>
        /// The ID of Policy governing this PE.
        /// </summary>
        [JsonProperty(PropertyName = "policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// The name of Policy governing this PE.
        /// </summary>
        [JsonProperty(PropertyName = "policyFriendlyName")]
        public string PolicyFriendlyName { get; set; }

        /// <summary>
        /// The Last successful failover time.
        /// </summary>
        [JsonProperty(PropertyName = "lastSuccessfulFailoverTime")]
        public DateTime? LastSuccessfulFailoverTime { get; set; }

        /// <summary>
        /// The Last successful test failover time.
        /// </summary>
        [JsonProperty(PropertyName = "lastSuccessfulTestFailoverTime")]
        public DateTime? LastSuccessfulTestFailoverTime { get; set; }

        /// <summary>
        /// The current scenario.
        /// </summary>
        [JsonProperty(PropertyName = "currentScenario")]
        public CurrentScenarioDetails CurrentScenario { get; set; }

        /// <summary>
        /// The recovery point ARM Id to which the Vm was failed over.
        /// </summary>
        [JsonProperty(PropertyName = "failoverRecoveryPointId")]
        public string FailoverRecoveryPointId { get; set; }

        /// <summary>
        /// The Replication provider custom settings.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ReplicationProviderSpecificSettings ProviderSpecificDetails { get; set; }

        /// <summary>
        /// The recovery container Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryContainerId")]
        public string RecoveryContainerId { get; set; }

    }
}

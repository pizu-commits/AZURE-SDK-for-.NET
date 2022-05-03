// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing the EventHubNamespace data model. </summary>
    public partial class EventHubNamespaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of EventHubNamespaceData. </summary>
        /// <param name="location"> The location. </param>
        public EventHubNamespaceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<EventHubsPrivateEndpointConnectionData>();
            KeyVaultProperties = new ChangeTrackingList<Models.KeyVaultProperties>();
            KeySource = "Microsoft.KeyVault";
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of EventHubNamespaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of sku resource. </param>
        /// <param name="provisioningState"> Provisioning state of the Namespace. </param>
        /// <param name="status"> Status of the Namespace. </param>
        /// <param name="createdOn"> The time the Namespace was created. </param>
        /// <param name="updatedOn"> The time the Namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="clusterArmId"> Cluster ARM ID of the Namespace. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="isAutoInflateEnabled"> Value that indicates whether AutoInflate is enabled for eventhub namespace. </param>
        /// <param name="maximumThroughputUnits"> Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( &apos;0&apos; if AutoInflateEnabled = true). </param>
        /// <param name="kafkaEnabled"> Value that indicates whether Kafka is enabled for eventhub namespace. </param>
        /// <param name="zoneRedundant"> Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Event Hubs namespace. </param>
        /// <param name="alternateName"> Alternate name specified when alias and namespace names are same. </param>
        /// <param name="keyVaultProperties"> Properties of KeyVault. </param>
        /// <param name="keySource"> Enumerates the possible value of keySource for Encryption. </param>
        /// <param name="requireInfrastructureEncryption"> Enable Infrastructure Encryption (Double Encryption). </param>
        /// <param name="principalId"> ObjectId from the KeyVault. </param>
        /// <param name="tenantId"> TenantId from the KeyVault. </param>
        /// <param name="typeIdentityType"> Type of managed service identity. </param>
        /// <param name="userAssignedIdentities"> Properties for User Assigned Identities. </param>
        internal EventHubNamespaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, EventHubsSku sku, string provisioningState, string status, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string serviceBusEndpoint, string clusterArmId, string metricId, bool? isAutoInflateEnabled, int? maximumThroughputUnits, bool? kafkaEnabled, bool? zoneRedundant, IList<EventHubsPrivateEndpointConnectionData> privateEndpointConnections, bool? disableLocalAuth, string alternateName, IList<Models.KeyVaultProperties> keyVaultProperties, string keySource, bool? requireInfrastructureEncryption, string principalId, string tenantId, ResourceIdentityType? typeIdentityType, IDictionary<string, UserAssignedIdentity> userAssignedIdentities) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ServiceBusEndpoint = serviceBusEndpoint;
            ClusterArmId = clusterArmId;
            MetricId = metricId;
            IsAutoInflateEnabled = isAutoInflateEnabled;
            MaximumThroughputUnits = maximumThroughputUnits;
            KafkaEnabled = kafkaEnabled;
            ZoneRedundant = zoneRedundant;
            PrivateEndpointConnections = privateEndpointConnections;
            DisableLocalAuth = disableLocalAuth;
            AlternateName = alternateName;
            KeyVaultProperties = keyVaultProperties;
            KeySource = keySource;
            RequireInfrastructureEncryption = requireInfrastructureEncryption;
            PrincipalId = principalId;
            TenantId = tenantId;
            TypeIdentityType = typeIdentityType;
            UserAssignedIdentities = userAssignedIdentities;
        }

        /// <summary> Properties of sku resource. </summary>
        public EventHubsSku Sku { get; set; }
        /// <summary> Provisioning state of the Namespace. </summary>
        public string ProvisioningState { get; }
        /// <summary> Status of the Namespace. </summary>
        public string Status { get; }
        /// <summary> The time the Namespace was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the Namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Cluster ARM ID of the Namespace. </summary>
        public string ClusterArmId { get; set; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> Value that indicates whether AutoInflate is enabled for eventhub namespace. </summary>
        public bool? IsAutoInflateEnabled { get; set; }
        /// <summary> Upper limit of throughput units when AutoInflate is enabled, value should be within 0 to 20 throughput units. ( &apos;0&apos; if AutoInflateEnabled = true). </summary>
        public int? MaximumThroughputUnits { get; set; }
        /// <summary> Value that indicates whether Kafka is enabled for eventhub namespace. </summary>
        public bool? KafkaEnabled { get; set; }
        /// <summary> Enabling this property creates a Standard Event Hubs Namespace in regions supported availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> List of private endpoint connections. </summary>
        public IList<EventHubsPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> This property disables SAS authentication for the Event Hubs namespace. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Alternate name specified when alias and namespace names are same. </summary>
        public string AlternateName { get; set; }
        /// <summary> Properties of KeyVault. </summary>
        public IList<Models.KeyVaultProperties> KeyVaultProperties { get; }
        /// <summary> Enumerates the possible value of keySource for Encryption. </summary>
        public string KeySource { get; set; }
        /// <summary> Enable Infrastructure Encryption (Double Encryption). </summary>
        public bool? RequireInfrastructureEncryption { get; set; }
        /// <summary> ObjectId from the KeyVault. </summary>
        public string PrincipalId { get; }
        /// <summary> TenantId from the KeyVault. </summary>
        public string TenantId { get; }
        /// <summary> Type of managed service identity. </summary>
        public ResourceIdentityType? TypeIdentityType { get; set; }
        /// <summary> Properties for User Assigned Identities. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}

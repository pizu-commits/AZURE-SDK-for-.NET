// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Description of a namespace resource. </summary>
    public partial class ServiceBusNamespaceUpdateOptions : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ServiceBusNamespaceUpdateOptions. </summary>
        /// <param name="location"> The location. </param>
        public ServiceBusNamespaceUpdateOptions(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ServiceBusNamespaceUpdateOptions. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of SKU. </param>
        /// <param name="identity"> Properties of BYOK Identity description. </param>
        /// <param name="provisioningState"> Provisioning state of the namespace. </param>
        /// <param name="status"> Status of the namespace. </param>
        /// <param name="createdAt"> The time the namespace was created. </param>
        /// <param name="updatedAt"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="zoneRedundant"> Enabling this property creates a Premium Service Bus Namespace in regions supported availability zones. </param>
        /// <param name="encryption"> Properties of BYOK Encryption description. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Service Bus namespace. </param>
        internal ServiceBusNamespaceUpdateOptions(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Sku sku, ManagedServiceIdentity identity, string provisioningState, string status, DateTimeOffset? createdAt, DateTimeOffset? updatedAt, string serviceBusEndpoint, string metricId, bool? zoneRedundant, EncryptionProperties encryption, IList<PrivateEndpointConnectionData> privateEndpointConnections, bool? disableLocalAuth) : base(id, name, type, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
            ZoneRedundant = zoneRedundant;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            DisableLocalAuth = disableLocalAuth;
        }

        /// <summary> Properties of SKU. </summary>
        public Sku Sku { get; set; }
        /// <summary> Properties of BYOK Identity description. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the namespace. </summary>
        public string ProvisioningState { get; }
        /// <summary> Status of the namespace. </summary>
        public string Status { get; }
        /// <summary> The time the namespace was created. </summary>
        public DateTimeOffset? CreatedAt { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedAt { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> Enabling this property creates a Premium Service Bus Namespace in regions supported availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> Properties of BYOK Encryption description. </summary>
        public EncryptionProperties Encryption { get; set; }
        /// <summary> List of private endpoint connections. </summary>
        public IList<PrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> This property disables SAS authentication for the Service Bus namespace. </summary>
        public bool? DisableLocalAuth { get; set; }
    }
}

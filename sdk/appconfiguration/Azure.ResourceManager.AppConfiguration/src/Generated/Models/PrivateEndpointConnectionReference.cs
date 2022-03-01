// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    /// <summary> A reference to a related private endpoint connection. </summary>
    public partial class PrivateEndpointConnectionReference : ResourceData
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionReference. </summary>
        internal PrivateEndpointConnectionReference()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionReference. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning status of the private endpoint connection. </param>
        /// <param name="privateEndpoint"> The resource of private endpoint. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        internal PrivateEndpointConnectionReference(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, ProvisioningState? provisioningState, WritableSubResource privateEndpoint, PrivateLinkServiceConnectionState privateLinkServiceConnectionState) : base(id, name, type, systemData)
        {
            ProvisioningState = provisioningState;
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        }

        /// <summary> The provisioning status of the private endpoint connection. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The resource of private endpoint. </summary>
        internal WritableSubResource PrivateEndpoint { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint.Id;
            set => PrivateEndpoint.Id = value;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; }
    }
}

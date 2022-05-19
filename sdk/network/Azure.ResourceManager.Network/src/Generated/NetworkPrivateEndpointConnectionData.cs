// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the NetworkPrivateEndpointConnection data model. </summary>
    public partial class NetworkPrivateEndpointConnectionData : NetworkSubResource
    {
        /// <summary> Initializes a new instance of NetworkPrivateEndpointConnectionData. </summary>
        public NetworkPrivateEndpointConnectionData()
        {
        }

        /// <summary> Initializes a new instance of NetworkPrivateEndpointConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="resourceType"> The resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="linkIdentifier"> The consumer link id. </param>
        internal NetworkPrivateEndpointConnectionData(ResourceIdentifier id, string name, string resourceType, string etag, PrivateEndpointData privateEndpoint, NetworkPrivateLinkServiceConnectionState connectionState, ProvisioningState? provisioningState, string linkIdentifier) : base(id)
        {
            Name = name;
            ResourceType = resourceType;
            Etag = etag;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            LinkIdentifier = linkIdentifier;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public string ResourceType { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The resource of private end point. </summary>
        public PrivateEndpointData PrivateEndpoint { get; }
        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public NetworkPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The consumer link id. </summary>
        public string LinkIdentifier { get; }
    }
}

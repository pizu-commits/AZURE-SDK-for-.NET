// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary>
    /// A class representing the KeyVaultPrivateEndpointConnection data model.
    /// Private endpoint connection resource.
    /// </summary>
    public partial class KeyVaultPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultPrivateEndpointConnectionData"/>. </summary>
        public KeyVaultPrivateEndpointConnectionData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Modified whenever there is a change in the state of private endpoint connection. </param>
        /// <param name="privateEndpoint"> Properties of the private endpoint object. </param>
        /// <param name="connectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, SubResource privateEndpoint, KeyVaultPrivateLinkServiceConnectionState connectionState, KeyVaultPrivateEndpointConnectionProvisioningState? provisioningState, AzureLocation? location, IReadOnlyDictionary<string, string> tags, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            Location = location;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Modified whenever there is a change in the state of private endpoint connection. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Properties of the private endpoint object. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> Approval state of the private link connection. </summary>
        public KeyVaultPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> Provisioning state of the private endpoint connection. </summary>
        public KeyVaultPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
        /// <summary> Azure location of the key vault resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Tags assigned to the key vault resource. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}

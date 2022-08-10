// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary> A class representing the MediaService data model. </summary>
    public partial class MediaServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of MediaServiceData. </summary>
        /// <param name="location"> The location. </param>
        public MediaServiceData(AzureLocation location) : base(location)
        {
            StorageAccounts = new ChangeTrackingList<MediaServiceStorageAccount>();
            PrivateEndpointConnections = new ChangeTrackingList<MediaPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of MediaServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The Managed Identity for the Media Services account. </param>
        /// <param name="mediaServiceId"> The Media Services account ID. </param>
        /// <param name="storageAccounts"> The storage accounts for this resource. </param>
        /// <param name="storageAuthentication"></param>
        /// <param name="encryption"> The account encryption properties. </param>
        /// <param name="keyDelivery"> The Key Delivery properties for Media Services account. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for resources under the Media Services account. </param>
        /// <param name="provisioningState"> Provisioning state of the Media Services account. </param>
        /// <param name="privateEndpointConnections"> The Private Endpoint Connections created for the Media Service account. </param>
        internal MediaServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, Guid? mediaServiceId, IList<MediaServiceStorageAccount> storageAccounts, MediaStorageAuthentication? storageAuthentication, AccountEncryption encryption, MediaKeyDelivery keyDelivery, MediaPublicNetworkAccessStatus? publicNetworkAccess, MediaProvisioningState? provisioningState, IReadOnlyList<MediaPrivateEndpointConnectionData> privateEndpointConnections) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            MediaServiceId = mediaServiceId;
            StorageAccounts = storageAccounts;
            StorageAuthentication = storageAuthentication;
            Encryption = encryption;
            KeyDelivery = keyDelivery;
            PublicNetworkAccess = publicNetworkAccess;
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> The Managed Identity for the Media Services account. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The Media Services account ID. </summary>
        public Guid? MediaServiceId { get; }
        /// <summary> The storage accounts for this resource. </summary>
        public IList<MediaServiceStorageAccount> StorageAccounts { get; }
        /// <summary> Gets or sets the storage authentication. </summary>
        public MediaStorageAuthentication? StorageAuthentication { get; set; }
        /// <summary> The account encryption properties. </summary>
        public AccountEncryption Encryption { get; set; }
        /// <summary> The Key Delivery properties for Media Services account. </summary>
        internal MediaKeyDelivery KeyDelivery { get; set; }
        /// <summary> The access control properties for Key Delivery. </summary>
        public MediaAccessControl KeyDeliveryAccessControl
        {
            get => KeyDelivery is null ? default : KeyDelivery.AccessControl;
            set
            {
                if (KeyDelivery is null)
                    KeyDelivery = new MediaKeyDelivery();
                KeyDelivery.AccessControl = value;
            }
        }

        /// <summary> Whether or not public network access is allowed for resources under the Media Services account. </summary>
        public MediaPublicNetworkAccessStatus? PublicNetworkAccess { get; set; }
        /// <summary> Provisioning state of the Media Services account. </summary>
        public MediaProvisioningState? ProvisioningState { get; }
        /// <summary> The Private Endpoint Connections created for the Media Service account. </summary>
        public IReadOnlyList<MediaPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}

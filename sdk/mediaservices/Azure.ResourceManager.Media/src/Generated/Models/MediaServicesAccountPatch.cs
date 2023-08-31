// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> A Media Services account update. </summary>
    public partial class MediaServicesAccountPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MediaServicesAccountPatch"/>. </summary>
        public MediaServicesAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            StorageAccounts = new ChangeTrackingList<MediaServicesStorageAccount>();
            PrivateEndpointConnections = new ChangeTrackingList<MediaServicesPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="MediaServicesAccountPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The Managed Identity for the Media Services account. </param>
        /// <param name="mediaServiceId"> The Media Services account ID. </param>
        /// <param name="storageAccounts"> The storage accounts for this resource. </param>
        /// <param name="storageAuthentication"></param>
        /// <param name="encryption"> The account encryption properties. </param>
        /// <param name="keyDelivery"> The Key Delivery properties for Media Services account. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for resources under the Media Services account. </param>
        /// <param name="provisioningState"> Provisioning state of the Media Services account. </param>
        /// <param name="privateEndpointConnections"> The Private Endpoint Connections created for the Media Service account. </param>
        /// <param name="minimumTlsVersion"> The minimum TLS version allowed for this account's requests. This is an optional property. If unspecified, a secure default value will be used. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MediaServicesAccountPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, Guid? mediaServiceId, IList<MediaServicesStorageAccount> storageAccounts, MediaStorageAuthentication? storageAuthentication, AccountEncryption encryption, MediaKeyDelivery keyDelivery, MediaServicesPublicNetworkAccess? publicNetworkAccess, MediaServicesProvisioningState? provisioningState, IReadOnlyList<MediaServicesPrivateEndpointConnectionData> privateEndpointConnections, MediaServicesMinimumTlsVersion? minimumTlsVersion, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            Identity = identity;
            MediaServiceId = mediaServiceId;
            StorageAccounts = storageAccounts;
            StorageAuthentication = storageAuthentication;
            Encryption = encryption;
            KeyDelivery = keyDelivery;
            PublicNetworkAccess = publicNetworkAccess;
            ProvisioningState = provisioningState;
            PrivateEndpointConnections = privateEndpointConnections;
            MinimumTlsVersion = minimumTlsVersion;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The Managed Identity for the Media Services account. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The Media Services account ID. </summary>
        public Guid? MediaServiceId { get; }
        /// <summary> The storage accounts for this resource. </summary>
        public IList<MediaServicesStorageAccount> StorageAccounts { get; }
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
        public MediaServicesPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Provisioning state of the Media Services account. </summary>
        public MediaServicesProvisioningState? ProvisioningState { get; }
        /// <summary> The Private Endpoint Connections created for the Media Service account. </summary>
        public IReadOnlyList<MediaServicesPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> The minimum TLS version allowed for this account's requests. This is an optional property. If unspecified, a secure default value will be used. </summary>
        public MediaServicesMinimumTlsVersion? MinimumTlsVersion { get; set; }
    }
}

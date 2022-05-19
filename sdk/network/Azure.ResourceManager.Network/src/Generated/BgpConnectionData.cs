// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the BgpConnection data model. </summary>
    public partial class BgpConnectionData : NetworkSubResource
    {
        /// <summary> Initializes a new instance of BgpConnectionData. </summary>
        public BgpConnectionData()
        {
        }

        /// <summary> Initializes a new instance of BgpConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the connection. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> Connection type. </param>
        /// <param name="peerAsn"> Peer ASN. </param>
        /// <param name="peerIP"> Peer IP. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="connectionState"> The current state of the VirtualHub to Peer. </param>
        internal BgpConnectionData(ResourceIdentifier id, string name, string etag, string resourceType, long? peerAsn, string peerIP, ProvisioningState? provisioningState, HubBgpConnectionStatus? connectionState) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            PeerAsn = peerAsn;
            PeerIP = peerIP;
            ProvisioningState = provisioningState;
            ConnectionState = connectionState;
        }

        /// <summary> Name of the connection. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Connection type. </summary>
        public string ResourceType { get; }
        /// <summary> Peer ASN. </summary>
        public long? PeerAsn { get; set; }
        /// <summary> Peer IP. </summary>
        public string PeerIP { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The current state of the VirtualHub to Peer. </summary>
        public HubBgpConnectionStatus? ConnectionState { get; }
    }
}

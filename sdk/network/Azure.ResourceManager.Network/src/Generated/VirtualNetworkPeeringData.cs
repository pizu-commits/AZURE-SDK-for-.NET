// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VirtualNetworkPeering data model.
    /// Peerings in a virtual network resource.
    /// </summary>
    public partial class VirtualNetworkPeeringData : NetworkWritableResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualNetworkPeeringData"/>. </summary>
        public VirtualNetworkPeeringData()
        {
            LocalSubnetNames = new ChangeTrackingList<string>();
            RemoteSubnetNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkPeeringData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="allowVirtualNetworkAccess"> Whether the VMs in the local virtual network space would be able to access the VMs in remote virtual network space. </param>
        /// <param name="allowForwardedTraffic"> Whether the forwarded traffic from the VMs in the local virtual network will be allowed/disallowed in remote virtual network. </param>
        /// <param name="allowGatewayTransit"> If gateway links can be used in remote virtual networking to link to this virtual network. </param>
        /// <param name="useRemoteGateways"> If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway. </param>
        /// <param name="remoteVirtualNetwork"> The reference to the remote virtual network. The remote virtual network can be in the same or different region (preview). See here to register for the preview and learn more (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering). </param>
        /// <param name="localAddressSpace"> The local address space of the local virtual network that is peered. </param>
        /// <param name="localVirtualNetworkAddressSpace"> The current local address space of the local virtual network that is peered. </param>
        /// <param name="remoteAddressSpace"> The reference to the address space peered with the remote virtual network. </param>
        /// <param name="remoteVirtualNetworkAddressSpace"> The reference to the current address space of the remote virtual network. </param>
        /// <param name="remoteBgpCommunities"> The reference to the remote virtual network's Bgp Communities. </param>
        /// <param name="remoteVirtualNetworkEncryption"> The reference to the remote virtual network's encryption. </param>
        /// <param name="peeringState"> The status of the virtual network peering. </param>
        /// <param name="peeringSyncLevel"> The peering sync status of the virtual network peering. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network peering resource. </param>
        /// <param name="doNotVerifyRemoteGateways"> If we need to verify the provisioning state of the remote gateway. </param>
        /// <param name="resourceGuid"> The resourceGuid property of the Virtual Network peering resource. </param>
        /// <param name="areCompleteVnetsPeered"> Whether complete virtual network address space is peered. </param>
        /// <param name="enableOnlyIPv6Peering"> Whether only Ipv6 address space is peered for subnet peering. </param>
        /// <param name="localSubnetNames"> List of local subnet names that are subnet peered with remote virtual network. </param>
        /// <param name="remoteSubnetNames"> List of remote subnet names from remote virtual network that are subnet peered. </param>
        internal VirtualNetworkPeeringData(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, bool? allowVirtualNetworkAccess, bool? allowForwardedTraffic, bool? allowGatewayTransit, bool? useRemoteGateways, WritableSubResource remoteVirtualNetwork, AddressSpace localAddressSpace, AddressSpace localVirtualNetworkAddressSpace, AddressSpace remoteAddressSpace, AddressSpace remoteVirtualNetworkAddressSpace, VirtualNetworkBgpCommunities remoteBgpCommunities, VirtualNetworkEncryption remoteVirtualNetworkEncryption, VirtualNetworkPeeringState? peeringState, VirtualNetworkPeeringLevel? peeringSyncLevel, NetworkProvisioningState? provisioningState, bool? doNotVerifyRemoteGateways, Guid? resourceGuid, bool? areCompleteVnetsPeered, bool? enableOnlyIPv6Peering, IList<string> localSubnetNames, IList<string> remoteSubnetNames) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            AllowVirtualNetworkAccess = allowVirtualNetworkAccess;
            AllowForwardedTraffic = allowForwardedTraffic;
            AllowGatewayTransit = allowGatewayTransit;
            UseRemoteGateways = useRemoteGateways;
            RemoteVirtualNetwork = remoteVirtualNetwork;
            LocalAddressSpace = localAddressSpace;
            LocalVirtualNetworkAddressSpace = localVirtualNetworkAddressSpace;
            RemoteAddressSpace = remoteAddressSpace;
            RemoteVirtualNetworkAddressSpace = remoteVirtualNetworkAddressSpace;
            RemoteBgpCommunities = remoteBgpCommunities;
            RemoteVirtualNetworkEncryption = remoteVirtualNetworkEncryption;
            PeeringState = peeringState;
            PeeringSyncLevel = peeringSyncLevel;
            ProvisioningState = provisioningState;
            DoNotVerifyRemoteGateways = doNotVerifyRemoteGateways;
            ResourceGuid = resourceGuid;
            AreCompleteVnetsPeered = areCompleteVnetsPeered;
            EnableOnlyIPv6Peering = enableOnlyIPv6Peering;
            LocalSubnetNames = localSubnetNames;
            RemoteSubnetNames = remoteSubnetNames;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Whether the VMs in the local virtual network space would be able to access the VMs in remote virtual network space. </summary>
        public bool? AllowVirtualNetworkAccess { get; set; }
        /// <summary> Whether the forwarded traffic from the VMs in the local virtual network will be allowed/disallowed in remote virtual network. </summary>
        public bool? AllowForwardedTraffic { get; set; }
        /// <summary> If gateway links can be used in remote virtual networking to link to this virtual network. </summary>
        public bool? AllowGatewayTransit { get; set; }
        /// <summary> If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway. </summary>
        public bool? UseRemoteGateways { get; set; }
        /// <summary> The reference to the remote virtual network. The remote virtual network can be in the same or different region (preview). See here to register for the preview and learn more (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering). </summary>
        internal WritableSubResource RemoteVirtualNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RemoteVirtualNetworkId
        {
            get => RemoteVirtualNetwork is null ? default : RemoteVirtualNetwork.Id;
            set
            {
                if (RemoteVirtualNetwork is null)
                    RemoteVirtualNetwork = new WritableSubResource();
                RemoteVirtualNetwork.Id = value;
            }
        }

        /// <summary> The local address space of the local virtual network that is peered. </summary>
        public AddressSpace LocalAddressSpace { get; set; }
        /// <summary> The current local address space of the local virtual network that is peered. </summary>
        public AddressSpace LocalVirtualNetworkAddressSpace { get; set; }
        /// <summary> The reference to the address space peered with the remote virtual network. </summary>
        public AddressSpace RemoteAddressSpace { get; set; }
        /// <summary> The reference to the current address space of the remote virtual network. </summary>
        public AddressSpace RemoteVirtualNetworkAddressSpace { get; set; }
        /// <summary> The reference to the remote virtual network's Bgp Communities. </summary>
        public VirtualNetworkBgpCommunities RemoteBgpCommunities { get; set; }
        /// <summary> The reference to the remote virtual network's encryption. </summary>
        public VirtualNetworkEncryption RemoteVirtualNetworkEncryption { get; }
        /// <summary> The status of the virtual network peering. </summary>
        public VirtualNetworkPeeringState? PeeringState { get; set; }
        /// <summary> The peering sync status of the virtual network peering. </summary>
        public VirtualNetworkPeeringLevel? PeeringSyncLevel { get; set; }
        /// <summary> The provisioning state of the virtual network peering resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> If we need to verify the provisioning state of the remote gateway. </summary>
        public bool? DoNotVerifyRemoteGateways { get; set; }
        /// <summary> The resourceGuid property of the Virtual Network peering resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> Whether complete virtual network address space is peered. </summary>
        public bool? AreCompleteVnetsPeered { get; set; }
        /// <summary> Whether only Ipv6 address space is peered for subnet peering. </summary>
        public bool? EnableOnlyIPv6Peering { get; set; }
        /// <summary> List of local subnet names that are subnet peered with remote virtual network. </summary>
        public IList<string> LocalSubnetNames { get; }
        /// <summary> List of remote subnet names from remote virtual network that are subnet peered. </summary>
        public IList<string> RemoteSubnetNames { get; }
    }
}

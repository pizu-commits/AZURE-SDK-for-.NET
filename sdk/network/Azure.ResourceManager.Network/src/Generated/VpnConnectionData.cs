// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VpnConnection data model. </summary>
    public partial class VpnConnectionData : NetworkSubResource
    {
        /// <summary> Initializes a new instance of VpnConnectionData. </summary>
        public VpnConnectionData()
        {
            IPsecPolicies = new ChangeTrackingList<IPsecPolicy>();
            TrafficSelectorPolicies = new ChangeTrackingList<TrafficSelectorPolicy>();
            VpnLinkConnections = new ChangeTrackingList<VpnSiteLinkConnectionData>();
        }

        /// <summary> Initializes a new instance of VpnConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="remoteVpnSite"> Id of the connected vpn site. </param>
        /// <param name="routingWeight"> Routing weight for vpn connection. </param>
        /// <param name="dpdTimeoutSeconds"> DPD timeout in seconds for vpn connection. </param>
        /// <param name="connectionStatus"> The connection status. </param>
        /// <param name="vpnConnectionProtocolType"> Connection protocol used for this connection. </param>
        /// <param name="ingressBytesTransferred"> Ingress bytes transferred. </param>
        /// <param name="egressBytesTransferred"> Egress bytes transferred. </param>
        /// <param name="connectionBandwidth"> Expected bandwidth in MBPS. </param>
        /// <param name="sharedKey"> SharedKey for the vpn connection. </param>
        /// <param name="enableBgp"> EnableBgp flag. </param>
        /// <param name="usePolicyBasedTrafficSelectors"> Enable policy-based traffic selectors. </param>
        /// <param name="iPsecPolicies"> The IPSec Policies to be considered by this connection. </param>
        /// <param name="trafficSelectorPolicies"> The Traffic Selector Policies to be considered by this connection. </param>
        /// <param name="enableRateLimiting"> EnableBgp flag. </param>
        /// <param name="enableInternetSecurity"> Enable internet security. </param>
        /// <param name="useLocalAzureIPAddress"> Use local azure ip to initiate connection. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN connection resource. </param>
        /// <param name="vpnLinkConnections"> List of all vpn site link connections to the gateway. </param>
        /// <param name="routingConfiguration"> The Routing Configuration indicating the associated and propagated route tables on this connection. </param>
        internal VpnConnectionData(ResourceIdentifier id, string name, string etag, WritableSubResource remoteVpnSite, int? routingWeight, int? dpdTimeoutSeconds, VpnConnectionStatus? connectionStatus, VirtualNetworkGatewayConnectionProtocol? vpnConnectionProtocolType, long? ingressBytesTransferred, long? egressBytesTransferred, int? connectionBandwidth, string sharedKey, bool? enableBgp, bool? usePolicyBasedTrafficSelectors, IList<IPsecPolicy> iPsecPolicies, IList<TrafficSelectorPolicy> trafficSelectorPolicies, bool? enableRateLimiting, bool? enableInternetSecurity, bool? useLocalAzureIPAddress, ProvisioningState? provisioningState, IList<VpnSiteLinkConnectionData> vpnLinkConnections, RoutingConfiguration routingConfiguration) : base(id)
        {
            Name = name;
            Etag = etag;
            RemoteVpnSite = remoteVpnSite;
            RoutingWeight = routingWeight;
            DpdTimeoutSeconds = dpdTimeoutSeconds;
            ConnectionStatus = connectionStatus;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
            IngressBytesTransferred = ingressBytesTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            ConnectionBandwidth = connectionBandwidth;
            SharedKey = sharedKey;
            EnableBgp = enableBgp;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IPsecPolicies = iPsecPolicies;
            TrafficSelectorPolicies = trafficSelectorPolicies;
            EnableRateLimiting = enableRateLimiting;
            EnableInternetSecurity = enableInternetSecurity;
            UseLocalAzureIPAddress = useLocalAzureIPAddress;
            ProvisioningState = provisioningState;
            VpnLinkConnections = vpnLinkConnections;
            RoutingConfiguration = routingConfiguration;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Id of the connected vpn site. </summary>
        internal WritableSubResource RemoteVpnSite { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier RemoteVpnSiteId
        {
            get => RemoteVpnSite is null ? default : RemoteVpnSite.Id;
            set
            {
                if (RemoteVpnSite is null)
                    RemoteVpnSite = new WritableSubResource();
                RemoteVpnSite.Id = value;
            }
        }

        /// <summary> Routing weight for vpn connection. </summary>
        public int? RoutingWeight { get; set; }
        /// <summary> DPD timeout in seconds for vpn connection. </summary>
        public int? DpdTimeoutSeconds { get; set; }
        /// <summary> The connection status. </summary>
        public VpnConnectionStatus? ConnectionStatus { get; }
        /// <summary> Connection protocol used for this connection. </summary>
        public VirtualNetworkGatewayConnectionProtocol? VpnConnectionProtocolType { get; set; }
        /// <summary> Ingress bytes transferred. </summary>
        public long? IngressBytesTransferred { get; }
        /// <summary> Egress bytes transferred. </summary>
        public long? EgressBytesTransferred { get; }
        /// <summary> Expected bandwidth in MBPS. </summary>
        public int? ConnectionBandwidth { get; set; }
        /// <summary> SharedKey for the vpn connection. </summary>
        public string SharedKey { get; set; }
        /// <summary> EnableBgp flag. </summary>
        public bool? EnableBgp { get; set; }
        /// <summary> Enable policy-based traffic selectors. </summary>
        public bool? UsePolicyBasedTrafficSelectors { get; set; }
        /// <summary> The IPSec Policies to be considered by this connection. </summary>
        public IList<IPsecPolicy> IPsecPolicies { get; }
        /// <summary> The Traffic Selector Policies to be considered by this connection. </summary>
        public IList<TrafficSelectorPolicy> TrafficSelectorPolicies { get; }
        /// <summary> EnableBgp flag. </summary>
        public bool? EnableRateLimiting { get; set; }
        /// <summary> Enable internet security. </summary>
        public bool? EnableInternetSecurity { get; set; }
        /// <summary> Use local azure ip to initiate connection. </summary>
        public bool? UseLocalAzureIPAddress { get; set; }
        /// <summary> The provisioning state of the VPN connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> List of all vpn site link connections to the gateway. </summary>
        public IList<VpnSiteLinkConnectionData> VpnLinkConnections { get; }
        /// <summary> The Routing Configuration indicating the associated and propagated route tables on this connection. </summary>
        public RoutingConfiguration RoutingConfiguration { get; set; }
    }
}

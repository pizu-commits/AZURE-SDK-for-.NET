// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmNetworkModelFactory
    {
        /// <summary> Initializes a new instance of ApplicationGatewayFrontendIPConfiguration. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateIPAddress"> PrivateIPAddress of the network interface IP Configuration. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="subnetId"> Reference to the subnet resource. </param>
        /// <param name="publicIPAddressId"> Reference to the PublicIP resource. </param>
        /// <param name="privateLinkConfigurationId"> Reference to the application gateway private link configuration. </param>
        /// <param name="provisioningState"> The provisioning state of the frontend IP configuration resource. </param>
        /// <returns> A new <see cref="Models.ApplicationGatewayFrontendIPConfiguration"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ApplicationGatewayFrontendIPConfiguration ApplicationGatewayFrontendIPConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, string privateIPAddress, NetworkIPAllocationMethod? privateIPAllocationMethod, ResourceIdentifier subnetId, ResourceIdentifier publicIPAddressId, ResourceIdentifier privateLinkConfigurationId, NetworkProvisioningState? provisioningState)
            => ApplicationGatewayFrontendIPConfiguration(id, name, resourceType, etag, privateIPAddress, privateIPAllocationMethod, subnetId, publicIPAddressId, privateLinkConfigurationId, provisioningState);

        /// <summary> Initializes a new instance of BackendAddressPoolData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="location"> The location of the backend address pool. </param>
        /// <param name="tunnelInterfaces"> An array of gateway load balancer tunnel interfaces. </param>
        /// <param name="loadBalancerBackendAddresses"> An array of backend addresses. </param>
        /// <param name="backendIPConfigurations"> An array of references to IP addresses defined in network interfaces. </param>
        /// <param name="loadBalancingRules"> An array of references to load balancing rules that use this backend address pool. </param>
        /// <param name="outboundRuleId"> A reference to an outbound rule that uses this backend address pool. </param>
        /// <param name="outboundRules"> An array of references to outbound rules that use this backend address pool. </param>
        /// <param name="inboundNatRules"> An array of references to inbound NAT rules that use this backend address pool. </param>
        /// <param name="provisioningState"> The provisioning state of the backend address pool resource. </param>
        /// <param name="drainPeriodInSeconds"> Amount of seconds Load Balancer waits for before sending RESET to client and backend address. </param>
        /// <param name="virtualNetworkId"> A reference to a virtual network. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static BackendAddressPoolData BackendAddressPoolData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, AzureLocation? location, IEnumerable<GatewayLoadBalancerTunnelInterface> tunnelInterfaces, IEnumerable<LoadBalancerBackendAddress> loadBalancerBackendAddresses, IEnumerable<NetworkInterfaceIPConfigurationData> backendIPConfigurations, IEnumerable<WritableSubResource> loadBalancingRules, ResourceIdentifier outboundRuleId, IEnumerable<WritableSubResource> outboundRules, IEnumerable<WritableSubResource> inboundNatRules, NetworkProvisioningState? provisioningState, int? drainPeriodInSeconds, ResourceIdentifier virtualNetworkId)
            => BackendAddressPoolData(id, name, resourceType, etag, location, tunnelInterfaces, loadBalancerBackendAddresses, backendIPConfigurations, loadBalancingRules, outboundRuleId, outboundRules, inboundNatRules, provisioningState, drainPeriodInSeconds, virtualNetworkId);

        /// <summary> Initializes a new instance of BastionHostData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="skuName"> The sku of this Bastion Host. </param>
        /// <param name="ipConfigurations"> IP configuration of the Bastion Host resource. </param>
        /// <param name="dnsName"> FQDN for the endpoint on which bastion host is accessible. </param>
        /// <param name="provisioningState"> The provisioning state of the bastion host resource. </param>
        /// <param name="scaleUnits"> The scale units for the Bastion Host resource. </param>
        /// <param name="disableCopyPaste"> Enable/Disable Copy/Paste feature of the Bastion Host resource. </param>
        /// <param name="enableFileCopy"> Enable/Disable File Copy feature of the Bastion Host resource. </param>
        /// <param name="enableIPConnect"> Enable/Disable IP Connect feature of the Bastion Host resource. </param>
        /// <param name="enableShareableLink"> Enable/Disable Shareable Link of the Bastion Host resource. </param>
        /// <param name="enableTunneling"> Enable/Disable Tunneling feature of the Bastion Host resource. </param>
        /// <param name="enableKerberos"> Enable/Disable Kerberos feature of the Bastion Host resource. </param>
        /// <returns> A new <see cref="Network.BastionHostData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static BastionHostData BastionHostData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, BastionHostSkuName? skuName, IEnumerable<BastionHostIPConfiguration> ipConfigurations, string dnsName, NetworkProvisioningState? provisioningState, int? scaleUnits, bool? disableCopyPaste, bool? enableFileCopy, bool? enableIPConnect, bool? enableShareableLink, bool? enableTunneling, bool? enableKerberos)
            => BastionHostData(id, name, resourceType, location, tags, null, etag, skuName, ipConfigurations, dnsName, null, null, provisioningState, scaleUnits, disableCopyPaste, enableFileCopy, enableIPConnect, enableShareableLink, enableTunneling, enableKerberos);

        /// <summary> Initializes a new instance of <see cref="Network.BastionHostData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="skuName"> The sku of this Bastion Host. </param>
        /// <param name="ipConfigurations"> IP configuration of the Bastion Host resource. </param>
        /// <param name="dnsName"> FQDN for the endpoint on which bastion host is accessible. </param>
        /// <param name="virtualNetworkId"> Reference to an existing virtual network required for Developer Bastion Host only. </param>
        /// <param name="networkAclsIPRules"></param>
        /// <param name="provisioningState"> The provisioning state of the bastion host resource. </param>
        /// <param name="scaleUnits"> The scale units for the Bastion Host resource. </param>
        /// <param name="disableCopyPaste"> Enable/Disable Copy/Paste feature of the Bastion Host resource. </param>
        /// <param name="enableFileCopy"> Enable/Disable File Copy feature of the Bastion Host resource. </param>
        /// <param name="enableIPConnect"> Enable/Disable IP Connect feature of the Bastion Host resource. </param>
        /// <param name="enableShareableLink"> Enable/Disable Shareable Link of the Bastion Host resource. </param>
        /// <param name="enableTunneling"> Enable/Disable Tunneling feature of the Bastion Host resource. </param>
        /// <param name="enableKerberos"> Enable/Disable Kerberos feature of the Bastion Host resource. </param>
        /// <returns> A new <see cref="Network.BastionHostData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static BastionHostData BastionHostData(ResourceIdentifier id = null, string name = null, ResourceType? resourceType = null, AzureLocation? location = null, IDictionary<string, string> tags = null, ETag? etag = null, BastionHostSkuName? skuName = null, IEnumerable<BastionHostIPConfiguration> ipConfigurations = null, string dnsName = null, ResourceIdentifier virtualNetworkId = null, IEnumerable<BastionHostIPRule> networkAclsIPRules = null, NetworkProvisioningState? provisioningState = null, int? scaleUnits = null, bool? disableCopyPaste = null, bool? enableFileCopy = null, bool? enableIPConnect = null, bool? enableShareableLink = null, bool? enableTunneling = null, bool? enableKerberos = null)
            => BastionHostData(id, name, resourceType, location, tags, null, etag, skuName, ipConfigurations, dnsName, virtualNetworkId, networkAclsIPRules, provisioningState, scaleUnits, disableCopyPaste, enableFileCopy, enableIPConnect, enableShareableLink, enableTunneling, enableKerberos);

        /// <summary> Initializes a new instance of FirewallPolicyData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="identity"> The identity of the firewall policy. </param>
        /// <param name="ruleCollectionGroups"> List of references to FirewallPolicyRuleCollectionGroups. </param>
        /// <param name="provisioningState"> The provisioning state of the firewall policy resource. </param>
        /// <param name="basePolicyId"> The parent firewall policy from which rules are inherited. </param>
        /// <param name="firewalls"> List of references to Azure Firewalls that this Firewall Policy is associated with. </param>
        /// <param name="childPolicies"> List of references to Child Firewall Policies. </param>
        /// <param name="threatIntelMode"> The operation mode for Threat Intelligence. </param>
        /// <param name="threatIntelWhitelist"> ThreatIntel Whitelist for Firewall Policy. </param>
        /// <param name="insights"> Insights on Firewall Policy. </param>
        /// <param name="snat"> The private IP addresses/IP ranges to which traffic will not be SNAT. </param>
        /// <param name="allowSqlRedirect"> SQL Settings definition. </param>
        /// <param name="dnsSettings"> DNS Proxy Settings definition. </param>
        /// <param name="explicitProxy"> Explicit Proxy Settings definition. </param>
        /// <param name="intrusionDetection"> The configuration for Intrusion detection. </param>
        /// <param name="transportSecurityCertificateAuthority"> TLS Configuration definition. </param>
        /// <param name="skuTier"> The Firewall Policy SKU. </param>
        /// <returns> A new <see cref="Network.FirewallPolicyData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static FirewallPolicyData FirewallPolicyData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, ManagedServiceIdentity identity, IEnumerable<WritableSubResource> ruleCollectionGroups, NetworkProvisioningState? provisioningState, ResourceIdentifier basePolicyId, IEnumerable<WritableSubResource> firewalls, IEnumerable<WritableSubResource> childPolicies, AzureFirewallThreatIntelMode? threatIntelMode, FirewallPolicyThreatIntelWhitelist threatIntelWhitelist, FirewallPolicyInsights insights, FirewallPolicySnat snat, bool? allowSqlRedirect, DnsSettings dnsSettings, FirewallPolicyExplicitProxy explicitProxy, FirewallPolicyIntrusionDetection intrusionDetection, FirewallPolicyCertificateAuthority transportSecurityCertificateAuthority, FirewallPolicySkuTier? skuTier)
            => FirewallPolicyData(id, name, resourceType, location, tags, etag, identity, null, ruleCollectionGroups, provisioningState, basePolicyId, firewalls, childPolicies, threatIntelMode, threatIntelWhitelist, insights, snat, allowSqlRedirect, dnsSettings, explicitProxy, intrusionDetection, transportSecurityCertificateAuthority, skuTier);

        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionGroupData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection Group resource. </param>
        /// <param name="ruleCollections">
        /// Group of Firewall Policy rule collections.
        /// Please note <see cref="FirewallPolicyRuleCollectionInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FirewallPolicyFilterRuleCollectionInfo"/> and <see cref="FirewallPolicyNatRuleCollectionInfo"/>.
        /// </param>
        /// <param name="provisioningState"> The provisioning state of the firewall policy rule collection group resource. </param>
        /// <returns> A new <see cref="Network.FirewallPolicyRuleCollectionGroupData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static FirewallPolicyRuleCollectionGroupData FirewallPolicyRuleCollectionGroupData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, int? priority, IEnumerable<FirewallPolicyRuleCollectionInfo> ruleCollections, NetworkProvisioningState? provisioningState)
            => FirewallPolicyRuleCollectionGroupData(id, name, resourceType, etag, null, priority, ruleCollections, provisioningState);

        /// <summary> Initializes a new instance of SubnetData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="addressPrefix"> The address prefix for the subnet. </param>
        /// <param name="addressPrefixes"> List of address prefixes for the subnet. </param>
        /// <param name="networkSecurityGroup"> The reference to the NetworkSecurityGroup resource. </param>
        /// <param name="routeTable"> The reference to the RouteTable resource. </param>
        /// <param name="natGatewayId"> Nat gateway associated with this subnet. </param>
        /// <param name="serviceEndpoints"> An array of service endpoints. </param>
        /// <param name="serviceEndpointPolicies"> An array of service endpoint policies. </param>
        /// <param name="privateEndpoints"> An array of references to private endpoints. </param>
        /// <param name="ipConfigurations"> An array of references to the network interface IP configurations using subnet. </param>
        /// <param name="ipConfigurationProfiles"> Array of IP configuration profiles which reference this subnet. </param>
        /// <param name="ipAllocations"> Array of IpAllocation which reference this subnet. </param>
        /// <param name="resourceNavigationLinks"> An array of references to the external resources using subnet. </param>
        /// <param name="serviceAssociationLinks"> An array of references to services injecting into this subnet. </param>
        /// <param name="delegations"> An array of references to the delegations on the subnet. </param>
        /// <param name="purpose"> A read-only string identifying the intention of use for this subnet based on delegations and other user-defined properties. </param>
        /// <param name="provisioningState"> The provisioning state of the subnet resource. </param>
        /// <param name="privateEndpointNetworkPolicy"> Enable or Disable apply network policies on private end point in the subnet. </param>
        /// <param name="privateLinkServiceNetworkPolicy"> Enable or Disable apply network policies on private link service in the subnet. </param>
        /// <param name="applicationGatewayIPConfigurations"> Application gateway IP configurations of virtual network resource. </param>
        /// <returns> A new <see cref="Network.SubnetData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static SubnetData SubnetData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, string addressPrefix, IEnumerable<string> addressPrefixes, NetworkSecurityGroupData networkSecurityGroup, RouteTableData routeTable, ResourceIdentifier natGatewayId, IEnumerable<ServiceEndpointProperties> serviceEndpoints, IEnumerable<ServiceEndpointPolicyData> serviceEndpointPolicies, IEnumerable<PrivateEndpointData> privateEndpoints, IEnumerable<NetworkIPConfiguration> ipConfigurations, IEnumerable<NetworkIPConfigurationProfile> ipConfigurationProfiles, IEnumerable<WritableSubResource> ipAllocations, IEnumerable<ResourceNavigationLink> resourceNavigationLinks, IEnumerable<ServiceAssociationLink> serviceAssociationLinks, IEnumerable<ServiceDelegation> delegations, string purpose, NetworkProvisioningState? provisioningState, VirtualNetworkPrivateEndpointNetworkPolicy? privateEndpointNetworkPolicy, VirtualNetworkPrivateLinkServiceNetworkPolicy? privateLinkServiceNetworkPolicy, IEnumerable<ApplicationGatewayIPConfiguration> applicationGatewayIPConfigurations)
            => SubnetData(id, name, resourceType, etag, addressPrefix, addressPrefixes, networkSecurityGroup, routeTable, natGatewayId, serviceEndpoints, serviceEndpointPolicies, privateEndpoints, ipConfigurations, ipConfigurationProfiles, ipAllocations, resourceNavigationLinks, serviceAssociationLinks, delegations, purpose, provisioningState, privateEndpointNetworkPolicy, privateLinkServiceNetworkPolicy, applicationGatewayIPConfigurations, null);

        /// <summary> Initializes a new instance of VirtualNetworkGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="extendedLocation"> The extended location of type local virtual network gateway. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ipConfigurations"> IP configurations for virtual network gateway. </param>
        /// <param name="gatewayType"> The type of this virtual network gateway. </param>
        /// <param name="vpnType"> The type of this virtual network gateway. </param>
        /// <param name="vpnGatewayGeneration"> The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN. </param>
        /// <param name="enableBgp"> Whether BGP is enabled for this virtual network gateway or not. </param>
        /// <param name="enablePrivateIPAddress"> Whether private IP needs to be enabled on this gateway for connections or not. </param>
        /// <param name="active"> ActiveActive flag. </param>
        /// <param name="disableIPSecReplayProtection"> disableIPSecReplayProtection flag. </param>
        /// <param name="gatewayDefaultSiteId"> The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting. </param>
        /// <param name="sku"> The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway. </param>
        /// <param name="vpnClientConfiguration"> The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations. </param>
        /// <param name="virtualNetworkGatewayPolicyGroups"> The reference to the VirtualNetworkGatewayPolicyGroup resource which represents the available VirtualNetworkGatewayPolicyGroup for the gateway. </param>
        /// <param name="bgpSettings"> Virtual network gateway's BGP speaker settings. </param>
        /// <param name="customRoutesAddressPrefixes"> The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient. </param>
        /// <param name="resourceGuid"> The resource GUID property of the virtual network gateway resource. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network gateway resource. </param>
        /// <param name="enableDnsForwarding"> Whether dns forwarding is enabled or not. </param>
        /// <param name="inboundDnsForwardingEndpoint"> The IP address allocated by the gateway to which dns requests can be sent. </param>
        /// <param name="vNetExtendedLocationResourceId"> Customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet. </param>
        /// <param name="natRules"> NatRules for virtual network gateway. </param>
        /// <param name="enableBgpRouteTranslationForNat"> EnableBgpRouteTranslationForNat flag. </param>
        /// <param name="allowVirtualWanTraffic"> Configures this gateway to accept traffic from remote Virtual WAN networks. </param>
        /// <param name="allowRemoteVnetTraffic"> Configure this gateway to accept traffic from other Azure Virtual Networks. This configuration does not support connectivity to Azure Virtual WAN. </param>
        /// <param name="adminState"> Property to indicate if the Express Route Gateway serves traffic when there are multiple Express Route Gateways in the vnet. </param>
        /// <returns> A new <see cref="Network.VirtualNetworkGatewayData"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static VirtualNetworkGatewayData VirtualNetworkGatewayData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ExtendedLocation extendedLocation, ETag? etag, IEnumerable<VirtualNetworkGatewayIPConfiguration> ipConfigurations, VirtualNetworkGatewayType? gatewayType, VpnType? vpnType, VpnGatewayGeneration? vpnGatewayGeneration, bool? enableBgp, bool? enablePrivateIPAddress, bool? active, bool? disableIPSecReplayProtection, ResourceIdentifier gatewayDefaultSiteId, VirtualNetworkGatewaySku sku, VpnClientConfiguration vpnClientConfiguration, IEnumerable<VirtualNetworkGatewayPolicyGroup> virtualNetworkGatewayPolicyGroups, BgpSettings bgpSettings, IEnumerable<string> customRoutesAddressPrefixes, Guid? resourceGuid, NetworkProvisioningState? provisioningState, bool? enableDnsForwarding, string inboundDnsForwardingEndpoint, ResourceIdentifier vNetExtendedLocationResourceId, IEnumerable<VirtualNetworkGatewayNatRuleData> natRules, bool? enableBgpRouteTranslationForNat, bool? allowVirtualWanTraffic, bool? allowRemoteVnetTraffic, ExpressRouteGatewayAdminState? adminState)
            => VirtualNetworkGatewayData(id, name, resourceType, location, tags, extendedLocation, etag, ipConfigurations, gatewayType, vpnType, vpnGatewayGeneration, enableBgp, enablePrivateIPAddress, active, disableIPSecReplayProtection, gatewayDefaultSiteId, sku, vpnClientConfiguration, virtualNetworkGatewayPolicyGroups, bgpSettings, customRoutesAddressPrefixes, resourceGuid, provisioningState, enableDnsForwarding, inboundDnsForwardingEndpoint, vNetExtendedLocationResourceId, natRules, enableBgpRouteTranslationForNat, allowVirtualWanTraffic, allowRemoteVnetTraffic, adminState);

        /// <summary> Initializes a new instance of NetworkVirtualApplianceConnectionData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="namePropertiesName"> The name of the resource. </param>
        /// <param name="provisioningState"> The provisioning state of the NetworkVirtualApplianceConnection resource. </param>
        /// <param name="asn"> Network Virtual Appliance ASN. </param>
        /// <param name="tunnelIdentifier"> Unique identifier for the connection. </param>
        /// <param name="bgpPeerAddress"> List of bgpPeerAddresses for the NVA instances. </param>
        /// <param name="enableInternetSecurity"> Enable internet security. </param>
        /// <param name="routingConfiguration"> The Routing Configuration indicating the associated and propagated route tables on this connection. </param>
        /// <returns> A new <see cref="Network.NetworkVirtualApplianceConnectionData"/> instance for mocking. </returns>
        public static NetworkVirtualApplianceConnectionData NetworkVirtualApplianceConnectionData(ResourceIdentifier id, string name, ResourceType? resourceType, string namePropertiesName, NetworkProvisioningState? provisioningState, long? asn, long? tunnelIdentifier, IEnumerable<string> bgpPeerAddress, bool? enableInternetSecurity, RoutingConfigurationNfv routingConfiguration)
            => NetworkVirtualApplianceConnectionData(id, name, resourceType, namePropertiesName, provisioningState, asn, tunnelIdentifier, bgpPeerAddress, enableInternetSecurity, connectionRoutingConfiguration : null);

        /// <summary> Initializes a new instance of ApplicationGatewayListener. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="frontendIPConfigurationId"> Frontend IP configuration resource of an application gateway. </param>
        /// <param name="frontendPortId"> Frontend port resource of an application gateway. </param>
        /// <param name="protocol"> Protocol of the listener. </param>
        /// <param name="sslCertificateId"> SSL certificate resource of an application gateway. </param>
        /// <param name="sslProfileId"> SSL profile resource of the application gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the listener resource. </param>
        /// <returns> A new <see cref="Models.ApplicationGatewayListener"/> instance for mocking. </returns>
        public static ApplicationGatewayListener ApplicationGatewayListener(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, ResourceIdentifier frontendIPConfigurationId, ResourceIdentifier frontendPortId, ApplicationGatewayProtocol? protocol, ResourceIdentifier sslCertificateId, ResourceIdentifier sslProfileId, NetworkProvisioningState? provisioningState)
            => ApplicationGatewayListener(id, name, resourceType, etag, frontendIPConfigurationId, frontendPortId, protocol, sslCertificateId, sslProfileId, provisioningState, null);

        /// <summary> Initializes a new instance of NetworkVirtualApplianceData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> The service principal that has read access to cloud-init and config blob. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="nvaSku"> Network Virtual Appliance SKU. </param>
        /// <param name="addressPrefix"> Address Prefix. </param>
        /// <param name="bootStrapConfigurationBlobs"> BootStrapConfigurationBlobs storage URLs. </param>
        /// <param name="virtualHubId"> The Virtual Hub where Network Virtual Appliance is being deployed. </param>
        /// <param name="cloudInitConfigurationBlobs"> CloudInitConfigurationBlob storage URLs. </param>
        /// <param name="cloudInitConfiguration"> CloudInitConfiguration string in plain text. </param>
        /// <param name="virtualApplianceAsn"> VirtualAppliance ASN. Microsoft private, public and IANA reserved ASN are not supported. </param>
        /// <param name="sshPublicKey"> Public key for SSH login. </param>
        /// <param name="virtualApplianceNics"> List of Virtual Appliance Network Interfaces. </param>
        /// <param name="additionalNics"> Details required for Additional Network Interface. </param>
        /// <param name="virtualApplianceSites"> List of references to VirtualApplianceSite. </param>
        /// <param name="virtualApplianceConnections"> List of references to VirtualApplianceConnections. </param>
        /// <param name="inboundSecurityRules"> List of references to InboundSecurityRules. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="deploymentType"> The deployment type. PartnerManaged for the SaaS NVA. </param>
        /// <param name="delegation"> The delegation for the Virtual Appliance. </param>
        /// <param name="partnerManagedResource"> The delegation for the Virtual Appliance. </param>
        /// <returns> A new <see cref="Network.NetworkVirtualApplianceData"/> instance for mocking. </returns>
        public static NetworkVirtualApplianceData NetworkVirtualApplianceData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ManagedServiceIdentity identity, ETag? etag, VirtualApplianceSkuProperties nvaSku, string addressPrefix, IEnumerable<string> bootStrapConfigurationBlobs, ResourceIdentifier virtualHubId, IEnumerable<string> cloudInitConfigurationBlobs, string cloudInitConfiguration, long? virtualApplianceAsn, string sshPublicKey, IEnumerable<VirtualApplianceNicProperties> virtualApplianceNics, IEnumerable<VirtualApplianceAdditionalNicProperties> additionalNics, IEnumerable<WritableSubResource> virtualApplianceSites, IEnumerable<WritableSubResource> virtualApplianceConnections, IEnumerable<WritableSubResource> inboundSecurityRules, NetworkProvisioningState? provisioningState, string deploymentType, VirtualApplianceDelegationProperties delegation, PartnerManagedResourceProperties partnerManagedResource)
            => NetworkVirtualApplianceData(id, name, resourceType, location, tags, identity, etag, nvaSku, addressPrefix, bootStrapConfigurationBlobs, virtualHubId, cloudInitConfigurationBlobs, cloudInitConfiguration, virtualApplianceAsn, sshPublicKey, virtualApplianceNics, additionalNics, null, virtualApplianceSites, virtualApplianceConnections, inboundSecurityRules, provisioningState, deploymentType, delegation, partnerManagedResource);

        /// <summary> Initializes a new instance of <see cref="Models.InboundSecurityRule"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="ruleType"> Rule Type. This should be either AutoExpire or Permanent. Auto Expire Rule only creates NSG rules. Permanent Rule creates NSG rule and SLB LB Rule. </param>
        /// <param name="rules"> List of allowed rules. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="Models.InboundSecurityRule"/> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static InboundSecurityRule InboundSecurityRule(ResourceIdentifier id = null, string name = null, ResourceType? resourceType = null, ETag? etag = null, InboundSecurityRuleType? ruleType = null, IEnumerable<InboundSecurityRules> rules = null, NetworkProvisioningState? provisioningState = null)
        {
            rules ??= new List<InboundSecurityRules>();

            return new InboundSecurityRule(
                id,
                name,
                resourceType,
                serializedAdditionalRawData: null,
                etag,
                ruleType,
                rules?.ToList(),
                provisioningState);
        }

        /// <summary> Initializes a new instance of <see cref="T:Azure.ResourceManager.Network.Models.InboundSecurityRule" />. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="rules"> List of allowed rules. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <returns> A new <see cref="T:Azure.ResourceManager.Network.Models.InboundSecurityRule" /> instance for mocking. </returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static InboundSecurityRule InboundSecurityRule(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, IEnumerable<InboundSecurityRules> rules, NetworkProvisioningState? provisioningState)
        {
            return InboundSecurityRule(id: id, name: name, resourceType: resourceType, etag: etag, ruleType: default, rules: rules, provisioningState: provisioningState);
        }
    }
}

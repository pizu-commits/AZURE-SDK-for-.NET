// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabric data model.
    /// The Network Fabric resource definition.
    /// </summary>
    public partial class NetworkFabricData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="networkFabricSku"> Supported Network Fabric SKU.Example: Compute / Aggregate racks. Once the user chooses a particular SKU, only supported racks can be added to the Network Fabric. The SKU determines whether it is a single / multi rack Network Fabric. </param>
        /// <param name="networkFabricControllerId"> Azure resource ID for the NetworkFabricController the NetworkFabric belongs. </param>
        /// <param name="serverCountPerRack"> Number of servers.Possible values are from 1-16. </param>
        /// <param name="ipv4Prefix"> IPv4Prefix for Management Network. Example: 10.1.0.0/19. </param>
        /// <param name="fabricAsn"> ASN of CE devices for CE/PE connectivity. </param>
        /// <param name="terminalServerConfiguration"> Network and credentials configuration currently applied to terminal server. </param>
        /// <param name="managementNetworkConfiguration"> Configuration to be used to setup the management network. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricSku"/>, <paramref name="networkFabricControllerId"/>, <paramref name="ipv4Prefix"/>, <paramref name="terminalServerConfiguration"/> or <paramref name="managementNetworkConfiguration"/> is null. </exception>
        public NetworkFabricData(AzureLocation location, string networkFabricSku, ResourceIdentifier networkFabricControllerId, int serverCountPerRack, string ipv4Prefix, long fabricAsn, TerminalServerConfiguration terminalServerConfiguration, ManagementNetworkConfigurationProperties managementNetworkConfiguration) : base(location)
        {
            Argument.AssertNotNull(networkFabricSku, nameof(networkFabricSku));
            Argument.AssertNotNull(networkFabricControllerId, nameof(networkFabricControllerId));
            Argument.AssertNotNull(ipv4Prefix, nameof(ipv4Prefix));
            Argument.AssertNotNull(terminalServerConfiguration, nameof(terminalServerConfiguration));
            Argument.AssertNotNull(managementNetworkConfiguration, nameof(managementNetworkConfiguration));

            NetworkFabricSku = networkFabricSku;
            RouterIds = new ChangeTrackingList<string>();
            NetworkFabricControllerId = networkFabricControllerId;
            ServerCountPerRack = serverCountPerRack;
            IPv4Prefix = ipv4Prefix;
            FabricAsn = fabricAsn;
            TerminalServerConfiguration = terminalServerConfiguration;
            ManagementNetworkConfiguration = managementNetworkConfiguration;
            Racks = new ChangeTrackingList<string>();
            L2IsolationDomains = new ChangeTrackingList<string>();
            L3IsolationDomains = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="networkFabricSku"> Supported Network Fabric SKU.Example: Compute / Aggregate racks. Once the user chooses a particular SKU, only supported racks can be added to the Network Fabric. The SKU determines whether it is a single / multi rack Network Fabric. </param>
        /// <param name="fabricVersion"> The version of Network Fabric. </param>
        /// <param name="routerIds"> Array of router IDs. </param>
        /// <param name="networkFabricControllerId"> Azure resource ID for the NetworkFabricController the NetworkFabric belongs. </param>
        /// <param name="rackCount"> Number of compute racks associated to Network Fabric. </param>
        /// <param name="serverCountPerRack"> Number of servers.Possible values are from 1-16. </param>
        /// <param name="ipv4Prefix"> IPv4Prefix for Management Network. Example: 10.1.0.0/19. </param>
        /// <param name="ipv6Prefix"> IPv6Prefix for Management Network. Example: 3FFE:FFFF:0:CD40::/59. </param>
        /// <param name="fabricAsn"> ASN of CE devices for CE/PE connectivity. </param>
        /// <param name="terminalServerConfiguration"> Network and credentials configuration currently applied to terminal server. </param>
        /// <param name="managementNetworkConfiguration"> Configuration to be used to setup the management network. </param>
        /// <param name="racks"> List of NetworkRack resource IDs under the Network Fabric. The number of racks allowed depends on the Network Fabric SKU. </param>
        /// <param name="l2IsolationDomains"> List of L2 Isolation Domain resource IDs under the Network Fabric. </param>
        /// <param name="l3IsolationDomains"> List of L3 Isolation Domain resource IDs under the Network Fabric. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provides you the latest status of the NFC service, whether it is Accepted, updating, Succeeded or Failed. During this process, the states keep changing based on the status of NFC provisioning. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, string networkFabricSku, string fabricVersion, IReadOnlyList<string> routerIds, ResourceIdentifier networkFabricControllerId, int? rackCount, int serverCountPerRack, string ipv4Prefix, string ipv6Prefix, long fabricAsn, TerminalServerConfiguration terminalServerConfiguration, ManagementNetworkConfigurationProperties managementNetworkConfiguration, IReadOnlyList<string> racks, IReadOnlyList<string> l2IsolationDomains, IReadOnlyList<string> l3IsolationDomains, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            NetworkFabricSku = networkFabricSku;
            FabricVersion = fabricVersion;
            RouterIds = routerIds;
            NetworkFabricControllerId = networkFabricControllerId;
            RackCount = rackCount;
            ServerCountPerRack = serverCountPerRack;
            IPv4Prefix = ipv4Prefix;
            IPv6Prefix = ipv6Prefix;
            FabricAsn = fabricAsn;
            TerminalServerConfiguration = terminalServerConfiguration;
            ManagementNetworkConfiguration = managementNetworkConfiguration;
            Racks = racks;
            L2IsolationDomains = l2IsolationDomains;
            L3IsolationDomains = l3IsolationDomains;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricData"/> for deserialization. </summary>
        internal NetworkFabricData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Supported Network Fabric SKU.Example: Compute / Aggregate racks. Once the user chooses a particular SKU, only supported racks can be added to the Network Fabric. The SKU determines whether it is a single / multi rack Network Fabric. </summary>
        public string NetworkFabricSku { get; set; }
        /// <summary> The version of Network Fabric. </summary>
        public string FabricVersion { get; }
        /// <summary> Array of router IDs. </summary>
        public IReadOnlyList<string> RouterIds { get; }
        /// <summary> Azure resource ID for the NetworkFabricController the NetworkFabric belongs. </summary>
        public ResourceIdentifier NetworkFabricControllerId { get; set; }
        /// <summary> Number of compute racks associated to Network Fabric. </summary>
        public int? RackCount { get; set; }
        /// <summary> Number of servers.Possible values are from 1-16. </summary>
        public int ServerCountPerRack { get; set; }
        /// <summary> IPv4Prefix for Management Network. Example: 10.1.0.0/19. </summary>
        public string IPv4Prefix { get; set; }
        /// <summary> IPv6Prefix for Management Network. Example: 3FFE:FFFF:0:CD40::/59. </summary>
        public string IPv6Prefix { get; set; }
        /// <summary> ASN of CE devices for CE/PE connectivity. </summary>
        public long FabricAsn { get; set; }
        /// <summary> Network and credentials configuration currently applied to terminal server. </summary>
        public TerminalServerConfiguration TerminalServerConfiguration { get; set; }
        /// <summary> Configuration to be used to setup the management network. </summary>
        public ManagementNetworkConfigurationProperties ManagementNetworkConfiguration { get; set; }
        /// <summary> List of NetworkRack resource IDs under the Network Fabric. The number of racks allowed depends on the Network Fabric SKU. </summary>
        public IReadOnlyList<string> Racks { get; }
        /// <summary> List of L2 Isolation Domain resource IDs under the Network Fabric. </summary>
        public IReadOnlyList<string> L2IsolationDomains { get; }
        /// <summary> List of L3 Isolation Domain resource IDs under the Network Fabric. </summary>
        public IReadOnlyList<string> L3IsolationDomains { get; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provides you the latest status of the NFC service, whether it is Accepted, updating, Succeeded or Failed. During this process, the states keep changing based on the status of NFC provisioning. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}

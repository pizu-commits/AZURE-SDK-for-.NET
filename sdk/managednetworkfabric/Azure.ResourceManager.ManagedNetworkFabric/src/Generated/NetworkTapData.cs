// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkTap data model.
    /// The Network Tap resource definition.
    /// </summary>
    public partial class NetworkTapData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkTapData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="networkPacketBrokerId"> ARM resource ID of the Network Packet Broker. </param>
        /// <param name="destinations"> List of destinations to send the filter traffic. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkPacketBrokerId"/> or <paramref name="destinations"/> is null. </exception>
        public NetworkTapData(AzureLocation location, ResourceIdentifier networkPacketBrokerId, IEnumerable<NetworkTapPropertiesDestinationsItem> destinations) : base(location)
        {
            Argument.AssertNotNull(networkPacketBrokerId, nameof(networkPacketBrokerId));
            Argument.AssertNotNull(destinations, nameof(destinations));

            NetworkPacketBrokerId = networkPacketBrokerId;
            Destinations = destinations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="networkPacketBrokerId"> ARM resource ID of the Network Packet Broker. </param>
        /// <param name="sourceTapRuleId"> Source Tap Rule Id. ARM Resource ID of the Network Tap Rule. </param>
        /// <param name="destinations"> List of destinations to send the filter traffic. </param>
        /// <param name="pollingType"> Polling type. </param>
        /// <param name="configurationState"> Gets the configurations state of the resource. </param>
        /// <param name="provisioningState"> Provides you the latest status of the NFC service, whether it is Accepted, updating, Succeeded or Failed. During this process, the states keep changing based on the status of Network Tap provisioning. </param>
        /// <param name="administrativeState"> Administrative state of the resource. Example -Enabled/Disabled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkTapData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, ResourceIdentifier networkPacketBrokerId, ResourceIdentifier sourceTapRuleId, IList<NetworkTapPropertiesDestinationsItem> destinations, NetworkTapPollingType? pollingType, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            NetworkPacketBrokerId = networkPacketBrokerId;
            SourceTapRuleId = sourceTapRuleId;
            Destinations = destinations;
            PollingType = pollingType;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapData"/> for deserialization. </summary>
        internal NetworkTapData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> ARM resource ID of the Network Packet Broker. </summary>
        public ResourceIdentifier NetworkPacketBrokerId { get; set; }
        /// <summary> Source Tap Rule Id. ARM Resource ID of the Network Tap Rule. </summary>
        public ResourceIdentifier SourceTapRuleId { get; }
        /// <summary> List of destinations to send the filter traffic. </summary>
        public IList<NetworkTapPropertiesDestinationsItem> Destinations { get; }
        /// <summary> Polling type. </summary>
        public NetworkTapPollingType? PollingType { get; set; }
        /// <summary> Gets the configurations state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provides you the latest status of the NFC service, whether it is Accepted, updating, Succeeded or Failed. During this process, the states keep changing based on the status of Network Tap provisioning. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. Example -Enabled/Disabled. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}

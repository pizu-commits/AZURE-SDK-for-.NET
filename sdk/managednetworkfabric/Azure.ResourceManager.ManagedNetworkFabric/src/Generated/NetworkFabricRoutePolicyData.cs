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
    /// A class representing the NetworkFabricRoutePolicy data model.
    /// The RoutePolicy resource definition.
    /// </summary>
    public partial class NetworkFabricRoutePolicyData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkFabricRoutePolicyData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="networkFabricId"> Arm Resource ID of Network Fabric. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkFabricId"/> is null. </exception>
        public NetworkFabricRoutePolicyData(AzureLocation location, ResourceIdentifier networkFabricId) : base(location)
        {
            Argument.AssertNotNull(networkFabricId, nameof(networkFabricId));

            Statements = new ChangeTrackingList<RoutePolicyStatementProperties>();
            NetworkFabricId = networkFabricId;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricRoutePolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="statements"> Route Policy statements. </param>
        /// <param name="networkFabricId"> Arm Resource ID of Network Fabric. </param>
        /// <param name="addressFamilyType"> AddressFamilyType. This parameter decides whether the given ipv4 or ipv6 route policy. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricRoutePolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, IList<RoutePolicyStatementProperties> statements, ResourceIdentifier networkFabricId, AddressFamilyType? addressFamilyType, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            Statements = statements;
            NetworkFabricId = networkFabricId;
            AddressFamilyType = addressFamilyType;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricRoutePolicyData"/> for deserialization. </summary>
        internal NetworkFabricRoutePolicyData()
        {
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Route Policy statements. </summary>
        public IList<RoutePolicyStatementProperties> Statements { get; }
        /// <summary> Arm Resource ID of Network Fabric. </summary>
        public ResourceIdentifier NetworkFabricId { get; set; }
        /// <summary> AddressFamilyType. This parameter decides whether the given ipv4 or ipv6 route policy. </summary>
        public AddressFamilyType? AddressFamilyType { get; set; }
        /// <summary> Configuration state of the resource. </summary>
        public NetworkFabricConfigurationState? ConfigurationState { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public NetworkFabricProvisioningState? ProvisioningState { get; }
        /// <summary> Administrative state of the resource. </summary>
        public NetworkFabricAdministrativeState? AdministrativeState { get; }
    }
}

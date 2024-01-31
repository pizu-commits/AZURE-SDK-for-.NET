// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ManagedNetwork;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmManagedNetworkModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ManagedNetwork.ManagedNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="scope"> The collection of management groups, subscriptions, virtual networks, and subnets by the Managed Network. This is a read-only property that is reflective of all ScopeAssignments for this Managed Network. </param>
        /// <param name="connectivity"> The collection of groups and policies concerned with connectivity. </param>
        /// <returns> A new <see cref="ManagedNetwork.ManagedNetworkData"/> instance for mocking. </returns>
        public static ManagedNetworkData ManagedNetworkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ProvisioningState? provisioningState = null, ETag? etag = null, Scope scope = null, ConnectivityCollection connectivity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ManagedNetworkData(id, name, resourceType, systemData, tags, location, provisioningState, etag, scope, connectivity, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ConnectivityCollection"/>. </summary>
        /// <param name="groups"> The collection of connectivity related Managed Network Groups within the Managed Network. </param>
        /// <param name="peerings"> The collection of Managed Network Peering Policies within the Managed Network. </param>
        /// <returns> A new <see cref="Models.ConnectivityCollection"/> instance for mocking. </returns>
        public static ConnectivityCollection ConnectivityCollection(IEnumerable<ManagedNetworkGroupData> groups = null, IEnumerable<ManagedNetworkPeeringPolicyData> peerings = null)
        {
            groups ??= new List<ManagedNetworkGroupData>();
            peerings ??= new List<ManagedNetworkPeeringPolicyData>();

            return new ConnectivityCollection(groups?.ToList(), peerings?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ManagedNetwork.ManagedNetworkGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Responsibility role under which this Managed Network Group will be created. </param>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="managementGroups"> The collection of management groups covered by the Managed Network. </param>
        /// <param name="subscriptions"> The collection of subscriptions covered by the Managed Network. </param>
        /// <param name="virtualNetworks"> The collection of virtual nets covered by the Managed Network. </param>
        /// <param name="subnets"> The collection of  subnets covered by the Managed Network. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ManagedNetwork.ManagedNetworkGroupData"/> instance for mocking. </returns>
        public static ManagedNetworkGroupData ManagedNetworkGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedNetworkKind? kind = null, ProvisioningState? provisioningState = null, ETag? etag = null, IEnumerable<WritableSubResource> managementGroups = null, IEnumerable<WritableSubResource> subscriptions = null, IEnumerable<WritableSubResource> virtualNetworks = null, IEnumerable<WritableSubResource> subnets = null, AzureLocation? location = null)
        {
            managementGroups ??= new List<WritableSubResource>();
            subscriptions ??= new List<WritableSubResource>();
            virtualNetworks ??= new List<WritableSubResource>();
            subnets ??= new List<WritableSubResource>();

            return new ManagedNetworkGroupData(id, name, resourceType, systemData, kind, provisioningState, etag, managementGroups?.ToList(), subscriptions?.ToList(), virtualNetworks?.ToList(), subnets?.ToList(), location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ResourceProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <returns> A new <see cref="Models.ResourceProperties"/> instance for mocking. </returns>
        public static ResourceProperties ResourceProperties(ProvisioningState? provisioningState = null, ETag? etag = null)
        {
            return new ResourceProperties(provisioningState, etag, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ManagedNetwork.ManagedNetworkPeeringPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Gets or sets the properties of a Managed Network Policy. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ManagedNetwork.ManagedNetworkPeeringPolicyData"/> instance for mocking. </returns>
        public static ManagedNetworkPeeringPolicyData ManagedNetworkPeeringPolicyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ManagedNetworkPeeringPolicyProperties properties = null, AzureLocation? location = null)
        {
            return new ManagedNetworkPeeringPolicyData(id, name, resourceType, systemData, properties, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedNetworkPeeringPolicyProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="connectivityType"> Gets or sets the connectivity type of a network structure policy. </param>
        /// <param name="hubId"> Gets or sets the hub virtual network ID. </param>
        /// <param name="spokes"> Gets or sets the spokes group IDs. </param>
        /// <param name="mesh"> Gets or sets the mesh group IDs. </param>
        /// <returns> A new <see cref="Models.ManagedNetworkPeeringPolicyProperties"/> instance for mocking. </returns>
        public static ManagedNetworkPeeringPolicyProperties ManagedNetworkPeeringPolicyProperties(ProvisioningState? provisioningState = null, ETag? etag = null, ConnectivityType connectivityType = default, ResourceIdentifier hubId = null, IEnumerable<WritableSubResource> spokes = null, IEnumerable<WritableSubResource> mesh = null)
        {
            spokes ??= new List<WritableSubResource>();
            mesh ??= new List<WritableSubResource>();

            return new ManagedNetworkPeeringPolicyProperties(provisioningState, etag, serializedAdditionalRawData: null, connectivityType, hubId != null ? ResourceManagerModelFactory.WritableSubResource(hubId) : null, spokes?.ToList(), mesh?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="ManagedNetwork.ScopeAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="assignedManagedNetwork"> The managed network ID with scope will be assigned to. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ManagedNetwork.ScopeAssignmentData"/> instance for mocking. </returns>
        public static ScopeAssignmentData ScopeAssignmentData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ProvisioningState? provisioningState = null, ETag? etag = null, string assignedManagedNetwork = null, AzureLocation? location = null)
        {
            return new ScopeAssignmentData(id, name, resourceType, systemData, provisioningState, etag, assignedManagedNetwork, location, serializedAdditionalRawData: null);
        }
    }
}

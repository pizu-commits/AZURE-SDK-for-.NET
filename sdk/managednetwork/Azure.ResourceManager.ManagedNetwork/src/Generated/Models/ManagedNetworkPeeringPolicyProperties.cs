// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    /// <summary> Properties of a Managed Network Peering Policy. </summary>
    public partial class ManagedNetworkPeeringPolicyProperties : ResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="ManagedNetworkPeeringPolicyProperties"/>. </summary>
        /// <param name="connectivityType"> Gets or sets the connectivity type of a network structure policy. </param>
        public ManagedNetworkPeeringPolicyProperties(ConnectivityType connectivityType)
        {
            ConnectivityType = connectivityType;
            Spokes = new ChangeTrackingList<WritableSubResource>();
            Mesh = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedNetworkPeeringPolicyProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="connectivityType"> Gets or sets the connectivity type of a network structure policy. </param>
        /// <param name="hub"> Gets or sets the hub virtual network ID. </param>
        /// <param name="spokes"> Gets or sets the spokes group IDs. </param>
        /// <param name="mesh"> Gets or sets the mesh group IDs. </param>
        internal ManagedNetworkPeeringPolicyProperties(ProvisioningState? provisioningState, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData, ConnectivityType connectivityType, WritableSubResource hub, IList<WritableSubResource> spokes, IList<WritableSubResource> mesh) : base(provisioningState, etag, serializedAdditionalRawData)
        {
            ConnectivityType = connectivityType;
            Hub = hub;
            Spokes = spokes;
            Mesh = mesh;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedNetworkPeeringPolicyProperties"/> for deserialization. </summary>
        internal ManagedNetworkPeeringPolicyProperties()
        {
        }

        /// <summary> Gets or sets the connectivity type of a network structure policy. </summary>
        public ConnectivityType ConnectivityType { get; set; }
        /// <summary> Gets or sets the hub virtual network ID. </summary>
        internal WritableSubResource Hub { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HubId
        {
            get => Hub is null ? default : Hub.Id;
            set
            {
                if (Hub is null)
                    Hub = new WritableSubResource();
                Hub.Id = value;
            }
        }

        /// <summary> Gets or sets the spokes group IDs. </summary>
        public IList<WritableSubResource> Spokes { get; }
        /// <summary> Gets or sets the mesh group IDs. </summary>
        public IList<WritableSubResource> Mesh { get; }
    }
}

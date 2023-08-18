// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Attestation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Attestation
{
    /// <summary>
    /// A class representing the AttestationProvider data model.
    /// Attestation service response message.
    /// </summary>
    public partial class AttestationProviderData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of AttestationProviderData. </summary>
        /// <param name="location"> The location. </param>
        public AttestationProviderData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new Core.ChangeTrackingList<AttestationPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of AttestationProviderData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="trustModel"> Trust model for the attestation provider. </param>
        /// <param name="status"> Status of attestation service. </param>
        /// <param name="attestUri"> Gets the uri of attestation service. </param>
        /// <param name="publicNetworkAccess"> Controls whether traffic from the public network is allowed to access the Attestation Provider APIs. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections associated with the attestation provider. </param>
        internal AttestationProviderData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string trustModel, AttestationServiceStatus? status, Uri attestUri, PublicNetworkAccessType? publicNetworkAccess, IReadOnlyList<AttestationPrivateEndpointConnectionData> privateEndpointConnections) : base(id, name, resourceType, systemData, tags, location)
        {
            TrustModel = trustModel;
            Status = status;
            AttestUri = attestUri;
            PublicNetworkAccess = publicNetworkAccess;
            PrivateEndpointConnections = privateEndpointConnections;
        }

        /// <summary> Trust model for the attestation provider. </summary>
        public string TrustModel { get; set; }
        /// <summary> Status of attestation service. </summary>
        public AttestationServiceStatus? Status { get; set; }
        /// <summary> Gets the uri of attestation service. </summary>
        public Uri AttestUri { get; set; }
        /// <summary> Controls whether traffic from the public network is allowed to access the Attestation Provider APIs. </summary>
        public PublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> List of private endpoint connections associated with the attestation provider. </summary>
        public IReadOnlyList<AttestationPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
    }
}

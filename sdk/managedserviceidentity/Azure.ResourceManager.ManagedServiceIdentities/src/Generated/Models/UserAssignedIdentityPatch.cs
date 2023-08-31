// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServiceIdentities.Models
{
    /// <summary> Describes an identity resource. </summary>
    public partial class UserAssignedIdentityPatch : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UserAssignedIdentityPatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public UserAssignedIdentityPatch(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="UserAssignedIdentityPatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UserAssignedIdentityPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? tenantId, Guid? principalId, Guid? clientId, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            TenantId = tenantId;
            PrincipalId = principalId;
            ClientId = clientId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="UserAssignedIdentityPatch"/> for deserialization. </summary>
        internal UserAssignedIdentityPatch()
        {
        }

        /// <summary> The id of the tenant which the identity belongs to. </summary>
        public Guid? TenantId { get; }
        /// <summary> The id of the service principal object associated with the created identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The id of the app associated with the identity. This is a random generated UUID by MSI. </summary>
        public Guid? ClientId { get; }
    }
}

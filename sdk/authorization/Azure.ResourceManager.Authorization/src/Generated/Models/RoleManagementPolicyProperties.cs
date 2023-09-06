// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Expanded info of resource scope. </summary>
    public partial class RoleManagementPolicyProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyProperties"/>. </summary>
        internal RoleManagementPolicyProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoleManagementPolicyProperties"/>. </summary>
        /// <param name="scopeId"> Scope id of the resource. </param>
        /// <param name="scopeDisplayName"> Display name of the resource. </param>
        /// <param name="scopeType"> Type of the scope. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleManagementPolicyProperties(ResourceIdentifier scopeId, string scopeDisplayName, RoleManagementScopeType? scopeType, Dictionary<string, BinaryData> rawData)
        {
            ScopeId = scopeId;
            ScopeDisplayName = scopeDisplayName;
            ScopeType = scopeType;
            _rawData = rawData;
        }

        /// <summary> Scope id of the resource. </summary>
        public ResourceIdentifier ScopeId { get; }
        /// <summary> Display name of the resource. </summary>
        public string ScopeDisplayName { get; }
        /// <summary> Type of the scope. </summary>
        public RoleManagementScopeType? ScopeType { get; }
    }
}

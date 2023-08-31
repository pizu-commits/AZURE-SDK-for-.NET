// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role assignment properties. </summary>
    internal partial class KeyVaultRoleAssignmentPropertiesInternal
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleAssignmentPropertiesInternal"/>. </summary>
        /// <param name="roleDefinitionId"> The role definition ID used in the role assignment. </param>
        /// <param name="principalId"> The principal ID assigned to the role. This maps to the ID inside the Active Directory. It can point to a user, service principal, or security group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> or <paramref name="principalId"/> is null. </exception>
        public KeyVaultRoleAssignmentPropertiesInternal(string roleDefinitionId, string principalId)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));
            Argument.AssertNotNull(principalId, nameof(principalId));

            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleAssignmentPropertiesInternal"/>. </summary>
        /// <param name="roleDefinitionId"> The role definition ID used in the role assignment. </param>
        /// <param name="principalId"> The principal ID assigned to the role. This maps to the ID inside the Active Directory. It can point to a user, service principal, or security group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KeyVaultRoleAssignmentPropertiesInternal(string roleDefinitionId, string principalId, Dictionary<string, BinaryData> rawData)
        {
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="KeyVaultRoleAssignmentPropertiesInternal"/> for deserialization. </summary>
        internal KeyVaultRoleAssignmentPropertiesInternal()
        {
        }

        /// <summary> The role definition ID used in the role assignment. </summary>
        public string RoleDefinitionId { get; }
        /// <summary> The principal ID assigned to the role. This maps to the ID inside the Active Directory. It can point to a user, service principal, or security group. </summary>
        public string PrincipalId { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role assignment create parameters. </summary>
    public partial class RoleAssignmentCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentCreateOrUpdateContent"/>. </summary>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        public RoleAssignmentCreateOrUpdateContent(ResourceIdentifier roleDefinitionId, Guid principalId)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));

            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentCreateOrUpdateContent"/>. </summary>
        /// <param name="scope"> The role assignment scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="principalType"> The principal type of the assigned principal ID. </param>
        /// <param name="description"> Description of role assignment. </param>
        /// <param name="condition"> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </param>
        /// <param name="conditionVersion"> Version of the condition. Currently the only accepted value is '2.0'. </param>
        /// <param name="createdOn"> Time it was created. </param>
        /// <param name="updatedOn"> Time it was updated. </param>
        /// <param name="createdBy"> Id of the user who created the assignment. </param>
        /// <param name="updatedBy"> Id of the user who updated the assignment. </param>
        /// <param name="delegatedManagedIdentityResourceId"> Id of the delegated managed identity resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleAssignmentCreateOrUpdateContent(string scope, ResourceIdentifier roleDefinitionId, Guid principalId, RoleManagementPrincipalType? principalType, string description, string condition, string conditionVersion, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string createdBy, string updatedBy, ResourceIdentifier delegatedManagedIdentityResourceId, Dictionary<string, BinaryData> rawData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            Description = description;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            DelegatedManagedIdentityResourceId = delegatedManagedIdentityResourceId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentCreateOrUpdateContent"/> for deserialization. </summary>
        internal RoleAssignmentCreateOrUpdateContent()
        {
        }

        /// <summary> The role assignment scope. </summary>
        public string Scope { get; }
        /// <summary> The role definition ID. </summary>
        public ResourceIdentifier RoleDefinitionId { get; }
        /// <summary> The principal ID. </summary>
        public Guid PrincipalId { get; }
        /// <summary> The principal type of the assigned principal ID. </summary>
        public RoleManagementPrincipalType? PrincipalType { get; set; }
        /// <summary> Description of role assignment. </summary>
        public string Description { get; set; }
        /// <summary> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </summary>
        public string Condition { get; set; }
        /// <summary> Version of the condition. Currently the only accepted value is '2.0'. </summary>
        public string ConditionVersion { get; set; }
        /// <summary> Time it was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Time it was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Id of the user who created the assignment. </summary>
        public string CreatedBy { get; }
        /// <summary> Id of the user who updated the assignment. </summary>
        public string UpdatedBy { get; }
        /// <summary> Id of the delegated managed identity resource. </summary>
        public ResourceIdentifier DelegatedManagedIdentityResourceId { get; set; }
    }
}

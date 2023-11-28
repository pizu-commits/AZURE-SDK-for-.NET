// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role assignment create parameters. </summary>
    public partial class RoleAssignmentCreateOrUpdateContent
    {
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

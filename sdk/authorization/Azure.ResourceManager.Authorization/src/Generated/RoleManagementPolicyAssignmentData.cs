// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing the RoleManagementPolicyAssignment data model.
    /// Role management policy
    /// </summary>
    public partial class RoleManagementPolicyAssignmentData : ResourceData
    {
        /// <summary> Initializes a new instance of RoleManagementPolicyAssignmentData. </summary>
        public RoleManagementPolicyAssignmentData()
        {
            EffectiveRules = new Core.ChangeTrackingList<RoleManagementPolicyRule>();
        }

        /// <summary> Initializes a new instance of RoleManagementPolicyAssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role management policy scope. </param>
        /// <param name="roleDefinitionId"> The role definition of management policy assignment. </param>
        /// <param name="policyId"> The policy id role management policy assignment. </param>
        /// <param name="effectiveRules">
        /// The readonly computed rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </param>
        /// <param name="policyAssignmentProperties"> Additional properties of scope, role definition and policy. </param>
        internal RoleManagementPolicyAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, ResourceIdentifier policyId, IReadOnlyList<RoleManagementPolicyRule> effectiveRules, PolicyAssignmentProperties policyAssignmentProperties) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PolicyId = policyId;
            EffectiveRules = effectiveRules;
            PolicyAssignmentProperties = policyAssignmentProperties;
        }

        /// <summary> The role management policy scope. </summary>
        public string Scope { get; set; }
        /// <summary> The role definition of management policy assignment. </summary>
        public ResourceIdentifier RoleDefinitionId { get; set; }
        /// <summary> The policy id role management policy assignment. </summary>
        public ResourceIdentifier PolicyId { get; set; }
        /// <summary>
        /// The readonly computed rule applied to the policy.
        /// Please note <see cref="RoleManagementPolicyRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RoleManagementPolicyApprovalRule"/>, <see cref="RoleManagementPolicyAuthenticationContextRule"/>, <see cref="RoleManagementPolicyEnablementRule"/>, <see cref="RoleManagementPolicyExpirationRule"/> and <see cref="RoleManagementPolicyNotificationRule"/>.
        /// </summary>
        public IReadOnlyList<RoleManagementPolicyRule> EffectiveRules { get; }
        /// <summary> Additional properties of scope, role definition and policy. </summary>
        public PolicyAssignmentProperties PolicyAssignmentProperties { get; }
    }
}

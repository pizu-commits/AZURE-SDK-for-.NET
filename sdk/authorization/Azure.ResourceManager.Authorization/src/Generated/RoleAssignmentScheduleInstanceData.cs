// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing the RoleAssignmentScheduleInstance data model.
    /// Information about current or upcoming role assignment schedule instance
    /// </summary>
    public partial class RoleAssignmentScheduleInstanceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentScheduleInstanceData"/>. </summary>
        internal RoleAssignmentScheduleInstanceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentScheduleInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role assignment schedule scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="principalType"> The principal type of the assigned principal ID. </param>
        /// <param name="roleAssignmentScheduleId"> Id of the master role assignment schedule. </param>
        /// <param name="originRoleAssignmentId"> Role Assignment Id in external system. </param>
        /// <param name="status"> The status of the role assignment schedule instance. </param>
        /// <param name="startOn"> The startDateTime of the role assignment schedule instance. </param>
        /// <param name="endOn"> The endDateTime of the role assignment schedule instance. </param>
        /// <param name="linkedRoleEligibilityScheduleId"> roleEligibilityScheduleId used to activate. </param>
        /// <param name="linkedRoleEligibilityScheduleInstanceId"> roleEligibilityScheduleInstanceId linked to this roleAssignmentScheduleInstance. </param>
        /// <param name="assignmentType"> Assignment type of the role assignment schedule. </param>
        /// <param name="memberType"> Membership type of the role assignment schedule. </param>
        /// <param name="condition"> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </param>
        /// <param name="conditionVersion"> Version of the condition. Currently accepted value is '2.0'. </param>
        /// <param name="createdOn"> DateTime when role assignment schedule was created. </param>
        /// <param name="expandedProperties"> Additional properties of principal, scope and role definition. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleAssignmentScheduleInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, Guid? principalId, RoleManagementPrincipalType? principalType, ResourceIdentifier roleAssignmentScheduleId, ResourceIdentifier originRoleAssignmentId, RoleManagementScheduleStatus? status, DateTimeOffset? startOn, DateTimeOffset? endOn, ResourceIdentifier linkedRoleEligibilityScheduleId, ResourceIdentifier linkedRoleEligibilityScheduleInstanceId, RoleAssignmentScheduleAssignmentType? assignmentType, RoleManagementScheduleMemberType? memberType, string condition, string conditionVersion, DateTimeOffset? createdOn, RoleManagementExpandedProperties expandedProperties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            RoleAssignmentScheduleId = roleAssignmentScheduleId;
            OriginRoleAssignmentId = originRoleAssignmentId;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            LinkedRoleEligibilityScheduleId = linkedRoleEligibilityScheduleId;
            LinkedRoleEligibilityScheduleInstanceId = linkedRoleEligibilityScheduleInstanceId;
            AssignmentType = assignmentType;
            MemberType = memberType;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            ExpandedProperties = expandedProperties;
            _rawData = rawData;
        }

        /// <summary> The role assignment schedule scope. </summary>
        public string Scope { get; }
        /// <summary> The role definition ID. </summary>
        public ResourceIdentifier RoleDefinitionId { get; }
        /// <summary> The principal ID. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The principal type of the assigned principal ID. </summary>
        public RoleManagementPrincipalType? PrincipalType { get; }
        /// <summary> Id of the master role assignment schedule. </summary>
        public ResourceIdentifier RoleAssignmentScheduleId { get; }
        /// <summary> Role Assignment Id in external system. </summary>
        public ResourceIdentifier OriginRoleAssignmentId { get; }
        /// <summary> The status of the role assignment schedule instance. </summary>
        public RoleManagementScheduleStatus? Status { get; }
        /// <summary> The startDateTime of the role assignment schedule instance. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The endDateTime of the role assignment schedule instance. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> roleEligibilityScheduleId used to activate. </summary>
        public ResourceIdentifier LinkedRoleEligibilityScheduleId { get; }
        /// <summary> roleEligibilityScheduleInstanceId linked to this roleAssignmentScheduleInstance. </summary>
        public ResourceIdentifier LinkedRoleEligibilityScheduleInstanceId { get; }
        /// <summary> Assignment type of the role assignment schedule. </summary>
        public RoleAssignmentScheduleAssignmentType? AssignmentType { get; }
        /// <summary> Membership type of the role assignment schedule. </summary>
        public RoleManagementScheduleMemberType? MemberType { get; }
        /// <summary> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </summary>
        public string Condition { get; }
        /// <summary> Version of the condition. Currently accepted value is '2.0'. </summary>
        public string ConditionVersion { get; }
        /// <summary> DateTime when role assignment schedule was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Additional properties of principal, scope and role definition. </summary>
        public RoleManagementExpandedProperties ExpandedProperties { get; }
    }
}

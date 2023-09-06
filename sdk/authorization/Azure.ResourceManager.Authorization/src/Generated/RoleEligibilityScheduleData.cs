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
    /// A class representing the RoleEligibilitySchedule data model.
    /// Role eligibility schedule
    /// </summary>
    public partial class RoleEligibilityScheduleData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoleEligibilityScheduleData"/>. </summary>
        internal RoleEligibilityScheduleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoleEligibilityScheduleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scope"> The role eligibility schedule scope. </param>
        /// <param name="roleDefinitionId"> The role definition ID. </param>
        /// <param name="principalId"> The principal ID. </param>
        /// <param name="principalType"> The principal type of the assigned principal ID. </param>
        /// <param name="roleEligibilityScheduleRequestId"> The id of roleEligibilityScheduleRequest used to create this roleAssignmentSchedule. </param>
        /// <param name="memberType"> Membership type of the role eligibility schedule. </param>
        /// <param name="status"> The status of the role eligibility schedule. </param>
        /// <param name="startOn"> Start DateTime when role eligibility schedule. </param>
        /// <param name="endOn"> End DateTime when role eligibility schedule. </param>
        /// <param name="condition"> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </param>
        /// <param name="conditionVersion"> Version of the condition. Currently accepted value is '2.0'. </param>
        /// <param name="createdOn"> DateTime when role eligibility schedule was created. </param>
        /// <param name="updatedOn"> DateTime when role eligibility schedule was modified. </param>
        /// <param name="expandedProperties"> Additional properties of principal, scope and role definition. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleEligibilityScheduleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string scope, ResourceIdentifier roleDefinitionId, Guid? principalId, RoleManagementPrincipalType? principalType, ResourceIdentifier roleEligibilityScheduleRequestId, RoleManagementScheduleMemberType? memberType, RoleManagementScheduleStatus? status, DateTimeOffset? startOn, DateTimeOffset? endOn, string condition, string conditionVersion, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, RoleManagementExpandedProperties expandedProperties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Scope = scope;
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
            PrincipalType = principalType;
            RoleEligibilityScheduleRequestId = roleEligibilityScheduleRequestId;
            MemberType = memberType;
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            Condition = condition;
            ConditionVersion = conditionVersion;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ExpandedProperties = expandedProperties;
            _rawData = rawData;
        }

        /// <summary> The role eligibility schedule scope. </summary>
        public string Scope { get; }
        /// <summary> The role definition ID. </summary>
        public ResourceIdentifier RoleDefinitionId { get; }
        /// <summary> The principal ID. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The principal type of the assigned principal ID. </summary>
        public RoleManagementPrincipalType? PrincipalType { get; }
        /// <summary> The id of roleEligibilityScheduleRequest used to create this roleAssignmentSchedule. </summary>
        public ResourceIdentifier RoleEligibilityScheduleRequestId { get; }
        /// <summary> Membership type of the role eligibility schedule. </summary>
        public RoleManagementScheduleMemberType? MemberType { get; }
        /// <summary> The status of the role eligibility schedule. </summary>
        public RoleManagementScheduleStatus? Status { get; }
        /// <summary> Start DateTime when role eligibility schedule. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End DateTime when role eligibility schedule. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'. </summary>
        public string Condition { get; }
        /// <summary> Version of the condition. Currently accepted value is '2.0'. </summary>
        public string ConditionVersion { get; }
        /// <summary> DateTime when role eligibility schedule was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> DateTime when role eligibility schedule was modified. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Additional properties of principal, scope and role definition. </summary>
        public RoleManagementExpandedProperties ExpandedProperties { get; }
    }
}

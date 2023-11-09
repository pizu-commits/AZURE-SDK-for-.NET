// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Blueprint.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing the Assignment data model.
    /// Represents a blueprint assignment.
    /// </summary>
    public partial class AssignmentData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AssignmentData"/>. </summary>
        /// <param name="identity"> Managed identity for this blueprint assignment. </param>
        /// <param name="parameters"> Blueprint assignment parameter values. </param>
        /// <param name="resourceGroups"> Names and locations of resource group placeholders. </param>
        /// <param name="location"> The location of this blueprint assignment. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identity"/>, <paramref name="parameters"/> or <paramref name="resourceGroups"/> is null. </exception>
        public AssignmentData(Models.ManagedServiceIdentity identity, IDictionary<string, ParameterValue> parameters, IDictionary<string, ResourceGroupValue> resourceGroups, AzureLocation location)
        {
            Argument.AssertNotNull(identity, nameof(identity));
            Argument.AssertNotNull(parameters, nameof(parameters));
            Argument.AssertNotNull(resourceGroups, nameof(resourceGroups));

            Identity = identity;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            Location = location;
        }

        /// <summary> Initializes a new instance of <see cref="AssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> Managed identity for this blueprint assignment. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="blueprintId"> ID of the published version of a blueprint definition. </param>
        /// <param name="scope"> The target subscription scope of the blueprint assignment (format: '/subscriptions/{subscriptionId}'). For management group level assignments, the property is required. </param>
        /// <param name="parameters"> Blueprint assignment parameter values. </param>
        /// <param name="resourceGroups"> Names and locations of resource group placeholders. </param>
        /// <param name="status"> Status of blueprint assignment. This field is readonly. </param>
        /// <param name="locks"> Defines how resources deployed by a blueprint assignment are locked. </param>
        /// <param name="provisioningState"> State of the blueprint assignment. </param>
        /// <param name="location"> The location of this blueprint assignment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Models.ManagedServiceIdentity identity, string displayName, string description, string blueprintId, string scope, IDictionary<string, ParameterValue> parameters, IDictionary<string, ResourceGroupValue> resourceGroups, AssignmentStatus status, AssignmentLockSettings locks, AssignmentProvisioningState? provisioningState, AzureLocation location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Identity = identity;
            DisplayName = displayName;
            Description = description;
            BlueprintId = blueprintId;
            Scope = scope;
            Parameters = parameters;
            ResourceGroups = resourceGroups;
            Status = status;
            Locks = locks;
            ProvisioningState = provisioningState;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssignmentData"/> for deserialization. </summary>
        internal AssignmentData()
        {
        }

        /// <summary> Managed identity for this blueprint assignment. </summary>
        public Models.ManagedServiceIdentity Identity { get; set; }
        /// <summary> One-liner string explain this resource. </summary>
        public string DisplayName { get; set; }
        /// <summary> Multi-line explain this resource. </summary>
        public string Description { get; set; }
        /// <summary> ID of the published version of a blueprint definition. </summary>
        public string BlueprintId { get; set; }
        /// <summary> The target subscription scope of the blueprint assignment (format: '/subscriptions/{subscriptionId}'). For management group level assignments, the property is required. </summary>
        public string Scope { get; set; }
        /// <summary> Blueprint assignment parameter values. </summary>
        public IDictionary<string, ParameterValue> Parameters { get; }
        /// <summary> Names and locations of resource group placeholders. </summary>
        public IDictionary<string, ResourceGroupValue> ResourceGroups { get; }
        /// <summary> Status of blueprint assignment. This field is readonly. </summary>
        public AssignmentStatus Status { get; }
        /// <summary> Defines how resources deployed by a blueprint assignment are locked. </summary>
        public AssignmentLockSettings Locks { get; set; }
        /// <summary> State of the blueprint assignment. </summary>
        public AssignmentProvisioningState? ProvisioningState { get; }
        /// <summary> The location of this blueprint assignment. </summary>
        public AzureLocation Location { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary>
    /// Defines the dependency override of the move resource.
    /// Serialized Name: MoveResourceDependencyOverride
    /// </summary>
    public partial class MoveResourceDependencyOverride
    {
        /// <summary> Initializes a new instance of MoveResourceDependencyOverride. </summary>
        public MoveResourceDependencyOverride()
        {
        }

        /// <summary> Initializes a new instance of MoveResourceDependencyOverride. </summary>
        /// <param name="id">
        /// Gets or sets the ARM ID of the dependent resource.
        /// Serialized Name: MoveResourceDependencyOverride.id
        /// </param>
        /// <param name="targetId">
        /// Gets or sets the resource ARM id of either the MoveResource or the resource ARM ID of
        /// the dependent resource.
        /// Serialized Name: MoveResourceDependencyOverride.targetId
        /// </param>
        internal MoveResourceDependencyOverride(ResourceIdentifier id, ResourceIdentifier targetId)
        {
            Id = id;
            TargetId = targetId;
        }

        /// <summary>
        /// Gets or sets the ARM ID of the dependent resource.
        /// Serialized Name: MoveResourceDependencyOverride.id
        /// </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary>
        /// Gets or sets the resource ARM id of either the MoveResource or the resource ARM ID of
        /// the dependent resource.
        /// Serialized Name: MoveResourceDependencyOverride.targetId
        /// </summary>
        public ResourceIdentifier TargetId { get; set; }
    }
}

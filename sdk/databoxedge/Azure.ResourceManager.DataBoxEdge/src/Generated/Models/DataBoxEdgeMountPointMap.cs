// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The share mount point. </summary>
    public partial class DataBoxEdgeMountPointMap
    {
        /// <summary> Initializes a new instance of DataBoxEdgeMountPointMap. </summary>
        /// <param name="shareId"> ID of the share mounted to the role VM. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="shareId"/> is null. </exception>
        public DataBoxEdgeMountPointMap(ResourceIdentifier shareId)
        {
            if (shareId == null)
            {
                throw new ArgumentNullException(nameof(shareId));
            }

            ShareId = shareId;
        }

        /// <summary> Initializes a new instance of DataBoxEdgeMountPointMap. </summary>
        /// <param name="shareId"> ID of the share mounted to the role VM. </param>
        /// <param name="roleId"> ID of the role to which share is mounted. </param>
        /// <param name="mountPoint"> Mount point for the share. </param>
        /// <param name="mountType"> Mounting type. </param>
        /// <param name="roleType"> Role type. </param>
        internal DataBoxEdgeMountPointMap(ResourceIdentifier shareId, ResourceIdentifier roleId, string mountPoint, DataBoxEdgeMountType? mountType, DataBoxEdgeRoleType? roleType)
        {
            ShareId = shareId;
            RoleId = roleId;
            MountPoint = mountPoint;
            MountType = mountType;
            RoleType = roleType;
        }

        /// <summary> ID of the share mounted to the role VM. </summary>
        public ResourceIdentifier ShareId { get; set; }
        /// <summary> ID of the role to which share is mounted. </summary>
        public ResourceIdentifier RoleId { get; }
        /// <summary> Mount point for the share. </summary>
        public string MountPoint { get; }
        /// <summary> Mounting type. </summary>
        public DataBoxEdgeMountType? MountType { get; }
        /// <summary> Role type. </summary>
        public DataBoxEdgeRoleType? RoleType { get; }
    }
}

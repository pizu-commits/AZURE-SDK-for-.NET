// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> Metadata pertaining to creation and last modification of the key vault resource. </summary>
    internal partial class SystemData
    {
        /// <summary> Initializes a new instance of SystemData. </summary>
        internal SystemData()
        {
        }

        /// <summary> Initializes a new instance of SystemData. </summary>
        /// <param name="createdBy"> The identity that created the key vault resource. </param>
        /// <param name="createdByType"> The type of identity that created the key vault resource. </param>
        /// <param name="createdOn"> The timestamp of the key vault resource creation (UTC). </param>
        /// <param name="lastModifiedBy"> The identity that last modified the key vault resource. </param>
        /// <param name="lastModifiedByType"> The type of identity that last modified the key vault resource. </param>
        /// <param name="lastModifiedOn"> The timestamp of the key vault resource last modification (UTC). </param>
        internal SystemData(string createdBy, IdentityType? createdByType, DateTimeOffset? createdOn, string lastModifiedBy, IdentityType? lastModifiedByType, DateTimeOffset? lastModifiedOn)
        {
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            CreatedOn = createdOn;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
            LastModifiedOn = lastModifiedOn;
        }

        /// <summary> The identity that created the key vault resource. </summary>
        public string CreatedBy { get; }
        /// <summary> The type of identity that created the key vault resource. </summary>
        public IdentityType? CreatedByType { get; }
        /// <summary> The timestamp of the key vault resource creation (UTC). </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The identity that last modified the key vault resource. </summary>
        public string LastModifiedBy { get; }
        /// <summary> The type of identity that last modified the key vault resource. </summary>
        public IdentityType? LastModifiedByType { get; }
        /// <summary> The timestamp of the key vault resource last modification (UTC). </summary>
        public DateTimeOffset? LastModifiedOn { get; }
    }
}

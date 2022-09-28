// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Table Access Policy Properties Object. </summary>
    public partial class StorageTableAccessPolicy
    {
        /// <summary> Initializes a new instance of StorageTableAccessPolicy. </summary>
        /// <param name="permission"> Required. List of abbreviated permissions. Supported permission values include &apos;r&apos;,&apos;a&apos;,&apos;u&apos;,&apos;d&apos;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="permission"/> is null. </exception>
        public StorageTableAccessPolicy(string permission)
        {
            if (permission == null)
            {
                throw new ArgumentNullException(nameof(permission));
            }

            Permission = permission;
        }

        /// <summary> Initializes a new instance of StorageTableAccessPolicy. </summary>
        /// <param name="startOn"> Start time of the access policy. </param>
        /// <param name="expireOn"> Expiry time of the access policy. </param>
        /// <param name="permission"> Required. List of abbreviated permissions. Supported permission values include &apos;r&apos;,&apos;a&apos;,&apos;u&apos;,&apos;d&apos;. </param>
        internal StorageTableAccessPolicy(DateTimeOffset? startOn, DateTimeOffset? expireOn, string permission)
        {
            StartOn = startOn;
            ExpireOn = expireOn;
            Permission = permission;
        }

        /// <summary> Start time of the access policy. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Expiry time of the access policy. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Required. List of abbreviated permissions. Supported permission values include &apos;r&apos;,&apos;a&apos;,&apos;u&apos;,&apos;d&apos;. </summary>
        public string Permission { get; set; }
    }
}

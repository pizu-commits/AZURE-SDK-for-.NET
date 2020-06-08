// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Storage.Models
{
    /// <summary> The blob service properties for blob restore policy. </summary>
    public partial class RestorePolicyProperties
    {
        /// <summary> Initializes a new instance of RestorePolicyProperties. </summary>
        /// <param name="enabled"> Blob restore is enabled if set to true. </param>
        public RestorePolicyProperties(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of RestorePolicyProperties. </summary>
        /// <param name="enabled"> Blob restore is enabled if set to true. </param>
        /// <param name="days"> how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days. </param>
        /// <param name="lastEnabledTime"> Returns the date and time the restore policy was last enabled. </param>
        internal RestorePolicyProperties(bool enabled, int? days, DateTimeOffset? lastEnabledTime)
        {
            Enabled = enabled;
            Days = days;
            LastEnabledTime = lastEnabledTime;
        }

        /// <summary> Blob restore is enabled if set to true. </summary>
        public bool Enabled { get; set; }
        /// <summary> how long this blob can be restored. It should be great than zero and less than DeleteRetentionPolicy.days. </summary>
        public int? Days { get; set; }
        /// <summary> Returns the date and time the restore policy was last enabled. </summary>
        public DateTimeOffset? LastEnabledTime { get; }
    }
}

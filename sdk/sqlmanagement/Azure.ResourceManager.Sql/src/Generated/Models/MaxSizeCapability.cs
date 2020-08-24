// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The maximum size capability. </summary>
    public partial class MaxSizeCapability
    {
        /// <summary> Initializes a new instance of MaxSizeCapability. </summary>
        internal MaxSizeCapability()
        {
        }

        /// <summary> Initializes a new instance of MaxSizeCapability. </summary>
        /// <param name="limit"> The maximum size limit (see &apos;unit&apos; for the units). </param>
        /// <param name="unit"> The units that the limit is expressed in. </param>
        internal MaxSizeCapability(int? limit, MaxSizeUnit? unit)
        {
            Limit = limit;
            Unit = unit;
        }

        /// <summary> The maximum size limit (see &apos;unit&apos; for the units). </summary>
        public int? Limit { get; }
        /// <summary> The units that the limit is expressed in. </summary>
        public MaxSizeUnit? Unit { get; }
    }
}

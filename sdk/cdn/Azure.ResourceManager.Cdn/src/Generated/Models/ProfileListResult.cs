// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list profiles. It contains a list of profile objects and a URL link to get the next set of results. </summary>
    internal partial class ProfileListResult
    {
        /// <summary> Initializes a new instance of <see cref="ProfileListResult"/>. </summary>
        internal ProfileListResult()
        {
            Value = new ChangeTrackingList<ProfileData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProfileListResult"/>. </summary>
        /// <param name="value"> List of CDN profiles within a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of profile objects if there are any. </param>
        internal ProfileListResult(IReadOnlyList<ProfileData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of CDN profiles within a resource group. </summary>
        public IReadOnlyList<ProfileData> Value { get; }
        /// <summary> URL to get the next set of profile objects if there are any. </summary>
        public string NextLink { get; }
    }
}

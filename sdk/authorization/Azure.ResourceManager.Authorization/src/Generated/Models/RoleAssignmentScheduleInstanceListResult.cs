// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> Role assignment schedule instance list operation result. </summary>
    internal partial class RoleAssignmentScheduleInstanceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentScheduleInstanceListResult"/>. </summary>
        internal RoleAssignmentScheduleInstanceListResult()
        {
            Value = new ChangeTrackingList<RoleAssignmentScheduleInstanceData>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentScheduleInstanceListResult"/>. </summary>
        /// <param name="value"> Role assignment schedule instance list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleAssignmentScheduleInstanceListResult(IReadOnlyList<RoleAssignmentScheduleInstanceData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Role assignment schedule instance list. </summary>
        public IReadOnlyList<RoleAssignmentScheduleInstanceData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}

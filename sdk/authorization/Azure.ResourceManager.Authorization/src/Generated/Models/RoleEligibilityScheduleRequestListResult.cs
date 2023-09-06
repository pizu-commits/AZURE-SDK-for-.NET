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
    /// <summary> Role eligibility schedule request list operation result. </summary>
    internal partial class RoleEligibilityScheduleRequestListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoleEligibilityScheduleRequestListResult"/>. </summary>
        internal RoleEligibilityScheduleRequestListResult()
        {
            Value = new ChangeTrackingList<RoleEligibilityScheduleRequestData>();
        }

        /// <summary> Initializes a new instance of <see cref="RoleEligibilityScheduleRequestListResult"/>. </summary>
        /// <param name="value"> Role eligibility schedule request list. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoleEligibilityScheduleRequestListResult(IReadOnlyList<RoleEligibilityScheduleRequestData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Role eligibility schedule request list. </summary>
        public IReadOnlyList<RoleEligibilityScheduleRequestData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}

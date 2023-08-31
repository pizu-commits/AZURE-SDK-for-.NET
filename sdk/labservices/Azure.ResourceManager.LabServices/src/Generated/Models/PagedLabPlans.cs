// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.LabServices;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Paged list of lab plans. </summary>
    internal partial class PagedLabPlans
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PagedLabPlans"/>. </summary>
        internal PagedLabPlans()
        {
            Value = new ChangeTrackingList<LabPlanData>();
        }

        /// <summary> Initializes a new instance of <see cref="PagedLabPlans"/>. </summary>
        /// <param name="value"> The array page of lab plans. </param>
        /// <param name="nextLink"> The link to get the next page of lab plan results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PagedLabPlans(IReadOnlyList<LabPlanData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The array page of lab plans. </summary>
        public IReadOnlyList<LabPlanData> Value { get; }
        /// <summary> The link to get the next page of lab plan results. </summary>
        public string NextLink { get; }
    }
}

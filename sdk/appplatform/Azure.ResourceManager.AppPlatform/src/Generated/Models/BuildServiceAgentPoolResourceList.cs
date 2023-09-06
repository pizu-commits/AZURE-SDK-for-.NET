// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of build service agent pool resources and a possible link for next set. </summary>
    internal partial class BuildServiceAgentPoolResourceList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BuildServiceAgentPoolResourceList"/>. </summary>
        internal BuildServiceAgentPoolResourceList()
        {
            Value = new ChangeTrackingList<AppPlatformBuildServiceAgentPoolData>();
        }

        /// <summary> Initializes a new instance of <see cref="BuildServiceAgentPoolResourceList"/>. </summary>
        /// <param name="value"> Collection of build service agent pool resource. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BuildServiceAgentPoolResourceList(IReadOnlyList<AppPlatformBuildServiceAgentPoolData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Collection of build service agent pool resource. </summary>
        public IReadOnlyList<AppPlatformBuildServiceAgentPoolData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}

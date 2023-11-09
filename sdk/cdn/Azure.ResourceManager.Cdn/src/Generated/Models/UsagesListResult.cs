// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The list usages operation response. </summary>
    internal partial class UsagesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UsagesListResult"/>. </summary>
        internal UsagesListResult()
        {
            Value = new ChangeTrackingList<FrontDoorUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="UsagesListResult"/>. </summary>
        /// <param name="value"> The list of resource usages. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UsagesListResult(IReadOnlyList<FrontDoorUsage> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of resource usages. </summary>
        public IReadOnlyList<FrontDoorUsage> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of check resource usage API. </summary>
    internal partial class ResourceUsageListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceUsageListResult"/>. </summary>
        internal ResourceUsageListResult()
        {
            Value = new ChangeTrackingList<CdnUsage>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceUsageListResult"/>. </summary>
        /// <param name="value"> List of resource usages. </param>
        /// <param name="nextLink"> URL to get the next set of custom domain objects if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceUsageListResult(IReadOnlyList<CdnUsage> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of resource usages. </summary>
        public IReadOnlyList<CdnUsage> Value { get; }
        /// <summary> URL to get the next set of custom domain objects if there are any. </summary>
        public string NextLink { get; }
    }
}

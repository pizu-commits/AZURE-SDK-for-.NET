// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class ListPrivateLinkResourcesResult
    {
        /// <summary> Initializes a new instance of ListPrivateLinkResourcesResult. </summary>
        internal ListPrivateLinkResourcesResult()
        {
            Value = new Core.ChangeTrackingList<BatchPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of ListPrivateLinkResourcesResult. </summary>
        /// <param name="value"> The collection of returned private link resources. </param>
        /// <param name="nextLink"> The continuation token. </param>
        internal ListPrivateLinkResourcesResult(IReadOnlyList<BatchPrivateLinkResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of returned private link resources. </summary>
        public IReadOnlyList<BatchPrivateLinkResourceData> Value { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}

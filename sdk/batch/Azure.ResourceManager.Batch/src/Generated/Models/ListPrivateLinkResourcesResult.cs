// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Batch;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Values returned by the List operation. </summary>
    internal partial class ListPrivateLinkResourcesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListPrivateLinkResourcesResult"/>. </summary>
        internal ListPrivateLinkResourcesResult()
        {
            Value = new ChangeTrackingList<BatchPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListPrivateLinkResourcesResult"/>. </summary>
        /// <param name="value"> The collection of returned private link resources. </param>
        /// <param name="nextLink"> The continuation token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListPrivateLinkResourcesResult(IReadOnlyList<BatchPrivateLinkResourceData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The collection of returned private link resources. </summary>
        public IReadOnlyList<BatchPrivateLinkResourceData> Value { get; }
        /// <summary> The continuation token. </summary>
        public string NextLink { get; }
    }
}

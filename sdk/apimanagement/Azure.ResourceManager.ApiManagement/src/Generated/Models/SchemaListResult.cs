// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The response of the list schema operation. </summary>
    internal partial class SchemaListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SchemaListResult"/>. </summary>
        internal SchemaListResult()
        {
            Value = new ChangeTrackingList<ApiSchemaData>();
        }

        /// <summary> Initializes a new instance of <see cref="SchemaListResult"/>. </summary>
        /// <param name="value"> API Schema Contract value. </param>
        /// <param name="count"> Total record count number. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SchemaListResult(IReadOnlyList<ApiSchemaData> value, long? count, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> API Schema Contract value. </summary>
        public IReadOnlyList<ApiSchemaData> Value { get; }
        /// <summary> Total record count number. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}

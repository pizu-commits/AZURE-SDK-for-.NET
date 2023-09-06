// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Quota Counter list representation. </summary>
    internal partial class QuotaCounterListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QuotaCounterListResult"/>. </summary>
        internal QuotaCounterListResult()
        {
            Value = new ChangeTrackingList<QuotaCounterContract>();
        }

        /// <summary> Initializes a new instance of <see cref="QuotaCounterListResult"/>. </summary>
        /// <param name="value"> Quota counter values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaCounterListResult(IReadOnlyList<QuotaCounterContract> value, long? count, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Quota counter values. </summary>
        public IReadOnlyList<QuotaCounterContract> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}

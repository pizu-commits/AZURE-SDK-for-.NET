// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> Summary of the results for the batch request. </summary>
    internal partial class BatchResultSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchResultSummary"/>. </summary>
        internal BatchResultSummary()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchResultSummary"/>. </summary>
        /// <param name="successfulRequests"> Number of successful requests in the batch. </param>
        /// <param name="totalRequests"> Total number of requests in the batch. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchResultSummary(int? successfulRequests, int? totalRequests, Dictionary<string, BinaryData> rawData)
        {
            SuccessfulRequests = successfulRequests;
            TotalRequests = totalRequests;
            _rawData = rawData;
        }

        /// <summary> Number of successful requests in the batch. </summary>
        public int? SuccessfulRequests { get; }
        /// <summary> Total number of requests in the batch. </summary>
        public int? TotalRequests { get; }
    }
}

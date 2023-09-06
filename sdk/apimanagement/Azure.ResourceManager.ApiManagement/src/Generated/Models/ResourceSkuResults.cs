// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The API Management service SKUs operation response. </summary>
    internal partial class ResourceSkuResults
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceSkuResults"/>. </summary>
        /// <param name="value"> The list of skus available for the service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ResourceSkuResults(IEnumerable<AvailableApiManagementServiceSkuResult> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSkuResults"/>. </summary>
        /// <param name="value"> The list of skus available for the service. </param>
        /// <param name="nextLink"> The uri to fetch the next page of API Management service Skus. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceSkuResults(IReadOnlyList<AvailableApiManagementServiceSkuResult> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceSkuResults"/> for deserialization. </summary>
        internal ResourceSkuResults()
        {
        }

        /// <summary> The list of skus available for the service. </summary>
        public IReadOnlyList<AvailableApiManagementServiceSkuResult> Value { get; }
        /// <summary> The uri to fetch the next page of API Management service Skus. </summary>
        public string NextLink { get; }
    }
}

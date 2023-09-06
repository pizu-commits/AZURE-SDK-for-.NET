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
    /// <summary> The List Resource Skus operation response. </summary>
    internal partial class ApiManagementSkusResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkusResult"/>. </summary>
        /// <param name="value"> The list of skus available for the subscription. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ApiManagementSkusResult(IEnumerable<ApiManagementSku> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkusResult"/>. </summary>
        /// <param name="value"> The list of skus available for the subscription. </param>
        /// <param name="nextLink"> The URI to fetch the next page of Resource Skus. Call ListNext() with this URI to fetch the next page of Resource Skus. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementSkusResult(IReadOnlyList<ApiManagementSku> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementSkusResult"/> for deserialization. </summary>
        internal ApiManagementSkusResult()
        {
        }

        /// <summary> The list of skus available for the subscription. </summary>
        public IReadOnlyList<ApiManagementSku> Value { get; }
        /// <summary> The URI to fetch the next page of Resource Skus. Call ListNext() with this URI to fetch the next page of Resource Skus. </summary>
        public string NextLink { get; }
    }
}

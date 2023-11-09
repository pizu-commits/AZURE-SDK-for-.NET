// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> A list of 0 or more Application Insights WebTest definitions. </summary>
    internal partial class WebTestListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebTestListResult"/>. </summary>
        /// <param name="value"> Set of Application Insights WebTest definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal WebTestListResult(IEnumerable<WebTestData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="WebTestListResult"/>. </summary>
        /// <param name="value"> Set of Application Insights WebTest definitions. </param>
        /// <param name="nextLink"> The link to get the next part of the returned list of WebTest, should the return set be too large for a single request. May be null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebTestListResult(IReadOnlyList<WebTestData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebTestListResult"/> for deserialization. </summary>
        internal WebTestListResult()
        {
        }

        /// <summary> Set of Application Insights WebTest definitions. </summary>
        public IReadOnlyList<WebTestData> Value { get; }
        /// <summary> The link to get the next part of the returned list of WebTest, should the return set be too large for a single request. May be null. </summary>
        public string NextLink { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The properties that are associated with a SKU. </summary>
    internal partial class StreamAnalyticsSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsSku"/>. </summary>
        public StreamAnalyticsSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsSku"/>. </summary>
        /// <param name="name"> The name of the SKU. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsSku(StreamAnalyticsSkuName? name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the SKU. Required on PUT (CreateOrReplace) requests. </summary>
        public StreamAnalyticsSkuName? Name { get; set; }
    }
}

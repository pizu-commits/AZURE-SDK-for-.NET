// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    /// <summary> Paged response contains list of requested objects and a URL link to get the next set of results. </summary>
    internal partial class FarmBeatsListResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FarmBeatsListResponse"/>. </summary>
        internal FarmBeatsListResponse()
        {
            Value = new ChangeTrackingList<FarmBeatData>();
        }

        /// <summary> Initializes a new instance of <see cref="FarmBeatsListResponse"/>. </summary>
        /// <param name="value"> List of requested objects. </param>
        /// <param name="nextLink"> Continuation link (absolute URI) to the next page of results in the list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FarmBeatsListResponse(IReadOnlyList<FarmBeatData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of requested objects. </summary>
        public IReadOnlyList<FarmBeatData> Value { get; }
        /// <summary> Continuation link (absolute URI) to the next page of results in the list. </summary>
        public string NextLink { get; }
    }
}

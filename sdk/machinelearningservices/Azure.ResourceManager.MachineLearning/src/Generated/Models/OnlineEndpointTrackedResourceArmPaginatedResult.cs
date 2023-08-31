// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> A paginated list of OnlineEndpoint entities. </summary>
    internal partial class OnlineEndpointTrackedResourceArmPaginatedResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OnlineEndpointTrackedResourceArmPaginatedResult"/>. </summary>
        internal OnlineEndpointTrackedResourceArmPaginatedResult()
        {
            Value = new ChangeTrackingList<MachineLearningOnlineEndpointData>();
        }

        /// <summary> Initializes a new instance of <see cref="OnlineEndpointTrackedResourceArmPaginatedResult"/>. </summary>
        /// <param name="nextLink"> The link to the next page of OnlineEndpoint objects. If null, there are no additional pages. </param>
        /// <param name="value"> An array of objects of type OnlineEndpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OnlineEndpointTrackedResourceArmPaginatedResult(string nextLink, IReadOnlyList<MachineLearningOnlineEndpointData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link to the next page of OnlineEndpoint objects. If null, there are no additional pages. </summary>
        public string NextLink { get; }
        /// <summary> An array of objects of type OnlineEndpoint. </summary>
        public IReadOnlyList<MachineLearningOnlineEndpointData> Value { get; }
    }
}

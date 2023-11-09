// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list routes. It contains a list of route objects and a URL link to get the next set of results. </summary>
    internal partial class RouteListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RouteListResult"/>. </summary>
        internal RouteListResult()
        {
            Value = new ChangeTrackingList<FrontDoorRouteData>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteListResult"/>. </summary>
        /// <param name="value"> List of AzureFrontDoor routes within a profile. </param>
        /// <param name="nextLink"> URL to get the next set of route objects if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouteListResult(IReadOnlyList<FrontDoorRouteData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of AzureFrontDoor routes within a profile. </summary>
        public IReadOnlyList<FrontDoorRouteData> Value { get; }
        /// <summary> URL to get the next set of route objects if there are any. </summary>
        public string NextLink { get; }
    }
}

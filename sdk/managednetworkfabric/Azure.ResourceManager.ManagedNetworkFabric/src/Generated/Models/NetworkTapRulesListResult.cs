// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of NetworkTapRules. </summary>
    internal partial class NetworkTapRulesListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkTapRulesListResult"/>. </summary>
        internal NetworkTapRulesListResult()
        {
            Value = new ChangeTrackingList<NetworkTapRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkTapRulesListResult"/>. </summary>
        /// <param name="value"> List of NetworkTapRule resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkTapRulesListResult(IReadOnlyList<NetworkTapRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of NetworkTapRule resources. </summary>
        public IReadOnlyList<NetworkTapRuleData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}

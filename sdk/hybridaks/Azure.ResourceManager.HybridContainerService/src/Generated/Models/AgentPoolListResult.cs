// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The AgentPoolListResult. </summary>
    internal partial class AgentPoolListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AgentPoolListResult"/>. </summary>
        internal AgentPoolListResult()
        {
            Value = new ChangeTrackingList<HybridContainerServiceAgentPoolData>();
        }

        /// <summary> Initializes a new instance of <see cref="AgentPoolListResult"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentPoolListResult(IReadOnlyList<HybridContainerServiceAgentPoolData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<HybridContainerServiceAgentPoolData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}

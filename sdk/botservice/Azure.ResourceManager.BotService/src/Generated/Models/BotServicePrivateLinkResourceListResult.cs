// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class BotServicePrivateLinkResourceListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BotServicePrivateLinkResourceListResult"/>. </summary>
        internal BotServicePrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<BotServicePrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="BotServicePrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BotServicePrivateLinkResourceListResult(IReadOnlyList<BotServicePrivateLinkResourceData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<BotServicePrivateLinkResourceData> Value { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The list of bot service channel operation response. </summary>
    internal partial class ChannelResponseList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChannelResponseList"/>. </summary>
        internal ChannelResponseList()
        {
            Value = new ChangeTrackingList<BotChannelData>();
        }

        /// <summary> Initializes a new instance of <see cref="ChannelResponseList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of bot service channel resources. </param>
        /// <param name="value"> Gets the list of bot service channel results and their properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChannelResponseList(string nextLink, IReadOnlyList<BotChannelData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link used to get the next page of bot service channel resources. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of bot service channel results and their properties. </summary>
        public IReadOnlyList<BotChannelData> Value { get; }
    }
}

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
    /// <summary> The list of bot service operation response. </summary>
    internal partial class BotResponseList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BotResponseList"/>. </summary>
        internal BotResponseList()
        {
            Value = new ChangeTrackingList<BotData>();
        }

        /// <summary> Initializes a new instance of <see cref="BotResponseList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of bot service resources. </param>
        /// <param name="value"> Gets the list of bot service results and their properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BotResponseList(string nextLink, IReadOnlyList<BotData> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The link used to get the next page of bot service resources. </summary>
        public string NextLink { get; }
        /// <summary> Gets the list of bot service results and their properties. </summary>
        public IReadOnlyList<BotData> Value { get; }
    }
}

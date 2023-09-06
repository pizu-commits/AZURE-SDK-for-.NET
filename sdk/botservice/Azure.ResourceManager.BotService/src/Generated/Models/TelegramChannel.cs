// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Telegram channel definition. </summary>
    public partial class TelegramChannel : BotChannelProperties
    {
        /// <summary> Initializes a new instance of <see cref="TelegramChannel"/>. </summary>
        public TelegramChannel()
        {
            ChannelName = "TelegramChannel";
        }

        /// <summary> Initializes a new instance of <see cref="TelegramChannel"/>. </summary>
        /// <param name="channelName"> The channel name. </param>
        /// <param name="etag"> Entity Tag of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="properties"> The set of properties specific to Telegram channel resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TelegramChannel(string channelName, ETag? etag, string provisioningState, AzureLocation? location, TelegramChannelProperties properties, Dictionary<string, BinaryData> rawData) : base(channelName, etag, provisioningState, location, rawData)
        {
            Properties = properties;
            ChannelName = channelName ?? "TelegramChannel";
        }

        /// <summary> The set of properties specific to Telegram channel resource. </summary>
        public TelegramChannelProperties Properties { get; set; }
    }
}

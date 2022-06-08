// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json.Serialization;

namespace Azure.Communication.Chat.Models
{
    /// <summary> The base class of chat events. </summary>
    public abstract class ChatEvent
    {
        /// <summary> Chat thread id. </summary>
        [JsonPropertyName("groupId")]
        public string ThreadId { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    ///   A representation of the additional context information available when Azure OpenAI chat extensions are involved
    ///   in the generation of a corresponding chat completions response. This context information is only populated when
    ///   using an Azure OpenAI request configured to use a matching extension.
    /// </summary>
    public partial class AzureChatExtensionsMessageContext
    {
        /// <summary> Initializes a new instance of AzureChatExtensionsMessageContext. </summary>
        internal AzureChatExtensionsMessageContext()
        {
            Messages = new ChangeTrackingList<ChatResponseMessage>();
        }

        /// <summary> Initializes a new instance of AzureChatExtensionsMessageContext. </summary>
        /// <param name="messages">
        ///   The contextual message payload associated with the Azure chat extensions used for a chat completions request.
        ///   These messages describe the data source retrievals, plugin invocations, and other intermediate steps taken in the
        ///   course of generating a chat completions response that was augmented by capabilities from Azure OpenAI chat
        ///   extensions.
        /// </param>
        internal AzureChatExtensionsMessageContext(IReadOnlyList<ChatResponseMessage> messages)
        {
            Messages = messages;
        }

        /// <summary>
        ///   The contextual message payload associated with the Azure chat extensions used for a chat completions request.
        ///   These messages describe the data source retrievals, plugin invocations, and other intermediate steps taken in the
        ///   course of generating a chat completions response that was augmented by capabilities from Azure OpenAI chat
        ///   extensions.
        /// </summary>
        public IReadOnlyList<ChatResponseMessage> Messages { get; }
    }
}

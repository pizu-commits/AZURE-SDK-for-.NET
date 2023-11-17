// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    public partial class AzureChatExtensionsMessageContext
    {
        public ContentFilterResultsForPrompt RequestContentFilterResults { get; internal set; }
        public ContentFilterResultsForChoice ResponseContentFilterResults { get; internal set; }

        internal AzureChatExtensionsMessageContext(
            IReadOnlyList<ChatResponseMessage> messages,
            ContentFilterResultsForPrompt requestContentFilterResults,
            ContentFilterResultsForChoice responseContentFilterResults)
            : this(messages)
        {
            RequestContentFilterResults = requestContentFilterResults;
            ResponseContentFilterResults = responseContentFilterResults;
        }
    }
}

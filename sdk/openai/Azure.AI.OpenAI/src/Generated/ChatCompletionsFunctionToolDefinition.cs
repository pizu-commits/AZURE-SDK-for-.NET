// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> The definition information for a chat completions function tool that can call a function in response to a tool call. </summary>
    public partial class ChatCompletionsFunctionToolDefinition : ChatCompletionsToolDefinition
    {
        /// <summary> Initializes a new instance of ChatCompletionsFunctionToolDefinition. </summary>
        /// <param name="function"> The function definition details for the function tool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="function"/> is null. </exception>
        public ChatCompletionsFunctionToolDefinition(FunctionDefinition function)
        {
            Argument.AssertNotNull(function, nameof(function));

            Type = "function";
            Function = function;
        }

        /// <summary> Initializes a new instance of ChatCompletionsFunctionToolDefinition. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="function"> The function definition details for the function tool. </param>
        internal ChatCompletionsFunctionToolDefinition(string type, FunctionDefinition function) : base(type)
        {
            Function = function;
        }

        /// <summary> The function definition details for the function tool. </summary>
        public FunctionDefinition Function { get; }
    }
}

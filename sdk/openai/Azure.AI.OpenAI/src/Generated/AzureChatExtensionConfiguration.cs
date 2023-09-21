// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    ///   A representation of configuration data for a single Azure OpenAI chat extension. This will be used by a chat
    ///   completions request that should use Azure OpenAI chat extensions to augment the response behavior.
    ///   The use of this configuration is compatible only with Azure OpenAI.
    /// </summary>
    internal partial class AzureChatExtensionConfiguration
    {
        /// <summary> Initializes a new instance of AzureChatExtensionConfiguration. </summary>
        /// <param name="type">
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </param>
        /// <param name="parameters">
        ///   The configuration payload used for the Azure chat extension. The structure payload details are specific to the
        ///   extension being configured.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public AzureChatExtensionConfiguration(AzureChatExtensionType type, BinaryData parameters)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            Type = type;
            Parameters = parameters;
        }

        /// <summary>
        ///   The label for the type of an Azure chat extension. This typically corresponds to a matching Azure resource.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// </summary>
        public AzureChatExtensionType Type { get; }
        /// <summary>
        ///   The configuration payload used for the Azure chat extension. The structure payload details are specific to the
        ///   extension being configured.
        ///   Azure chat extensions are only compatible with Azure OpenAI.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Parameters { get; }
    }
}

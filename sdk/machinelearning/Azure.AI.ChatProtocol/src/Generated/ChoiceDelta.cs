// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.ChatProtocol
{
    /// <summary> The representation of an incremental choice received in a streaming completion. </summary>
    public partial class ChoiceDelta
    {
        /// <summary> Initializes a new instance of ChoiceDelta. </summary>
        /// <param name="index"> The index of the of the chat choice, relative to the other choices in the same completion. </param>
        /// <param name="delta"> The partial message received for this choice. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="delta"/> is null. </exception>
        internal ChoiceDelta(long index, ChatMessageDelta delta)
        {
            Argument.AssertNotNull(delta, nameof(delta));

            Index = index;
            Delta = delta;
            Context = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ChoiceDelta. </summary>
        /// <param name="index"> The index of the of the chat choice, relative to the other choices in the same completion. </param>
        /// <param name="delta"> The partial message received for this choice. </param>
        /// <param name="sessionState"> Backend-specific information for the tracking of a session. </param>
        /// <param name="context"> Backend-specific context or arguments. </param>
        /// <param name="finishReason"> The reason this chat completion completed its generation. </param>
        internal ChoiceDelta(long index, ChatMessageDelta delta, BinaryData sessionState, IReadOnlyDictionary<string, BinaryData> context, FinishReason? finishReason)
        {
            Index = index;
            Delta = delta;
            SessionState = sessionState;
            Context = context;
            FinishReason = finishReason;
        }

        /// <summary> The index of the of the chat choice, relative to the other choices in the same completion. </summary>
        public long Index { get; }
        /// <summary> The partial message received for this choice. </summary>
        public ChatMessageDelta Delta { get; }
        /// <summary>
        /// Backend-specific information for the tracking of a session.
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
        public BinaryData SessionState { get; }
        /// <summary>
        /// Backend-specific context or arguments.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> Context { get; }
        /// <summary> The reason this chat completion completed its generation. </summary>
        public FinishReason? FinishReason { get; }
    }
}

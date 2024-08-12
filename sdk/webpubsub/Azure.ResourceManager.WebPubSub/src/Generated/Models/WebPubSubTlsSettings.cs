// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> TLS settings for the resource. </summary>
    internal partial class WebPubSubTlsSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebPubSubTlsSettings"/>. </summary>
        public WebPubSubTlsSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WebPubSubTlsSettings"/>. </summary>
        /// <param name="isClientCertEnabled"> Request client certificate during TLS handshake if enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebPubSubTlsSettings(bool? isClientCertEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsClientCertEnabled = isClientCertEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Request client certificate during TLS handshake if enabled. </summary>
        [WirePath("clientCertEnabled")]
        public bool? IsClientCertEnabled { get; set; }
    }
}

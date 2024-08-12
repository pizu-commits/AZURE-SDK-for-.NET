// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> For a non-Azure machine that is not connected directly to the internet, specify a proxy server that the non-Azure machine can use. </summary>
    public partial class ProxyServerProperties
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

        /// <summary> Initializes a new instance of <see cref="ProxyServerProperties"/>. </summary>
        public ProxyServerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProxyServerProperties"/>. </summary>
        /// <param name="ip"> Proxy server IP. </param>
        /// <param name="port"> Proxy server port. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProxyServerProperties(string ip, string port, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IP = ip;
            Port = port;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Proxy server IP. </summary>
        public string IP { get; set; }
        /// <summary> Proxy server port. </summary>
        public string Port { get; set; }
    }
}

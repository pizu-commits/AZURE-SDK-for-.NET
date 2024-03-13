// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Represents a Configuration. </summary>
    public partial class MySqlFlexibleServerConfigurationForBatchUpdate
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

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurationForBatchUpdate"/>. </summary>
        public MySqlFlexibleServerConfigurationForBatchUpdate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerConfigurationForBatchUpdate"/>. </summary>
        /// <param name="name"> Name of the configuration. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerConfigurationForBatchUpdate(string name, string value, string source, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            Source = source;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the configuration. </summary>
        [WirePath("name")]
        public string Name { get; set; }
        /// <summary> Value of the configuration. </summary>
        [WirePath("properties.value")]
        public string Value { get; set; }
        /// <summary> Source of the configuration. </summary>
        [WirePath("properties.source")]
        public string Source { get; set; }
    }
}

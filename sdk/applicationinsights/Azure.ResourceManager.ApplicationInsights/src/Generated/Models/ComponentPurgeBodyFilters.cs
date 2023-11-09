// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> User-defined filters to return data which will be purged from the table. </summary>
    public partial class ComponentPurgeBodyFilters
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBodyFilters"/>. </summary>
        public ComponentPurgeBodyFilters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBodyFilters"/>. </summary>
        /// <param name="column"> The column of the table over which the given query should run. </param>
        /// <param name="operator"> A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, &gt;, &gt;=, &lt;, &lt;=, between, and have the same behavior as they would in a KQL query. </param>
        /// <param name="value"> the value for the operator to function over. This can be a number (e.g., &gt; 100), a string (timestamp &gt;= '2017-09-01') or array of values. </param>
        /// <param name="key"> When filtering over custom dimensions, this key will be used as the name of the custom dimension. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentPurgeBodyFilters(string column, string @operator, BinaryData value, string key, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Column = column;
            Operator = @operator;
            Value = value;
            Key = key;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The column of the table over which the given query should run. </summary>
        public string Column { get; set; }
        /// <summary> A query operator to evaluate over the provided column and value(s). Supported operators are ==, =~, in, in~, &gt;, &gt;=, &lt;, &lt;=, between, and have the same behavior as they would in a KQL query. </summary>
        public string Operator { get; set; }
        /// <summary>
        /// the value for the operator to function over. This can be a number (e.g., &gt; 100), a string (timestamp &gt;= '2017-09-01') or array of values.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Value { get; set; }
        /// <summary> When filtering over custom dimensions, this key will be used as the name of the custom dimension. </summary>
        public string Key { get; set; }
    }
}

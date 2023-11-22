// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Contains the columns and rows for one table in a query response. </summary>
    public partial class LogsTable
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, JsonSerializerOptions?)"/>.
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

        /// <summary> Initializes a new instance of <see cref="LogsTable"/>. </summary>
        /// <param name="name"> The name of the table. </param>
        /// <param name="columns"> The list of columns in this table. </param>
        /// <param name="internalRows"> The resulting rows from this query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="columns"/> is null. </exception>
        internal LogsTable(string name, IEnumerable<LogsTableColumn> columns, JsonElement internalRows)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(columns, nameof(columns));

            Name = name;
            Columns = columns.ToList();
            InternalRows = internalRows;
        }

        /// <summary> Initializes a new instance of <see cref="LogsTable"/>. </summary>
        /// <param name="name"> The name of the table. </param>
        /// <param name="columns"> The list of columns in this table. </param>
        /// <param name="internalRows"> The resulting rows from this query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogsTable(string name, IReadOnlyList<LogsTableColumn> columns, JsonElement internalRows, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Columns = columns;
            InternalRows = internalRows;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="LogsTable"/> for deserialization. </summary>
        internal LogsTable()
        {
        }

        /// <summary> The name of the table. </summary>
        public string Name { get; }
        /// <summary> The list of columns in this table. </summary>
        public IReadOnlyList<LogsTableColumn> Columns { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A object which contains list of tables and connection details for a source connection. </summary>
    public partial class MapperSourceConnectionsInfo
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

        /// <summary> Initializes a new instance of <see cref="MapperSourceConnectionsInfo"/>. </summary>
        public MapperSourceConnectionsInfo()
        {
            SourceEntities = new ChangeTrackingList<MapperTable>();
        }

        /// <summary> Initializes a new instance of <see cref="MapperSourceConnectionsInfo"/>. </summary>
        /// <param name="sourceEntities"> List of source tables for a source connection. </param>
        /// <param name="connection"> Source connection details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MapperSourceConnectionsInfo(IList<MapperTable> sourceEntities, MapperConnection connection, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceEntities = sourceEntities;
            Connection = connection;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of source tables for a source connection. </summary>
        public IList<MapperTable> SourceEntities { get; }
        /// <summary> Source connection details. </summary>
        public MapperConnection Connection { get; set; }
    }
}

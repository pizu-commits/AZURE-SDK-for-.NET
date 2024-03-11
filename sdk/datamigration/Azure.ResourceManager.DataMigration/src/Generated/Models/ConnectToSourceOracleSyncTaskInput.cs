// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataMigration;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates Oracle database connection. </summary>
    internal partial class ConnectToSourceOracleSyncTaskInput
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

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceOracleSyncTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to Oracle source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceConnectionInfo"/> is null. </exception>
        public ConnectToSourceOracleSyncTaskInput(OracleConnectionInfo sourceConnectionInfo)
        {
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));

            SourceConnectionInfo = sourceConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceOracleSyncTaskInput"/>. </summary>
        /// <param name="sourceConnectionInfo"> Information for connecting to Oracle source. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectToSourceOracleSyncTaskInput(OracleConnectionInfo sourceConnectionInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceConnectionInfo = sourceConnectionInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceOracleSyncTaskInput"/> for deserialization. </summary>
        internal ConnectToSourceOracleSyncTaskInput()
        {
        }

        /// <summary> Information for connecting to Oracle source. </summary>
        public OracleConnectionInfo SourceConnectionInfo { get; set; }
    }
}

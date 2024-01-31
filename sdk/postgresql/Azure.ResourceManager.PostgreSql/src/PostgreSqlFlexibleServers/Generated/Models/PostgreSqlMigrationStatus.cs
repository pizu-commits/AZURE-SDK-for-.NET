// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Migration status. </summary>
    public partial class PostgreSqlMigrationStatus
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

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationStatus"/>. </summary>
        internal PostgreSqlMigrationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlMigrationStatus"/>. </summary>
        /// <param name="state"> State of migration. </param>
        /// <param name="error"> Error message, if any, for the migration state. </param>
        /// <param name="currentSubStateDetails"> Current Migration sub state details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlMigrationStatus(PostgreSqlMigrationState? state, string error, PostgreSqlMigrationSubStateDetails currentSubStateDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            State = state;
            Error = error;
            CurrentSubStateDetails = currentSubStateDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> State of migration. </summary>
        public PostgreSqlMigrationState? State { get; }
        /// <summary> Error message, if any, for the migration state. </summary>
        public string Error { get; }
        /// <summary> Current Migration sub state details. </summary>
        internal PostgreSqlMigrationSubStateDetails CurrentSubStateDetails { get; }
        /// <summary> Migration sub state. </summary>
        public PostgreSqlMigrationSubState? CurrentSubState
        {
            get => CurrentSubStateDetails?.CurrentSubState;
        }
    }
}

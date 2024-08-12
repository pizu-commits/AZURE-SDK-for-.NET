// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output of the task that collects user tables for the given list of databases. </summary>
    public partial class GetUserTablesSqlTaskOutput
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

        /// <summary> Initializes a new instance of <see cref="GetUserTablesSqlTaskOutput"/>. </summary>
        internal GetUserTablesSqlTaskOutput()
        {
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of <see cref="GetUserTablesSqlTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="databasesToTables"> Mapping from database name to list of tables. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetUserTablesSqlTaskOutput(string id, string databasesToTables, IReadOnlyList<ReportableException> validationErrors, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            DatabasesToTables = databasesToTables;
            ValidationErrors = validationErrors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Mapping from database name to list of tables. </summary>
        public string DatabasesToTables { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}

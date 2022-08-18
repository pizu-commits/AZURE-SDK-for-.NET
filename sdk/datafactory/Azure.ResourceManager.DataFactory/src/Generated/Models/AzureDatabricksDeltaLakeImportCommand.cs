// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Databricks Delta Lake import command settings. </summary>
    public partial class AzureDatabricksDeltaLakeImportCommand : ImportSettings
    {
        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeImportCommand. </summary>
        public AzureDatabricksDeltaLakeImportCommand()
        {
            ImportSettingsType = "AzureDatabricksDeltaLakeImportCommand";
        }

        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeImportCommand. </summary>
        /// <param name="importSettingsType"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="dateFormat"> Specify the date format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </param>
        /// <param name="timestampFormat"> Specify the timestamp format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </param>
        internal AzureDatabricksDeltaLakeImportCommand(string importSettingsType, IDictionary<string, BinaryData> additionalProperties, BinaryData dateFormat, BinaryData timestampFormat) : base(importSettingsType, additionalProperties)
        {
            DateFormat = dateFormat;
            TimestampFormat = timestampFormat;
            ImportSettingsType = importSettingsType ?? "AzureDatabricksDeltaLakeImportCommand";
        }

        /// <summary>
        /// Specify the date format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string)..
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
        public BinaryData DateFormat { get; set; }
        /// <summary>
        /// Specify the timestamp format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string)..
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
        public BinaryData TimestampFormat { get; set; }
    }
}

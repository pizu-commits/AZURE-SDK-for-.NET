// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Snowflake import command settings. </summary>
    public partial class SnowflakeImportCopyCommand : ImportSettings
    {
        /// <summary> Initializes a new instance of <see cref="SnowflakeImportCopyCommand"/>. </summary>
        public SnowflakeImportCopyCommand()
        {
            AdditionalCopyOptions = new ChangeTrackingDictionary<string, BinaryData>();
            AdditionalFormatOptions = new ChangeTrackingDictionary<string, BinaryData>();
            ImportSettingsType = "SnowflakeImportCopyCommand";
        }

        /// <summary> Initializes a new instance of <see cref="SnowflakeImportCopyCommand"/>. </summary>
        /// <param name="importSettingsType"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="additionalCopyOptions"> Additional copy options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalCopyOptions": { "DATE_FORMAT": "MM/DD/YYYY", "TIME_FORMAT": "'HH24:MI:SS.FF'" }. </param>
        /// <param name="additionalFormatOptions"> Additional format options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalFormatOptions": { "FORCE": "TRUE", "LOAD_UNCERTAIN_FILES": "'FALSE'" }. </param>
        /// <param name="storageIntegration"> The name of the snowflake storage integration to use for the copy operation. Type: string (or Expression with resultType string). </param>
        internal SnowflakeImportCopyCommand(string importSettingsType, IDictionary<string, BinaryData> additionalProperties, IDictionary<string, BinaryData> additionalCopyOptions, IDictionary<string, BinaryData> additionalFormatOptions, DataFactoryElement<string> storageIntegration) : base(importSettingsType, additionalProperties)
        {
            AdditionalCopyOptions = additionalCopyOptions;
            AdditionalFormatOptions = additionalFormatOptions;
            StorageIntegration = storageIntegration;
            ImportSettingsType = importSettingsType ?? "SnowflakeImportCopyCommand";
        }

        /// <summary>
        /// Additional copy options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalCopyOptions": { "DATE_FORMAT": "MM/DD/YYYY", "TIME_FORMAT": "'HH24:MI:SS.FF'" }
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
        public IDictionary<string, BinaryData> AdditionalCopyOptions { get; }
        /// <summary>
        /// Additional format options directly passed to snowflake Copy Command. Type: key value pairs (value should be string type) (or Expression with resultType object). Example: "additionalFormatOptions": { "FORCE": "TRUE", "LOAD_UNCERTAIN_FILES": "'FALSE'" }
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
        public IDictionary<string, BinaryData> AdditionalFormatOptions { get; }
        /// <summary> The name of the snowflake storage integration to use for the copy operation. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> StorageIntegration { get; set; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Function App stack major version. </summary>
    public partial class FunctionAppMajorVersion
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

        /// <summary> Initializes a new instance of <see cref="FunctionAppMajorVersion"/>. </summary>
        internal FunctionAppMajorVersion()
        {
            MinorVersions = new ChangeTrackingList<FunctionAppMinorVersion>();
        }

        /// <summary> Initializes a new instance of <see cref="FunctionAppMajorVersion"/>. </summary>
        /// <param name="displayText"> Function App stack major version (display only). </param>
        /// <param name="value"> Function App stack major version name. </param>
        /// <param name="minorVersions"> Minor versions associated with the major version. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FunctionAppMajorVersion(string displayText, string value, IReadOnlyList<FunctionAppMinorVersion> minorVersions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayText = displayText;
            Value = value;
            MinorVersions = minorVersions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Function App stack major version (display only). </summary>
        public string DisplayText { get; }
        /// <summary> Function App stack major version name. </summary>
        public string Value { get; }
        /// <summary> Minor versions associated with the major version. </summary>
        public IReadOnlyList<FunctionAppMinorVersion> MinorVersions { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Spark user plugin. </summary>
    public partial class SparkUserPlugin
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

        /// <summary> Initializes a new instance of <see cref="SparkUserPlugin"/>. </summary>
        /// <param name="path"> Fully qualified path to the folder containing the plugins. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public SparkUserPlugin(string path)
        {
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
        }

        /// <summary> Initializes a new instance of <see cref="SparkUserPlugin"/>. </summary>
        /// <param name="path"> Fully qualified path to the folder containing the plugins. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkUserPlugin(string path, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Path = path;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SparkUserPlugin"/> for deserialization. </summary>
        internal SparkUserPlugin()
        {
        }

        /// <summary> Fully qualified path to the folder containing the plugins. </summary>
        public string Path { get; set; }
    }
}

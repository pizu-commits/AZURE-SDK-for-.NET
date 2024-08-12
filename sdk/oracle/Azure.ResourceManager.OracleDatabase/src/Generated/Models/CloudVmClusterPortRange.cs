// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary> Port Range to specify particular destination ports for TCP rules. </summary>
    public partial class CloudVmClusterPortRange
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

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterPortRange"/>. </summary>
        /// <param name="min"> The minimum port number, which must not be greater than the maximum port number. </param>
        /// <param name="max"> The maximum port number, which must not be less than the minimum port number. To specify a single port number, set both the min and max to the same value. </param>
        public CloudVmClusterPortRange(int min, int max)
        {
            Min = min;
            Max = max;
        }

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterPortRange"/>. </summary>
        /// <param name="min"> The minimum port number, which must not be greater than the maximum port number. </param>
        /// <param name="max"> The maximum port number, which must not be less than the minimum port number. To specify a single port number, set both the min and max to the same value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudVmClusterPortRange(int min, int max, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Min = min;
            Max = max;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CloudVmClusterPortRange"/> for deserialization. </summary>
        internal CloudVmClusterPortRange()
        {
        }

        /// <summary> The minimum port number, which must not be greater than the maximum port number. </summary>
        public int Min { get; set; }
        /// <summary> The maximum port number, which must not be less than the minimum port number. To specify a single port number, set both the min and max to the same value. </summary>
        public int Max { get; set; }
    }
}

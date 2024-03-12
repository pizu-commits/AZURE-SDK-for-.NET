// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Properties of upgrade notification. </summary>
    public partial class RedisUpgradeNotification
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

        /// <summary> Initializes a new instance of <see cref="RedisUpgradeNotification"/>. </summary>
        internal RedisUpgradeNotification()
        {
            UpsellNotification = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisUpgradeNotification"/>. </summary>
        /// <param name="name"> Name of upgrade notification. </param>
        /// <param name="timestamp"> Timestamp when upgrade notification occurred. </param>
        /// <param name="upsellNotification"> Details about this upgrade notification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisUpgradeNotification(string name, DateTimeOffset? timestamp, IReadOnlyDictionary<string, string> upsellNotification, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Timestamp = timestamp;
            UpsellNotification = upsellNotification;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of upgrade notification. </summary>
        public string Name { get; }
        /// <summary> Timestamp when upgrade notification occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Details about this upgrade notification. </summary>
        public IReadOnlyDictionary<string, string> UpsellNotification { get; }
    }
}

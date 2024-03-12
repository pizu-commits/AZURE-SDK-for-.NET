// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Properties to configure retention settings for the  eventhub. </summary>
    public partial class RetentionDescription
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

        /// <summary> Initializes a new instance of <see cref="RetentionDescription"/>. </summary>
        public RetentionDescription()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RetentionDescription"/>. </summary>
        /// <param name="cleanupPolicy"> Enumerates the possible values for cleanup policy. </param>
        /// <param name="retentionTimeInHours"> Number of hours to retain the events for this Event Hub. This value is only used when cleanupPolicy is Delete. If cleanupPolicy is Compaction the returned value of this property is Long.MaxValue. </param>
        /// <param name="tombstoneRetentionTimeInHours"> Number of hours to retain the tombstone markers of a compacted Event Hub. This value is only used when cleanupPolicy is Compaction. Consumer must complete reading the tombstone marker within this specified amount of time if consumer begins from starting offset to ensure they get a valid snapshot for the specific key described by the tombstone marker within the compacted Event Hub. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RetentionDescription(CleanupPolicyRetentionDescription? cleanupPolicy, long? retentionTimeInHours, int? tombstoneRetentionTimeInHours, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CleanupPolicy = cleanupPolicy;
            RetentionTimeInHours = retentionTimeInHours;
            TombstoneRetentionTimeInHours = tombstoneRetentionTimeInHours;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Enumerates the possible values for cleanup policy. </summary>
        [WirePath("cleanupPolicy")]
        public CleanupPolicyRetentionDescription? CleanupPolicy { get; set; }
        /// <summary> Number of hours to retain the events for this Event Hub. This value is only used when cleanupPolicy is Delete. If cleanupPolicy is Compaction the returned value of this property is Long.MaxValue. </summary>
        [WirePath("retentionTimeInHours")]
        public long? RetentionTimeInHours { get; set; }
        /// <summary> Number of hours to retain the tombstone markers of a compacted Event Hub. This value is only used when cleanupPolicy is Compaction. Consumer must complete reading the tombstone marker within this specified amount of time if consumer begins from starting offset to ensure they get a valid snapshot for the specific key described by the tombstone marker within the compacted Event Hub. </summary>
        [WirePath("tombstoneRetentionTimeInHours")]
        public int? TombstoneRetentionTimeInHours { get; set; }
    }
}

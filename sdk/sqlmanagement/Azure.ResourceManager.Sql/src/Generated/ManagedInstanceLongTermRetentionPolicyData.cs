// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstanceLongTermRetentionPolicy data model.
    /// A long term retention policy.
    /// </summary>
    public partial class ManagedInstanceLongTermRetentionPolicyData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceLongTermRetentionPolicyData"/>. </summary>
        public ManagedInstanceLongTermRetentionPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceLongTermRetentionPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="weeklyRetention"> The weekly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="monthlyRetention"> The monthly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="yearlyRetention"> The yearly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="weekOfYear"> The week of year to take the yearly backup in an ISO 8601 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceLongTermRetentionPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string weeklyRetention, string monthlyRetention, string yearlyRetention, int? weekOfYear, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            WeeklyRetention = weeklyRetention;
            MonthlyRetention = monthlyRetention;
            YearlyRetention = yearlyRetention;
            WeekOfYear = weekOfYear;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The weekly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string WeeklyRetention { get; set; }
        /// <summary> The monthly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string MonthlyRetention { get; set; }
        /// <summary> The yearly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string YearlyRetention { get; set; }
        /// <summary> The week of year to take the yearly backup in an ISO 8601 format. </summary>
        public int? WeekOfYear { get; set; }
    }
}

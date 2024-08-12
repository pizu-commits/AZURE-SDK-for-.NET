// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The Sql pool usages. </summary>
    public partial class SqlPoolUsage
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

        /// <summary> Initializes a new instance of <see cref="SqlPoolUsage"/>. </summary>
        internal SqlPoolUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlPoolUsage"/>. </summary>
        /// <param name="name"> The name of the usage metric. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="displayName"> The usage metric display name. </param>
        /// <param name="currentValue"> The current value of the usage metric. </param>
        /// <param name="limit"> The current limit of the usage metric. </param>
        /// <param name="unit"> The units of the usage metric. </param>
        /// <param name="nextResetOn"> The next reset time for the usage metric (ISO8601 format). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlPoolUsage(string name, string resourceName, string displayName, double? currentValue, double? limit, string unit, DateTimeOffset? nextResetOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceName = resourceName;
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            NextResetOn = nextResetOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the usage metric. </summary>
        public string Name { get; }
        /// <summary> The name of the resource. </summary>
        public string ResourceName { get; }
        /// <summary> The usage metric display name. </summary>
        public string DisplayName { get; }
        /// <summary> The current value of the usage metric. </summary>
        public double? CurrentValue { get; }
        /// <summary> The current limit of the usage metric. </summary>
        public double? Limit { get; }
        /// <summary> The units of the usage metric. </summary>
        public string Unit { get; }
        /// <summary> The next reset time for the usage metric (ISO8601 format). </summary>
        public DateTimeOffset? NextResetOn { get; }
    }
}

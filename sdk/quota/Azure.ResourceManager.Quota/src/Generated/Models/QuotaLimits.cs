// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Quota;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> Quota limits. </summary>
    internal partial class QuotaLimits
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

        /// <summary> Initializes a new instance of <see cref="QuotaLimits"/>. </summary>
        internal QuotaLimits()
        {
            Value = new ChangeTrackingList<CurrentQuotaLimitBaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="QuotaLimits"/>. </summary>
        /// <param name="value"> List of quota limits. </param>
        /// <param name="nextLink"> The URI used to fetch the next page of quota limits. When there are no more pages, this string is null. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaLimits(IReadOnlyList<CurrentQuotaLimitBaseData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of quota limits. </summary>
        public IReadOnlyList<CurrentQuotaLimitBaseData> Value { get; }
        /// <summary> The URI used to fetch the next page of quota limits. When there are no more pages, this string is null. </summary>
        public string NextLink { get; }
    }
}

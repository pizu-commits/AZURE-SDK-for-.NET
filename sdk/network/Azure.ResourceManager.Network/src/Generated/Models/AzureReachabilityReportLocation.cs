// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define a geographic location. </summary>
    public partial class AzureReachabilityReportLocation
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

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReportLocation"/>. </summary>
        /// <param name="country"> The name of the country. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="country"/> is null. </exception>
        public AzureReachabilityReportLocation(string country)
        {
            Argument.AssertNotNull(country, nameof(country));

            Country = country;
        }

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReportLocation"/>. </summary>
        /// <param name="country"> The name of the country. </param>
        /// <param name="state"> The name of the state. </param>
        /// <param name="city"> The name of the city or town. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureReachabilityReportLocation(string country, string state, string city, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Country = country;
            State = state;
            City = city;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureReachabilityReportLocation"/> for deserialization. </summary>
        internal AzureReachabilityReportLocation()
        {
        }

        /// <summary> The name of the country. </summary>
        public string Country { get; set; }
        /// <summary> The name of the state. </summary>
        public string State { get; set; }
        /// <summary> The name of the city or town. </summary>
        public string City { get; set; }
    }
}

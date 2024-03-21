// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The class to specify one track property condition. </summary>
    public partial class FilterTrackPropertyCondition
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

        /// <summary> Initializes a new instance of <see cref="FilterTrackPropertyCondition"/>. </summary>
        /// <param name="property"> The track property type. </param>
        /// <param name="value"> The track property value. </param>
        /// <param name="operation"> The track property condition operation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FilterTrackPropertyCondition(FilterTrackPropertyType property, string value, FilterTrackPropertyCompareOperation operation)
        {
            Argument.AssertNotNull(value, nameof(value));

            Property = property;
            Value = value;
            Operation = operation;
        }

        /// <summary> Initializes a new instance of <see cref="FilterTrackPropertyCondition"/>. </summary>
        /// <param name="property"> The track property type. </param>
        /// <param name="value"> The track property value. </param>
        /// <param name="operation"> The track property condition operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FilterTrackPropertyCondition(FilterTrackPropertyType property, string value, FilterTrackPropertyCompareOperation operation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Property = property;
            Value = value;
            Operation = operation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FilterTrackPropertyCondition"/> for deserialization. </summary>
        internal FilterTrackPropertyCondition()
        {
        }

        /// <summary> The track property type. </summary>
        public FilterTrackPropertyType Property { get; set; }
        /// <summary> The track property value. </summary>
        public string Value { get; set; }
        /// <summary> The track property condition operation. </summary>
        public FilterTrackPropertyCompareOperation Operation { get; set; }
    }
}

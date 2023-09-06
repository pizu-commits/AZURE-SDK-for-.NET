// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameter example. </summary>
    public partial class ParameterExampleContract
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ParameterExampleContract"/>. </summary>
        public ParameterExampleContract()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ParameterExampleContract"/>. </summary>
        /// <param name="summary"> Short description for the example. </param>
        /// <param name="description"> Long description for the example. </param>
        /// <param name="value"> Example value. May be a primitive value, or an object. </param>
        /// <param name="externalValue"> A URL that points to the literal example. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ParameterExampleContract(string summary, string description, BinaryData value, string externalValue, Dictionary<string, BinaryData> rawData)
        {
            Summary = summary;
            Description = description;
            Value = value;
            ExternalValue = externalValue;
            _rawData = rawData;
        }

        /// <summary> Short description for the example. </summary>
        public string Summary { get; set; }
        /// <summary> Long description for the example. </summary>
        public string Description { get; set; }
        /// <summary>
        /// Example value. May be a primitive value, or an object.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Value { get; set; }
        /// <summary> A URL that points to the literal example. </summary>
        public string ExternalValue { get; set; }
    }
}

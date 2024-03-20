// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the collection of SAP Central Services Instance resources. </summary>
    internal partial class SapCentralInstanceList
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

        /// <summary> Initializes a new instance of <see cref="SapCentralInstanceList"/>. </summary>
        internal SapCentralInstanceList()
        {
            Value = new ChangeTrackingList<SapCentralServerInstanceData>();
        }

        /// <summary> Initializes a new instance of <see cref="SapCentralInstanceList"/>. </summary>
        /// <param name="value"> Gets the list of SAP central services instance resources. </param>
        /// <param name="nextLink"> Gets the value of next link. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapCentralInstanceList(IReadOnlyList<SapCentralServerInstanceData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the list of SAP central services instance resources. </summary>
        public IReadOnlyList<SapCentralServerInstanceData> Value { get; }
        /// <summary> Gets the value of next link. </summary>
        public string NextLink { get; }
    }
}

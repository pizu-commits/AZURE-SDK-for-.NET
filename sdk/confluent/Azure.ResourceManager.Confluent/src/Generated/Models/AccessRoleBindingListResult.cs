// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> Details of the role bindings returned on successful response. </summary>
    public partial class AccessRoleBindingListResult
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

        /// <summary> Initializes a new instance of <see cref="AccessRoleBindingListResult"/>. </summary>
        internal AccessRoleBindingListResult()
        {
            Data = new ChangeTrackingList<AccessRoleBindingRecord>();
        }

        /// <summary> Initializes a new instance of <see cref="AccessRoleBindingListResult"/>. </summary>
        /// <param name="kind"> Type of response. </param>
        /// <param name="metadata"> Metadata of the list. </param>
        /// <param name="data"> List of role binding. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AccessRoleBindingListResult(string kind, ConfluentListMetadata metadata, IReadOnlyList<AccessRoleBindingRecord> data, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Metadata = metadata;
            Data = data;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of response. </summary>
        public string Kind { get; }
        /// <summary> Metadata of the list. </summary>
        public ConfluentListMetadata Metadata { get; }
        /// <summary> List of role binding. </summary>
        public IReadOnlyList<AccessRoleBindingRecord> Data { get; }
    }
}

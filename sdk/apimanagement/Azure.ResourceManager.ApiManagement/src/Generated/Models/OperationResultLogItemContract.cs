// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Log of the entity being created, updated or deleted. </summary>
    public partial class OperationResultLogItemContract
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

        /// <summary> Initializes a new instance of <see cref="OperationResultLogItemContract"/>. </summary>
        internal OperationResultLogItemContract()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationResultLogItemContract"/>. </summary>
        /// <param name="objectType"> The type of entity contract. </param>
        /// <param name="action"> Action like create/update/delete. </param>
        /// <param name="objectKey"> Identifier of the entity being created/updated/deleted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationResultLogItemContract(string objectType, string action, string objectKey, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ObjectType = objectType;
            Action = action;
            ObjectKey = objectKey;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of entity contract. </summary>
        [WirePath("objectType")]
        public string ObjectType { get; }
        /// <summary> Action like create/update/delete. </summary>
        [WirePath("action")]
        public string Action { get; }
        /// <summary> Identifier of the entity being created/updated/deleted. </summary>
        [WirePath("objectKey")]
        public string ObjectKey { get; }
    }
}

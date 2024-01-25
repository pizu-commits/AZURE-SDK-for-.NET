// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Api Operation Annotation. </summary>
    public partial class LogicApiOperationAnnotation
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

        /// <summary> Initializes a new instance of <see cref="LogicApiOperationAnnotation"/>. </summary>
        public LogicApiOperationAnnotation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LogicApiOperationAnnotation"/>. </summary>
        /// <param name="status"> The status annotation. </param>
        /// <param name="family"> The family. </param>
        /// <param name="revision"> The revision. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LogicApiOperationAnnotation(LogicApiOperationAnnotationStatus? status, string family, int? revision, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Family = family;
            Revision = revision;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status annotation. </summary>
        public LogicApiOperationAnnotationStatus? Status { get; set; }
        /// <summary> The family. </summary>
        public string Family { get; set; }
        /// <summary> The revision. </summary>
        public int? Revision { get; set; }
    }
}

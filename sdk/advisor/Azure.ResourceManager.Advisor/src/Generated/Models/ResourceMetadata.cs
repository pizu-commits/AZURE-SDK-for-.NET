// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> Recommendation resource metadata. </summary>
    public partial class ResourceMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceMetadata"/>. </summary>
        public ResourceMetadata()
        {
            Action = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceMetadata"/>. </summary>
        /// <param name="resourceId"> Azure resource Id of the assessed resource. </param>
        /// <param name="source"> Source from which recommendation is generated. </param>
        /// <param name="action"> The action to view resource. </param>
        /// <param name="singular"> The singular user friendly name of resource type. eg: virtual machine. </param>
        /// <param name="plural"> The plural user friendly name of resource type. eg: virtual machines. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceMetadata(string resourceId, string source, IDictionary<string, BinaryData> action, string singular, string plural, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            Source = source;
            Action = action;
            Singular = singular;
            Plural = plural;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Azure resource Id of the assessed resource. </summary>
        public string ResourceId { get; set; }
        /// <summary> Source from which recommendation is generated. </summary>
        public string Source { get; set; }
        /// <summary>
        /// The action to view resource.
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
        public IDictionary<string, BinaryData> Action { get; }
        /// <summary> The singular user friendly name of resource type. eg: virtual machine. </summary>
        public string Singular { get; set; }
        /// <summary> The plural user friendly name of resource type. eg: virtual machines. </summary>
        public string Plural { get; set; }
    }
}

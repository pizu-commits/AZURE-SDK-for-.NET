// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> The resource status information. </summary>
    public partial class VMwareResourceStatus
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

        /// <summary> Initializes a new instance of <see cref="VMwareResourceStatus"/>. </summary>
        internal VMwareResourceStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VMwareResourceStatus"/>. </summary>
        /// <param name="resourceStatusType"> The type of the condition. </param>
        /// <param name="status"> Status of the condition. </param>
        /// <param name="reason"> The reason for the condition's status. </param>
        /// <param name="message"> A human readable message indicating details about the status. </param>
        /// <param name="severity"> Severity with which to treat failures of this type of condition. </param>
        /// <param name="lastUpdatedOn"> The last update time for this condition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareResourceStatus(string resourceStatusType, string status, string reason, string message, string severity, DateTimeOffset? lastUpdatedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceStatusType = resourceStatusType;
            Status = status;
            Reason = reason;
            Message = message;
            Severity = severity;
            LastUpdatedOn = lastUpdatedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the condition. </summary>
        public string ResourceStatusType { get; }
        /// <summary> Status of the condition. </summary>
        public string Status { get; }
        /// <summary> The reason for the condition's status. </summary>
        public string Reason { get; }
        /// <summary> A human readable message indicating details about the status. </summary>
        public string Message { get; }
        /// <summary> Severity with which to treat failures of this type of condition. </summary>
        public string Severity { get; }
        /// <summary> The last update time for this condition. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
    }
}

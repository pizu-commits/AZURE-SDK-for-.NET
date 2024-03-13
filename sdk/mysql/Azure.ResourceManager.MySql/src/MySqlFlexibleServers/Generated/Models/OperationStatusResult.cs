// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> The current status of an async operation. </summary>
    public partial class OperationStatusResult
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OperationStatusResult"/>. </summary>
        /// <param name="status"> Operation status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="status"/> is null. </exception>
        internal OperationStatusResult(string status)
        {
            Argument.AssertNotNull(status, nameof(status));

            Status = status;
            Operations = new ChangeTrackingList<OperationStatusResult>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusResult"/>. </summary>
        /// <param name="id"> Fully qualified ID for the async operation. </param>
        /// <param name="resourceId"> Fully qualified ID of the resource against which the original async operation was started. </param>
        /// <param name="name"> Name of the async operation. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="percentComplete"> Percent of the operation that is complete. </param>
        /// <param name="startOn"> The start time of the operation. </param>
        /// <param name="endOn"> The end time of the operation. </param>
        /// <param name="operations"> The operations list. </param>
        /// <param name="error"> If present, details of the operation error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationStatusResult(ResourceIdentifier id, ResourceIdentifier resourceId, string name, string status, float? percentComplete, DateTimeOffset? startOn, DateTimeOffset? endOn, IReadOnlyList<OperationStatusResult> operations, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ResourceId = resourceId;
            Name = name;
            Status = status;
            PercentComplete = percentComplete;
            StartOn = startOn;
            EndOn = endOn;
            Operations = operations;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusResult"/> for deserialization. </summary>
        internal OperationStatusResult()
        {
        }

        /// <summary> Fully qualified ID for the async operation. </summary>
        [WirePath("id")]
        public ResourceIdentifier Id { get; }
        /// <summary> Fully qualified ID of the resource against which the original async operation was started. </summary>
        [WirePath("resourceId")]
        public ResourceIdentifier ResourceId { get; }
        /// <summary> Name of the async operation. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> Operation status. </summary>
        [WirePath("status")]
        public string Status { get; }
        /// <summary> Percent of the operation that is complete. </summary>
        [WirePath("percentComplete")]
        public float? PercentComplete { get; }
        /// <summary> The start time of the operation. </summary>
        [WirePath("startTime")]
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the operation. </summary>
        [WirePath("endTime")]
        public DateTimeOffset? EndOn { get; }
        /// <summary> The operations list. </summary>
        [WirePath("operations")]
        public IReadOnlyList<OperationStatusResult> Operations { get; }
        /// <summary> If present, details of the operation error. </summary>
        [WirePath("error")]
        public ResponseError Error { get; }
    }
}

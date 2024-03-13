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
    /// <summary> Represents Operation Results API Response. </summary>
    public partial class OperationStatusExtendedResult : OperationStatusResult
    {
        /// <summary> Initializes a new instance of <see cref="OperationStatusExtendedResult"/>. </summary>
        /// <param name="status"> Operation status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="status"/> is null. </exception>
        internal OperationStatusExtendedResult(string status) : base(status)
        {
            Argument.AssertNotNull(status, nameof(status));

            Properties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusExtendedResult"/>. </summary>
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
        /// <param name="properties"> The extended properties of Operation Results. </param>
        internal OperationStatusExtendedResult(ResourceIdentifier id, ResourceIdentifier resourceId, string name, string status, float? percentComplete, DateTimeOffset? startOn, DateTimeOffset? endOn, IReadOnlyList<OperationStatusResult> operations, ResponseError error, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyDictionary<string, BinaryData> properties) : base(id, resourceId, name, status, percentComplete, startOn, endOn, operations, error, serializedAdditionalRawData)
        {
            Properties = properties;
        }

        /// <summary> Initializes a new instance of <see cref="OperationStatusExtendedResult"/> for deserialization. </summary>
        internal OperationStatusExtendedResult()
        {
        }

        /// <summary>
        /// The extended properties of Operation Results
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
        [WirePath("properties")]
        public IReadOnlyDictionary<string, BinaryData> Properties { get; }
    }
}

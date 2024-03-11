// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An ImportExport operation result resource. </summary>
    public partial class ImportExportOperationResult : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ImportExportOperationResult"/>. </summary>
        public ImportExportOperationResult()
        {
            PrivateEndpointConnections = new ChangeTrackingList<PrivateEndpointConnectionRequestStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="ImportExportOperationResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="requestId"> Request Id. </param>
        /// <param name="requestType"> Request type. </param>
        /// <param name="queuedTime"> Queued time. </param>
        /// <param name="lastModifiedTime"> Last modified time. </param>
        /// <param name="blobUri"> Blob Uri. </param>
        /// <param name="serverName"> Server name. </param>
        /// <param name="databaseName"> Database name. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="errorMessage"> Error message. </param>
        /// <param name="privateEndpointConnections"> Gets the status of private endpoints associated with this request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImportExportOperationResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? requestId, string requestType, string queuedTime, string lastModifiedTime, Uri blobUri, string serverName, string databaseName, string status, string errorMessage, IReadOnlyList<PrivateEndpointConnectionRequestStatus> privateEndpointConnections, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            RequestId = requestId;
            RequestType = requestType;
            QueuedTime = queuedTime;
            LastModifiedTime = lastModifiedTime;
            BlobUri = blobUri;
            ServerName = serverName;
            DatabaseName = databaseName;
            Status = status;
            ErrorMessage = errorMessage;
            PrivateEndpointConnections = privateEndpointConnections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Request Id. </summary>
        public Guid? RequestId { get; }
        /// <summary> Request type. </summary>
        public string RequestType { get; }
        /// <summary> Queued time. </summary>
        public string QueuedTime { get; }
        /// <summary> Last modified time. </summary>
        public string LastModifiedTime { get; }
        /// <summary> Blob Uri. </summary>
        public Uri BlobUri { get; }
        /// <summary> Server name. </summary>
        public string ServerName { get; }
        /// <summary> Database name. </summary>
        public string DatabaseName { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> Error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Gets the status of private endpoints associated with this request. </summary>
        public IReadOnlyList<PrivateEndpointConnectionRequestStatus> PrivateEndpointConnections { get; }
    }
}

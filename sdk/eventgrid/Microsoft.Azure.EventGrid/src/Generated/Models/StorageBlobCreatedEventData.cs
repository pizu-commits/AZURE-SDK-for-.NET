// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for an
    /// Microsoft.Storage.BlobCreated event.
    /// </summary>
    public partial class StorageBlobCreatedEventData
    {
        /// <summary>
        /// Initializes a new instance of the StorageBlobCreatedEventData
        /// class.
        /// </summary>
        public StorageBlobCreatedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageBlobCreatedEventData
        /// class.
        /// </summary>
        /// <param name="api">The name of the API/operation that triggered this
        /// event.</param>
        /// <param name="clientRequestId">A request id provided by the client
        /// of the storage API operation that triggered this event.</param>
        /// <param name="requestId">The request id generated by the Storage
        /// service for the storage API operation that triggered this
        /// event.</param>
        /// <param name="eTag">The etag of the blob at the time this event was
        /// triggered.</param>
        /// <param name="contentType">The content type of the blob. This is the
        /// same as what would be returned in the Content-Type header from the
        /// blob.</param>
        /// <param name="contentLength">The size of the blob in bytes. This is
        /// the same as what would be returned in the Content-Length header
        /// from the blob.</param>
        /// <param name="contentOffset">The offset of the blob in
        /// bytes.</param>
        /// <param name="blobType">The type of blob.</param>
        /// <param name="url">The path to the blob.</param>
        /// <param name="sequencer">An opaque string value representing the
        /// logical sequence of events for any particular blob name. Users can
        /// use standard string comparison to understand the relative sequence
        /// of two events on the same blob name.</param>
        /// <param name="identity">The identity of the requester that triggered
        /// this event.</param>
        /// <param name="storageDiagnostics">For service use only. Diagnostic
        /// data occasionally included by the Azure Storage service. This
        /// property should be ignored by event consumers.</param>
        public StorageBlobCreatedEventData(string api = default(string), string clientRequestId = default(string), string requestId = default(string), string eTag = default(string), string contentType = default(string), long? contentLength = default(long?), long? contentOffset = default(long?), string blobType = default(string), string url = default(string), string sequencer = default(string), string identity = default(string), object storageDiagnostics = default(object))
        {
            Api = api;
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            ETag = eTag;
            ContentType = contentType;
            ContentLength = contentLength;
            ContentOffset = contentOffset;
            BlobType = blobType;
            Url = url;
            Sequencer = sequencer;
            Identity = identity;
            StorageDiagnostics = storageDiagnostics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the API/operation that triggered this
        /// event.
        /// </summary>
        [JsonProperty(PropertyName = "api")]
        public string Api { get; set; }

        /// <summary>
        /// Gets or sets a request id provided by the client of the storage API
        /// operation that triggered this event.
        /// </summary>
        [JsonProperty(PropertyName = "clientRequestId")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the request id generated by the Storage service for
        /// the storage API operation that triggered this event.
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets the etag of the blob at the time this event was
        /// triggered.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the content type of the blob. This is the same as what
        /// would be returned in the Content-Type header from the blob.
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the size of the blob in bytes. This is the same as
        /// what would be returned in the Content-Length header from the blob.
        /// </summary>
        [JsonProperty(PropertyName = "contentLength")]
        public long? ContentLength { get; set; }

        /// <summary>
        /// Gets or sets the offset of the blob in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "contentOffset")]
        public long? ContentOffset { get; set; }

        /// <summary>
        /// Gets or sets the type of blob.
        /// </summary>
        [JsonProperty(PropertyName = "blobType")]
        public string BlobType { get; set; }

        /// <summary>
        /// Gets or sets the path to the blob.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets an opaque string value representing the logical
        /// sequence of events for any particular blob name. Users can use
        /// standard string comparison to understand the relative sequence of
        /// two events on the same blob name.
        /// </summary>
        [JsonProperty(PropertyName = "sequencer")]
        public string Sequencer { get; set; }

        /// <summary>
        /// Gets or sets the identity of the requester that triggered this
        /// event.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public string Identity { get; set; }

        /// <summary>
        /// Gets or sets for service use only. Diagnostic data occasionally
        /// included by the Azure Storage service. This property should be
        /// ignored by event consumers.
        /// </summary>
        [JsonProperty(PropertyName = "storageDiagnostics")]
        public object StorageDiagnostics { get; set; }

    }
}

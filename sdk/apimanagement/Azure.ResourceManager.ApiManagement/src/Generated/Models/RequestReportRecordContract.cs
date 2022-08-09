// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Request Report data. </summary>
    public partial class RequestReportRecordContract
    {
        /// <summary> Initializes a new instance of RequestReportRecordContract. </summary>
        internal RequestReportRecordContract()
        {
        }

        /// <summary> Initializes a new instance of RequestReportRecordContract. </summary>
        /// <param name="apiId"> API identifier path. /apis/{apiId}. </param>
        /// <param name="operationId"> Operation identifier path. /apis/{apiId}/operations/{operationId}. </param>
        /// <param name="productId"> Product identifier path. /products/{productId}. </param>
        /// <param name="userId"> User identifier path. /users/{userId}. </param>
        /// <param name="method"> The HTTP method associated with this request.. </param>
        /// <param name="uri"> The full URL associated with this request. </param>
        /// <param name="ipAddress"> The client IP address associated with this request. </param>
        /// <param name="backendResponseCode"> The HTTP status code received by the gateway as a result of forwarding this request to the backend. </param>
        /// <param name="responseCode"> The HTTP status code returned by the gateway. </param>
        /// <param name="responseSize"> The size of the response returned by the gateway. </param>
        /// <param name="timestamp"> The date and time when this request was received by the gateway in ISO 8601 format. </param>
        /// <param name="cache"> Specifies if response cache was involved in generating the response. If the value is none, the cache was not used. If the value is hit, cached response was returned. If the value is miss, the cache was used but lookup resulted in a miss and request was fulfilled by the backend. </param>
        /// <param name="apiTime"> The total time it took to process this request. </param>
        /// <param name="serviceTime"> he time it took to forward this request to the backend and get the response back. </param>
        /// <param name="apiRegion"> Azure region where the gateway that processed this request is located. </param>
        /// <param name="subscriptionResourceId"> Subscription identifier path. /subscriptions/{subscriptionId}. </param>
        /// <param name="requestId"> Request Identifier. </param>
        /// <param name="requestSize"> The size of this request.. </param>
        internal RequestReportRecordContract(string apiId, string operationId, string productId, string userId, RequestMethod? method, Uri uri, IPAddress ipAddress, string backendResponseCode, int? responseCode, int? responseSize, DateTimeOffset? timestamp, string cache, double? apiTime, double? serviceTime, string apiRegion, ResourceIdentifier subscriptionResourceId, string requestId, int? requestSize)
        {
            ApiId = apiId;
            OperationId = operationId;
            ProductId = productId;
            UserId = userId;
            Method = method;
            Uri = uri;
            IPAddress = ipAddress;
            BackendResponseCode = backendResponseCode;
            ResponseCode = responseCode;
            ResponseSize = responseSize;
            Timestamp = timestamp;
            Cache = cache;
            ApiTime = apiTime;
            ServiceTime = serviceTime;
            ApiRegion = apiRegion;
            SubscriptionResourceId = subscriptionResourceId;
            RequestId = requestId;
            RequestSize = requestSize;
        }

        /// <summary> API identifier path. /apis/{apiId}. </summary>
        public string ApiId { get; }
        /// <summary> Operation identifier path. /apis/{apiId}/operations/{operationId}. </summary>
        public string OperationId { get; }
        /// <summary> Product identifier path. /products/{productId}. </summary>
        public string ProductId { get; }
        /// <summary> User identifier path. /users/{userId}. </summary>
        public string UserId { get; }
        /// <summary> The HTTP method associated with this request.. </summary>
        public RequestMethod? Method { get; }
        /// <summary> The full URL associated with this request. </summary>
        public Uri Uri { get; }
        /// <summary> The client IP address associated with this request. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The HTTP status code received by the gateway as a result of forwarding this request to the backend. </summary>
        public string BackendResponseCode { get; }
        /// <summary> The HTTP status code returned by the gateway. </summary>
        public int? ResponseCode { get; }
        /// <summary> The size of the response returned by the gateway. </summary>
        public int? ResponseSize { get; }
        /// <summary> The date and time when this request was received by the gateway in ISO 8601 format. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Specifies if response cache was involved in generating the response. If the value is none, the cache was not used. If the value is hit, cached response was returned. If the value is miss, the cache was used but lookup resulted in a miss and request was fulfilled by the backend. </summary>
        public string Cache { get; }
        /// <summary> The total time it took to process this request. </summary>
        public double? ApiTime { get; }
        /// <summary> he time it took to forward this request to the backend and get the response back. </summary>
        public double? ServiceTime { get; }
        /// <summary> Azure region where the gateway that processed this request is located. </summary>
        public string ApiRegion { get; }
        /// <summary> Subscription identifier path. /subscriptions/{subscriptionId}. </summary>
        public ResourceIdentifier SubscriptionResourceId { get; }
        /// <summary> Request Identifier. </summary>
        public string RequestId { get; }
        /// <summary> The size of this request.. </summary>
        public int? RequestSize { get; }
    }
}

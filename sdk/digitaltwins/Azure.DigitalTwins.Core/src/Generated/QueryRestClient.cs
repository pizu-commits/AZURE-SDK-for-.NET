// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.DigitalTwins.Core
{
    internal partial class QueryRestClient
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of QueryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public QueryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-05-31-preview")
        {
            endpoint ??= new Uri("https://digitaltwins-name.digitaltwins.azure.net");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateQueryTwinsRequest(QuerySpecification querySpecification)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/query", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(querySpecification);
            request.Content = content;
            return message;
        }

        /// <summary>
        /// Executes a query that allows traversing relationships and filtering by property values.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// </summary>
        /// <param name="querySpecification"> The query specification to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ResponseWithHeaders<QueryResult, QueryQueryTwinsHeaders>> QueryTwinsAsync(QuerySpecification querySpecification, CancellationToken cancellationToken = default)
        {
            if (querySpecification == null)
            {
                throw new ArgumentNullException(nameof(querySpecification));
            }

            using var message = CreateQueryTwinsRequest(querySpecification);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueryQueryTwinsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = QueryResult.DeserializeQueryResult(document.RootElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a query that allows traversing relationships and filtering by property values.
        /// Status codes:
        /// 200 (OK): Success.
        /// 400 (Bad Request): The request is invalid.
        /// </summary>
        /// <param name="querySpecification"> The query specification to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ResponseWithHeaders<QueryResult, QueryQueryTwinsHeaders> QueryTwins(QuerySpecification querySpecification, CancellationToken cancellationToken = default)
        {
            if (querySpecification == null)
            {
                throw new ArgumentNullException(nameof(querySpecification));
            }

            using var message = CreateQueryTwinsRequest(querySpecification);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueryQueryTwinsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = QueryResult.DeserializeQueryResult(document.RootElement);
                        }
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

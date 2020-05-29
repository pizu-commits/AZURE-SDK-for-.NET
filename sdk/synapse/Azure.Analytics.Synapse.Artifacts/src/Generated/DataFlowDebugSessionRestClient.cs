// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    internal partial class DataFlowDebugSessionRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DataFlowDebugSessionRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public DataFlowDebugSessionRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2019-06-01-preview")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateDataFlowDebugSessionRequest(CreateDataFlowDebugSessionRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/createDataFlowDebugSession", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Creates a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CreateDataFlowDebugSessionAsync(CreateDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateCreateDataFlowDebugSessionRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response CreateDataFlowDebugSession(CreateDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateCreateDataFlowDebugSessionRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateQueryDataFlowDebugSessionsByWorkspaceRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/queryDataFlowDebugSessions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Query all active data flow debug sessions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<QueryDataFlowDebugSessionsResponse>> QueryDataFlowDebugSessionsByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryDataFlowDebugSessionsByWorkspaceRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryDataFlowDebugSessionsResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = QueryDataFlowDebugSessionsResponse.DeserializeQueryDataFlowDebugSessionsResponse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Query all active data flow debug sessions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<QueryDataFlowDebugSessionsResponse> QueryDataFlowDebugSessionsByWorkspace(CancellationToken cancellationToken = default)
        {
            using var message = CreateQueryDataFlowDebugSessionsByWorkspaceRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryDataFlowDebugSessionsResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = QueryDataFlowDebugSessionsResponse.DeserializeQueryDataFlowDebugSessionsResponse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddDataFlowRequest(DataFlowDebugPackage request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/addDataFlowToDebugSession", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Add a data flow into debug session. </summary>
        /// <param name="request"> Data flow debug session definition with debug content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<AddDataFlowToDebugSessionResponse>> AddDataFlowAsync(DataFlowDebugPackage request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAddDataFlowRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddDataFlowToDebugSessionResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = AddDataFlowToDebugSessionResponse.DeserializeAddDataFlowToDebugSessionResponse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Add a data flow into debug session. </summary>
        /// <param name="request"> Data flow debug session definition with debug content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<AddDataFlowToDebugSessionResponse> AddDataFlow(DataFlowDebugPackage request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAddDataFlowRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AddDataFlowToDebugSessionResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = AddDataFlowToDebugSessionResponse.DeserializeAddDataFlowToDebugSessionResponse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteDataFlowDebugSessionRequest(DeleteDataFlowDebugSessionRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/deleteDataFlowDebugSession", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Deletes a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition for deletion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteDataFlowDebugSessionAsync(DeleteDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateDeleteDataFlowDebugSessionRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a data flow debug session. </summary>
        /// <param name="request"> Data flow debug session definition for deletion. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteDataFlowDebugSession(DeleteDataFlowDebugSessionRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateDeleteDataFlowDebugSessionRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateExecuteCommandRequest(DataFlowDebugCommandRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/executeDataFlowDebugCommand", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(request);
            request0.Content = content;
            return message;
        }

        /// <summary> Execute a data flow debug command. </summary>
        /// <param name="request"> Data flow debug command definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> ExecuteCommandAsync(DataFlowDebugCommandRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateExecuteCommandRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Execute a data flow debug command. </summary>
        /// <param name="request"> Data flow debug command definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response ExecuteCommand(DataFlowDebugCommandRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateExecuteCommandRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateQueryDataFlowDebugSessionsByWorkspaceNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Query all active data flow debug sessions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<QueryDataFlowDebugSessionsResponse>> QueryDataFlowDebugSessionsByWorkspaceNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateQueryDataFlowDebugSessionsByWorkspaceNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryDataFlowDebugSessionsResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = QueryDataFlowDebugSessionsResponse.DeserializeQueryDataFlowDebugSessionsResponse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Query all active data flow debug sessions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<QueryDataFlowDebugSessionsResponse> QueryDataFlowDebugSessionsByWorkspaceNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateQueryDataFlowDebugSessionsByWorkspaceNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        QueryDataFlowDebugSessionsResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = QueryDataFlowDebugSessionsResponse.DeserializeQueryDataFlowDebugSessionsResponse(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

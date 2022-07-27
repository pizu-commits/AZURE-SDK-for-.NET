// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.HybridConnectivity.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    internal partial class EndpointsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of EndpointsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public EndpointsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-06-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List of endpoints to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public async Task<Response<EndpointsList>> ListAsync(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EndpointsList.DeserializeEndpointsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of endpoints to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> is null. </exception>
        public Response<EndpointsList> List(string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListRequest(scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EndpointsList.DeserializeEndpointsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string scope, string endpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the endpoint to the resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="endpointName"/> is null. </exception>
        public async Task<Response<EndpointResourceData>> GetAsync(string scope, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateGetRequest(scope, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EndpointResourceData.DeserializeEndpointResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((EndpointResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the endpoint to the resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="endpointName"/> is null. </exception>
        public Response<EndpointResourceData> Get(string scope, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateGetRequest(scope, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EndpointResourceData.DeserializeEndpointResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((EndpointResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string scope, string endpointName, EndpointResourceData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update the endpoint to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public async Task<Response<EndpointResourceData>> CreateOrUpdateAsync(string scope, string endpointName, EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(scope, endpointName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EndpointResourceData.DeserializeEndpointResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update the endpoint to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public Response<EndpointResourceData> CreateOrUpdate(string scope, string endpointName, EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(scope, endpointName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EndpointResourceData.DeserializeEndpointResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string scope, string endpointName, EndpointResourceData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update the endpoint to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public async Task<Response<EndpointResourceData>> UpdateAsync(string scope, string endpointName, EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(scope, endpointName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EndpointResourceData.DeserializeEndpointResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update the endpoint to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="data"> Endpoint details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/>, <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public Response<EndpointResourceData> Update(string scope, string endpointName, EndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateUpdateRequest(scope, endpointName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EndpointResourceData.DeserializeEndpointResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string scope, string endpointName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the endpoint access to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="endpointName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string scope, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateDeleteRequest(scope, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the endpoint access to the target resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="endpointName"/> is null. </exception>
        public Response Delete(string scope, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateDeleteRequest(scope, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListCredentialsRequest(string scope, string endpointName, long? expiresin)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(scope, false);
            uri.AppendPath("/providers/Microsoft.HybridConnectivity/endpoints/", false);
            uri.AppendPath(endpointName, false);
            uri.AppendPath("/listCredentials", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expiresin != null)
            {
                uri.AppendQuery("expiresin", expiresin.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the endpoint access credentials to the resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="endpointName"/> is null. </exception>
        public async Task<Response<TargetResourceEndpointAccess>> ListCredentialsAsync(string scope, string endpointName, long? expiresin = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateListCredentialsRequest(scope, endpointName, expiresin);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetResourceEndpointAccess value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TargetResourceEndpointAccess.DeserializeTargetResourceEndpointAccess(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the endpoint access credentials to the resource. </summary>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="endpointName"> The endpoint name. </param>
        /// <param name="expiresin"> The is how long the endpoint access token is valid (in seconds). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scope"/> or <paramref name="endpointName"/> is null. </exception>
        public Response<TargetResourceEndpointAccess> ListCredentials(string scope, string endpointName, long? expiresin = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(scope, nameof(scope));
            Argument.AssertNotNull(endpointName, nameof(endpointName));

            using var message = CreateListCredentialsRequest(scope, endpointName, expiresin);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TargetResourceEndpointAccess value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TargetResourceEndpointAccess.DeserializeTargetResourceEndpointAccess(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string scope)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List of endpoints to the target resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public async Task<Response<EndpointsList>> ListNextPageAsync(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EndpointsList.DeserializeEndpointsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of endpoints to the target resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="scope"> The fully qualified Azure Resource manager identifier of the resource to be connected. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="scope"/> is null. </exception>
        public Response<EndpointsList> ListNextPage(string nextLink, string scope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(scope, nameof(scope));

            using var message = CreateListNextPageRequest(nextLink, scope);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EndpointsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EndpointsList.DeserializeEndpointsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

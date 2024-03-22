// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    internal partial class AttestationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AttestationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AttestationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListForResourceRequest(string resourceId, PolicyQuerySettings policyQuerySettings)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.PolicyInsights/attestations", false);
            if (policyQuerySettings?.Top != null)
            {
                uri.AppendQuery("$top", policyQuerySettings.Top.Value, true);
            }
            if (policyQuerySettings?.Filter != null)
            {
                uri.AppendQuery("$filter", policyQuerySettings.Filter, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all attestations for a resource. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public async Task<Response<AttestationListResult>> ListForResourceAsync(string resourceId, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListForResourceRequest(resourceId, policyQuerySettings);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AttestationListResult.DeserializeAttestationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all attestations for a resource. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public Response<AttestationListResult> ListForResource(string resourceId, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListForResourceRequest(resourceId, policyQuerySettings);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AttestationListResult.DeserializeAttestationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateAtResourceRequest(string resourceId, string attestationName, PolicyAttestationData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.PolicyInsights/attestations/", false);
            uri.AppendPath(attestationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<PolicyAttestationData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates an attestation at resource scope. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="data"> The attestation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/>, <paramref name="attestationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAtResourceAsync(string resourceId, string attestationName, PolicyAttestationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateAtResourceRequest(resourceId, attestationName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates an attestation at resource scope. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="data"> The attestation parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/>, <paramref name="attestationName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdateAtResource(string resourceId, string attestationName, PolicyAttestationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateAtResourceRequest(resourceId, attestationName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAtResourceRequest(string resourceId, string attestationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.PolicyInsights/attestations/", false);
            uri.AppendPath(attestationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an existing attestation at resource scope. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="attestationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PolicyAttestationData>> GetAtResourceAsync(string resourceId, string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var message = CreateGetAtResourceRequest(resourceId, attestationName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyAttestationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PolicyAttestationData.DeserializePolicyAttestationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PolicyAttestationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an existing attestation at resource scope. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="attestationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PolicyAttestationData> GetAtResource(string resourceId, string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var message = CreateGetAtResourceRequest(resourceId, attestationName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PolicyAttestationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PolicyAttestationData.DeserializePolicyAttestationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PolicyAttestationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteAtResourceRequest(string resourceId, string attestationName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceId, false);
            uri.AppendPath("/providers/Microsoft.PolicyInsights/attestations/", false);
            uri.AppendPath(attestationName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an existing attestation at individual resource scope. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="attestationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAtResourceAsync(string resourceId, string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var message = CreateDeleteAtResourceRequest(resourceId, attestationName);
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

        /// <summary> Deletes an existing attestation at individual resource scope. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="attestationName"> The name of the attestation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> or <paramref name="attestationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="attestationName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response DeleteAtResource(string resourceId, string attestationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));
            Argument.AssertNotNullOrEmpty(attestationName, nameof(attestationName));

            using var message = CreateDeleteAtResourceRequest(resourceId, attestationName);
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

        internal HttpMessage CreateListForResourceNextPageRequest(string nextLink, string resourceId, PolicyQuerySettings policyQuerySettings)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all attestations for a resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceId"/> is null. </exception>
        public async Task<Response<AttestationListResult>> ListForResourceNextPageAsync(string nextLink, string resourceId, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListForResourceNextPageRequest(nextLink, resourceId, policyQuerySettings);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AttestationListResult.DeserializeAttestationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all attestations for a resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="policyQuerySettings"> Parameter group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceId"/> is null. </exception>
        public Response<AttestationListResult> ListForResourceNextPage(string nextLink, string resourceId, PolicyQuerySettings policyQuerySettings = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            using var message = CreateListForResourceNextPageRequest(nextLink, resourceId, policyQuerySettings);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AttestationListResult.DeserializeAttestationListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

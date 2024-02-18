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

namespace Azure.ResourceManager.SecurityCenter
{
    internal partial class ApplicationRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ApplicationRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ApplicationRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-07-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string applicationId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/applications/", false);
            uri.AppendPath(applicationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string applicationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/applications/", false);
            uri.AppendPath(applicationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a specific application for the requested scope by applicationId. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityApplicationData>> GetAsync(string subscriptionId, string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var message = CreateGetRequest(subscriptionId, applicationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityApplicationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityApplicationData.DeserializeSecurityApplicationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityApplicationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a specific application for the requested scope by applicationId. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityApplicationData> Get(string subscriptionId, string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var message = CreateGetRequest(subscriptionId, applicationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityApplicationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityApplicationData.DeserializeSecurityApplicationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityApplicationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateOrUpdateRequestUri(string subscriptionId, string applicationId, SecurityApplicationData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/applications/", false);
            uri.AppendPath(applicationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string applicationId, SecurityApplicationData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/applications/", false);
            uri.AppendPath(applicationId, true);
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

        /// <summary> Creates or update a security application on the given subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="data"> Application over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="applicationId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SecurityApplicationData>> CreateOrUpdateAsync(string subscriptionId, string applicationId, SecurityApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, applicationId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityApplicationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityApplicationData.DeserializeSecurityApplicationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or update a security application on the given subscription. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="data"> Application over a subscription scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="applicationId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SecurityApplicationData> CreateOrUpdate(string subscriptionId, string applicationId, SecurityApplicationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, applicationId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SecurityApplicationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityApplicationData.DeserializeSecurityApplicationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string applicationId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/applications/", false);
            uri.AppendPath(applicationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string applicationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Security/applications/", false);
            uri.AppendPath(applicationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete an Application over a given scope. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var message = CreateDeleteRequest(subscriptionId, applicationId);
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

        /// <summary> Delete an Application over a given scope. </summary>
        /// <param name="subscriptionId"> Azure subscription ID. </param>
        /// <param name="applicationId"> The security Application key - unique key for the standard application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="applicationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string applicationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(applicationId, nameof(applicationId));

            using var message = CreateDeleteRequest(subscriptionId, applicationId);
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
    }
}

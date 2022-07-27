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
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class IntegrationAccountCertificatesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IntegrationAccountCertificatesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IntegrationAccountCertificatesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/certificates", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of integration account certificates. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountCertificateListResult>> ListAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, integrationAccountName, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountCertificateListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountCertificateListResult.DeserializeIntegrationAccountCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of integration account certificates. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountCertificateListResult> List(string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, integrationAccountName, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountCertificateListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountCertificateListResult.DeserializeIntegrationAccountCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(certificateName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an integration account certificate. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountCertificateData>> GetAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, integrationAccountName, certificateName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountCertificateData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountCertificateData.DeserializeIntegrationAccountCertificateData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationAccountCertificateData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an integration account certificate. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountCertificateData> Get(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, integrationAccountName, certificateName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountCertificateData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountCertificateData.DeserializeIntegrationAccountCertificateData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationAccountCertificateData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName, IntegrationAccountCertificateData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(certificateName, true);
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

        /// <summary> Creates or updates an integration account certificate. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="data"> The integration account certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountCertificateData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName, IntegrationAccountCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, integrationAccountName, certificateName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        IntegrationAccountCertificateData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountCertificateData.DeserializeIntegrationAccountCertificateData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates an integration account certificate. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="data"> The integration account certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountCertificateData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName, IntegrationAccountCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, integrationAccountName, certificateName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        IntegrationAccountCertificateData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountCertificateData.DeserializeIntegrationAccountCertificateData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/certificates/", false);
            uri.AppendPath(certificateName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an integration account certificate. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, integrationAccountName, certificateName);
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

        /// <summary> Deletes an integration account certificate. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="certificateName"> The integration account certificate name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string integrationAccountName, string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, integrationAccountName, certificateName);
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

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string integrationAccountName, int? top)
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

        /// <summary> Gets a list of integration account certificates. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountCertificateListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, integrationAccountName, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountCertificateListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountCertificateListResult.DeserializeIntegrationAccountCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of integration account certificates. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountCertificateListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, integrationAccountName, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountCertificateListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountCertificateListResult.DeserializeIntegrationAccountCertificateListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

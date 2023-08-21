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
    internal partial class IntegrationAccountPartnersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of IntegrationAccountPartnersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public IntegrationAccountPartnersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, int? top, string filter)
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
            uri.AppendPath("/partners", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of integration account partners. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: PartnerType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountPartnerListResult>> ListAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, integrationAccountName, top, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountPartnerListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountPartnerListResult.DeserializeIntegrationAccountPartnerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of integration account partners. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: PartnerType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountPartnerListResult> List(string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, integrationAccountName, top, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountPartnerListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountPartnerListResult.DeserializeIntegrationAccountPartnerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName)
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
            uri.AppendPath("/partners/", false);
            uri.AppendPath(partnerName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an integration account partner. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountPartnerData>> GetAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountPartnerData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountPartnerData.DeserializeIntegrationAccountPartnerData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationAccountPartnerData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an integration account partner. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountPartnerData> Get(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountPartnerData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountPartnerData.DeserializeIntegrationAccountPartnerData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((IntegrationAccountPartnerData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, IntegrationAccountPartnerData data)
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
            uri.AppendPath("/partners/", false);
            uri.AppendPath(partnerName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates an integration account partner. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="data"> The integration account partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="partnerName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountPartnerData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, IntegrationAccountPartnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        IntegrationAccountPartnerData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountPartnerData.DeserializeIntegrationAccountPartnerData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates an integration account partner. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="data"> The integration account partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="partnerName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountPartnerData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, IntegrationAccountPartnerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        IntegrationAccountPartnerData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountPartnerData.DeserializeIntegrationAccountPartnerData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName)
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
            uri.AppendPath("/partners/", false);
            uri.AppendPath(partnerName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an integration account partner. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
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

        /// <summary> Deletes an integration account partner. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName);
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

        internal HttpMessage CreateListContentCallbackUrlRequest(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, ListOperationCallbackUrlParameterInfo info)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/integrationAccounts/", false);
            uri.AppendPath(integrationAccountName, true);
            uri.AppendPath("/partners/", false);
            uri.AppendPath(partnerName, true);
            uri.AppendPath("/listContentCallbackUrl", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(info);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the content callback url. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="info"> The ListOperationCallbackUrlParameterInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="partnerName"/> or <paramref name="info"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowTriggerCallbackUri>> ListContentCallbackUrlAsync(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, ListOperationCallbackUrlParameterInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));
            Argument.AssertNotNull(info, nameof(info));

            using var message = CreateListContentCallbackUrlRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName, info);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowTriggerCallbackUri value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowTriggerCallbackUri.DeserializeLogicWorkflowTriggerCallbackUri(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the content callback url. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="partnerName"> The integration account partner name. </param>
        /// <param name="info"> The ListOperationCallbackUrlParameterInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/>, <paramref name="partnerName"/> or <paramref name="info"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="integrationAccountName"/> or <paramref name="partnerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowTriggerCallbackUri> ListContentCallbackUrl(string subscriptionId, string resourceGroupName, string integrationAccountName, string partnerName, ListOperationCallbackUrlParameterInfo info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));
            Argument.AssertNotNullOrEmpty(partnerName, nameof(partnerName));
            Argument.AssertNotNull(info, nameof(info));

            using var message = CreateListContentCallbackUrlRequest(subscriptionId, resourceGroupName, integrationAccountName, partnerName, info);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowTriggerCallbackUri value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LogicWorkflowTriggerCallbackUri.DeserializeLogicWorkflowTriggerCallbackUri(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string integrationAccountName, int? top, string filter)
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

        /// <summary> Gets a list of integration account partners. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: PartnerType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<IntegrationAccountPartnerListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, integrationAccountName, top, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountPartnerListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = IntegrationAccountPartnerListResult.DeserializeIntegrationAccountPartnerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of integration account partners. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="integrationAccountName"> The integration account name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="filter"> The filter to apply on the operation. Options for filters include: PartnerType. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="integrationAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<IntegrationAccountPartnerListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string integrationAccountName, int? top = null, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(integrationAccountName, nameof(integrationAccountName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, integrationAccountName, top, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IntegrationAccountPartnerListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = IntegrationAccountPartnerListResult.DeserializeIntegrationAccountPartnerListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

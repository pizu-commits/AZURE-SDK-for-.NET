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
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    internal partial class ImpactedResourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ImpactedResourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ImpactedResourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-10-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListBySubscriptionIdAndEventIdRequestUri(string subscriptionId, string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateListBySubscriptionIdAndEventIdRequest(string subscriptionId, string eventTrackingId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists impacted resources in the subscription by an event. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListBySubscriptionIdAndEventIdAsync(string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListBySubscriptionIdAndEventIdRequest(subscriptionId, eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the subscription by an event. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListBySubscriptionIdAndEventId(string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListBySubscriptionIdAndEventIdRequest(subscriptionId, eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string eventTrackingId, string impactedResourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources/", false);
            uri.AppendPath(impactedResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string eventTrackingId, string impactedResourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources/", false);
            uri.AppendPath(impactedResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the specific impacted resource in the subscription by an event. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceHealthEventImpactedResourceData>> GetAsync(string subscriptionId, string eventTrackingId, string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var message = CreateGetRequest(subscriptionId, eventTrackingId, impactedResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthEventImpactedResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResourceHealthEventImpactedResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the specific impacted resource in the subscription by an event. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceHealthEventImpactedResourceData> Get(string subscriptionId, string eventTrackingId, string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var message = CreateGetRequest(subscriptionId, eventTrackingId, impactedResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthEventImpactedResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResourceHealthEventImpactedResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByTenantIdAndEventIdRequestUri(string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByTenantIdAndEventIdRequest(string eventTrackingId, string filter)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists impacted resources in the tenant by an event. </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListByTenantIdAndEventIdAsync(string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListByTenantIdAndEventIdRequest(eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the tenant by an event. </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListByTenantIdAndEventId(string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListByTenantIdAndEventIdRequest(eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetByTenantIdRequestUri(string eventTrackingId, string impactedResourceName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources/", false);
            uri.AppendPath(impactedResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetByTenantIdRequest(string eventTrackingId, string impactedResourceName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.ResourceHealth/events/", false);
            uri.AppendPath(eventTrackingId, true);
            uri.AppendPath("/impactedResources/", false);
            uri.AppendPath(impactedResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the specific impacted resource in the tenant by an event. </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ResourceHealthEventImpactedResourceData>> GetByTenantIdAsync(string eventTrackingId, string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var message = CreateGetByTenantIdRequest(eventTrackingId, impactedResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthEventImpactedResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResourceHealthEventImpactedResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the specific impacted resource in the tenant by an event. </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="impactedResourceName"> Name of the Impacted Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> or <paramref name="impactedResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ResourceHealthEventImpactedResourceData> GetByTenantId(string eventTrackingId, string impactedResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));
            Argument.AssertNotNullOrEmpty(impactedResourceName, nameof(impactedResourceName));

            using var message = CreateGetByTenantIdRequest(eventTrackingId, impactedResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResourceHealthEventImpactedResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResourceHealthEventImpactedResourceData.DeserializeResourceHealthEventImpactedResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResourceHealthEventImpactedResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListBySubscriptionIdAndEventIdNextPageRequestUri(string nextLink, string subscriptionId, string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListBySubscriptionIdAndEventIdNextPageRequest(string nextLink, string subscriptionId, string eventTrackingId, string filter)
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

        /// <summary> Lists impacted resources in the subscription by an event. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListBySubscriptionIdAndEventIdNextPageAsync(string nextLink, string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListBySubscriptionIdAndEventIdNextPageRequest(nextLink, subscriptionId, eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the subscription by an event. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListBySubscriptionIdAndEventIdNextPage(string nextLink, string subscriptionId, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListBySubscriptionIdAndEventIdNextPageRequest(nextLink, subscriptionId, eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByTenantIdAndEventIdNextPageRequestUri(string nextLink, string eventTrackingId, string filter)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByTenantIdAndEventIdNextPageRequest(string nextLink, string eventTrackingId, string filter)
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

        /// <summary> Lists impacted resources in the tenant by an event. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<EventImpactedResourceListResult>> ListByTenantIdAndEventIdNextPageAsync(string nextLink, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListByTenantIdAndEventIdNextPageRequest(nextLink, eventTrackingId, filter);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists impacted resources in the tenant by an event. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="eventTrackingId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<EventImpactedResourceListResult> ListByTenantIdAndEventIdNextPage(string nextLink, string eventTrackingId, string filter = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var message = CreateListByTenantIdAndEventIdNextPageRequest(nextLink, eventTrackingId, filter);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        EventImpactedResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = EventImpactedResourceListResult.DeserializeEventImpactedResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

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
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    internal partial class FrontDoorRoutesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of FrontDoorRoutesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public FrontDoorRoutesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByEndpointRequest(string subscriptionId, string resourceGroupName, string profileName, string endpointName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/afdEndpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/routes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RouteListResult>> ListByEndpointAsync(string subscriptionId, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointRequest(subscriptionId, resourceGroupName, profileName, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RouteListResult> ListByEndpoint(string subscriptionId, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointRequest(subscriptionId, resourceGroupName, profileName, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/afdEndpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/routes/", false);
            uri.AppendPath(routeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FrontDoorRouteData>> GetAsync(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FrontDoorRouteData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FrontDoorRouteData.DeserializeFrontDoorRouteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FrontDoorRouteData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FrontDoorRouteData> Get(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FrontDoorRouteData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FrontDoorRouteData.DeserializeFrontDoorRouteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FrontDoorRouteData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, FrontDoorRouteData data)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/afdEndpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/routes/", false);
            uri.AppendPath(routeName, true);
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

        /// <summary> Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="data"> Route properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="routeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, FrontDoorRouteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="data"> Route properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="routeName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, FrontDoorRouteData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, FrontDoorRoutePatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/afdEndpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/routes/", false);
            uri.AppendPath(routeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="patch"> Route update properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="routeName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, FrontDoorRoutePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="patch"> Route update properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/>, <paramref name="routeName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, FrontDoorRoutePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName)
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
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/afdEndpoints/", false);
            uri.AppendPath(endpointName, true);
            uri.AppendPath("/routes/", false);
            uri.AppendPath(routeName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="endpointName"/> or <paramref name="routeName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string profileName, string endpointName, string routeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNullOrEmpty(routeName, nameof(routeName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, profileName, endpointName, routeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByEndpointNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string profileName, string endpointName)
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

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RouteListResult>> ListByEndpointNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointNextPageRequest(nextLink, subscriptionId, resourceGroupName, profileName, endpointName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="endpointName"> Name of the endpoint under the profile which is unique globally. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RouteListResult> ListByEndpointNextPage(string nextLink, string subscriptionId, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var message = CreateListByEndpointNextPageRequest(nextLink, subscriptionId, resourceGroupName, profileName, endpointName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class ServiceEndpointPolicyDefinitionsRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public ServiceEndpointPolicyDefinitionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions/", false);
            uri.AppendPath(serviceEndpointPolicyDefinitionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes the specified ServiceEndpoint policy definitions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the Service Endpoint Policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, or <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified ServiceEndpoint policy definitions. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the Service Endpoint Policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, or <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions/", false);
            uri.AppendPath(serviceEndpointPolicyDefinitionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the specified service endpoint policy definitions from service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, or <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public async Task<Response<ServiceEndpointPolicyDefinitionData>> GetAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateGetRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceEndpointPolicyDefinitionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the specified service endpoint policy definitions from service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, or <paramref name="serviceEndpointPolicyDefinitionName"/> is null. </exception>
        public Response<ServiceEndpointPolicyDefinitionData> Get(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }

            using var message = CreateGetRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ServiceEndpointPolicyDefinitionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinitionData serviceEndpointPolicyDefinitions)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions/", false);
            uri.AppendPath(serviceEndpointPolicyDefinitionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(serviceEndpointPolicyDefinitions);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a service endpoint policy definition in the specified service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, <paramref name="serviceEndpointPolicyDefinitionName"/>, or <paramref name="serviceEndpointPolicyDefinitions"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinitionData serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }
            if (serviceEndpointPolicyDefinitions == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitions));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a service endpoint policy definition in the specified service endpoint policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="serviceEndpointPolicyDefinitionName"> The name of the service endpoint policy definition name. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serviceEndpointPolicyName"/>, <paramref name="serviceEndpointPolicyDefinitionName"/>, or <paramref name="serviceEndpointPolicyDefinitions"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinitionData serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (serviceEndpointPolicyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitionName));
            }
            if (serviceEndpointPolicyDefinitions == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyDefinitions));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByResourceGroupRequest(string resourceGroupName, string serviceEndpointPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/serviceEndpointPolicies/", false);
            uri.AppendPath(serviceEndpointPolicyName, true);
            uri.AppendPath("/serviceEndpointPolicyDefinitions", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public async Task<Response<ServiceEndpointPolicyDefinitionListResult>> GetAllByResourceGroupAsync(string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateGetAllByResourceGroupRequest(resourceGroupName, serviceEndpointPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public Response<ServiceEndpointPolicyDefinitionListResult> GetAllByResourceGroup(string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateGetAllByResourceGroupRequest(resourceGroupName, serviceEndpointPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllByResourceGroupNextPageRequest(string nextLink, string resourceGroupName, string serviceEndpointPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public async Task<Response<ServiceEndpointPolicyDefinitionListResult>> GetAllByResourceGroupNextPageAsync(string nextLink, string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateGetAllByResourceGroupNextPageRequest(nextLink, resourceGroupName, serviceEndpointPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all service endpoint policy definitions in a service end point policy. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public Response<ServiceEndpointPolicyDefinitionListResult> GetAllByResourceGroupNextPage(string nextLink, string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var message = CreateGetAllByResourceGroupNextPageRequest(nextLink, resourceGroupName, serviceEndpointPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ServiceEndpointPolicyDefinitionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ServiceEndpointPolicyDefinitionListResult.DeserializeServiceEndpointPolicyDefinitionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

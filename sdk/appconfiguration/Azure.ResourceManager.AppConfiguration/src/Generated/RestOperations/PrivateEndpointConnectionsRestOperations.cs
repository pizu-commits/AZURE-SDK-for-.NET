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
using Azure.ResourceManager.AppConfiguration.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppConfiguration
{
    internal partial class PrivateEndpointConnectionsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of PrivateEndpointConnectionsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public PrivateEndpointConnectionsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2020-06-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateListByConfigurationStoreRequest(string subscriptionId, string resourceGroupName, string configStoreName)
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
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateEndpointConnections", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all private endpoint connections for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public async Task<Response<PrivateEndpointConnectionListResult>> ListByConfigurationStoreAsync(string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreRequest(subscriptionId, resourceGroupName, configStoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateEndpointConnectionListResult.DeserializePrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all private endpoint connections for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public Response<PrivateEndpointConnectionListResult> ListByConfigurationStore(string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreRequest(subscriptionId, resourceGroupName, configStoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateEndpointConnectionListResult.DeserializePrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName)
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
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the specified private endpoint connection associated with the configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async Task<Response<PrivateEndpointConnectionData>> GetAsync(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateEndpointConnectionData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified private endpoint connection associated with the configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public Response<PrivateEndpointConnectionData> Get(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateEndpointConnectionData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName, PrivateEndpointConnectionData privateEndpointConnection)
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
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(privateEndpointConnection);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Update the state of the specified private endpoint connection associated with the configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="privateEndpointConnection"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, <paramref name="privateEndpointConnectionName"/>, or <paramref name="privateEndpointConnection"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName, PrivateEndpointConnectionData privateEndpointConnection, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnection == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnection));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName, privateEndpointConnection);
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

        /// <summary> Update the state of the specified private endpoint connection associated with the configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="privateEndpointConnection"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, <paramref name="privateEndpointConnectionName"/>, or <paramref name="privateEndpointConnection"/> is null. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName, PrivateEndpointConnectionData privateEndpointConnection, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (privateEndpointConnection == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnection));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName, privateEndpointConnection);
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

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName)
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
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateEndpointConnections/", false);
            uri.AppendPath(privateEndpointConnectionName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes a private endpoint connection. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName);
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

        /// <summary> Deletes a private endpoint connection. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="privateEndpointConnectionName"> Private endpoint connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/>, or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string configStoreName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, configStoreName, privateEndpointConnectionName);
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

        internal HttpMessage CreateListByConfigurationStoreNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all private endpoint connections for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public async Task<Response<PrivateEndpointConnectionListResult>> ListByConfigurationStoreNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, subscriptionId, resourceGroupName, configStoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateEndpointConnectionListResult.DeserializePrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all private endpoint connections for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="configStoreName"/> is null. </exception>
        public Response<PrivateEndpointConnectionListResult> ListByConfigurationStoreNextPage(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (configStoreName == null)
            {
                throw new ArgumentNullException(nameof(configStoreName));
            }

            using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, subscriptionId, resourceGroupName, configStoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateEndpointConnectionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateEndpointConnectionListResult.DeserializePrivateEndpointConnectionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

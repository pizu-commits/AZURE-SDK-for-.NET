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
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    internal partial class SAPCentralInstancesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SAPCentralInstancesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SAPCentralInstancesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-12-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName)
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
            uri.AppendPath("/providers/Microsoft.Workloads/sapVirtualInstances/", false);
            uri.AppendPath(sapVirtualInstanceName, true);
            uri.AppendPath("/centralInstances/", false);
            uri.AppendPath(centralInstanceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the SAP Central Instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SapCentralServerInstanceData>> GetAsync(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SapCentralServerInstanceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SapCentralServerInstanceData.DeserializeSapCentralServerInstanceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SapCentralServerInstanceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the SAP Central Instance. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SapCentralServerInstanceData> Get(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SapCentralServerInstanceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SapCentralServerInstanceData.DeserializeSapCentralServerInstanceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SapCentralServerInstanceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, SapCentralServerInstanceData data)
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
            uri.AppendPath("/providers/Microsoft.Workloads/sapVirtualInstances/", false);
            uri.AppendPath(sapVirtualInstanceName, true);
            uri.AppendPath("/centralInstances/", false);
            uri.AppendPath(centralInstanceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (data != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(data);
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Puts the SAP Central Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> The SAP Central Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, SapCentralServerInstanceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName, data);
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

        /// <summary> Puts the SAP Central Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. PUT by end user will return a Bad Request error. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="data"> The SAP Central Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, SapCentralServerInstanceData data = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName, data);
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

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, SapCentralServerInstancePatch patch)
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
            uri.AppendPath("/providers/Microsoft.Workloads/sapVirtualInstances/", false);
            uri.AppendPath(sapVirtualInstanceName, true);
            uri.AppendPath("/centralInstances/", false);
            uri.AppendPath(centralInstanceName, true);
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

        /// <summary> Updates the SAP Central Instance. &lt;br&gt;&lt;br&gt;This can be used to update tags. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="patch"> The SAP Central Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/>, <paramref name="centralInstanceName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, SapCentralServerInstancePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName, patch);
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

        /// <summary> Updates the SAP Central Instance. &lt;br&gt;&lt;br&gt;This can be used to update tags. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="patch"> The SAP Central Server instance request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/>, <paramref name="centralInstanceName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, SapCentralServerInstancePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName, patch);
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

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName)
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
            uri.AppendPath("/providers/Microsoft.Workloads/sapVirtualInstances/", false);
            uri.AppendPath(sapVirtualInstanceName, true);
            uri.AppendPath("/centralInstances/", false);
            uri.AppendPath(centralInstanceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the SAP Central Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. Delete by end user will return a Bad Request error. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
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

        /// <summary> Deletes the SAP Central Instance. &lt;br&gt;&lt;br&gt;This will be used by service only. Delete by end user will return a Bad Request error. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="centralInstanceName"> Central Instance name string modeled as parameter for auto generation to work correctly. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="sapVirtualInstanceName"/> or <paramref name="centralInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, string centralInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));
            Argument.AssertNotNullOrEmpty(centralInstanceName, nameof(centralInstanceName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName, centralInstanceName);
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

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName)
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
            uri.AppendPath("/providers/Microsoft.Workloads/sapVirtualInstances/", false);
            uri.AppendPath(sapVirtualInstanceName, true);
            uri.AppendPath("/centralInstances", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the SAP Central Instances in an SVI. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SapCentralInstanceList>> ListAsync(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SapCentralInstanceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SapCentralInstanceList.DeserializeSapCentralInstanceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the SAP Central Instances in an SVI. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SapCentralInstanceList> List(string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, sapVirtualInstanceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SapCentralInstanceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SapCentralInstanceList.DeserializeSapCentralInstanceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string sapVirtualInstanceName)
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

        /// <summary> Lists the SAP Central Instances in an SVI. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SapCentralInstanceList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, sapVirtualInstanceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SapCentralInstanceList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SapCentralInstanceList.DeserializeSapCentralInstanceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the SAP Central Instances in an SVI. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="sapVirtualInstanceName"> The name of the Virtual Instances for SAP. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="sapVirtualInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SapCentralInstanceList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string sapVirtualInstanceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(sapVirtualInstanceName, nameof(sapVirtualInstanceName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, sapVirtualInstanceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SapCentralInstanceList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SapCentralInstanceList.DeserializeSapCentralInstanceList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

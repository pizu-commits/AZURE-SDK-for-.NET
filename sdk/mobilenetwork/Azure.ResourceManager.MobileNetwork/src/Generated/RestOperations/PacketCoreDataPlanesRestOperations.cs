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
using Azure.ResourceManager.MobileNetwork.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    internal partial class PacketCoreDataPlanesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PacketCoreDataPlanesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PacketCoreDataPlanesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-09-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/packetCoreDataPlanes/", false);
            uri.AppendPath(packetCoreDataPlaneName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the specified packet core data plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName);
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

        /// <summary> Deletes the specified packet core data plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName);
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

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/packetCoreDataPlanes/", false);
            uri.AppendPath(packetCoreDataPlaneName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about the specified packet core data plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PacketCoreDataPlaneData>> GetAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PacketCoreDataPlaneData.DeserializePacketCoreDataPlaneData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PacketCoreDataPlaneData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about the specified packet core data plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PacketCoreDataPlaneData> Get(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PacketCoreDataPlaneData.DeserializePacketCoreDataPlaneData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PacketCoreDataPlaneData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, PacketCoreDataPlaneData data)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/packetCoreDataPlanes/", false);
            uri.AppendPath(packetCoreDataPlaneName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<PacketCoreDataPlaneData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a packet core data plane. Must be created in the same location as its parent packet core control plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="data"> Parameters supplied to the create or update packet core data plane operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/>, <paramref name="packetCoreDataPlaneName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, PacketCoreDataPlaneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName, data);
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

        /// <summary> Creates or updates a packet core data plane. Must be created in the same location as its parent packet core control plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="data"> Parameters supplied to the create or update packet core data plane operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/>, <paramref name="packetCoreDataPlaneName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, PacketCoreDataPlaneData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName, data);
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

        internal HttpMessage CreateUpdateTagsRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, MobileNetworkTagsPatch patch)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/packetCoreDataPlanes/", false);
            uri.AppendPath(packetCoreDataPlaneName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<MobileNetworkTagsPatch>(patch, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates packet core data planes tags. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="patch"> Parameters supplied to update packet core data plane tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/>, <paramref name="packetCoreDataPlaneName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PacketCoreDataPlaneData>> UpdateTagsAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, MobileNetworkTagsPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateTagsRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PacketCoreDataPlaneData.DeserializePacketCoreDataPlaneData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates packet core data planes tags. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="packetCoreDataPlaneName"> The name of the packet core data plane. </param>
        /// <param name="patch"> Parameters supplied to update packet core data plane tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/>, <paramref name="packetCoreDataPlaneName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="packetCoreDataPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PacketCoreDataPlaneData> UpdateTags(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string packetCoreDataPlaneName, MobileNetworkTagsPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(packetCoreDataPlaneName, nameof(packetCoreDataPlaneName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateTagsRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, packetCoreDataPlaneName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PacketCoreDataPlaneData.DeserializePacketCoreDataPlaneData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPacketCoreControlPlaneRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName)
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
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/packetCoreDataPlanes", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the packet core data planes associated with a packet core control plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PacketCoreDataPlaneListResult>> ListByPacketCoreControlPlaneAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PacketCoreDataPlaneListResult.DeserializePacketCoreDataPlaneListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the packet core data planes associated with a packet core control plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PacketCoreDataPlaneListResult> ListByPacketCoreControlPlane(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PacketCoreDataPlaneListResult.DeserializePacketCoreDataPlaneListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPacketCoreControlPlaneNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName)
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

        /// <summary> Lists all the packet core data planes associated with a packet core control plane. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PacketCoreDataPlaneListResult>> ListByPacketCoreControlPlaneNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneNextPageRequest(nextLink, subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PacketCoreDataPlaneListResult.DeserializePacketCoreDataPlaneListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the packet core data planes associated with a packet core control plane. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PacketCoreDataPlaneListResult> ListByPacketCoreControlPlaneNextPage(string nextLink, string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneNextPageRequest(nextLink, subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PacketCoreDataPlaneListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PacketCoreDataPlaneListResult.DeserializePacketCoreDataPlaneListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

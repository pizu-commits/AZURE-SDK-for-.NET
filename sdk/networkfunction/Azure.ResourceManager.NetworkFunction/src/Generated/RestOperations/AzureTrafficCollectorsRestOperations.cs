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
using Azure.ResourceManager.NetworkFunction.Models;

namespace Azure.ResourceManager.NetworkFunction
{
    internal partial class AzureTrafficCollectorsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of AzureTrafficCollectorsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public AzureTrafficCollectorsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName)
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
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the specified Azure Traffic Collector in a specified resource group. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureTrafficCollectorData>> GetAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureTrafficCollectorData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureTrafficCollectorData.DeserializeAzureTrafficCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AzureTrafficCollectorData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the specified Azure Traffic Collector in a specified resource group. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureTrafficCollectorData> Get(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureTrafficCollectorData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureTrafficCollectorData.DeserializeAzureTrafficCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AzureTrafficCollectorData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, AzureTrafficCollectorData data)
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
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<AzureTrafficCollectorData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a Azure Traffic Collector resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="data"> The parameters to provide for the created Azure Traffic Collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, AzureTrafficCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, data);
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

        /// <summary> Creates or updates a Azure Traffic Collector resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="data"> The parameters to provide for the created Azure Traffic Collector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, AzureTrafficCollectorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, data);
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

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName)
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
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a specified Azure Traffic Collector resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName);
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

        /// <summary> Deletes a specified Azure Traffic Collector resource. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName);
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

        internal HttpMessage CreateUpdateTagsRequest(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, TagsObject tagsObject)
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
            uri.AppendPath("/providers/Microsoft.NetworkFunction/azureTrafficCollectors/", false);
            uri.AppendPath(azureTrafficCollectorName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<TagsObject>(tagsObject, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates the specified Azure Traffic Collector tags. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="tagsObject"> Parameters supplied to update Azure Traffic Collector tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="tagsObject"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AzureTrafficCollectorData>> UpdateTagsAsync(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, TagsObject tagsObject, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNull(tagsObject, nameof(tagsObject));

            using var message = CreateUpdateTagsRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, tagsObject);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureTrafficCollectorData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AzureTrafficCollectorData.DeserializeAzureTrafficCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates the specified Azure Traffic Collector tags. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="azureTrafficCollectorName"> Azure Traffic Collector name. </param>
        /// <param name="tagsObject"> Parameters supplied to update Azure Traffic Collector tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="azureTrafficCollectorName"/> or <paramref name="tagsObject"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="azureTrafficCollectorName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AzureTrafficCollectorData> UpdateTags(string subscriptionId, string resourceGroupName, string azureTrafficCollectorName, TagsObject tagsObject, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(azureTrafficCollectorName, nameof(azureTrafficCollectorName));
            Argument.AssertNotNull(tagsObject, nameof(tagsObject));

            using var message = CreateUpdateTagsRequest(subscriptionId, resourceGroupName, azureTrafficCollectorName, tagsObject);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AzureTrafficCollectorData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AzureTrafficCollectorData.DeserializeAzureTrafficCollectorData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

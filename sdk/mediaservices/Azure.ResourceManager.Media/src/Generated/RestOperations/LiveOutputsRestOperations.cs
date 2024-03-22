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
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media
{
    internal partial class LiveOutputsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of LiveOutputsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public LiveOutputsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string accountName, string liveEventName)
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
            uri.AppendPath("/providers/Microsoft.Media/mediaservices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/liveEvents/", false);
            uri.AppendPath(liveEventName, true);
            uri.AppendPath("/liveOutputs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists the live outputs of a live event. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LiveOutputListResult>> ListAsync(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, liveEventName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LiveOutputListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LiveOutputListResult.DeserializeLiveOutputListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the live outputs of a live event. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LiveOutputListResult> List(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, accountName, liveEventName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LiveOutputListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LiveOutputListResult.DeserializeLiveOutputListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName)
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
            uri.AppendPath("/providers/Microsoft.Media/mediaservices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/liveEvents/", false);
            uri.AppendPath(liveEventName, true);
            uri.AppendPath("/liveOutputs/", false);
            uri.AppendPath(liveOutputName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a live output. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MediaLiveOutputData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaLiveOutputData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaLiveOutputData.DeserializeMediaLiveOutputData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MediaLiveOutputData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a live output. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MediaLiveOutputData> Get(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaLiveOutputData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaLiveOutputData.DeserializeMediaLiveOutputData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MediaLiveOutputData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName, MediaLiveOutputData data)
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
            uri.AppendPath("/providers/Microsoft.Media/mediaservices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/liveEvents/", false);
            uri.AppendPath(liveEventName, true);
            uri.AppendPath("/liveOutputs/", false);
            uri.AppendPath(liveOutputName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<MediaLiveOutputData>(data, new ModelReaderWriterOptions("W"));
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a new live output. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="data"> Live Output properties needed for creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/>, <paramref name="liveOutputName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName, MediaLiveOutputData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName, data);
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

        /// <summary> Creates a new live output. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="data"> Live Output properties needed for creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/>, <paramref name="liveOutputName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName, MediaLiveOutputData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName, data);
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

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName)
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
            uri.AppendPath("/providers/Microsoft.Media/mediaservices/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/liveEvents/", false);
            uri.AppendPath(liveEventName, true);
            uri.AppendPath("/liveOutputs/", false);
            uri.AppendPath(liveOutputName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a live output. Deleting a live output does not delete the asset the live output is writing to. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName);
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

        /// <summary> Deletes a live output. Deleting a live output does not delete the asset the live output is writing to. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="liveOutputName"> The name of the live output. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="liveEventName"/> or <paramref name="liveOutputName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string accountName, string liveEventName, string liveOutputName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));
            Argument.AssertNotNullOrEmpty(liveOutputName, nameof(liveOutputName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, liveEventName, liveOutputName);
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

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string liveEventName)
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

        /// <summary> Lists the live outputs of a live event. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LiveOutputListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, liveEventName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LiveOutputListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LiveOutputListResult.DeserializeLiveOutputListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists the live outputs of a live event. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group within the Azure subscription. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="liveEventName"> The name of the live event, maximum length is 32. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="liveEventName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LiveOutputListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string liveEventName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(liveEventName, nameof(liveEventName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, liveEventName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LiveOutputListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LiveOutputListResult.DeserializeLiveOutputListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

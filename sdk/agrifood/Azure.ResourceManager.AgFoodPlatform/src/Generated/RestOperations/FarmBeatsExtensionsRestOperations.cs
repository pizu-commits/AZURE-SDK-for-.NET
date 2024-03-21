// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AgFoodPlatform.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    internal partial class FarmBeatsExtensionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of FarmBeatsExtensionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public FarmBeatsExtensionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(IEnumerable<string> farmBeatsExtensionIds, IEnumerable<string> farmBeatsExtensionNames, IEnumerable<string> extensionCategories, IEnumerable<string> publisherIds, int? maxPageSize)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions", false);
            if (farmBeatsExtensionIds != null && !(farmBeatsExtensionIds is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                foreach (var param in farmBeatsExtensionIds)
                {
                    uri.AppendQuery("farmBeatsExtensionIds", param, true);
                }
            }
            if (farmBeatsExtensionNames != null && !(farmBeatsExtensionNames is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var param in farmBeatsExtensionNames)
                {
                    uri.AppendQuery("farmBeatsExtensionNames", param, true);
                }
            }
            if (extensionCategories != null && !(extensionCategories is ChangeTrackingList<string> changeTrackingList1 && changeTrackingList1.IsUndefined))
            {
                foreach (var param in extensionCategories)
                {
                    uri.AppendQuery("extensionCategories", param, true);
                }
            }
            if (publisherIds != null && !(publisherIds is ChangeTrackingList<string> changeTrackingList2 && changeTrackingList2.IsUndefined))
            {
                foreach (var param in publisherIds)
                {
                    uri.AppendQuery("publisherIds", param, true);
                }
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<FarmBeatsExtensionListResponse>> ListAsync(IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<FarmBeatsExtensionListResponse> List(IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string farmBeatsExtensionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/", false);
            uri.AppendPath(farmBeatsExtensionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FarmBeatsExtensionData>> GetAsync(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsExtensionId, nameof(farmBeatsExtensionId));

            using var message = CreateGetRequest(farmBeatsExtensionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FarmBeatsExtensionData.DeserializeFarmBeatsExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FarmBeatsExtensionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get farmBeats extension. </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FarmBeatsExtensionData> Get(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(farmBeatsExtensionId, nameof(farmBeatsExtensionId));

            using var message = CreateGetRequest(farmBeatsExtensionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FarmBeatsExtensionData.DeserializeFarmBeatsExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FarmBeatsExtensionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, IEnumerable<string> farmBeatsExtensionIds, IEnumerable<string> farmBeatsExtensionNames, IEnumerable<string> extensionCategories, IEnumerable<string> publisherIds, int? maxPageSize)
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

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<FarmBeatsExtensionListResponse>> ListNextPageAsync(string nextLink, IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink, farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get list of farmBeats extension. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="farmBeatsExtensionIds"> FarmBeatsExtension ids. </param>
        /// <param name="farmBeatsExtensionNames"> FarmBeats extension names. </param>
        /// <param name="extensionCategories"> Extension categories. </param>
        /// <param name="publisherIds"> Publisher ids. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<FarmBeatsExtensionListResponse> ListNextPage(string nextLink, IEnumerable<string> farmBeatsExtensionIds = null, IEnumerable<string> farmBeatsExtensionNames = null, IEnumerable<string> extensionCategories = null, IEnumerable<string> publisherIds = null, int? maxPageSize = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListNextPageRequest(nextLink, farmBeatsExtensionIds, farmBeatsExtensionNames, extensionCategories, publisherIds, maxPageSize);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FarmBeatsExtensionListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FarmBeatsExtensionListResponse.DeserializeFarmBeatsExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    /// <summary> The Attachments service client. </summary>
    public partial class AttachmentsClient
    {
        private static readonly string[] AuthorizationScopes = { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of AttachmentsClient for mocking. </summary>
        protected AttachmentsClient()
        {
        }

        /// <summary> Initializes a new instance of AttachmentsClient. </summary>
        /// <param name="endpoint"> The endpoint of your FarmBeats resource (protocol and hostname, for example: https://{resourceName}.farmbeats.azure.net). </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public AttachmentsClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new FarmBeatsClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Gets a specified attachment resource under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the associated farmer. </param>
        /// <param name="attachmentId"> ID of the attachment. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   originalFileName: string,
        ///   id: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   eTag: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetAsync(string farmerId, string attachmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.Get");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetRequest(farmerId, attachmentId);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a specified attachment resource under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the associated farmer. </param>
        /// <param name="attachmentId"> ID of the attachment. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   originalFileName: string,
        ///   id: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   eTag: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Get(string farmerId, string attachmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.Get");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetRequest(farmerId, attachmentId);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an attachment resource under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the associated farmer resource. </param>
        /// <param name="attachmentId"> ID of the attachment resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   originalFileName: string,
        ///   id: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   eTag: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateAsync(string farmerId, string attachmentId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(farmerId, attachmentId, content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an attachment resource under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the associated farmer resource. </param>
        /// <param name="attachmentId"> ID of the attachment resource. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   farmerId: string,
        ///   resourceId: string,
        ///   resourceType: string,
        ///   originalFileName: string,
        ///   id: string,
        ///   status: string,
        ///   createdDateTime: string (ISO 8601 Format),
        ///   modifiedDateTime: string (ISO 8601 Format),
        ///   name: string,
        ///   description: string,
        ///   eTag: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdate(string farmerId, string attachmentId, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateRequest(farmerId, attachmentId, content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a specified attachment resource under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the farmer. </param>
        /// <param name="attachmentId"> ID of the attachment. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteAsync(string farmerId, string attachmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(farmerId, attachmentId);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a specified attachment resource under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the farmer. </param>
        /// <param name="attachmentId"> ID of the attachment. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Delete(string farmerId, string attachmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.Delete");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteRequest(farmerId, attachmentId);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Downloads and returns attachment as response for the given input filePath. </summary>
        /// <param name="farmerId"> ID of the associated farmer. </param>
        /// <param name="attachmentId"> ID of attachment to be downloaded. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DownloadAsync(string farmerId, string attachmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.Download");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDownloadRequest(farmerId, attachmentId);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Downloads and returns attachment as response for the given input filePath. </summary>
        /// <param name="farmerId"> ID of the associated farmer. </param>
        /// <param name="attachmentId"> ID of attachment to be downloaded. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> or <paramref name="attachmentId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response Download(string farmerId, string attachmentId, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("AttachmentsClient.Download");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDownloadRequest(farmerId, attachmentId);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns a paginated list of attachment resources under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the associated farmer. </param>
        /// <param name="resourceIds"> Resource Ids of the resource. </param>
        /// <param name="resourceTypes"> Resource Types of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       farmerId: string,
        ///       resourceId: string,
        ///       resourceType: string,
        ///       originalFileName: string,
        ///       id: string,
        ///       status: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format),
        ///       name: string,
        ///       description: string,
        ///       eTag: string
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual AsyncPageable<BinaryData> ListByFarmerIdAsync(string farmerId, IEnumerable<string> resourceIds = null, IEnumerable<string> resourceTypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            if (farmerId == null)
            {
                throw new ArgumentNullException(nameof(farmerId));
            }

            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, _clientDiagnostics, "AttachmentsClient.ListByFarmerId");
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateListByFarmerIdRequest(farmerId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken)
                        : CreateListByFarmerIdNextPageRequest(nextLink, farmerId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, _clientDiagnostics, options, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Returns a paginated list of attachment resources under a particular farmer. </summary>
        /// <param name="farmerId"> ID of the associated farmer. </param>
        /// <param name="resourceIds"> Resource Ids of the resource. </param>
        /// <param name="resourceTypes"> Resource Types of the resource. </param>
        /// <param name="ids"> Ids of the resource. </param>
        /// <param name="names"> Names of the resource. </param>
        /// <param name="propertyFilters">
        /// Filters on key-value pairs within the Properties object.
        /// eg. &quot;{testKey} eq {testValue}&quot;.
        /// </param>
        /// <param name="statuses"> Statuses of the resource. </param>
        /// <param name="minCreatedDateTime"> Minimum creation date of resource (inclusive). </param>
        /// <param name="maxCreatedDateTime"> Maximum creation date of resource (inclusive). </param>
        /// <param name="minLastModifiedDateTime"> Minimum last modified date of resource (inclusive). </param>
        /// <param name="maxLastModifiedDateTime"> Maximum last modified date of resource (inclusive). </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmerId"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   value: [
        ///     {
        ///       farmerId: string,
        ///       resourceId: string,
        ///       resourceType: string,
        ///       originalFileName: string,
        ///       id: string,
        ///       status: string,
        ///       createdDateTime: string (ISO 8601 Format),
        ///       modifiedDateTime: string (ISO 8601 Format),
        ///       name: string,
        ///       description: string,
        ///       eTag: string
        ///     }
        ///   ],
        ///   $skipToken: string,
        ///   nextLink: string
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     message: string,
        ///     target: string,
        ///     details: [Error],
        ///     innererror: {
        ///       code: string,
        ///       innererror: InnerError
        ///     }
        ///   },
        ///   traceId: string
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Pageable<BinaryData> ListByFarmerId(string farmerId, IEnumerable<string> resourceIds = null, IEnumerable<string> resourceTypes = null, IEnumerable<string> ids = null, IEnumerable<string> names = null, IEnumerable<string> propertyFilters = null, IEnumerable<string> statuses = null, DateTimeOffset? minCreatedDateTime = null, DateTimeOffset? maxCreatedDateTime = null, DateTimeOffset? minLastModifiedDateTime = null, DateTimeOffset? maxLastModifiedDateTime = null, int? maxPageSize = null, string skipToken = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            if (farmerId == null)
            {
                throw new ArgumentNullException(nameof(farmerId));
            }

            return PageableHelpers.CreatePageable(CreateEnumerable, _clientDiagnostics, "AttachmentsClient.ListByFarmerId");
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateListByFarmerIdRequest(farmerId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken)
                        : CreateListByFarmerIdNextPageRequest(nextLink, farmerId, resourceIds, resourceTypes, ids, names, propertyFilters, statuses, minCreatedDateTime, maxCreatedDateTime, minLastModifiedDateTime, maxLastModifiedDateTime, maxPageSize, skipToken);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, _clientDiagnostics, options, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateListByFarmerIdRequest(string farmerId, IEnumerable<string> resourceIds, IEnumerable<string> resourceTypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/farmers/", false);
            uri.AppendPath(farmerId, true);
            uri.AppendPath("/attachments", false);
            if (resourceIds != null)
            {
                foreach (var param in resourceIds)
                {
                    uri.AppendQuery("resourceIds", param, true);
                }
            }
            if (resourceTypes != null)
            {
                foreach (var param in resourceTypes)
                {
                    uri.AppendQuery("resourceTypes", param, true);
                }
            }
            if (ids != null)
            {
                foreach (var param in ids)
                {
                    uri.AppendQuery("ids", param, true);
                }
            }
            if (names != null)
            {
                foreach (var param in names)
                {
                    uri.AppendQuery("names", param, true);
                }
            }
            if (propertyFilters != null)
            {
                foreach (var param in propertyFilters)
                {
                    uri.AppendQuery("propertyFilters", param, true);
                }
            }
            if (statuses != null)
            {
                foreach (var param in statuses)
                {
                    uri.AppendQuery("statuses", param, true);
                }
            }
            if (minCreatedDateTime != null)
            {
                uri.AppendQuery("minCreatedDateTime", minCreatedDateTime.Value, "O", true);
            }
            if (maxCreatedDateTime != null)
            {
                uri.AppendQuery("maxCreatedDateTime", maxCreatedDateTime.Value, "O", true);
            }
            if (minLastModifiedDateTime != null)
            {
                uri.AppendQuery("minLastModifiedDateTime", minLastModifiedDateTime.Value, "O", true);
            }
            if (maxLastModifiedDateTime != null)
            {
                uri.AppendQuery("maxLastModifiedDateTime", maxLastModifiedDateTime.Value, "O", true);
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetRequest(string farmerId, string attachmentId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/farmers/", false);
            uri.AppendPath(farmerId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string farmerId, string attachmentId, RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/farmers/", false);
            uri.AppendPath(farmerId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "multipart/form-data");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200201.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteRequest(string farmerId, string attachmentId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/farmers/", false);
            uri.AppendPath(farmerId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier204.Instance;
            return message;
        }

        internal HttpMessage CreateDownloadRequest(string farmerId, string attachmentId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/farmers/", false);
            uri.AppendPath(farmerId, true);
            uri.AppendPath("/attachments/", false);
            uri.AppendPath(attachmentId, true);
            uri.AppendPath("/file", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/octet-stream, application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateListByFarmerIdNextPageRequest(string nextLink, string farmerId, IEnumerable<string> resourceIds, IEnumerable<string> resourceTypes, IEnumerable<string> ids, IEnumerable<string> names, IEnumerable<string> propertyFilters, IEnumerable<string> statuses, DateTimeOffset? minCreatedDateTime, DateTimeOffset? maxCreatedDateTime, DateTimeOffset? minLastModifiedDateTime, DateTimeOffset? maxLastModifiedDateTime, int? maxPageSize, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier200201 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200201();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    201 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier204 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier204();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    204 => false,
                    _ => true
                };
            }
        }
    }
}

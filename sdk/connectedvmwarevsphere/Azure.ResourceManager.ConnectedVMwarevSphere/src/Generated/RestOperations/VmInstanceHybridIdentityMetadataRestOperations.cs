// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    internal partial class VmInstanceHybridIdentityMetadataRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VmInstanceHybridIdentityMetadataRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VmInstanceHybridIdentityMetadataRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-12-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/hybridIdentityMetadata/default", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<VmInstanceHybridIdentityMetadataData>> GetAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateGetRequest(resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VmInstanceHybridIdentityMetadataData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VmInstanceHybridIdentityMetadataData.DeserializeVmInstanceHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VmInstanceHybridIdentityMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Implements HybridIdentityMetadata GET method. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<VmInstanceHybridIdentityMetadataData> Get(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateGetRequest(resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VmInstanceHybridIdentityMetadataData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VmInstanceHybridIdentityMetadataData.DeserializeVmInstanceHybridIdentityMetadataData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VmInstanceHybridIdentityMetadataData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListRequestUri(string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/hybridIdentityMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateListRequest(string resourceUri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(resourceUri, false);
            uri.AppendPath("/providers/Microsoft.ConnectedVMwarevSphere/virtualMachineInstances/default/hybridIdentityMetadata", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<VmInstanceHybridIdentityMetadataList>> ListAsync(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VmInstanceHybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VmInstanceHybridIdentityMetadataList.DeserializeVmInstanceHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceUri"/> is null. </exception>
        public Response<VmInstanceHybridIdentityMetadataList> List(string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListRequest(resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VmInstanceHybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VmInstanceHybridIdentityMetadataList.DeserializeVmInstanceHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string resourceUri)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string resourceUri)
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

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public async Task<Response<VmInstanceHybridIdentityMetadataList>> ListNextPageAsync(string nextLink, string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListNextPageRequest(nextLink, resourceUri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VmInstanceHybridIdentityMetadataList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VmInstanceHybridIdentityMetadataList.DeserializeVmInstanceHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the list of HybridIdentityMetadata of the given vm. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceUri"> The fully qualified Azure Resource manager identifier of the Hybrid Compute machine resource to be extended. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceUri"/> is null. </exception>
        public Response<VmInstanceHybridIdentityMetadataList> ListNextPage(string nextLink, string resourceUri, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNull(resourceUri, nameof(resourceUri));

            using var message = CreateListNextPageRequest(nextLink, resourceUri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VmInstanceHybridIdentityMetadataList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VmInstanceHybridIdentityMetadataList.DeserializeVmInstanceHybridIdentityMetadataList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

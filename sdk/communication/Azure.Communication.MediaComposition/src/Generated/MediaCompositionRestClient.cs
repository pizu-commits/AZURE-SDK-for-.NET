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

namespace Azure.Communication.MediaComposition
{
    internal partial class MediaCompositionRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MediaCompositionRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public MediaCompositionRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            this.endpoint = endpoint ?? new Uri("");
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string mediaCompositionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediaCompositions/", false);
            uri.AppendPath(mediaCompositionId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public async Task<Response<MediaCompositionBody>> GetAsync(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateGetRequest(mediaCompositionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaCompositionBody value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaCompositionBody.DeserializeMediaCompositionBody(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public Response<MediaCompositionBody> Get(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateGetRequest(mediaCompositionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaCompositionBody value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaCompositionBody.DeserializeMediaCompositionBody(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string mediaCompositionId, MediaCompositionBody body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediaCompositions/", false);
            uri.AppendPath(mediaCompositionId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="body"> The MediaCompositionBody to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public async Task<Response<MediaCompositionBody>> CreateAsync(string mediaCompositionId, MediaCompositionBody body = null, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateCreateRequest(mediaCompositionId, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaCompositionBody value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaCompositionBody.DeserializeMediaCompositionBody(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="body"> The MediaCompositionBody to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public Response<MediaCompositionBody> Create(string mediaCompositionId, MediaCompositionBody body = null, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateCreateRequest(mediaCompositionId, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaCompositionBody value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaCompositionBody.DeserializeMediaCompositionBody(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string mediaCompositionId, MediaCompositionBody body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediaCompositions/", false);
            uri.AppendPath(mediaCompositionId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (body != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="body"> The MediaCompositionBody to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public async Task<Response<MediaCompositionBody>> UpdateAsync(string mediaCompositionId, MediaCompositionBody body = null, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateUpdateRequest(mediaCompositionId, body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaCompositionBody value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaCompositionBody.DeserializeMediaCompositionBody(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="body"> The MediaCompositionBody to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public Response<MediaCompositionBody> Update(string mediaCompositionId, MediaCompositionBody body = null, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateUpdateRequest(mediaCompositionId, body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaCompositionBody value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaCompositionBody.DeserializeMediaCompositionBody(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string mediaCompositionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediaCompositions/", false);
            uri.AppendPath(mediaCompositionId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public async Task<Response> DeleteAsync(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateDeleteRequest(mediaCompositionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public Response Delete(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateDeleteRequest(mediaCompositionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStartRequest(string mediaCompositionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediaCompositions/", false);
            uri.AppendPath(mediaCompositionId, true);
            uri.AppendPath("/start", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public async Task<Response<CompositionStreamState>> StartAsync(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateStartRequest(mediaCompositionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CompositionStreamState value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = new CompositionStreamState(document.RootElement.GetString());
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public Response<CompositionStreamState> Start(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateStartRequest(mediaCompositionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CompositionStreamState value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = new CompositionStreamState(document.RootElement.GetString());
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateStopRequest(string mediaCompositionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/mediaCompositions/", false);
            uri.AppendPath(mediaCompositionId, true);
            uri.AppendPath("/stop", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public async Task<Response<CompositionStreamState>> StopAsync(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateStopRequest(mediaCompositionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CompositionStreamState value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = new CompositionStreamState(document.RootElement.GetString());
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="mediaCompositionId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mediaCompositionId"/> is null. </exception>
        public Response<CompositionStreamState> Stop(string mediaCompositionId, CancellationToken cancellationToken = default)
        {
            if (mediaCompositionId == null)
            {
                throw new ArgumentNullException(nameof(mediaCompositionId));
            }

            using var message = CreateStopRequest(mediaCompositionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CompositionStreamState value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = new CompositionStreamState(document.RootElement.GetString());
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}

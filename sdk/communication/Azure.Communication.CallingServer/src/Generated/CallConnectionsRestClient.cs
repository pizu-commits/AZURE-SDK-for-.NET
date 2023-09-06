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

namespace Azure.Communication.CallingServer
{
    internal partial class CallConnectionsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of CallConnectionsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public CallConnectionsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2022-04-07-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetCallRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get call connection. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response<CallConnectionPropertiesInternal>> GetCallAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateGetCallRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get call connection. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response<CallConnectionPropertiesInternal> GetCall(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateGetCallRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CallConnectionPropertiesInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CallConnectionPropertiesInternal.DeserializeCallConnectionPropertiesInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateHangupCallRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary> Hangup the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response> HangupCallAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateHangupCallRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Hangup the call. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response HangupCall(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateHangupCallRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateTerminateCallRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":terminate", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            return message;
        }

        /// <summary> Terminate a call using CallConnectionId. </summary>
        /// <param name="callConnectionId"> The terminate call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response> TerminateCallAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateTerminateCallRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Terminate a call using CallConnectionId. </summary>
        /// <param name="callConnectionId"> The terminate call request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response TerminateCall(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateTerminateCallRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateTransferToParticipantRequest(string callConnectionId, TransferToParticipantRequestInternal transferToParticipantRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath(":transferToParticipant", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = transferToParticipantRequest;
            return message;
        }

        /// <summary> Transfer the call to a participant. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="transferToParticipantRequest"> The transfer to participant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="transferToParticipantRequest"/> is null. </exception>
        public async Task<Response<TransferCallToParticipantResult>> TransferToParticipantAsync(string callConnectionId, TransferToParticipantRequestInternal transferToParticipantRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (transferToParticipantRequest == null)
            {
                throw new ArgumentNullException(nameof(transferToParticipantRequest));
            }

            using var message = CreateTransferToParticipantRequest(callConnectionId, transferToParticipantRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        TransferCallToParticipantResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TransferCallToParticipantResult.DeserializeTransferCallToParticipantResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Transfer the call to a participant. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="transferToParticipantRequest"> The transfer to participant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="transferToParticipantRequest"/> is null. </exception>
        public Response<TransferCallToParticipantResult> TransferToParticipant(string callConnectionId, TransferToParticipantRequestInternal transferToParticipantRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (transferToParticipantRequest == null)
            {
                throw new ArgumentNullException(nameof(transferToParticipantRequest));
            }

            using var message = CreateTransferToParticipantRequest(callConnectionId, transferToParticipantRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        TransferCallToParticipantResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TransferCallToParticipantResult.DeserializeTransferCallToParticipantResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetParticipantsRequest(string callConnectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/participants", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get participants from a call. </summary>
        /// <param name="callConnectionId"> The call connection Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public async Task<Response<GetParticipantsResponseInternal>> GetParticipantsAsync(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateGetParticipantsRequest(callConnectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetParticipantsResponseInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = GetParticipantsResponseInternal.DeserializeGetParticipantsResponseInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get participants from a call. </summary>
        /// <param name="callConnectionId"> The call connection Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> is null. </exception>
        public Response<GetParticipantsResponseInternal> GetParticipants(string callConnectionId, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }

            using var message = CreateGetParticipantsRequest(callConnectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetParticipantsResponseInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = GetParticipantsResponseInternal.DeserializeGetParticipantsResponseInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAddParticipantRequest(string callConnectionId, AddParticipantsRequestInternal addParticipantsRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/participants:add", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = addParticipantsRequest;
            return message;
        }

        /// <summary> Add participants to the call. </summary>
        /// <param name="callConnectionId"> The call connection Id. </param>
        /// <param name="addParticipantsRequest"> The add participants request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="addParticipantsRequest"/> is null. </exception>
        public async Task<Response<AddParticipantsResponseInternal>> AddParticipantAsync(string callConnectionId, AddParticipantsRequestInternal addParticipantsRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (addParticipantsRequest == null)
            {
                throw new ArgumentNullException(nameof(addParticipantsRequest));
            }

            using var message = CreateAddParticipantRequest(callConnectionId, addParticipantsRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        AddParticipantsResponseInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AddParticipantsResponseInternal.DeserializeAddParticipantsResponseInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Add participants to the call. </summary>
        /// <param name="callConnectionId"> The call connection Id. </param>
        /// <param name="addParticipantsRequest"> The add participants request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="addParticipantsRequest"/> is null. </exception>
        public Response<AddParticipantsResponseInternal> AddParticipant(string callConnectionId, AddParticipantsRequestInternal addParticipantsRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (addParticipantsRequest == null)
            {
                throw new ArgumentNullException(nameof(addParticipantsRequest));
            }

            using var message = CreateAddParticipantRequest(callConnectionId, addParticipantsRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        AddParticipantsResponseInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AddParticipantsResponseInternal.DeserializeAddParticipantsResponseInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRemoveParticipantsRequest(string callConnectionId, RemoveParticipantsRequestInternal removeParticipantsRequest)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/participants:remove", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = removeParticipantsRequest;
            return message;
        }

        /// <summary> Remove participant from the call using identifier. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="removeParticipantsRequest"> The participants to be removed from the call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="removeParticipantsRequest"/> is null. </exception>
        public async Task<Response<RemoveParticipantsResult>> RemoveParticipantsAsync(string callConnectionId, RemoveParticipantsRequestInternal removeParticipantsRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (removeParticipantsRequest == null)
            {
                throw new ArgumentNullException(nameof(removeParticipantsRequest));
            }

            using var message = CreateRemoveParticipantsRequest(callConnectionId, removeParticipantsRequest);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        RemoveParticipantsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RemoveParticipantsResult.DeserializeRemoveParticipantsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Remove participant from the call using identifier. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="removeParticipantsRequest"> The participants to be removed from the call. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="removeParticipantsRequest"/> is null. </exception>
        public Response<RemoveParticipantsResult> RemoveParticipants(string callConnectionId, RemoveParticipantsRequestInternal removeParticipantsRequest, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (removeParticipantsRequest == null)
            {
                throw new ArgumentNullException(nameof(removeParticipantsRequest));
            }

            using var message = CreateRemoveParticipantsRequest(callConnectionId, removeParticipantsRequest);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        RemoveParticipantsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RemoveParticipantsResult.DeserializeRemoveParticipantsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetParticipantRequest(string callConnectionId, string participantMri)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/calling/callConnections/", false);
            uri.AppendPath(callConnectionId, true);
            uri.AppendPath("/participants/", false);
            uri.AppendPath(participantMri, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get participant from a call. </summary>
        /// <param name="callConnectionId"> The call connection Id. </param>
        /// <param name="participantMri"> MRI of the participants to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="participantMri"/> is null. </exception>
        public async Task<Response<AcsCallParticipantInternal>> GetParticipantAsync(string callConnectionId, string participantMri, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (participantMri == null)
            {
                throw new ArgumentNullException(nameof(participantMri));
            }

            using var message = CreateGetParticipantRequest(callConnectionId, participantMri);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcsCallParticipantInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AcsCallParticipantInternal.DeserializeAcsCallParticipantInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get participant from a call. </summary>
        /// <param name="callConnectionId"> The call connection Id. </param>
        /// <param name="participantMri"> MRI of the participants to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="callConnectionId"/> or <paramref name="participantMri"/> is null. </exception>
        public Response<AcsCallParticipantInternal> GetParticipant(string callConnectionId, string participantMri, CancellationToken cancellationToken = default)
        {
            if (callConnectionId == null)
            {
                throw new ArgumentNullException(nameof(callConnectionId));
            }
            if (participantMri == null)
            {
                throw new ArgumentNullException(nameof(participantMri));
            }

            using var message = CreateGetParticipantRequest(callConnectionId, participantMri);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AcsCallParticipantInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AcsCallParticipantInternal.DeserializeAcsCallParticipantInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

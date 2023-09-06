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

namespace Azure.Security.Attestation
{
    internal partial class AttestationRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _instanceUrl;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AttestationRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="instanceUrl"> The attestation instance base URI, for example https://mytenant.attest.azure.net. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="instanceUrl"/> or <paramref name="apiVersion"/> is null. </exception>
        public AttestationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string instanceUrl, string apiVersion = "2020-10-01")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _instanceUrl = instanceUrl ?? throw new ArgumentNullException(nameof(instanceUrl));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateAttestOpenEnclaveRequest(AttestOpenEnclaveRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_instanceUrl, false);
            uri.AppendPath("/attest/OpenEnclave", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            request0.Content = request;
            return message;
        }

        /// <summary> Attest to an SGX enclave. </summary>
        /// <param name="request"> Request object containing the quote. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        /// <remarks> Processes an OpenEnclave report , producing an artifact. The type of artifact produced is dependent upon attestation policy. </remarks>
        public async Task<Response<AttestationResponse>> AttestOpenEnclaveAsync(AttestOpenEnclaveRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAttestOpenEnclaveRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AttestationResponse.DeserializeAttestationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Attest to an SGX enclave. </summary>
        /// <param name="request"> Request object containing the quote. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        /// <remarks> Processes an OpenEnclave report , producing an artifact. The type of artifact produced is dependent upon attestation policy. </remarks>
        public Response<AttestationResponse> AttestOpenEnclave(AttestOpenEnclaveRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAttestOpenEnclaveRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AttestationResponse.DeserializeAttestationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAttestSgxEnclaveRequest(AttestSgxEnclaveRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_instanceUrl, false);
            uri.AppendPath("/attest/SgxEnclave", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            request0.Content = request;
            return message;
        }

        /// <summary> Attest to an SGX enclave. </summary>
        /// <param name="request"> Request object containing the quote. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        /// <remarks> Processes an SGX enclave quote, producing an artifact. The type of artifact produced is dependent upon attestation policy. </remarks>
        public async Task<Response<AttestationResponse>> AttestSgxEnclaveAsync(AttestSgxEnclaveRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAttestSgxEnclaveRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AttestationResponse.DeserializeAttestationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Attest to an SGX enclave. </summary>
        /// <param name="request"> Request object containing the quote. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        /// <remarks> Processes an SGX enclave quote, producing an artifact. The type of artifact produced is dependent upon attestation policy. </remarks>
        public Response<AttestationResponse> AttestSgxEnclave(AttestSgxEnclaveRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAttestSgxEnclaveRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AttestationResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AttestationResponse.DeserializeAttestationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateAttestTpmRequest(TpmAttestationRequest request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_instanceUrl, false);
            uri.AppendPath("/attest/Tpm", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            request0.Content = request;
            return message;
        }

        /// <summary> Attest a Virtualization-based Security (VBS) enclave. </summary>
        /// <param name="request"> Request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        /// <remarks> Processes attestation evidence from a VBS enclave, producing an attestation result. The attestation result produced is dependent upon the attestation policy. </remarks>
        public async Task<Response<TpmAttestationResponse>> AttestTpmAsync(TpmAttestationRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAttestTpmRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TpmAttestationResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TpmAttestationResponse.DeserializeTpmAttestationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Attest a Virtualization-based Security (VBS) enclave. </summary>
        /// <param name="request"> Request object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/> is null. </exception>
        /// <remarks> Processes attestation evidence from a VBS enclave, producing an attestation result. The attestation result produced is dependent upon the attestation policy. </remarks>
        public Response<TpmAttestationResponse> AttestTpm(TpmAttestationRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            using var message = CreateAttestTpmRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TpmAttestationResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TpmAttestationResponse.DeserializeTpmAttestationResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

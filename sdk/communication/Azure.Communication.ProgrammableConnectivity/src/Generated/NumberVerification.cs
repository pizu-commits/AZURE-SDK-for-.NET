// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.ProgrammableConnectivity
{
    // Data plane generated sub-client.
    /// <summary> The NumberVerification sub-client. </summary>
    public partial class NumberVerification
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://management.azure.com//.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of NumberVerification for mocking. </summary>
        protected NumberVerification()
        {
        }

        /// <summary> Initializes a new instance of NumberVerification. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="tokenCredential"> The token credential to copy. </param>
        /// <param name="endpoint"> An Azure Programmable Connectivity Endpoint providing access to Network APIs, for example https://{region}.apcgatewayapi.azure.com. </param>
        /// <param name="apiVersion"> The <see cref="string"/> to use. </param>
        internal NumberVerification(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, TokenCredential tokenCredential, Uri endpoint, string apiVersion)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _tokenCredential = tokenCredential;
            _endpoint = endpoint;
            _apiVersion = apiVersion;
        }

        /// <summary> Verifies the phone number (MSISDN) associated with a device. </summary>
        /// <param name="apcGatewayId"> The <see cref="string"/> to use. </param>
        /// <param name="body"> The <see cref="NumberVerificationWithCodeContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="body"/> is null. </exception>
        /// <include file="Docs/NumberVerification.xml" path="doc/members/member[@name='VerifyWithCodeAsync(string,NumberVerificationWithCodeContent,CancellationToken)']/*" />
        public virtual async Task<Response<NumberVerificationResult>> VerifyWithCodeAsync(string apcGatewayId, NumberVerificationWithCodeContent body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await VerifyWithCodeAsync(apcGatewayId, content, context).ConfigureAwait(false);
            return Response.FromValue(NumberVerificationResult.FromResponse(response), response);
        }

        /// <summary> Verifies the phone number (MSISDN) associated with a device. </summary>
        /// <param name="apcGatewayId"> The <see cref="string"/> to use. </param>
        /// <param name="body"> The <see cref="NumberVerificationWithCodeContent"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="body"/> is null. </exception>
        /// <include file="Docs/NumberVerification.xml" path="doc/members/member[@name='VerifyWithCode(string,NumberVerificationWithCodeContent,CancellationToken)']/*" />
        public virtual Response<NumberVerificationResult> VerifyWithCode(string apcGatewayId, NumberVerificationWithCodeContent body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = VerifyWithCode(apcGatewayId, content, context);
            return Response.FromValue(NumberVerificationResult.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] Verifies the phone number (MSISDN) associated with a device.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="VerifyWithCodeAsync(string,NumberVerificationWithCodeContent,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apcGatewayId"> The <see cref="string"/> to use. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/NumberVerification.xml" path="doc/members/member[@name='VerifyWithCodeAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> VerifyWithCodeAsync(string apcGatewayId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("NumberVerification.VerifyWithCode");
            scope.Start();
            try
            {
                using HttpMessage message = CreateVerifyWithCodeRequest(apcGatewayId, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Verifies the phone number (MSISDN) associated with a device.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="VerifyWithCode(string,NumberVerificationWithCodeContent,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="apcGatewayId"> The <see cref="string"/> to use. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apcGatewayId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/NumberVerification.xml" path="doc/members/member[@name='VerifyWithCode(string,RequestContent,RequestContext)']/*" />
        public virtual Response VerifyWithCode(string apcGatewayId, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(apcGatewayId, nameof(apcGatewayId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("NumberVerification.VerifyWithCode");
            scope.Start();
            try
            {
                using HttpMessage message = CreateVerifyWithCodeRequest(apcGatewayId, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateVerifyWithoutCodeRequest(string apcGatewayId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier302);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/number-verification/number:verify", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("apc-gateway-id", apcGatewayId);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateVerifyWithCodeRequest(string apcGatewayId, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/number-verification/number:verify", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("apc-gateway-id", apcGatewayId);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier302;
        private static ResponseClassifier ResponseClassifier302 => _responseClassifier302 ??= new StatusCodeClassifier(stackalloc ushort[] { 302 });
        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}

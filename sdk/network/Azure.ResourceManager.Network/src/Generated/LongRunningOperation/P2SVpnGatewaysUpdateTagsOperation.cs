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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Updates virtual wan p2s vpn gateway tags. </summary>
    public partial class P2SVpnGatewaysUpdateTagsOperation : Operation<P2SVpnGateway>, IOperationSource<P2SVpnGateway>
    {
        private readonly OperationInternals<P2SVpnGateway> _operation;

        private readonly ResourceOperations _operationBase;

        /// <summary> Initializes a new instance of P2SVpnGatewaysUpdateTagsOperation for mocking. </summary>
        protected P2SVpnGatewaysUpdateTagsOperation()
        {
        }

        internal P2SVpnGatewaysUpdateTagsOperation(ResourceOperations operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<P2SVpnGateway>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "P2SVpnGatewaysUpdateTagsOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override P2SVpnGateway Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<P2SVpnGateway>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<P2SVpnGateway>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        P2SVpnGateway IOperationSource<P2SVpnGateway>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new P2SVpnGateway(_operationBase, P2SVpnGatewayData.DeserializeP2SVpnGatewayData(document.RootElement));
        }

        async ValueTask<P2SVpnGateway> IOperationSource<P2SVpnGateway>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new P2SVpnGateway(_operationBase, P2SVpnGatewayData.DeserializeP2SVpnGatewayData(document.RootElement));
        }
    }
}

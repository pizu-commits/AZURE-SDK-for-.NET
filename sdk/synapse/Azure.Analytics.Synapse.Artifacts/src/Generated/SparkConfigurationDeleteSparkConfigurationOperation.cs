// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Deletes a sparkConfiguration. </summary>
    public partial class SparkConfigurationDeleteSparkConfigurationOperation : Operation
    {
        private readonly OperationInternal _operation;

        /// <summary> Initializes a new instance of SparkConfigurationDeleteSparkConfigurationOperation for mocking. </summary>
        protected SparkConfigurationDeleteSparkConfigurationOperation()
        {
        }

        internal SparkConfigurationDeleteSparkConfigurationOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            var nextLinkOperation = NextLinkOperationImplementation.Create(pipeline, request.Method, request.Uri.ToUri(), response, OperationFinalStateVia.Location);
            _operation = new OperationInternal(clientDiagnostics, nextLinkOperation, response, "SparkConfigurationDeleteSparkConfigurationOperation");
        }

        /// <inheritdoc />
#pragma warning disable CA1822
        public override string Id => throw new NotImplementedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response WaitForCompletionResponse(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponse(cancellationToken);

        /// <inheritdoc />
        public override Response WaitForCompletionResponse(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponse(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}

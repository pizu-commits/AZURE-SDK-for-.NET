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
using Azure.ResourceManager;
using Azure.ResourceManager.StoragePool;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Update a Disk pool. </summary>
    public partial class DiskPoolUpdateOperation : Operation<DiskPool>, IOperationSource<DiskPool>
    {
        private readonly OperationInternals<DiskPool> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of DiskPoolUpdateOperation for mocking. </summary>
        protected DiskPoolUpdateOperation()
        {
        }

        internal DiskPoolUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DiskPool>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "DiskPoolUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DiskPool Value => _operation.Value;

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
        public override ValueTask<Response<DiskPool>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DiskPool>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DiskPool IOperationSource<DiskPool>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DiskPoolData.DeserializeDiskPoolData(document.RootElement);
            return new DiskPool(_armClient, data);
        }

        async ValueTask<DiskPool> IOperationSource<DiskPool>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DiskPoolData.DeserializeDiskPoolData(document.RootElement);
            return new DiskPool(_armClient, data);
        }
    }
}

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
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Creates or updates a disk encryption set. </summary>
    public partial class DiskEncryptionSetCreateOrUpdateOperation : Operation<DiskEncryptionSet>, IOperationSource<DiskEncryptionSet>
    {
        private readonly OperationInternals<DiskEncryptionSet> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of DiskEncryptionSetCreateOrUpdateOperation for mocking. </summary>
        protected DiskEncryptionSetCreateOrUpdateOperation()
        {
        }

        internal DiskEncryptionSetCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DiskEncryptionSet>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DiskEncryptionSetCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DiskEncryptionSet Value => _operation.Value;

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
        public override ValueTask<Response<DiskEncryptionSet>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DiskEncryptionSet>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DiskEncryptionSet IOperationSource<DiskEncryptionSet>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DiskEncryptionSetData.DeserializeDiskEncryptionSetData(document.RootElement);
            return new DiskEncryptionSet(_armClient, data);
        }

        async ValueTask<DiskEncryptionSet> IOperationSource<DiskEncryptionSet>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DiskEncryptionSetData.DeserializeDiskEncryptionSetData(document.RootElement);
            return new DiskEncryptionSet(_armClient, data);
        }
    }
}

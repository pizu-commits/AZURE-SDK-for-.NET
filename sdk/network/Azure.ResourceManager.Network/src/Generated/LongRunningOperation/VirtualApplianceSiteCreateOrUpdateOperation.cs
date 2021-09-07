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
    /// <summary> Creates or updates the specified Network Virtual Appliance Site. </summary>
    public partial class VirtualApplianceSiteCreateOrUpdateOperation : Operation<VirtualApplianceSite>, IOperationSource<VirtualApplianceSite>
    {
        private readonly OperationInternals<VirtualApplianceSite> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VirtualApplianceSiteCreateOrUpdateOperation for mocking. </summary>
        protected VirtualApplianceSiteCreateOrUpdateOperation()
        {
        }

        internal VirtualApplianceSiteCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualApplianceSite>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualApplianceSiteCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualApplianceSite Value => _operation.Value;

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
        public override ValueTask<Response<VirtualApplianceSite>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualApplianceSite>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualApplianceSite IOperationSource<VirtualApplianceSite>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VirtualApplianceSite(_operationBase, VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(document.RootElement));
        }

        async ValueTask<VirtualApplianceSite> IOperationSource<VirtualApplianceSite>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VirtualApplianceSite(_operationBase, VirtualApplianceSiteData.DeserializeVirtualApplianceSiteData(document.RootElement));
        }
    }
}

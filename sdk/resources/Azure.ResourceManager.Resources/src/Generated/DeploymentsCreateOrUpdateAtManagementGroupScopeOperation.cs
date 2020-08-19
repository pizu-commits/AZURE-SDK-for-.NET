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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
    public partial class DeploymentsCreateOrUpdateAtManagementGroupScopeOperation : Operation<DeploymentExtended>, IOperationSource<DeploymentExtended>
    {
        private readonly ArmOperationHelpers<DeploymentExtended> _operation;
        internal DeploymentsCreateOrUpdateAtManagementGroupScopeOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<DeploymentExtended>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DeploymentsCreateOrUpdateAtManagementGroupScopeOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DeploymentExtended Value => _operation.Value;

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
        public override ValueTask<Response<DeploymentExtended>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DeploymentExtended>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DeploymentExtended IOperationSource<DeploymentExtended>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DeploymentExtended.DeserializeDeploymentExtended(document.RootElement);
        }

        async ValueTask<DeploymentExtended> IOperationSource<DeploymentExtended>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DeploymentExtended.DeserializeDeploymentExtended(document.RootElement);
        }
    }
}

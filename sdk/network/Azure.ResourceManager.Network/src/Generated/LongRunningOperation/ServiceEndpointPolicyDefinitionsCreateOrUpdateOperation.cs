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
    /// <summary> Creates or updates a service endpoint policy definition in the specified service endpoint policy. </summary>
    public partial class ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation : Operation<ServiceEndpointPolicyDefinition>, IOperationSource<ServiceEndpointPolicyDefinition>
    {
        private readonly OperationInternals<ServiceEndpointPolicyDefinition> _operation;

        private readonly ResourceOperations _operationBase;

        /// <summary> Initializes a new instance of ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation for mocking. </summary>
        protected ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation()
        {
        }

        internal ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation(ResourceOperations operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ServiceEndpointPolicyDefinition>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "ServiceEndpointPolicyDefinitionsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServiceEndpointPolicyDefinition Value => _operation.Value;

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
        public override ValueTask<Response<ServiceEndpointPolicyDefinition>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServiceEndpointPolicyDefinition>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServiceEndpointPolicyDefinition IOperationSource<ServiceEndpointPolicyDefinition>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ServiceEndpointPolicyDefinition(_operationBase, ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(document.RootElement));
        }

        async ValueTask<ServiceEndpointPolicyDefinition> IOperationSource<ServiceEndpointPolicyDefinition>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ServiceEndpointPolicyDefinition(_operationBase, ServiceEndpointPolicyDefinitionData.DeserializeServiceEndpointPolicyDefinitionData(document.RootElement));
        }
    }
}

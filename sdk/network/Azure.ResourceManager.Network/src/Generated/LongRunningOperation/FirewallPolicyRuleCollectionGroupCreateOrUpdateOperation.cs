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
    /// <summary> Creates or updates the specified FirewallPolicyRuleCollectionGroup. </summary>
    public partial class FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation : Operation<FirewallPolicyRuleCollectionGroup>, IOperationSource<FirewallPolicyRuleCollectionGroup>
    {
        private readonly OperationInternals<FirewallPolicyRuleCollectionGroup> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation for mocking. </summary>
        protected FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation()
        {
        }

        internal FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<FirewallPolicyRuleCollectionGroup>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override FirewallPolicyRuleCollectionGroup Value => _operation.Value;

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
        public override ValueTask<Response<FirewallPolicyRuleCollectionGroup>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FirewallPolicyRuleCollectionGroup>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        FirewallPolicyRuleCollectionGroup IOperationSource<FirewallPolicyRuleCollectionGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FirewallPolicyRuleCollectionGroupData.DeserializeFirewallPolicyRuleCollectionGroupData(document.RootElement);
            return new FirewallPolicyRuleCollectionGroup(_operationBase, data);
        }

        async ValueTask<FirewallPolicyRuleCollectionGroup> IOperationSource<FirewallPolicyRuleCollectionGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FirewallPolicyRuleCollectionGroupData.DeserializeFirewallPolicyRuleCollectionGroupData(document.RootElement);
            return new FirewallPolicyRuleCollectionGroup(_operationBase, data);
        }
    }
}

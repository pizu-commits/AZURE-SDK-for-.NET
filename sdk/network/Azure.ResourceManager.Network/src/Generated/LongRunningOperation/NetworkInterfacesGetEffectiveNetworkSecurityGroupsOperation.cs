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

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Gets all network security groups applied to a network interface. </summary>
    public partial class NetworkInterfacesGetEffectiveNetworkSecurityGroupsOperation : Operation<EffectiveNetworkSecurityGroupListResult>, IOperationSource<EffectiveNetworkSecurityGroupListResult>
    {
        private readonly OperationInternals<EffectiveNetworkSecurityGroupListResult> _operation;

        /// <summary> Initializes a new instance of NetworkInterfacesGetEffectiveNetworkSecurityGroupsOperation for mocking. </summary>
        protected NetworkInterfacesGetEffectiveNetworkSecurityGroupsOperation()
        {
        }

        internal NetworkInterfacesGetEffectiveNetworkSecurityGroupsOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<EffectiveNetworkSecurityGroupListResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "NetworkInterfacesGetEffectiveNetworkSecurityGroupsOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override EffectiveNetworkSecurityGroupListResult Value => _operation.Value;

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
        public override ValueTask<Response<EffectiveNetworkSecurityGroupListResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<EffectiveNetworkSecurityGroupListResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        EffectiveNetworkSecurityGroupListResult IOperationSource<EffectiveNetworkSecurityGroupListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return EffectiveNetworkSecurityGroupListResult.DeserializeEffectiveNetworkSecurityGroupListResult(document.RootElement);
        }

        async ValueTask<EffectiveNetworkSecurityGroupListResult> IOperationSource<EffectiveNetworkSecurityGroupListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return EffectiveNetworkSecurityGroupListResult.DeserializeEffectiveNetworkSecurityGroupListResult(document.RootElement);
        }
    }
}

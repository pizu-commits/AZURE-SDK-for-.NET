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
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Updates an existing domain within a profile. </summary>
    public partial class AfdCustomDomainUpdateOperation : Operation<AfdCustomDomain>, IOperationSource<AfdCustomDomain>
    {
        private readonly OperationInternals<AfdCustomDomain> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of AfdCustomDomainUpdateOperation for mocking. </summary>
        protected AfdCustomDomainUpdateOperation()
        {
        }

        internal AfdCustomDomainUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AfdCustomDomain>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.OriginalUri, "AfdCustomDomainUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AfdCustomDomain Value => _operation.Value;

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
        public override ValueTask<Response<AfdCustomDomain>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AfdCustomDomain>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AfdCustomDomain IOperationSource<AfdCustomDomain>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AfdCustomDomainData.DeserializeAfdCustomDomainData(document.RootElement);
            return new AfdCustomDomain(_armClient, data);
        }

        async ValueTask<AfdCustomDomain> IOperationSource<AfdCustomDomain>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AfdCustomDomainData.DeserializeAfdCustomDomainData(document.RootElement);
            return new AfdCustomDomain(_armClient, data);
        }
    }
}

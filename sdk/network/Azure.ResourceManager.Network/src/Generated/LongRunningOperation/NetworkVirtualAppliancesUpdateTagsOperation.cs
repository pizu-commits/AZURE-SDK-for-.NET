// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Updates a Network Virtual Appliance. </summary>
    public partial class NetworkVirtualAppliancesUpdateTagsOperation : Operation<NetworkVirtualAppliance>
    {
        private readonly OperationOrResponseInternals<NetworkVirtualAppliance> _operation;

        /// <summary> Initializes a new instance of NetworkVirtualAppliancesUpdateTagsOperation for mocking. </summary>
        protected NetworkVirtualAppliancesUpdateTagsOperation()
        {
        }

        internal NetworkVirtualAppliancesUpdateTagsOperation(ResourceOperations operationsBase, Response<NetworkVirtualApplianceData> response)
        {
            _operation = new OperationOrResponseInternals<NetworkVirtualAppliance>(Response.FromValue(new NetworkVirtualAppliance(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override NetworkVirtualAppliance Value => _operation.Value;

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
        public override ValueTask<Response<NetworkVirtualAppliance>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<NetworkVirtualAppliance>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}

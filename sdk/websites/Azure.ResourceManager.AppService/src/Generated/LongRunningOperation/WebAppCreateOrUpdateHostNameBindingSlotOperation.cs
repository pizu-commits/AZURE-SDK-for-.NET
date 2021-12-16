// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates a hostname binding for an app. </summary>
    public partial class WebAppCreateOrUpdateHostNameBindingSlotOperation : Operation<SiteSlotHostNameBinding>
    {
        private readonly OperationOrResponseInternals<SiteSlotHostNameBinding> _operation;

        /// <summary> Initializes a new instance of WebAppCreateOrUpdateHostNameBindingSlotOperation for mocking. </summary>
        protected WebAppCreateOrUpdateHostNameBindingSlotOperation()
        {
        }

        internal WebAppCreateOrUpdateHostNameBindingSlotOperation(ArmResource operationsBase, Response<HostNameBindingData> response)
        {
            _operation = new OperationOrResponseInternals<SiteSlotHostNameBinding>(Response.FromValue(new SiteSlotHostNameBinding(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotHostNameBinding Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotHostNameBinding>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotHostNameBinding>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}

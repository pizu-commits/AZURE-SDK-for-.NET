﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The operation type for the create or update API. </summary>
    public partial class PredefinedTagCreateOrUpdateOperation : Operation<PredefinedTag>
    {
        private readonly OperationOrResponseInternals<PredefinedTag> _operation;

        /// <summary> Initializes a new instance of PreDefinedTagCreateOrUpdateOperation for mocking. </summary>
        protected PredefinedTagCreateOrUpdateOperation()
        {
        }

        internal PredefinedTagCreateOrUpdateOperation(ResourceOperations parentOperation, Response<PredefinedTagData> response)
        {
            _operation = new OperationOrResponseInternals<PredefinedTag>(Response.FromValue(new PredefinedTag(parentOperation, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => "";

        /// <inheritdoc />
        public override PredefinedTag Value => _operation.Value;

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
        public override ValueTask<Response<PredefinedTag>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PredefinedTag>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}

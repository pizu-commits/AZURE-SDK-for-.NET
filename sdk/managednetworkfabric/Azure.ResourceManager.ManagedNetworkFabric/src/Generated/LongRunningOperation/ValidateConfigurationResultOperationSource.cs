// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class ValidateConfigurationResultOperationSource : IOperationSource<ValidateConfigurationResult>
    {
        ValidateConfigurationResult IOperationSource<ValidateConfigurationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ValidateConfigurationResult.DeserializeValidateConfigurationResult(document.RootElement);
        }

        async ValueTask<ValidateConfigurationResult> IOperationSource<ValidateConfigurationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ValidateConfigurationResult.DeserializeValidateConfigurationResult(document.RootElement);
        }
    }
}

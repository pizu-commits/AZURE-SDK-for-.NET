// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    internal class DataShareOperationResultOperationSource : IOperationSource<DataShareOperationResult>
    {
        DataShareOperationResult IOperationSource<DataShareOperationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DataShareOperationResult.DeserializeDataShareOperationResult(document.RootElement);
        }

        async ValueTask<DataShareOperationResult> IOperationSource<DataShareOperationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DataShareOperationResult.DeserializeDataShareOperationResult(document.RootElement);
        }
    }
}

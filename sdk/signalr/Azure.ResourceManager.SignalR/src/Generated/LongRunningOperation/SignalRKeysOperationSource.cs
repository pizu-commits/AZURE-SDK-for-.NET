// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.SignalR.Models;

namespace Azure.ResourceManager.SignalR
{
    internal class SignalRKeysOperationSource : IOperationSource<SignalRKeys>
    {
        SignalRKeys IOperationSource<SignalRKeys>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SignalRKeys.DeserializeSignalRKeys(document.RootElement);
        }

        async ValueTask<SignalRKeys> IOperationSource<SignalRKeys>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SignalRKeys.DeserializeSignalRKeys(document.RootElement);
        }
    }
}

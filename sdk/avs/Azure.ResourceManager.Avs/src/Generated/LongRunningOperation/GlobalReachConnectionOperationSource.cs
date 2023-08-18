// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Avs
{
    internal class GlobalReachConnectionOperationSource : Core.IOperationSource<GlobalReachConnectionResource>
    {
        private readonly ArmClient _client;

        internal GlobalReachConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        GlobalReachConnectionResource Core.IOperationSource<GlobalReachConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GlobalReachConnectionData.DeserializeGlobalReachConnectionData(document.RootElement);
            return new GlobalReachConnectionResource(_client, data);
        }

        async ValueTask<GlobalReachConnectionResource> Core.IOperationSource<GlobalReachConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GlobalReachConnectionData.DeserializeGlobalReachConnectionData(document.RootElement);
            return new GlobalReachConnectionResource(_client, data);
        }
    }
}

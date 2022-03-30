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

namespace Azure.ResourceManager.StoragePool
{
    internal class DiskPoolOperationSource : IOperationSource<DiskPoolResource>
    {
        private readonly ArmClient _client;

        internal DiskPoolOperationSource(ArmClient client)
        {
            _client = client;
        }

        DiskPoolResource IOperationSource<DiskPoolResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DiskPoolData.DeserializeDiskPoolData(document.RootElement);
            return new DiskPoolResource(_client, data);
        }

        async ValueTask<DiskPoolResource> IOperationSource<DiskPoolResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DiskPoolData.DeserializeDiskPoolData(document.RootElement);
            return new DiskPoolResource(_client, data);
        }
    }
}

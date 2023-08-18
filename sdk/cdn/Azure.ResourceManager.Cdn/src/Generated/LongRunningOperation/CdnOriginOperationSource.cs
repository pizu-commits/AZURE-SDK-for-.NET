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

namespace Azure.ResourceManager.Cdn
{
    internal class CdnOriginOperationSource : Core.IOperationSource<CdnOriginResource>
    {
        private readonly ArmClient _client;

        internal CdnOriginOperationSource(ArmClient client)
        {
            _client = client;
        }

        CdnOriginResource Core.IOperationSource<CdnOriginResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CdnOriginData.DeserializeCdnOriginData(document.RootElement);
            return new CdnOriginResource(_client, data);
        }

        async ValueTask<CdnOriginResource> Core.IOperationSource<CdnOriginResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CdnOriginData.DeserializeCdnOriginData(document.RootElement);
            return new CdnOriginResource(_client, data);
        }
    }
}

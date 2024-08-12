// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Cdn
{
    internal class CdnOriginGroupOperationSource : IOperationSource<CdnOriginGroupResource>
    {
        private readonly ArmClient _client;

        internal CdnOriginGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        CdnOriginGroupResource IOperationSource<CdnOriginGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CdnOriginGroupData.DeserializeCdnOriginGroupData(document.RootElement);
            return new CdnOriginGroupResource(_client, data);
        }

        async ValueTask<CdnOriginGroupResource> IOperationSource<CdnOriginGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CdnOriginGroupData.DeserializeCdnOriginGroupData(document.RootElement);
            return new CdnOriginGroupResource(_client, data);
        }
    }
}

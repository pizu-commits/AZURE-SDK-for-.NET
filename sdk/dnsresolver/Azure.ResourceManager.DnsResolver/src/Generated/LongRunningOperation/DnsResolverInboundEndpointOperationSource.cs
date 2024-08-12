// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver
{
    internal class DnsResolverInboundEndpointOperationSource : IOperationSource<DnsResolverInboundEndpointResource>
    {
        private readonly ArmClient _client;

        internal DnsResolverInboundEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        DnsResolverInboundEndpointResource IOperationSource<DnsResolverInboundEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DnsResolverInboundEndpointData.DeserializeDnsResolverInboundEndpointData(document.RootElement);
            return new DnsResolverInboundEndpointResource(_client, data);
        }

        async ValueTask<DnsResolverInboundEndpointResource> IOperationSource<DnsResolverInboundEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DnsResolverInboundEndpointData.DeserializeDnsResolverInboundEndpointData(document.RootElement);
            return new DnsResolverInboundEndpointResource(_client, data);
        }
    }
}

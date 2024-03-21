// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork
{
    internal class SiteNetworkServiceOperationSource : IOperationSource<SiteNetworkServiceResource>
    {
        private readonly ArmClient _client;

        internal SiteNetworkServiceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SiteNetworkServiceResource IOperationSource<SiteNetworkServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SiteNetworkServiceData.DeserializeSiteNetworkServiceData(document.RootElement);
            return new SiteNetworkServiceResource(_client, data);
        }

        async ValueTask<SiteNetworkServiceResource> IOperationSource<SiteNetworkServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SiteNetworkServiceData.DeserializeSiteNetworkServiceData(document.RootElement);
            return new SiteNetworkServiceResource(_client, data);
        }
    }
}

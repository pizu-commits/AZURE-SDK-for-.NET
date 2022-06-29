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

namespace Azure.ResourceManager.AppPlatform
{
    internal class GatewayCustomDomainResourceOperationSource : IOperationSource<GatewayCustomDomainResource>
    {
        private readonly ArmClient _client;

        internal GatewayCustomDomainResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        GatewayCustomDomainResource IOperationSource<GatewayCustomDomainResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = GatewayCustomDomainResourceData.DeserializeGatewayCustomDomainResourceData(document.RootElement);
            return new GatewayCustomDomainResource(_client, data);
        }

        async ValueTask<GatewayCustomDomainResource> IOperationSource<GatewayCustomDomainResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = GatewayCustomDomainResourceData.DeserializeGatewayCustomDomainResourceData(document.RootElement);
            return new GatewayCustomDomainResource(_client, data);
        }
    }
}

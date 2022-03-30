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

namespace Azure.ResourceManager.Network
{
    internal class VirtualRouterPeeringOperationSource : IOperationSource<VirtualRouterPeeringResource>
    {
        private readonly ArmClient _client;

        internal VirtualRouterPeeringOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualRouterPeeringResource IOperationSource<VirtualRouterPeeringResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualRouterPeeringData.DeserializeVirtualRouterPeeringData(document.RootElement);
            return new VirtualRouterPeeringResource(_client, data);
        }

        async ValueTask<VirtualRouterPeeringResource> IOperationSource<VirtualRouterPeeringResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualRouterPeeringData.DeserializeVirtualRouterPeeringData(document.RootElement);
            return new VirtualRouterPeeringResource(_client, data);
        }
    }
}

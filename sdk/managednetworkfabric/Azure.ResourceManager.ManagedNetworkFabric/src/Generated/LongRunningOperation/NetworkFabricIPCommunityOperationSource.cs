// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricIPCommunityOperationSource : IOperationSource<NetworkFabricIPCommunityResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricIPCommunityOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricIPCommunityResource IOperationSource<NetworkFabricIPCommunityResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFabricIPCommunityData.DeserializeNetworkFabricIPCommunityData(document.RootElement);
            return new NetworkFabricIPCommunityResource(_client, data);
        }

        async ValueTask<NetworkFabricIPCommunityResource> IOperationSource<NetworkFabricIPCommunityResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFabricIPCommunityData.DeserializeNetworkFabricIPCommunityData(document.RootElement);
            return new NetworkFabricIPCommunityResource(_client, data);
        }
    }
}

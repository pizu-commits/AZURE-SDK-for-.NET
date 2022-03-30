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

namespace Azure.ResourceManager.CosmosDB
{
    internal class PrivateEndpointConnectionOperationSource : IOperationSource<PrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal PrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        PrivateEndpointConnectionResource IOperationSource<PrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(document.RootElement);
            return new PrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<PrivateEndpointConnectionResource> IOperationSource<PrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateEndpointConnectionData.DeserializePrivateEndpointConnectionData(document.RootElement);
            return new PrivateEndpointConnectionResource(_client, data);
        }
    }
}

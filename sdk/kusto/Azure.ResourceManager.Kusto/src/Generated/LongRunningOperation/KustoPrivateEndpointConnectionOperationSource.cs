// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Kusto
{
    internal class KustoPrivateEndpointConnectionOperationSource : IOperationSource<KustoPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal KustoPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        KustoPrivateEndpointConnectionResource IOperationSource<KustoPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = KustoPrivateEndpointConnectionData.DeserializeKustoPrivateEndpointConnectionData(document.RootElement);
            return new KustoPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<KustoPrivateEndpointConnectionResource> IOperationSource<KustoPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = KustoPrivateEndpointConnectionData.DeserializeKustoPrivateEndpointConnectionData(document.RootElement);
            return new KustoPrivateEndpointConnectionResource(_client, data);
        }
    }
}

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

namespace Azure.ResourceManager.PostgreSql
{
    internal class ServerAdministratorResourceOperationSource : IOperationSource<ServerAdministratorResource>
    {
        private readonly ArmClient _client;

        internal ServerAdministratorResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServerAdministratorResource IOperationSource<ServerAdministratorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServerAdministratorResourceData.DeserializeServerAdministratorResourceData(document.RootElement);
            return new ServerAdministratorResource(_client, data);
        }

        async ValueTask<ServerAdministratorResource> IOperationSource<ServerAdministratorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServerAdministratorResourceData.DeserializeServerAdministratorResourceData(document.RootElement);
            return new ServerAdministratorResource(_client, data);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    internal class CosmosDBForPostgreSqlRoleOperationSource : IOperationSource<CosmosDBForPostgreSqlRoleResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBForPostgreSqlRoleOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBForPostgreSqlRoleResource IOperationSource<CosmosDBForPostgreSqlRoleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBForPostgreSqlRoleData.DeserializeCosmosDBForPostgreSqlRoleData(document.RootElement);
            return new CosmosDBForPostgreSqlRoleResource(_client, data);
        }

        async ValueTask<CosmosDBForPostgreSqlRoleResource> IOperationSource<CosmosDBForPostgreSqlRoleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBForPostgreSqlRoleData.DeserializeCosmosDBForPostgreSqlRoleData(document.RootElement);
            return new CosmosDBForPostgreSqlRoleResource(_client, data);
        }
    }
}

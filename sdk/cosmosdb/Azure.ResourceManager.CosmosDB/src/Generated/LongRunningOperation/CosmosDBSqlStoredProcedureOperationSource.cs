// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBSqlStoredProcedureOperationSource : IOperationSource<CosmosDBSqlStoredProcedureResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBSqlStoredProcedureOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBSqlStoredProcedureResource IOperationSource<CosmosDBSqlStoredProcedureResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBSqlStoredProcedureData.DeserializeCosmosDBSqlStoredProcedureData(document.RootElement);
            return new CosmosDBSqlStoredProcedureResource(_client, data);
        }

        async ValueTask<CosmosDBSqlStoredProcedureResource> IOperationSource<CosmosDBSqlStoredProcedureResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBSqlStoredProcedureData.DeserializeCosmosDBSqlStoredProcedureData(document.RootElement);
            return new CosmosDBSqlStoredProcedureResource(_client, data);
        }
    }
}

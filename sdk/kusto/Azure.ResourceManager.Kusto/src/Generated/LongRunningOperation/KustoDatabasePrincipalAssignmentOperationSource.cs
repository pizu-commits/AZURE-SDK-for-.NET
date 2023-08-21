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

namespace Azure.ResourceManager.Kusto
{
    internal class KustoDatabasePrincipalAssignmentOperationSource : Core.IOperationSource<KustoDatabasePrincipalAssignmentResource>
    {
        private readonly ArmClient _client;

        internal KustoDatabasePrincipalAssignmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        KustoDatabasePrincipalAssignmentResource Core.IOperationSource<KustoDatabasePrincipalAssignmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = KustoDatabasePrincipalAssignmentData.DeserializeKustoDatabasePrincipalAssignmentData(document.RootElement);
            return new KustoDatabasePrincipalAssignmentResource(_client, data);
        }

        async ValueTask<KustoDatabasePrincipalAssignmentResource> Core.IOperationSource<KustoDatabasePrincipalAssignmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = KustoDatabasePrincipalAssignmentData.DeserializeKustoDatabasePrincipalAssignmentData(document.RootElement);
            return new KustoDatabasePrincipalAssignmentResource(_client, data);
        }
    }
}

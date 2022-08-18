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

namespace Azure.ResourceManager.HealthcareApis
{
    internal class WorkspacePrivateEndpointConnectionOperationSource : IOperationSource<WorkspacePrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal WorkspacePrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        WorkspacePrivateEndpointConnectionResource IOperationSource<WorkspacePrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PrivateEndpointConnectionDescriptionData.DeserializePrivateEndpointConnectionDescriptionData(document.RootElement);
            return new WorkspacePrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<WorkspacePrivateEndpointConnectionResource> IOperationSource<WorkspacePrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PrivateEndpointConnectionDescriptionData.DeserializePrivateEndpointConnectionDescriptionData(document.RootElement);
            return new WorkspacePrivateEndpointConnectionResource(_client, data);
        }
    }
}

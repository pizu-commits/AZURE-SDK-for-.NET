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

namespace Azure.ResourceManager.ContainerRegistry
{
    internal class ContainerRegistryWebhookOperationSource : IOperationSource<ContainerRegistryWebhookResource>
    {
        private readonly ArmClient _client;

        internal ContainerRegistryWebhookOperationSource(ArmClient client)
        {
            _client = client;
        }

        ContainerRegistryWebhookResource IOperationSource<ContainerRegistryWebhookResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ContainerRegistryWebhookData.DeserializeContainerRegistryWebhookData(document.RootElement);
            return new ContainerRegistryWebhookResource(_client, data);
        }

        async ValueTask<ContainerRegistryWebhookResource> IOperationSource<ContainerRegistryWebhookResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ContainerRegistryWebhookData.DeserializeContainerRegistryWebhookData(document.RootElement);
            return new ContainerRegistryWebhookResource(_client, data);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs
{
    internal class NotificationHubNamespaceOperationSource : IOperationSource<NotificationHubNamespaceResource>
    {
        private readonly ArmClient _client;

        internal NotificationHubNamespaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        NotificationHubNamespaceResource IOperationSource<NotificationHubNamespaceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NotificationHubNamespaceData.DeserializeNotificationHubNamespaceData(document.RootElement);
            return new NotificationHubNamespaceResource(_client, data);
        }

        async ValueTask<NotificationHubNamespaceResource> IOperationSource<NotificationHubNamespaceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NotificationHubNamespaceData.DeserializeNotificationHubNamespaceData(document.RootElement);
            return new NotificationHubNamespaceResource(_client, data);
        }
    }
}

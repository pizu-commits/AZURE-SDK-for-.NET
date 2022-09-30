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

namespace Azure.ResourceManager.Support
{
    internal class SupportTicketCommunicationOperationSource : IOperationSource<SupportTicketCommunicationResource>
    {
        private readonly ArmClient _client;

        internal SupportTicketCommunicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        SupportTicketCommunicationResource IOperationSource<SupportTicketCommunicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SupportTicketCommunicationData.DeserializeSupportTicketCommunicationData(document.RootElement);
            return new SupportTicketCommunicationResource(_client, data);
        }

        async ValueTask<SupportTicketCommunicationResource> IOperationSource<SupportTicketCommunicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SupportTicketCommunicationData.DeserializeSupportTicketCommunicationData(document.RootElement);
            return new SupportTicketCommunicationResource(_client, data);
        }
    }
}

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

namespace Azure.ResourceManager.Sql
{
    internal class OutboundFirewallRuleOperationSource : IOperationSource<OutboundFirewallRuleResource>
    {
        private readonly ArmClient _client;

        internal OutboundFirewallRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        OutboundFirewallRuleResource IOperationSource<OutboundFirewallRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = OutboundFirewallRuleData.DeserializeOutboundFirewallRuleData(document.RootElement);
            return new OutboundFirewallRuleResource(_client, data);
        }

        async ValueTask<OutboundFirewallRuleResource> IOperationSource<OutboundFirewallRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = OutboundFirewallRuleData.DeserializeOutboundFirewallRuleData(document.RootElement);
            return new OutboundFirewallRuleResource(_client, data);
        }
    }
}

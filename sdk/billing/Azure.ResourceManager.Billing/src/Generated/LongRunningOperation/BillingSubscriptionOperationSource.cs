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

namespace Azure.ResourceManager.Billing
{
    internal class BillingSubscriptionOperationSource : Core.IOperationSource<BillingSubscriptionResource>
    {
        private readonly ArmClient _client;

        internal BillingSubscriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        BillingSubscriptionResource Core.IOperationSource<BillingSubscriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BillingSubscriptionData.DeserializeBillingSubscriptionData(document.RootElement);
            return new BillingSubscriptionResource(_client, data);
        }

        async ValueTask<BillingSubscriptionResource> Core.IOperationSource<BillingSubscriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BillingSubscriptionData.DeserializeBillingSubscriptionData(document.RootElement);
            return new BillingSubscriptionResource(_client, data);
        }
    }
}

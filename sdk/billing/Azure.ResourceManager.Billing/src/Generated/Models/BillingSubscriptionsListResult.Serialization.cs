// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    internal partial class BillingSubscriptionsListResult
    {
        internal static BillingSubscriptionsListResult DeserializeBillingSubscriptionsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<BillingSubscriptionData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingSubscriptionData> array = new List<BillingSubscriptionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingSubscriptionData.DeserializeBillingSubscriptionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new BillingSubscriptionsListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}

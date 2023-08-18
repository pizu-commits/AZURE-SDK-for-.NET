// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingAmount
    {
        internal static BillingAmount DeserializeBillingAmount(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> currency = default;
            Core.Optional<float> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currency"u8))
                {
                    currency = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
            }
            return new BillingAmount(currency.Value, Core.Optional.ToNullable(value));
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class PiiTaskResult
    {
        internal static PiiTaskResult DeserializePiiTaskResult(JsonElement element)
        {
            Optional<PiiResult> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    results = PiiResult.DeserializePiiResult(property.Value);
                    continue;
                }
            }
            return new PiiTaskResult(results.Value);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyTrackedResource
    {
        internal static PolicyTrackedResource DeserializePolicyTrackedResource(JsonElement element)
        {
            Optional<string> trackedResourceId = default;
            Optional<PolicyDetails> policyDetails = default;
            Optional<TrackedResourceModificationDetails> createdBy = default;
            Optional<TrackedResourceModificationDetails> lastModifiedBy = default;
            Optional<DateTimeOffset> lastUpdateUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackedResourceId"))
                {
                    trackedResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policyDetails = PolicyDetails.DeserializePolicyDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdBy = TrackedResourceModificationDetails.DeserializeTrackedResourceModificationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastModifiedBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModifiedBy = TrackedResourceModificationDetails.DeserializeTrackedResourceModificationDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdateUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new PolicyTrackedResource(trackedResourceId.Value, policyDetails.Value, createdBy.Value, lastModifiedBy.Value, Optional.ToNullable(lastUpdateUtc));
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesObjectStatusCondition
    {
        internal static KubernetesObjectStatusCondition DeserializeKubernetesObjectStatusCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> lastTransitionTime = default;
            Core.Optional<string> message = default;
            Core.Optional<string> reason = default;
            Core.Optional<string> status = default;
            Core.Optional<string> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastTransitionTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastTransitionTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new KubernetesObjectStatusCondition(Core.Optional.ToNullable(lastTransitionTime), message.Value, reason.Value, status.Value, type.Value);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ManagedRuleOverride : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleId");
            writer.WriteStringValue(RuleId);
            if (Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState");
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action");
                writer.WriteStringValue(Action.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ManagedRuleOverride DeserializeManagedRuleOverride(JsonElement element)
        {
            string ruleId = default;
            Optional<ManagedRuleEnabledState> enabledState = default;
            Optional<ActionType> action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleId"))
                {
                    ruleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabledState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabledState = new ManagedRuleEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("action"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    action = new ActionType(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedRuleOverride(ruleId, Optional.ToNullable(enabledState), Optional.ToNullable(action));
        }
    }
}

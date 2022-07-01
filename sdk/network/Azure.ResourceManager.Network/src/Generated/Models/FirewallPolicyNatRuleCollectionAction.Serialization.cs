// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class FirewallPolicyNatRuleCollectionAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActionType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ActionType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyNatRuleCollectionAction DeserializeFirewallPolicyNatRuleCollectionAction(JsonElement element)
        {
            Optional<FirewallPolicyNatRuleCollectionActionType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new FirewallPolicyNatRuleCollectionActionType(property.Value.GetString());
                    continue;
                }
            }
            return new FirewallPolicyNatRuleCollectionAction(Optional.ToNullable(type));
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayFirewallRuleSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RuleSetType))
            {
                writer.WritePropertyName("ruleSetType");
                writer.WriteStringValue(RuleSetType);
            }
            if (Optional.IsDefined(RuleSetVersion))
            {
                writer.WritePropertyName("ruleSetVersion");
                writer.WriteStringValue(RuleSetVersion);
            }
            if (Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups");
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayFirewallRuleSet DeserializeApplicationGatewayFirewallRuleSet(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> ruleSetType = default;
            Optional<string> ruleSetVersion = default;
            Optional<IList<ApplicationGatewayFirewallRuleGroup>> ruleGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ruleSetType"))
                        {
                            ruleSetType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSetVersion"))
                        {
                            ruleSetVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationGatewayFirewallRuleGroup> array = new List<ApplicationGatewayFirewallRuleGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayFirewallRuleGroup.DeserializeApplicationGatewayFirewallRuleGroup(item));
                            }
                            ruleGroups = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewayFirewallRuleSet(id, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), Optional.ToNullable(provisioningState), ruleSetType.Value, ruleSetVersion.Value, Optional.ToList(ruleGroups));
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleManagementPolicyData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(IsOrganizationDefault))
            {
                writer.WritePropertyName("isOrganizationDefault"u8);
                writer.WriteBooleanValue(IsOrganizationDefault.Value);
            }
            if (Core.Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoleManagementPolicyData DeserializeRoleManagementPolicyData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<string> scope = default;
            Core.Optional<string> displayName = default;
            Core.Optional<string> description = default;
            Core.Optional<bool> isOrganizationDefault = default;
            Core.Optional<RoleManagementPrincipal> lastModifiedBy = default;
            Core.Optional<DateTimeOffset> lastModifiedDateTime = default;
            Core.Optional<IList<RoleManagementPolicyRule>> rules = default;
            Core.Optional<IReadOnlyList<RoleManagementPolicyRule>> effectiveRules = default;
            Core.Optional<RoleManagementPolicyProperties> policyProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isOrganizationDefault"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isOrganizationDefault = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedBy = RoleManagementPrincipal.DeserializeRoleManagementPrincipal(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("rules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RoleManagementPolicyRule> array = new List<RoleManagementPolicyRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoleManagementPolicyRule.DeserializeRoleManagementPolicyRule(item));
                            }
                            rules = array;
                            continue;
                        }
                        if (property0.NameEquals("effectiveRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RoleManagementPolicyRule> array = new List<RoleManagementPolicyRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RoleManagementPolicyRule.DeserializeRoleManagementPolicyRule(item));
                            }
                            effectiveRules = array;
                            continue;
                        }
                        if (property0.NameEquals("policyProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyProperties = RoleManagementPolicyProperties.DeserializeRoleManagementPolicyProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleManagementPolicyData(id, name, type, systemData.Value, scope.Value, displayName.Value, description.Value, Core.Optional.ToNullable(isOrganizationDefault), lastModifiedBy.Value, Core.Optional.ToNullable(lastModifiedDateTime), Core.Optional.ToList(rules), Core.Optional.ToList(effectiveRules), policyProperties.Value);
        }
    }
}

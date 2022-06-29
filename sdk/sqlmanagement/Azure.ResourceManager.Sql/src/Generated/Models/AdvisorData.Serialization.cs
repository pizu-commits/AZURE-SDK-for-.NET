// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class AdvisorData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoExecuteStatus))
            {
                writer.WritePropertyName("autoExecuteStatus");
                writer.WriteStringValue(AutoExecuteStatus.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AdvisorData DeserializeAdvisorData(JsonElement element)
        {
            Optional<string> kind = default;
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AdvisorStatus> advisorStatus = default;
            Optional<AutoExecuteStatus> autoExecuteStatus = default;
            Optional<AutoExecuteStatusInheritedFrom> autoExecuteStatusInheritedFrom = default;
            Optional<string> recommendationsStatus = default;
            Optional<DateTimeOffset> lastChecked = default;
            Optional<IReadOnlyList<RecommendedActionData>> recommendedActions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("advisorStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            advisorStatus = property0.Value.GetString().ToAdvisorStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoExecuteStatus = property0.Value.GetString().ToAutoExecuteStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatusInheritedFrom"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            autoExecuteStatusInheritedFrom = property0.Value.GetString().ToAutoExecuteStatusInheritedFrom();
                            continue;
                        }
                        if (property0.NameEquals("recommendationsStatus"))
                        {
                            recommendationsStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastChecked"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastChecked = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recommendedActions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RecommendedActionData> array = new List<RecommendedActionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionData.DeserializeRecommendedActionData(item));
                            }
                            recommendedActions = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AdvisorData(id, name, type, systemData.Value, kind.Value, Optional.ToNullable(location), Optional.ToNullable(advisorStatus), Optional.ToNullable(autoExecuteStatus), Optional.ToNullable(autoExecuteStatusInheritedFrom), recommendationsStatus.Value, Optional.ToNullable(lastChecked), Optional.ToList(recommendedActions));
        }
    }
}

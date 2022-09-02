// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class SmartGroupModification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Modifications))
            {
                writer.WritePropertyName("modifications");
                writer.WriteStartArray();
                foreach (var item in Modifications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink");
                writer.WriteStringValue(NextLink);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SmartGroupModification DeserializeSmartGroupModification(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> smartGroupId = default;
            Optional<IList<SmartGroupModificationItemData>> modifications = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("smartGroupId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            smartGroupId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("modifications"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SmartGroupModificationItemData> array = new List<SmartGroupModificationItemData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SmartGroupModificationItemData.DeserializeSmartGroupModificationItemData(item));
                            }
                            modifications = array;
                            continue;
                        }
                        if (property0.NameEquals("nextLink"))
                        {
                            nextLink = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SmartGroupModification(id, name, type, systemData.Value, Optional.ToNullable(smartGroupId), Optional.ToList(modifications), nextLink.Value);
        }
    }
}

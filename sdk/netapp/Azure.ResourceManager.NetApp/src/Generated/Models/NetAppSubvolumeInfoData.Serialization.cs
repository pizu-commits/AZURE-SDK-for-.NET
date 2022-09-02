// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppSubvolumeInfoData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Size))
            {
                if (Size != null)
                {
                    writer.WritePropertyName("size");
                    writer.WriteNumberValue(Size.Value);
                }
                else
                {
                    writer.WriteNull("size");
                }
            }
            if (Optional.IsDefined(ParentPath))
            {
                if (ParentPath != null)
                {
                    writer.WritePropertyName("parentPath");
                    writer.WriteStringValue(ParentPath);
                }
                else
                {
                    writer.WriteNull("parentPath");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetAppSubvolumeInfoData DeserializeNetAppSubvolumeInfoData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> path = default;
            Optional<long?> size = default;
            Optional<string> parentPath = default;
            Optional<string> provisioningState = default;
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
                        if (property0.NameEquals("path"))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                size = null;
                                continue;
                            }
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("parentPath"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                parentPath = null;
                                continue;
                            }
                            parentPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetAppSubvolumeInfoData(id, name, type, systemData.Value, path.Value, Optional.ToNullable(size), parentPath.Value, provisioningState.Value);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class LoadTestingQuotaBucketContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(CurrentUsage))
            {
                writer.WritePropertyName("currentUsage"u8);
                writer.WriteNumberValue(CurrentUsage.Value);
            }
            if (Core.Optional.IsDefined(CurrentQuota))
            {
                writer.WritePropertyName("currentQuota"u8);
                writer.WriteNumberValue(CurrentQuota.Value);
            }
            if (Core.Optional.IsDefined(NewQuota))
            {
                writer.WritePropertyName("newQuota"u8);
                writer.WriteNumberValue(NewQuota.Value);
            }
            if (Core.Optional.IsDefined(Dimensions))
            {
                writer.WritePropertyName("dimensions"u8);
                writer.WriteObjectValue(Dimensions);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static LoadTestingQuotaBucketContent DeserializeLoadTestingQuotaBucketContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<int> currentUsage = default;
            Core.Optional<int> currentQuota = default;
            Core.Optional<int> newQuota = default;
            Core.Optional<LoadTestingQuotaBucketDimensions> dimensions = default;
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
                        if (property0.NameEquals("currentUsage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentUsage = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentQuota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("newQuota"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newQuota = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dimensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dimensions = LoadTestingQuotaBucketDimensions.DeserializeLoadTestingQuotaBucketDimensions(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new LoadTestingQuotaBucketContent(id, name, type, systemData.Value, Core.Optional.ToNullable(currentUsage), Core.Optional.ToNullable(currentQuota), Core.Optional.ToNullable(newQuota), dimensions.Value);
        }
    }
}

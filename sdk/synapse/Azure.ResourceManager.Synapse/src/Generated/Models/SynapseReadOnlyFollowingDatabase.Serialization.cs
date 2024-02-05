// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseReadOnlyFollowingDatabase : IUtf8JsonSerializable, IJsonModel<SynapseReadOnlyFollowingDatabase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseReadOnlyFollowingDatabase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseReadOnlyFollowingDatabase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseReadOnlyFollowingDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseReadOnlyFollowingDatabase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SoftDeletePeriod))
            {
                writer.WritePropertyName("softDeletePeriod"u8);
                writer.WriteStringValue(SoftDeletePeriod.Value, "P");
            }
            if (Optional.IsDefined(HotCachePeriod))
            {
                writer.WritePropertyName("hotCachePeriod"u8);
                writer.WriteStringValue(HotCachePeriod.Value, "P");
            }
            if (options.Format != "W" && Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics"u8);
                writer.WriteObjectValue(Statistics);
            }
            if (options.Format != "W" && Optional.IsDefined(LeaderClusterResourceId))
            {
                writer.WritePropertyName("leaderClusterResourceId"u8);
                writer.WriteStringValue(LeaderClusterResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(AttachedDatabaseConfigurationName))
            {
                writer.WritePropertyName("attachedDatabaseConfigurationName"u8);
                writer.WriteStringValue(AttachedDatabaseConfigurationName);
            }
            if (options.Format != "W" && Optional.IsDefined(PrincipalsModificationKind))
            {
                writer.WritePropertyName("principalsModificationKind"u8);
                writer.WriteStringValue(PrincipalsModificationKind.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SynapseReadOnlyFollowingDatabase IJsonModel<SynapseReadOnlyFollowingDatabase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseReadOnlyFollowingDatabase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseReadOnlyFollowingDatabase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseReadOnlyFollowingDatabase(document.RootElement, options);
        }

        internal static SynapseReadOnlyFollowingDatabase DeserializeSynapseReadOnlyFollowingDatabase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            SynapseKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            Optional<TimeSpan> softDeletePeriod = default;
            Optional<TimeSpan> hotCachePeriod = default;
            Optional<DatabaseStatistics> statistics = default;
            Optional<string> leaderClusterResourceId = default;
            Optional<string> attachedDatabaseConfigurationName = default;
            Optional<SynapsePrincipalsModificationKind> principalsModificationKind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new SynapseKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("softDeletePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            softDeletePeriod = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("hotCachePeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hotCachePeriod = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("statistics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            statistics = DatabaseStatistics.DeserializeDatabaseStatistics(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("leaderClusterResourceId"u8))
                        {
                            leaderClusterResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("attachedDatabaseConfigurationName"u8))
                        {
                            attachedDatabaseConfigurationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("principalsModificationKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalsModificationKind = new SynapsePrincipalsModificationKind(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SynapseReadOnlyFollowingDatabase(id, name, type, systemData.Value, Optional.ToNullable(location), kind, serializedAdditionalRawData, Optional.ToNullable(provisioningState), Optional.ToNullable(softDeletePeriod), Optional.ToNullable(hotCachePeriod), statistics.Value, leaderClusterResourceId.Value, attachedDatabaseConfigurationName.Value, Optional.ToNullable(principalsModificationKind));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Location))
            {
                builder.Append("  location:");
                builder.AppendLine($" '{Location.Value.ToString()}'");
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsDefined(ProvisioningState))
            {
                builder.Append("    provisioningState:");
                builder.AppendLine($" '{ProvisioningState.ToString()}'");
            }

            if (Optional.IsDefined(SoftDeletePeriod))
            {
                builder.Append("    softDeletePeriod:");
                var formattedTimeSpan = TypeFormatters.ToString(SoftDeletePeriod.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(HotCachePeriod))
            {
                builder.Append("    hotCachePeriod:");
                var formattedTimeSpan = TypeFormatters.ToString(HotCachePeriod.Value, "P");
                builder.AppendLine($" '{formattedTimeSpan}'");
            }

            if (Optional.IsDefined(Statistics))
            {
                builder.Append("    statistics:");
                AppendChildObject(builder, Statistics, options, 4, false);
            }

            if (Optional.IsDefined(LeaderClusterResourceId))
            {
                builder.Append("    leaderClusterResourceId:");
                builder.AppendLine($" '{LeaderClusterResourceId}'");
            }

            if (Optional.IsDefined(AttachedDatabaseConfigurationName))
            {
                builder.Append("    attachedDatabaseConfigurationName:");
                builder.AppendLine($" '{AttachedDatabaseConfigurationName}'");
            }

            if (Optional.IsDefined(PrincipalsModificationKind))
            {
                builder.Append("    principalsModificationKind:");
                builder.AppendLine($" '{PrincipalsModificationKind.ToString()}'");
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<SynapseReadOnlyFollowingDatabase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseReadOnlyFollowingDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SynapseReadOnlyFollowingDatabase)} does not support '{options.Format}' format.");
            }
        }

        SynapseReadOnlyFollowingDatabase IPersistableModel<SynapseReadOnlyFollowingDatabase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseReadOnlyFollowingDatabase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseReadOnlyFollowingDatabase(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SynapseReadOnlyFollowingDatabase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseReadOnlyFollowingDatabase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

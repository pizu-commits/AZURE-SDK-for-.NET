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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterAutoscaleProfile : IUtf8JsonSerializable, IJsonModel<ClusterAutoscaleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterAutoscaleProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterAutoscaleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAutoscaleProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            if (Optional.IsDefined(GracefulDecommissionTimeout))
            {
                writer.WritePropertyName("gracefulDecommissionTimeout"u8);
                writer.WriteNumberValue(GracefulDecommissionTimeout.Value);
            }
            if (Optional.IsDefined(AutoscaleType))
            {
                writer.WritePropertyName("autoscaleType"u8);
                writer.WriteStringValue(AutoscaleType.Value.ToString());
            }
            if (Optional.IsDefined(ScheduleBasedConfig))
            {
                writer.WritePropertyName("scheduleBasedConfig"u8);
                writer.WriteObjectValue(ScheduleBasedConfig, options);
            }
            if (Optional.IsDefined(LoadBasedConfig))
            {
                writer.WritePropertyName("loadBasedConfig"u8);
                writer.WriteObjectValue(LoadBasedConfig, options);
            }
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

        ClusterAutoscaleProfile IJsonModel<ClusterAutoscaleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterAutoscaleProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterAutoscaleProfile(document.RootElement, options);
        }

        internal static ClusterAutoscaleProfile DeserializeClusterAutoscaleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            int? gracefulDecommissionTimeout = default;
            ClusterAutoscaleType? autoscaleType = default;
            ScheduleBasedConfig scheduleBasedConfig = default;
            LoadBasedConfig loadBasedConfig = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gracefulDecommissionTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gracefulDecommissionTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleType = new ClusterAutoscaleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scheduleBasedConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleBasedConfig = ScheduleBasedConfig.DeserializeScheduleBasedConfig(property.Value, options);
                    continue;
                }
                if (property.NameEquals("loadBasedConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBasedConfig = LoadBasedConfig.DeserializeLoadBasedConfig(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterAutoscaleProfile(
                enabled,
                gracefulDecommissionTimeout,
                autoscaleType,
                scheduleBasedConfig,
                loadBasedConfig,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  enabled: ");
                var boolValue = IsEnabled == true ? "true" : "false";
                builder.AppendLine($"{boolValue}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GracefulDecommissionTimeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  gracefulDecommissionTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GracefulDecommissionTimeout))
                {
                    builder.Append("  gracefulDecommissionTimeout: ");
                    builder.AppendLine($"{GracefulDecommissionTimeout.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AutoscaleType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  autoscaleType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AutoscaleType))
                {
                    builder.Append("  autoscaleType: ");
                    builder.AppendLine($"'{AutoscaleType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ScheduleBasedConfig), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scheduleBasedConfig: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ScheduleBasedConfig))
                {
                    builder.Append("  scheduleBasedConfig: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ScheduleBasedConfig, options, 2, false, "  scheduleBasedConfig: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LoadBasedConfig), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  loadBasedConfig: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LoadBasedConfig))
                {
                    builder.Append("  loadBasedConfig: ");
                    BicepSerializationHelpers.AppendChildObject(builder, LoadBasedConfig, options, 2, false, "  loadBasedConfig: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterAutoscaleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterAutoscaleProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterAutoscaleProfile IPersistableModel<ClusterAutoscaleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterAutoscaleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterAutoscaleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterAutoscaleProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterAutoscaleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

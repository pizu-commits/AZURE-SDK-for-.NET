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

namespace Azure.ResourceManager.Hci.Models
{
    public partial class DeploymentSettingObservability : IUtf8JsonSerializable, IJsonModel<DeploymentSettingObservability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentSettingObservability>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentSettingObservability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingObservability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingObservability)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsStreamingDataClientEnabled))
            {
                writer.WritePropertyName("streamingDataClient"u8);
                writer.WriteBooleanValue(IsStreamingDataClientEnabled.Value);
            }
            if (Optional.IsDefined(IsEULocation))
            {
                writer.WritePropertyName("euLocation"u8);
                writer.WriteBooleanValue(IsEULocation.Value);
            }
            if (Optional.IsDefined(IsEpisodicDataUploadEnabled))
            {
                writer.WritePropertyName("episodicDataUpload"u8);
                writer.WriteBooleanValue(IsEpisodicDataUploadEnabled.Value);
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

        DeploymentSettingObservability IJsonModel<DeploymentSettingObservability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingObservability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingObservability)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentSettingObservability(document.RootElement, options);
        }

        internal static DeploymentSettingObservability DeserializeDeploymentSettingObservability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? streamingDataClient = default;
            bool? euLocation = default;
            bool? episodicDataUpload = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streamingDataClient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    streamingDataClient = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("euLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    euLocation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("episodicDataUpload"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    episodicDataUpload = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentSettingObservability(streamingDataClient, euLocation, episodicDataUpload, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsStreamingDataClientEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  streamingDataClient: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsStreamingDataClientEnabled))
                {
                    builder.Append("  streamingDataClient: ");
                    var boolValue = IsStreamingDataClientEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEULocation), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  euLocation: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEULocation))
                {
                    builder.Append("  euLocation: ");
                    var boolValue = IsEULocation.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEpisodicDataUploadEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  episodicDataUpload: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEpisodicDataUploadEnabled))
                {
                    builder.Append("  episodicDataUpload: ");
                    var boolValue = IsEpisodicDataUploadEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DeploymentSettingObservability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingObservability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingObservability)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentSettingObservability IPersistableModel<DeploymentSettingObservability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingObservability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeploymentSettingObservability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingObservability)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentSettingObservability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

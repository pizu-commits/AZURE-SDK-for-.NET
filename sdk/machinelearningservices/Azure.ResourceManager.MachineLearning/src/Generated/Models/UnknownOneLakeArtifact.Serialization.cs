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

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownOneLakeArtifact : IUtf8JsonSerializable, IJsonModel<OneLakeArtifact>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OneLakeArtifact>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OneLakeArtifact>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            writer.WritePropertyName("artifactName"u8);
            writer.WriteStringValue(ArtifactName);
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

        OneLakeArtifact IJsonModel<OneLakeArtifact>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOneLakeArtifact(document.RootElement, options);
        }

        internal static UnknownOneLakeArtifact DeserializeUnknownOneLakeArtifact(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OneLakeArtifactType artifactType = "Unknown";
            string artifactName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new OneLakeArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("artifactName"u8))
                {
                    artifactName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownOneLakeArtifact(artifactType, artifactName, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArtifactType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  artifactType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  artifactType: ");
                builder.AppendLine($"'{ArtifactType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ArtifactName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  artifactName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ArtifactName))
                {
                    builder.Append("  artifactName: ");
                    if (ArtifactName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ArtifactName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ArtifactName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OneLakeArtifact>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support writing '{options.Format}' format.");
            }
        }

        OneLakeArtifact IPersistableModel<OneLakeArtifact>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OneLakeArtifact>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOneLakeArtifact(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OneLakeArtifact)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OneLakeArtifact>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

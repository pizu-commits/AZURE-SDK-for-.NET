// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryRunGetLogResult : IUtf8JsonSerializable, IJsonModel<ContainerRegistryRunGetLogResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryRunGetLogResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryRunGetLogResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunGetLogResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryRunGetLogResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LogLink))
            {
                writer.WritePropertyName("logLink"u8);
                writer.WriteStringValue(LogLink);
            }
            if (Optional.IsDefined(LogArtifactLink))
            {
                writer.WritePropertyName("logArtifactLink"u8);
                writer.WriteStringValue(LogArtifactLink);
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

        ContainerRegistryRunGetLogResult IJsonModel<ContainerRegistryRunGetLogResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunGetLogResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryRunGetLogResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryRunGetLogResult(document.RootElement, options);
        }

        internal static ContainerRegistryRunGetLogResult DeserializeContainerRegistryRunGetLogResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> logLink = default;
            Optional<string> logArtifactLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logLink"u8))
                {
                    logLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logArtifactLink"u8))
                {
                    logArtifactLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryRunGetLogResult(logLink.Value, logArtifactLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryRunGetLogResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunGetLogResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryRunGetLogResult)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryRunGetLogResult IPersistableModel<ContainerRegistryRunGetLogResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryRunGetLogResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryRunGetLogResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryRunGetLogResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryRunGetLogResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

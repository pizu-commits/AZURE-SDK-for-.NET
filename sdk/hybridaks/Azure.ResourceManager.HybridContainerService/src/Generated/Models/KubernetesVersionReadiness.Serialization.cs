// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class KubernetesVersionReadiness : IUtf8JsonSerializable, IJsonModel<KubernetesVersionReadiness>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesVersionReadiness>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesVersionReadiness>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionReadiness>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesVersionReadiness)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(OSSku))
            {
                writer.WritePropertyName("osSku"u8);
                writer.WriteStringValue(OSSku.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Ready))
            {
                writer.WritePropertyName("ready"u8);
                writer.WriteBooleanValue(Ready.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
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

        KubernetesVersionReadiness IJsonModel<KubernetesVersionReadiness>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionReadiness>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesVersionReadiness)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesVersionReadiness(document.RootElement, options);
        }

        internal static KubernetesVersionReadiness DeserializeKubernetesVersionReadiness(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridContainerServiceOSType> osType = default;
            Optional<HybridContainerServiceOSSku> osSku = default;
            Optional<bool> ready = default;
            Optional<string> errorMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HybridContainerServiceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osSku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osSku = new HybridContainerServiceOSSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ready"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ready = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesVersionReadiness(Optional.ToNullable(osType), Optional.ToNullable(osSku), Optional.ToNullable(ready), errorMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesVersionReadiness>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionReadiness>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesVersionReadiness)} does not support '{options.Format}' format.");
            }
        }

        KubernetesVersionReadiness IPersistableModel<KubernetesVersionReadiness>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionReadiness>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesVersionReadiness(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesVersionReadiness)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesVersionReadiness>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

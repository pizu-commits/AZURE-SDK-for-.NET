// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.VoiceServices.Models
{
    public partial class VoiceServicesServiceRegionProperties : IUtf8JsonSerializable, IJsonModel<VoiceServicesServiceRegionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VoiceServicesServiceRegionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VoiceServicesServiceRegionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesServiceRegionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VoiceServicesServiceRegionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("primaryRegionProperties"u8);
            writer.WriteObjectValue(PrimaryRegionProperties, options);
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

        VoiceServicesServiceRegionProperties IJsonModel<VoiceServicesServiceRegionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesServiceRegionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VoiceServicesServiceRegionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVoiceServicesServiceRegionProperties(document.RootElement, options);
        }

        internal static VoiceServicesServiceRegionProperties DeserializeVoiceServicesServiceRegionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            VoiceServicesPrimaryRegionProperties primaryRegionProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryRegionProperties"u8))
                {
                    primaryRegionProperties = VoiceServicesPrimaryRegionProperties.DeserializeVoiceServicesPrimaryRegionProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VoiceServicesServiceRegionProperties(name, primaryRegionProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VoiceServicesServiceRegionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesServiceRegionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VoiceServicesServiceRegionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        VoiceServicesServiceRegionProperties IPersistableModel<VoiceServicesServiceRegionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VoiceServicesServiceRegionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVoiceServicesServiceRegionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VoiceServicesServiceRegionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VoiceServicesServiceRegionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

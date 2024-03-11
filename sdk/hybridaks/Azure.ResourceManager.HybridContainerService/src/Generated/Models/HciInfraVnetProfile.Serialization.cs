// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class HciInfraVnetProfile : IUtf8JsonSerializable, IJsonModel<HciInfraVnetProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HciInfraVnetProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HciInfraVnetProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciInfraVnetProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciInfraVnetProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MocGroup))
            {
                writer.WritePropertyName("mocGroup"u8);
                writer.WriteStringValue(MocGroup);
            }
            if (Optional.IsDefined(MocLocation))
            {
                writer.WritePropertyName("mocLocation"u8);
                writer.WriteStringValue(MocLocation);
            }
            if (Optional.IsDefined(MocVnetName))
            {
                writer.WritePropertyName("mocVnetName"u8);
                writer.WriteStringValue(MocVnetName);
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

        HciInfraVnetProfile IJsonModel<HciInfraVnetProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciInfraVnetProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HciInfraVnetProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHciInfraVnetProfile(document.RootElement, options);
        }

        internal static HciInfraVnetProfile DeserializeHciInfraVnetProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mocGroup = default;
            string mocLocation = default;
            string mocVnetName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mocGroup"u8))
                {
                    mocGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocLocation"u8))
                {
                    mocLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocVnetName"u8))
                {
                    mocVnetName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HciInfraVnetProfile(mocGroup, mocLocation, mocVnetName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HciInfraVnetProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciInfraVnetProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HciInfraVnetProfile)} does not support '{options.Format}' format.");
            }
        }

        HciInfraVnetProfile IPersistableModel<HciInfraVnetProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HciInfraVnetProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHciInfraVnetProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HciInfraVnetProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HciInfraVnetProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

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

namespace Azure.ResourceManager.MobileNetwork.Models
{
    internal partial class SimStaticIPPropertiesStaticIP : IUtf8JsonSerializable, IJsonModel<SimStaticIPPropertiesStaticIP>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimStaticIPPropertiesStaticIP>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SimStaticIPPropertiesStaticIP>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimStaticIPPropertiesStaticIP>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimStaticIPPropertiesStaticIP)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IPv4Address))
            {
                writer.WritePropertyName("ipv4Address"u8);
                writer.WriteStringValue(IPv4Address);
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

        SimStaticIPPropertiesStaticIP IJsonModel<SimStaticIPPropertiesStaticIP>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimStaticIPPropertiesStaticIP>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimStaticIPPropertiesStaticIP)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimStaticIPPropertiesStaticIP(document.RootElement, options);
        }

        internal static SimStaticIPPropertiesStaticIP DeserializeSimStaticIPPropertiesStaticIP(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string ipv4Address = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipv4Address"u8))
                {
                    ipv4Address = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SimStaticIPPropertiesStaticIP(ipv4Address, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IPv4Address), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ipv4Address: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IPv4Address))
                {
                    builder.Append("  ipv4Address: ");
                    if (IPv4Address.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{IPv4Address}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{IPv4Address}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SimStaticIPPropertiesStaticIP>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimStaticIPPropertiesStaticIP>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SimStaticIPPropertiesStaticIP)} does not support writing '{options.Format}' format.");
            }
        }

        SimStaticIPPropertiesStaticIP IPersistableModel<SimStaticIPPropertiesStaticIP>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimStaticIPPropertiesStaticIP>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSimStaticIPPropertiesStaticIP(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SimStaticIPPropertiesStaticIP)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SimStaticIPPropertiesStaticIP>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

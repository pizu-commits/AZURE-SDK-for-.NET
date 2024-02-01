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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class L3ExportRoutePolicy : IUtf8JsonSerializable, IJsonModel<L3ExportRoutePolicy>, IPersistableModel<L3ExportRoutePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<L3ExportRoutePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<L3ExportRoutePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L3ExportRoutePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(L3ExportRoutePolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExportIPv4RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv4RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv4RoutePolicyId);
            }
            if (Optional.IsDefined(ExportIPv6RoutePolicyId))
            {
                writer.WritePropertyName("exportIpv6RoutePolicyId"u8);
                writer.WriteStringValue(ExportIPv6RoutePolicyId);
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

        L3ExportRoutePolicy IJsonModel<L3ExportRoutePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L3ExportRoutePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(L3ExportRoutePolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeL3ExportRoutePolicy(document.RootElement, options);
        }

        internal static L3ExportRoutePolicy DeserializeL3ExportRoutePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> exportIPv4RoutePolicyId = default;
            Optional<ResourceIdentifier> exportIPv6RoutePolicyId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exportIpv4RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv4RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("exportIpv6RoutePolicyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exportIPv6RoutePolicyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new L3ExportRoutePolicy(exportIPv4RoutePolicyId.Value, exportIPv6RoutePolicyId.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ExportIPv4RoutePolicyId))
            {
                builder.Append("  exportIpv4RoutePolicyId:");
                builder.AppendLine($" '{ExportIPv4RoutePolicyId.ToString()}'");
            }

            if (Optional.IsDefined(ExportIPv6RoutePolicyId))
            {
                builder.Append("  exportIpv6RoutePolicyId:");
                builder.AppendLine($" '{ExportIPv6RoutePolicyId.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                stringBuilder.AppendLine($"{indent}{line}");
            }
        }

        BinaryData IPersistableModel<L3ExportRoutePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L3ExportRoutePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(L3ExportRoutePolicy)} does not support '{options.Format}' format.");
            }
        }

        L3ExportRoutePolicy IPersistableModel<L3ExportRoutePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<L3ExportRoutePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeL3ExportRoutePolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(L3ExportRoutePolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<L3ExportRoutePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

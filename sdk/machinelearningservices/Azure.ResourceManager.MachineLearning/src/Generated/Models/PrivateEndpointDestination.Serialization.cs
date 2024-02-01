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
    public partial class PrivateEndpointDestination : IUtf8JsonSerializable, IJsonModel<PrivateEndpointDestination>, IPersistableModel<PrivateEndpointDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateEndpointDestination>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateEndpointDestination>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceResourceId))
            {
                writer.WritePropertyName("serviceResourceId"u8);
                writer.WriteStringValue(ServiceResourceId);
            }
            if (Optional.IsDefined(SparkEnabled))
            {
                writer.WritePropertyName("sparkEnabled"u8);
                writer.WriteBooleanValue(SparkEnabled.Value);
            }
            if (Optional.IsDefined(SparkStatus))
            {
                writer.WritePropertyName("sparkStatus"u8);
                writer.WriteStringValue(SparkStatus.Value.ToString());
            }
            if (Optional.IsDefined(SubresourceTarget))
            {
                writer.WritePropertyName("subresourceTarget"u8);
                writer.WriteStringValue(SubresourceTarget);
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

        PrivateEndpointDestination IJsonModel<PrivateEndpointDestination>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpointDestination(document.RootElement, options);
        }

        internal static PrivateEndpointDestination DeserializePrivateEndpointDestination(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceResourceId = default;
            Optional<bool> sparkEnabled = default;
            Optional<OutboundRuleStatus> sparkStatus = default;
            Optional<string> subresourceTarget = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceResourceId"u8))
                {
                    serviceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sparkEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sparkEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sparkStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sparkStatus = new OutboundRuleStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subresourceTarget"u8))
                {
                    subresourceTarget = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateEndpointDestination(serviceResourceId.Value, Optional.ToNullable(sparkEnabled), Optional.ToNullable(sparkStatus), subresourceTarget.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ServiceResourceId))
            {
                builder.Append("  serviceResourceId:");
                builder.AppendLine($" '{ServiceResourceId}'");
            }

            if (Optional.IsDefined(SparkEnabled))
            {
                builder.Append("  sparkEnabled:");
                var boolValue = SparkEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(SparkStatus))
            {
                builder.Append("  sparkStatus:");
                builder.AppendLine($" '{SparkStatus.ToString()}'");
            }

            if (Optional.IsDefined(SubresourceTarget))
            {
                builder.Append("  subresourceTarget:");
                builder.AppendLine($" '{SubresourceTarget}'");
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

        BinaryData IPersistableModel<PrivateEndpointDestination>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{options.Format}' format.");
            }
        }

        PrivateEndpointDestination IPersistableModel<PrivateEndpointDestination>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateEndpointDestination>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateEndpointDestination(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PrivateEndpointDestination)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateEndpointDestination>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

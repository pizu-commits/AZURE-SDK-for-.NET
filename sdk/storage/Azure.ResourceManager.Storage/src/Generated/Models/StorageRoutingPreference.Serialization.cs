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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageRoutingPreference : IUtf8JsonSerializable, IJsonModel<StorageRoutingPreference>, IPersistableModel<StorageRoutingPreference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageRoutingPreference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageRoutingPreference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingChoice))
            {
                writer.WritePropertyName("routingChoice"u8);
                writer.WriteStringValue(RoutingChoice.Value.ToString());
            }
            if (Optional.IsDefined(IsMicrosoftEndpointsPublished))
            {
                writer.WritePropertyName("publishMicrosoftEndpoints"u8);
                writer.WriteBooleanValue(IsMicrosoftEndpointsPublished.Value);
            }
            if (Optional.IsDefined(IsInternetEndpointsPublished))
            {
                writer.WritePropertyName("publishInternetEndpoints"u8);
                writer.WriteBooleanValue(IsInternetEndpointsPublished.Value);
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

        StorageRoutingPreference IJsonModel<StorageRoutingPreference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageRoutingPreference(document.RootElement, options);
        }

        internal static StorageRoutingPreference DeserializeStorageRoutingPreference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StorageRoutingChoice> routingChoice = default;
            Optional<bool> publishMicrosoftEndpoints = default;
            Optional<bool> publishInternetEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingChoice"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingChoice = new StorageRoutingChoice(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publishMicrosoftEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishMicrosoftEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishInternetEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishInternetEndpoints = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageRoutingPreference(Optional.ToNullable(routingChoice), Optional.ToNullable(publishMicrosoftEndpoints), Optional.ToNullable(publishInternetEndpoints), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RoutingChoice))
            {
                builder.Append("  routingChoice:");
                builder.AppendLine($" '{RoutingChoice.ToString()}'");
            }

            if (Optional.IsDefined(IsMicrosoftEndpointsPublished))
            {
                builder.Append("  publishMicrosoftEndpoints:");
                var boolValue = IsMicrosoftEndpointsPublished.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(IsInternetEndpointsPublished))
            {
                builder.Append("  publishInternetEndpoints:");
                var boolValue = IsInternetEndpointsPublished.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
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

        BinaryData IPersistableModel<StorageRoutingPreference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support '{options.Format}' format.");
            }
        }

        StorageRoutingPreference IPersistableModel<StorageRoutingPreference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageRoutingPreference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageRoutingPreference(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(StorageRoutingPreference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageRoutingPreference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

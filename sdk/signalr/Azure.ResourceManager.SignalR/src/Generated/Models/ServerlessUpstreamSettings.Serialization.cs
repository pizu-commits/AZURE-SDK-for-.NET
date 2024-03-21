// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    internal partial class ServerlessUpstreamSettings : IUtf8JsonSerializable, IJsonModel<ServerlessUpstreamSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServerlessUpstreamSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServerlessUpstreamSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessUpstreamSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessUpstreamSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Templates))
            {
                writer.WritePropertyName("templates"u8);
                writer.WriteStartArray();
                foreach (var item in Templates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ServerlessUpstreamSettings IJsonModel<ServerlessUpstreamSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessUpstreamSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServerlessUpstreamSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServerlessUpstreamSettings(document.RootElement, options);
        }

        internal static ServerlessUpstreamSettings DeserializeServerlessUpstreamSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<SignalRUpstreamTemplate> templates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SignalRUpstreamTemplate> array = new List<SignalRUpstreamTemplate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SignalRUpstreamTemplate.DeserializeSignalRUpstreamTemplate(item, options));
                    }
                    templates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServerlessUpstreamSettings(templates ?? new ChangeTrackingList<SignalRUpstreamTemplate>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServerlessUpstreamSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessUpstreamSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServerlessUpstreamSettings)} does not support '{options.Format}' format.");
            }
        }

        ServerlessUpstreamSettings IPersistableModel<ServerlessUpstreamSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServerlessUpstreamSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServerlessUpstreamSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServerlessUpstreamSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServerlessUpstreamSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class EventGridMQTTClientEventData : IUtf8JsonSerializable, IJsonModel<EventGridMQTTClientEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridMQTTClientEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventGridMQTTClientEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMQTTClientEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridMQTTClientEventData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientAuthenticationName))
            {
                writer.WritePropertyName("clientAuthenticationName"u8);
                writer.WriteStringValue(ClientAuthenticationName);
            }
            if (Optional.IsDefined(ClientName))
            {
                writer.WritePropertyName("clientName"u8);
                writer.WriteStringValue(ClientName);
            }
            if (Optional.IsDefined(NamespaceName))
            {
                writer.WritePropertyName("namespaceName"u8);
                writer.WriteStringValue(NamespaceName);
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

        EventGridMQTTClientEventData IJsonModel<EventGridMQTTClientEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMQTTClientEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridMQTTClientEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridMQTTClientEventData(document.RootElement, options);
        }

        internal static EventGridMQTTClientEventData DeserializeEventGridMQTTClientEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientAuthenticationName = default;
            string clientName = default;
            string namespaceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientAuthenticationName"u8))
                {
                    clientAuthenticationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientName"u8))
                {
                    clientName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespaceName"u8))
                {
                    namespaceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventGridMQTTClientEventData(clientAuthenticationName, clientName, namespaceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventGridMQTTClientEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMQTTClientEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridMQTTClientEventData)} does not support writing '{options.Format}' format.");
            }
        }

        EventGridMQTTClientEventData IPersistableModel<EventGridMQTTClientEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridMQTTClientEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridMQTTClientEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridMQTTClientEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridMQTTClientEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EventGridMQTTClientEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEventGridMQTTClientEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class EdifactOneWayAgreement : IUtf8JsonSerializable, IJsonModel<EdifactOneWayAgreement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdifactOneWayAgreement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EdifactOneWayAgreement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactOneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactOneWayAgreement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("senderBusinessIdentity"u8);
            writer.WriteObjectValue(SenderBusinessIdentity);
            writer.WritePropertyName("receiverBusinessIdentity"u8);
            writer.WriteObjectValue(ReceiverBusinessIdentity);
            writer.WritePropertyName("protocolSettings"u8);
            writer.WriteObjectValue(ProtocolSettings);
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

        EdifactOneWayAgreement IJsonModel<EdifactOneWayAgreement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactOneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdifactOneWayAgreement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdifactOneWayAgreement(document.RootElement, options);
        }

        internal static EdifactOneWayAgreement DeserializeEdifactOneWayAgreement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationAccountBusinessIdentity senderBusinessIdentity = default;
            IntegrationAccountBusinessIdentity receiverBusinessIdentity = default;
            EdifactProtocolSettings protocolSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderBusinessIdentity"u8))
                {
                    senderBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("receiverBusinessIdentity"u8))
                {
                    receiverBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("protocolSettings"u8))
                {
                    protocolSettings = EdifactProtocolSettings.DeserializeEdifactProtocolSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EdifactOneWayAgreement(senderBusinessIdentity, receiverBusinessIdentity, protocolSettings, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdifactOneWayAgreement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactOneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EdifactOneWayAgreement)} does not support '{options.Format}' format.");
            }
        }

        EdifactOneWayAgreement IPersistableModel<EdifactOneWayAgreement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdifactOneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEdifactOneWayAgreement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdifactOneWayAgreement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdifactOneWayAgreement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

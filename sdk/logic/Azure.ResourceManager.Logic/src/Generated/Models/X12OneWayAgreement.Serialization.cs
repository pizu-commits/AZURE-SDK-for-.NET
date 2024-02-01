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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class X12OneWayAgreement : IUtf8JsonSerializable, IJsonModel<X12OneWayAgreement>, IPersistableModel<X12OneWayAgreement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<X12OneWayAgreement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<X12OneWayAgreement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12OneWayAgreement)} does not support '{format}' format.");
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

        X12OneWayAgreement IJsonModel<X12OneWayAgreement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(X12OneWayAgreement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeX12OneWayAgreement(document.RootElement, options);
        }

        internal static X12OneWayAgreement DeserializeX12OneWayAgreement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationAccountBusinessIdentity senderBusinessIdentity = default;
            IntegrationAccountBusinessIdentity receiverBusinessIdentity = default;
            X12ProtocolSettings protocolSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderBusinessIdentity"u8))
                {
                    senderBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("receiverBusinessIdentity"u8))
                {
                    receiverBusinessIdentity = IntegrationAccountBusinessIdentity.DeserializeIntegrationAccountBusinessIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("protocolSettings"u8))
                {
                    protocolSettings = X12ProtocolSettings.DeserializeX12ProtocolSettings(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new X12OneWayAgreement(senderBusinessIdentity, receiverBusinessIdentity, protocolSettings, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(SenderBusinessIdentity))
            {
                builder.Append("  senderBusinessIdentity:");
                AppendChildObject(builder, SenderBusinessIdentity, options, 2);
            }

            if (Optional.IsDefined(ReceiverBusinessIdentity))
            {
                builder.Append("  receiverBusinessIdentity:");
                AppendChildObject(builder, ReceiverBusinessIdentity, options, 2);
            }

            if (Optional.IsDefined(ProtocolSettings))
            {
                builder.Append("  protocolSettings:");
                AppendChildObject(builder, ProtocolSettings, options, 2);
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

        BinaryData IPersistableModel<X12OneWayAgreement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(X12OneWayAgreement)} does not support '{options.Format}' format.");
            }
        }

        X12OneWayAgreement IPersistableModel<X12OneWayAgreement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<X12OneWayAgreement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeX12OneWayAgreement(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(X12OneWayAgreement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<X12OneWayAgreement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

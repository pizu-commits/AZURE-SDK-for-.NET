// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAssessmentPartner : IUtf8JsonSerializable, IJsonModel<SecurityAssessmentPartner>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAssessmentPartner>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityAssessmentPartner>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPartner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentPartner)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("partnerName"u8);
            writer.WriteStringValue(PartnerName);
            writer.WritePropertyName("secret"u8);
            writer.WriteStringValue(Secret);
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

        SecurityAssessmentPartner IJsonModel<SecurityAssessmentPartner>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPartner>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentPartner)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentPartner(document.RootElement, options);
        }

        internal static SecurityAssessmentPartner DeserializeSecurityAssessmentPartner(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partnerName = default;
            string secret = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partnerName"u8))
                {
                    partnerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secret"u8))
                {
                    secret = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityAssessmentPartner(partnerName, secret, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityAssessmentPartner>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPartner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentPartner)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityAssessmentPartner IPersistableModel<SecurityAssessmentPartner>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentPartner>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAssessmentPartner(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentPartner)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAssessmentPartner>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

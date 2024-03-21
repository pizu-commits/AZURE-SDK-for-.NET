// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class HealthcareApisServiceAuthenticationConfiguration : IUtf8JsonSerializable, IJsonModel<HealthcareApisServiceAuthenticationConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HealthcareApisServiceAuthenticationConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HealthcareApisServiceAuthenticationConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceAuthenticationConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Authority))
            {
                writer.WritePropertyName("authority"u8);
                writer.WriteStringValue(Authority);
            }
            if (Optional.IsDefined(Audience))
            {
                writer.WritePropertyName("audience"u8);
                writer.WriteStringValue(Audience);
            }
            if (Optional.IsDefined(IsSmartProxyEnabled))
            {
                writer.WritePropertyName("smartProxyEnabled"u8);
                writer.WriteBooleanValue(IsSmartProxyEnabled.Value);
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

        HealthcareApisServiceAuthenticationConfiguration IJsonModel<HealthcareApisServiceAuthenticationConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HealthcareApisServiceAuthenticationConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHealthcareApisServiceAuthenticationConfiguration(document.RootElement, options);
        }

        internal static HealthcareApisServiceAuthenticationConfiguration DeserializeHealthcareApisServiceAuthenticationConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authority = default;
            string audience = default;
            bool? smartProxyEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authority"u8))
                {
                    authority = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audience"u8))
                {
                    audience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("smartProxyEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartProxyEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HealthcareApisServiceAuthenticationConfiguration(authority, audience, smartProxyEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HealthcareApisServiceAuthenticationConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceAuthenticationConfiguration)} does not support '{options.Format}' format.");
            }
        }

        HealthcareApisServiceAuthenticationConfiguration IPersistableModel<HealthcareApisServiceAuthenticationConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HealthcareApisServiceAuthenticationConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHealthcareApisServiceAuthenticationConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HealthcareApisServiceAuthenticationConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HealthcareApisServiceAuthenticationConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

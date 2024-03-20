// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class OpenIdConnectConfig : IUtf8JsonSerializable, IJsonModel<OpenIdConnectConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenIdConnectConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OpenIdConnectConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenIdConnectConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AuthorizationEndpoint))
            {
                writer.WritePropertyName("authorizationEndpoint"u8);
                writer.WriteStringValue(AuthorizationEndpoint);
            }
            if (Optional.IsDefined(TokenEndpoint))
            {
                writer.WritePropertyName("tokenEndpoint"u8);
                writer.WriteStringValue(TokenEndpoint);
            }
            if (Optional.IsDefined(Issuer))
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (Optional.IsDefined(CertificationUri))
            {
                writer.WritePropertyName("certificationUri"u8);
                writer.WriteStringValue(CertificationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(WellKnownOpenIdConfiguration))
            {
                writer.WritePropertyName("wellKnownOpenIdConfiguration"u8);
                writer.WriteStringValue(WellKnownOpenIdConfiguration);
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

        OpenIdConnectConfig IJsonModel<OpenIdConnectConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenIdConnectConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenIdConnectConfig(document.RootElement, options);
        }

        internal static OpenIdConnectConfig DeserializeOpenIdConnectConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authorizationEndpoint = default;
            string tokenEndpoint = default;
            string issuer = default;
            Uri certificationUri = default;
            string wellKnownOpenIdConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationEndpoint"u8))
                {
                    authorizationEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenEndpoint"u8))
                {
                    tokenEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificationUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    certificationUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("wellKnownOpenIdConfiguration"u8))
                {
                    wellKnownOpenIdConfiguration = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OpenIdConnectConfig(
                authorizationEndpoint,
                tokenEndpoint,
                issuer,
                certificationUri,
                wellKnownOpenIdConfiguration,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OpenIdConnectConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OpenIdConnectConfig)} does not support '{options.Format}' format.");
            }
        }

        OpenIdConnectConfig IPersistableModel<OpenIdConnectConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenIdConnectConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOpenIdConnectConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenIdConnectConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenIdConnectConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

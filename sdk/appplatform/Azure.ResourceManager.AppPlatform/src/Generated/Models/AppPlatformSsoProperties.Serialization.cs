// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformSsoProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformSsoProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformSsoProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformSsoProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSsoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSsoProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStartArray();
                foreach (var item in Scope)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            if (Optional.IsDefined(IssuerUri))
            {
                writer.WritePropertyName("issuerUri"u8);
                writer.WriteStringValue(IssuerUri.AbsoluteUri);
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

        AppPlatformSsoProperties IJsonModel<AppPlatformSsoProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSsoProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformSsoProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformSsoProperties(document.RootElement, options);
        }

        internal static AppPlatformSsoProperties DeserializeAppPlatformSsoProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> scope = default;
            Optional<string> clientId = default;
            Optional<string> clientSecret = default;
            Optional<Uri> issuerUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    scope = array;
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issuerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformSsoProperties(Optional.ToList(scope), clientId.Value, clientSecret.Value, issuerUri.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformSsoProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSsoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSsoProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformSsoProperties IPersistableModel<AppPlatformSsoProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformSsoProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformSsoProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformSsoProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformSsoProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

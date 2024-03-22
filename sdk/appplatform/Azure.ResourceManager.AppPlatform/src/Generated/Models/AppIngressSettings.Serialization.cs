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
    public partial class AppIngressSettings : IUtf8JsonSerializable, IJsonModel<AppIngressSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppIngressSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppIngressSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppIngressSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppIngressSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ReadTimeoutInSeconds))
            {
                writer.WritePropertyName("readTimeoutInSeconds"u8);
                writer.WriteNumberValue(ReadTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(SendTimeoutInSeconds))
            {
                writer.WritePropertyName("sendTimeoutInSeconds"u8);
                writer.WriteNumberValue(SendTimeoutInSeconds.Value);
            }
            if (Optional.IsDefined(SessionAffinity))
            {
                writer.WritePropertyName("sessionAffinity"u8);
                writer.WriteStringValue(SessionAffinity.Value.ToString());
            }
            if (Optional.IsDefined(SessionCookieMaxAge))
            {
                writer.WritePropertyName("sessionCookieMaxAge"u8);
                writer.WriteNumberValue(SessionCookieMaxAge.Value);
            }
            if (Optional.IsDefined(BackendProtocol))
            {
                writer.WritePropertyName("backendProtocol"u8);
                writer.WriteStringValue(BackendProtocol.Value.ToString());
            }
            if (Optional.IsDefined(ClientAuth))
            {
                writer.WritePropertyName("clientAuth"u8);
                writer.WriteObjectValue<IngressSettingsClientAuth>(ClientAuth, options);
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

        AppIngressSettings IJsonModel<AppIngressSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppIngressSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppIngressSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppIngressSettings(document.RootElement, options);
        }

        internal static AppIngressSettings DeserializeAppIngressSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? readTimeoutInSeconds = default;
            int? sendTimeoutInSeconds = default;
            AppSessionAffinity? sessionAffinity = default;
            int? sessionCookieMaxAge = default;
            AppBackendProtocol? backendProtocol = default;
            IngressSettingsClientAuth clientAuth = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("readTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sendTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sessionAffinity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionAffinity = new AppSessionAffinity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sessionCookieMaxAge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionCookieMaxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendProtocol = new AppBackendProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientAuth = IngressSettingsClientAuth.DeserializeIngressSettingsClientAuth(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppIngressSettings(
                readTimeoutInSeconds,
                sendTimeoutInSeconds,
                sessionAffinity,
                sessionCookieMaxAge,
                backendProtocol,
                clientAuth,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppIngressSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppIngressSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppIngressSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AppIngressSettings IPersistableModel<AppIngressSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppIngressSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppIngressSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppIngressSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppIngressSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

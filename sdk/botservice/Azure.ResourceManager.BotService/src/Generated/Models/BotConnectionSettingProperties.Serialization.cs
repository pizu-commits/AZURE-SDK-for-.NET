// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotConnectionSettingProperties : IUtf8JsonSerializable, IJsonModel<BotConnectionSettingProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotConnectionSettingProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BotConnectionSettingProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotConnectionSettingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotConnectionSettingProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteStringValue(ClientId);
            }
            if (options.Format != "W" && Optional.IsDefined(SettingId))
            {
                writer.WritePropertyName("settingId"u8);
                writer.WriteStringValue(SettingId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret"u8);
                writer.WriteStringValue(ClientSecret);
            }
            if (Optional.IsDefined(Scopes))
            {
                writer.WritePropertyName("scopes"u8);
                writer.WriteStringValue(Scopes);
            }
            if (Optional.IsDefined(ServiceProviderId))
            {
                writer.WritePropertyName("serviceProviderId"u8);
                writer.WriteStringValue(ServiceProviderId);
            }
            if (Optional.IsDefined(ServiceProviderDisplayName))
            {
                writer.WritePropertyName("serviceProviderDisplayName"u8);
                writer.WriteStringValue(ServiceProviderDisplayName);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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

        BotConnectionSettingProperties IJsonModel<BotConnectionSettingProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotConnectionSettingProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotConnectionSettingProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotConnectionSettingProperties(document.RootElement, options);
        }

        internal static BotConnectionSettingProperties DeserializeBotConnectionSettingProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string clientId = default;
            string settingId = default;
            string clientSecret = default;
            string scopes = default;
            string serviceProviderId = default;
            string serviceProviderDisplayName = default;
            IList<BotConnectionSettingParameter> parameters = default;
            string provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("settingId"u8))
                {
                    settingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopes"u8))
                {
                    scopes = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceProviderId"u8))
                {
                    serviceProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceProviderDisplayName"u8))
                {
                    serviceProviderDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BotConnectionSettingParameter> array = new List<BotConnectionSettingParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BotConnectionSettingParameter.DeserializeBotConnectionSettingParameter(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BotConnectionSettingProperties(
                clientId,
                settingId,
                clientSecret,
                scopes,
                serviceProviderId,
                serviceProviderDisplayName,
                parameters ?? new ChangeTrackingList<BotConnectionSettingParameter>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BotConnectionSettingProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotConnectionSettingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BotConnectionSettingProperties)} does not support writing '{options.Format}' format.");
            }
        }

        BotConnectionSettingProperties IPersistableModel<BotConnectionSettingProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotConnectionSettingProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBotConnectionSettingProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BotConnectionSettingProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BotConnectionSettingProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

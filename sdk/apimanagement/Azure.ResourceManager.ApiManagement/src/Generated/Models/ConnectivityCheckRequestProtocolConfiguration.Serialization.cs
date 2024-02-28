// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class ConnectivityCheckRequestProtocolConfiguration : IUtf8JsonSerializable, IJsonModel<ConnectivityCheckRequestProtocolConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityCheckRequestProtocolConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectivityCheckRequestProtocolConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestProtocolConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckRequestProtocolConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (HttpConfiguration != null)
            {
                writer.WritePropertyName("HTTPConfiguration"u8);
                writer.WriteObjectValue(HttpConfiguration);
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

        ConnectivityCheckRequestProtocolConfiguration IJsonModel<ConnectivityCheckRequestProtocolConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestProtocolConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckRequestProtocolConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityCheckRequestProtocolConfiguration(document.RootElement, options);
        }

        internal static ConnectivityCheckRequestProtocolConfiguration DeserializeConnectivityCheckRequestProtocolConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConnectivityCheckRequestHttpConfiguration httpConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("HTTPConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpConfiguration = ConnectivityCheckRequestHttpConfiguration.DeserializeConnectivityCheckRequestHttpConfiguration(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectivityCheckRequestProtocolConfiguration(httpConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectivityCheckRequestProtocolConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestProtocolConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectivityCheckRequestProtocolConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ConnectivityCheckRequestProtocolConfiguration IPersistableModel<ConnectivityCheckRequestProtocolConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectivityCheckRequestProtocolConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectivityCheckRequestProtocolConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectivityCheckRequestProtocolConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectivityCheckRequestProtocolConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

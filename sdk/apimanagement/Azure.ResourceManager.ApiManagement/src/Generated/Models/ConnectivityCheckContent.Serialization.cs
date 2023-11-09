// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ConnectivityCheckContent : IUtf8JsonSerializable, IJsonModel<ConnectivityCheckContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectivityCheckContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<ConnectivityCheckContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            writer.WritePropertyName("destination"u8);
            writer.WriteObjectValue(Destination);
            if (Optional.IsDefined(PreferredIPVersion))
            {
                writer.WritePropertyName("preferredIPVersion"u8);
                writer.WriteStringValue(PreferredIPVersion.Value.ToString());
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsDefined(ProtocolConfiguration))
            {
                writer.WritePropertyName("protocolConfiguration"u8);
                writer.WriteObjectValue(ProtocolConfiguration);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        ConnectivityCheckContent IJsonModel<ConnectivityCheckContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectivityCheckContent(document.RootElement, options);
        }

        internal static ConnectivityCheckContent DeserializeConnectivityCheckContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConnectivityCheckRequestSource source = default;
            ConnectivityCheckRequestDestination destination = default;
            Optional<PreferredIPVersion> preferredIPVersion = default;
            Optional<ConnectivityCheckProtocol> protocol = default;
            Optional<ConnectivityCheckRequestProtocolConfiguration> protocolConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = ConnectivityCheckRequestSource.DeserializeConnectivityCheckRequestSource(property.Value);
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = ConnectivityCheckRequestDestination.DeserializeConnectivityCheckRequestDestination(property.Value);
                    continue;
                }
                if (property.NameEquals("preferredIPVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferredIPVersion = new PreferredIPVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocol = new ConnectivityCheckProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocolConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocolConfiguration = ConnectivityCheckRequestProtocolConfiguration.DeserializeConnectivityCheckRequestProtocolConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectivityCheckContent(source, destination, Optional.ToNullable(preferredIPVersion), Optional.ToNullable(protocol), protocolConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<ConnectivityCheckContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ConnectivityCheckContent IModel<ConnectivityCheckContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ConnectivityCheckContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeConnectivityCheckContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<ConnectivityCheckContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}

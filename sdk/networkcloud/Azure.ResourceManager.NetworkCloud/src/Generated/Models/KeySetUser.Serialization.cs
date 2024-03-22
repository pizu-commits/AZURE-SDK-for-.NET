// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class KeySetUser : IUtf8JsonSerializable, IJsonModel<KeySetUser>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeySetUser>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeySetUser>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeySetUser>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeySetUser)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("azureUserName"u8);
            writer.WriteStringValue(AzureUserName);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("sshPublicKey"u8);
            writer.WriteObjectValue<NetworkCloudSshPublicKey>(SshPublicKey, options);
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

        KeySetUser IJsonModel<KeySetUser>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeySetUser>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KeySetUser)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeySetUser(document.RootElement, options);
        }

        internal static KeySetUser DeserializeKeySetUser(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string azureUserName = default;
            string description = default;
            NetworkCloudSshPublicKey sshPublicKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureUserName"u8))
                {
                    azureUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPublicKey"u8))
                {
                    sshPublicKey = NetworkCloudSshPublicKey.DeserializeNetworkCloudSshPublicKey(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KeySetUser(azureUserName, description, sshPublicKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeySetUser>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeySetUser>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KeySetUser)} does not support writing '{options.Format}' format.");
            }
        }

        KeySetUser IPersistableModel<KeySetUser>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KeySetUser>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKeySetUser(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KeySetUser)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KeySetUser>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

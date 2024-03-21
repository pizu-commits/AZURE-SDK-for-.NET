// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxStorageAccount : IUtf8JsonSerializable, IJsonModel<NginxStorageAccount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxStorageAccount>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NginxStorageAccount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxStorageAccount)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
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

        NginxStorageAccount IJsonModel<NginxStorageAccount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxStorageAccount)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxStorageAccount(document.RootElement, options);
        }

        internal static NginxStorageAccount DeserializeNginxStorageAccount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            string containerName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NginxStorageAccount(accountName, containerName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxStorageAccount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxStorageAccount)} does not support '{options.Format}' format.");
            }
        }

        NginxStorageAccount IPersistableModel<NginxStorageAccount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNginxStorageAccount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxStorageAccount)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxStorageAccount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

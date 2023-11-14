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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountInternetEndpoints : IUtf8JsonSerializable, IJsonModel<StorageAccountInternetEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountInternetEndpoints>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StorageAccountInternetEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StorageAccountInternetEndpoints>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StorageAccountInternetEndpoints>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(BlobUri))
                {
                    writer.WritePropertyName("blob"u8);
                    writer.WriteStringValue(BlobUri.AbsoluteUri);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FileUri))
                {
                    writer.WritePropertyName("file"u8);
                    writer.WriteStringValue(FileUri.AbsoluteUri);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(WebUri))
                {
                    writer.WritePropertyName("web"u8);
                    writer.WriteStringValue(WebUri.AbsoluteUri);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DfsUri))
                {
                    writer.WritePropertyName("dfs"u8);
                    writer.WriteStringValue(DfsUri.AbsoluteUri);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        StorageAccountInternetEndpoints IJsonModel<StorageAccountInternetEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountInternetEndpoints)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountInternetEndpoints(document.RootElement, options);
        }

        internal static StorageAccountInternetEndpoints DeserializeStorageAccountInternetEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> blob = default;
            Optional<Uri> file = default;
            Optional<Uri> web = default;
            Optional<Uri> dfs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blob = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    file = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("web"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    web = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dfs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dfs = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountInternetEndpoints(blob.Value, file.Value, web.Value, dfs.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountInternetEndpoints>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountInternetEndpoints)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StorageAccountInternetEndpoints IPersistableModel<StorageAccountInternetEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountInternetEndpoints)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStorageAccountInternetEndpoints(document.RootElement, options);
        }

        string IPersistableModel<StorageAccountInternetEndpoints>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}

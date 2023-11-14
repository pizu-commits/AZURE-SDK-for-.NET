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

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class RequiredAmlFileSystemSubnetsSizeContent : IUtf8JsonSerializable, IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageCapacityTiB))
            {
                writer.WritePropertyName("storageCapacityTiB"u8);
                writer.WriteNumberValue(StorageCapacityTiB.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
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

        RequiredAmlFileSystemSubnetsSizeContent IJsonModel<RequiredAmlFileSystemSubnetsSizeContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RequiredAmlFileSystemSubnetsSizeContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequiredAmlFileSystemSubnetsSizeContent(document.RootElement, options);
        }

        internal static RequiredAmlFileSystemSubnetsSizeContent DeserializeRequiredAmlFileSystemSubnetsSizeContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> storageCapacityTiB = default;
            Optional<StorageCacheSkuName> sku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageCapacityTiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageCapacityTiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageCacheSkuName.DeserializeStorageCacheSkuName(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequiredAmlFileSystemSubnetsSizeContent(Optional.ToNullable(storageCapacityTiB), sku.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RequiredAmlFileSystemSubnetsSizeContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RequiredAmlFileSystemSubnetsSizeContent IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RequiredAmlFileSystemSubnetsSizeContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRequiredAmlFileSystemSubnetsSizeContent(document.RootElement, options);
        }

        string IPersistableModel<RequiredAmlFileSystemSubnetsSizeContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}

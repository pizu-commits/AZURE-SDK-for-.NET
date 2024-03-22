// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchResourceFile : IUtf8JsonSerializable, IJsonModel<BatchResourceFile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchResourceFile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchResourceFile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchResourceFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchResourceFile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AutoBlobContainerName))
            {
                writer.WritePropertyName("autoStorageContainerName"u8);
                writer.WriteStringValue(AutoBlobContainerName);
            }
            if (Optional.IsDefined(BlobContainerUri))
            {
                writer.WritePropertyName("storageContainerUrl"u8);
                writer.WriteStringValue(BlobContainerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(HttpUri))
            {
                writer.WritePropertyName("httpUrl"u8);
                writer.WriteStringValue(HttpUri.AbsoluteUri);
            }
            if (Optional.IsDefined(BlobPrefix))
            {
                writer.WritePropertyName("blobPrefix"u8);
                writer.WriteStringValue(BlobPrefix);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(FileMode))
            {
                writer.WritePropertyName("fileMode"u8);
                writer.WriteStringValue(FileMode);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identityReference"u8);
                writer.WriteObjectValue<ComputeNodeIdentityReference>(Identity, options);
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

        BatchResourceFile IJsonModel<BatchResourceFile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchResourceFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchResourceFile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchResourceFile(document.RootElement, options);
        }

        internal static BatchResourceFile DeserializeBatchResourceFile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string autoStorageContainerName = default;
            Uri storageContainerUrl = default;
            Uri httpUrl = default;
            string blobPrefix = default;
            string filePath = default;
            string fileMode = default;
            ComputeNodeIdentityReference identityReference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("autoStorageContainerName"u8))
                {
                    autoStorageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageContainerUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageContainerUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("blobPrefix"u8))
                {
                    blobPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filePath"u8))
                {
                    filePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileMode"u8))
                {
                    fileMode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityReference = ComputeNodeIdentityReference.DeserializeComputeNodeIdentityReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchResourceFile(
                autoStorageContainerName,
                storageContainerUrl,
                httpUrl,
                blobPrefix,
                filePath,
                fileMode,
                identityReference,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchResourceFile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchResourceFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchResourceFile)} does not support writing '{options.Format}' format.");
            }
        }

        BatchResourceFile IPersistableModel<BatchResourceFile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchResourceFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchResourceFile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchResourceFile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchResourceFile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

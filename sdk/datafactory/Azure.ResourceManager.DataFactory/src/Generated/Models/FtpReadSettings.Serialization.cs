// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class FtpReadSettings : IUtf8JsonSerializable, IJsonModel<FtpReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FtpReadSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FtpReadSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FtpReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FtpReadSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive"u8);
                JsonSerializer.Serialize(writer, Recursive);
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath"u8);
                JsonSerializer.Serialize(writer, WildcardFolderPath);
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName"u8);
                JsonSerializer.Serialize(writer, WildcardFileName);
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery"u8);
                JsonSerializer.Serialize(writer, EnablePartitionDiscovery);
            }
            if (Optional.IsDefined(PartitionRootPath))
            {
                writer.WritePropertyName("partitionRootPath"u8);
                JsonSerializer.Serialize(writer, PartitionRootPath);
            }
            if (Optional.IsDefined(DeleteFilesAfterCompletion))
            {
                writer.WritePropertyName("deleteFilesAfterCompletion"u8);
                JsonSerializer.Serialize(writer, DeleteFilesAfterCompletion);
            }
            if (Optional.IsDefined(FileListPath))
            {
                writer.WritePropertyName("fileListPath"u8);
                JsonSerializer.Serialize(writer, FileListPath);
            }
            if (Optional.IsDefined(UseBinaryTransfer))
            {
                writer.WritePropertyName("useBinaryTransfer"u8);
                JsonSerializer.Serialize(writer, UseBinaryTransfer);
            }
            if (Optional.IsDefined(DisableChunking))
            {
                writer.WritePropertyName("disableChunking"u8);
                JsonSerializer.Serialize(writer, DisableChunking);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StoreReadSettingsType);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        FtpReadSettings IJsonModel<FtpReadSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FtpReadSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FtpReadSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFtpReadSettings(document.RootElement, options);
        }

        internal static FtpReadSettings DeserializeFtpReadSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<bool> recursive = default;
            DataFactoryElement<string> wildcardFolderPath = default;
            DataFactoryElement<string> wildcardFileName = default;
            DataFactoryElement<bool> enablePartitionDiscovery = default;
            DataFactoryElement<string> partitionRootPath = default;
            DataFactoryElement<bool> deleteFilesAfterCompletion = default;
            DataFactoryElement<string> fileListPath = default;
            DataFactoryElement<bool> useBinaryTransfer = default;
            DataFactoryElement<bool> disableChunking = default;
            string type = default;
            DataFactoryElement<int> maxConcurrentConnections = default;
            DataFactoryElement<bool> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recursive = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFolderPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("wildcardFileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFileName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePartitionDiscovery = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionRootPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionRootPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deleteFilesAfterCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteFilesAfterCompletion = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileListPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileListPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("useBinaryTransfer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    useBinaryTransfer = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableChunking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableChunking = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new FtpReadSettings(
                type,
                maxConcurrentConnections,
                disableMetricsCollection,
                additionalProperties,
                recursive,
                wildcardFolderPath,
                wildcardFileName,
                enablePartitionDiscovery,
                partitionRootPath,
                deleteFilesAfterCompletion,
                fileListPath,
                useBinaryTransfer,
                disableChunking);
        }

        BinaryData IPersistableModel<FtpReadSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FtpReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FtpReadSettings)} does not support '{options.Format}' format.");
            }
        }

        FtpReadSettings IPersistableModel<FtpReadSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FtpReadSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFtpReadSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FtpReadSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FtpReadSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

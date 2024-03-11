// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxCustomerDiskCopyProgress : IUtf8JsonSerializable, IJsonModel<DataBoxCustomerDiskCopyProgress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxCustomerDiskCopyProgress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxCustomerDiskCopyProgress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyProgress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(CopyStatus))
            {
                writer.WritePropertyName("copyStatus"u8);
                writer.WriteStringValue(CopyStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAccountName))
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            if (options.Format != "W" && Optional.IsDefined(TransferType))
            {
                writer.WritePropertyName("transferType"u8);
                writer.WriteStringValue(TransferType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(DataAccountType))
            {
                writer.WritePropertyName("dataAccountType"u8);
                writer.WriteStringValue(DataAccountType.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(AccountId))
            {
                writer.WritePropertyName("accountId"u8);
                writer.WriteStringValue(AccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(BytesProcessed))
            {
                writer.WritePropertyName("bytesProcessed"u8);
                writer.WriteNumberValue(BytesProcessed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalBytesToProcess))
            {
                writer.WritePropertyName("totalBytesToProcess"u8);
                writer.WriteNumberValue(TotalBytesToProcess.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FilesProcessed))
            {
                writer.WritePropertyName("filesProcessed"u8);
                writer.WriteNumberValue(FilesProcessed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TotalFilesToProcess))
            {
                writer.WritePropertyName("totalFilesToProcess"u8);
                writer.WriteNumberValue(TotalFilesToProcess.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InvalidFilesProcessed))
            {
                writer.WritePropertyName("invalidFilesProcessed"u8);
                writer.WriteNumberValue(InvalidFilesProcessed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InvalidFileBytesUploaded))
            {
                writer.WritePropertyName("invalidFileBytesUploaded"u8);
                writer.WriteNumberValue(InvalidFileBytesUploaded.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(RenamedContainerCount))
            {
                writer.WritePropertyName("renamedContainerCount"u8);
                writer.WriteNumberValue(RenamedContainerCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FilesErroredOut))
            {
                writer.WritePropertyName("filesErroredOut"u8);
                writer.WriteNumberValue(FilesErroredOut.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DirectoriesErroredOut))
            {
                writer.WritePropertyName("directoriesErroredOut"u8);
                writer.WriteNumberValue(DirectoriesErroredOut.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(InvalidDirectoriesProcessed))
            {
                writer.WritePropertyName("invalidDirectoriesProcessed"u8);
                writer.WriteNumberValue(InvalidDirectoriesProcessed.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IsEnumerationInProgress))
            {
                writer.WritePropertyName("isEnumerationInProgress"u8);
                writer.WriteBooleanValue(IsEnumerationInProgress.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
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

        DataBoxCustomerDiskCopyProgress IJsonModel<DataBoxCustomerDiskCopyProgress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyProgress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyProgress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxCustomerDiskCopyProgress(document.RootElement, options);
        }

        internal static DataBoxCustomerDiskCopyProgress DeserializeDataBoxCustomerDiskCopyProgress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serialNumber = default;
            DataBoxCopyStatus? copyStatus = default;
            string storageAccountName = default;
            DataBoxJobTransferType? transferType = default;
            DataAccountType? dataAccountType = default;
            ResourceIdentifier accountId = default;
            long? bytesProcessed = default;
            long? totalBytesToProcess = default;
            long? filesProcessed = default;
            long? totalFilesToProcess = default;
            long? invalidFilesProcessed = default;
            long? invalidFileBytesUploaded = default;
            long? renamedContainerCount = default;
            long? filesErroredOut = default;
            long? directoriesErroredOut = default;
            long? invalidDirectoriesProcessed = default;
            bool? isEnumerationInProgress = default;
            ResponseError error = default;
            IReadOnlyList<CustomerResolutionCode> actions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyStatus = new DataBoxCopyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountName"u8))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transferType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferType = property.Value.GetString().ToDataBoxJobTransferType();
                    continue;
                }
                if (property.NameEquals("dataAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("accountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bytesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bytesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalBytesToProcess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalFilesToProcess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalFilesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFilesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidFilesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFileBytesUploaded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidFileBytesUploaded = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("renamedContainerCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renamedContainerCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesErroredOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("directoriesErroredOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    directoriesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidDirectoriesProcessed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invalidDirectoriesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("isEnumerationInProgress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnumerationInProgress = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CustomerResolutionCode> array = new List<CustomerResolutionCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToCustomerResolutionCode());
                    }
                    actions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxCustomerDiskCopyProgress(
                storageAccountName,
                transferType,
                dataAccountType,
                accountId,
                bytesProcessed,
                totalBytesToProcess,
                filesProcessed,
                totalFilesToProcess,
                invalidFilesProcessed,
                invalidFileBytesUploaded,
                renamedContainerCount,
                filesErroredOut,
                directoriesErroredOut,
                invalidDirectoriesProcessed,
                isEnumerationInProgress,
                error,
                actions ?? new ChangeTrackingList<CustomerResolutionCode>(),
                serializedAdditionalRawData,
                serialNumber,
                copyStatus);
        }

        BinaryData IPersistableModel<DataBoxCustomerDiskCopyProgress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyProgress)} does not support '{options.Format}' format.");
            }
        }

        DataBoxCustomerDiskCopyProgress IPersistableModel<DataBoxCustomerDiskCopyProgress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxCustomerDiskCopyProgress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxCustomerDiskCopyProgress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxCustomerDiskCopyProgress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxCustomerDiskCopyProgress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

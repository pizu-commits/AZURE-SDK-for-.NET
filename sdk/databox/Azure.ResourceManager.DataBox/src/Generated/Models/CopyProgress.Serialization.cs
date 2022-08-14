// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class CopyProgress
    {
        internal static CopyProgress DeserializeCopyProgress(JsonElement element)
        {
            Optional<string> storageAccountName = default;
            Optional<TransferType> transferType = default;
            Optional<DataAccountType> dataAccountType = default;
            Optional<string> accountId = default;
            Optional<long> bytesProcessed = default;
            Optional<long> totalBytesToProcess = default;
            Optional<long> filesProcessed = default;
            Optional<long> totalFilesToProcess = default;
            Optional<long> invalidFilesProcessed = default;
            Optional<long> invalidFileBytesUploaded = default;
            Optional<long> renamedContainerCount = default;
            Optional<long> filesErroredOut = default;
            Optional<long> directoriesErroredOut = default;
            Optional<long> invalidDirectoriesProcessed = default;
            Optional<bool> isEnumerationInProgress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountName"))
                {
                    storageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("transferType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    transferType = property.Value.GetString().ToTransferType();
                    continue;
                }
                if (property.NameEquals("dataAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataAccountType = property.Value.GetString().ToDataAccountType();
                    continue;
                }
                if (property.NameEquals("accountId"))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bytesProcessed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bytesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalBytesToProcess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalBytesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesProcessed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalFilesToProcess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalFilesToProcess = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFilesProcessed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invalidFilesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidFileBytesUploaded"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invalidFileBytesUploaded = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("renamedContainerCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    renamedContainerCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("filesErroredOut"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("directoriesErroredOut"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    directoriesErroredOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("invalidDirectoriesProcessed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invalidDirectoriesProcessed = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("isEnumerationInProgress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEnumerationInProgress = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CopyProgress(storageAccountName.Value, Optional.ToNullable(transferType), Optional.ToNullable(dataAccountType), accountId.Value, Optional.ToNullable(bytesProcessed), Optional.ToNullable(totalBytesToProcess), Optional.ToNullable(filesProcessed), Optional.ToNullable(totalFilesToProcess), Optional.ToNullable(invalidFilesProcessed), Optional.ToNullable(invalidFileBytesUploaded), Optional.ToNullable(renamedContainerCount), Optional.ToNullable(filesErroredOut), Optional.ToNullable(directoriesErroredOut), Optional.ToNullable(invalidDirectoriesProcessed), Optional.ToNullable(isEnumerationInProgress));
        }
    }
}

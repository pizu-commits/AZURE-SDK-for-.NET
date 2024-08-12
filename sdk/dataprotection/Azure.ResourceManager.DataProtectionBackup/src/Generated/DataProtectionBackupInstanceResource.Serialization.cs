// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataProtectionBackup
{
    public partial class DataProtectionBackupInstanceResource : IJsonModel<DataProtectionBackupInstanceData>
    {
        void IJsonModel<DataProtectionBackupInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataProtectionBackupInstanceData>)Data).Write(writer, options);

        DataProtectionBackupInstanceData IJsonModel<DataProtectionBackupInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataProtectionBackupInstanceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataProtectionBackupInstanceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DataProtectionBackupInstanceData IPersistableModel<DataProtectionBackupInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataProtectionBackupInstanceData>(data, options);

        string IPersistableModel<DataProtectionBackupInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataProtectionBackupInstanceData>)Data).GetFormatFromOptions(options);
    }
}

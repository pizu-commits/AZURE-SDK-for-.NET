// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerBackupResource : IJsonModel<MySqlFlexibleServerBackupData>
    {
        void IJsonModel<MySqlFlexibleServerBackupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MySqlFlexibleServerBackupData IJsonModel<MySqlFlexibleServerBackupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlFlexibleServerBackupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerBackupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MySqlFlexibleServerBackupData IPersistableModel<MySqlFlexibleServerBackupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlFlexibleServerBackupData>(data, options);
        }

        string IPersistableModel<MySqlFlexibleServerBackupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

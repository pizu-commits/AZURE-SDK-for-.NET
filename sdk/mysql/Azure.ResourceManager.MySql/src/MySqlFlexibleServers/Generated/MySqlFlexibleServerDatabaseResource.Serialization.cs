// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerDatabaseResource : IJsonModel<MySqlFlexibleServerDatabaseData>
    {
        void IJsonModel<MySqlFlexibleServerDatabaseData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MySqlFlexibleServerDatabaseData IJsonModel<MySqlFlexibleServerDatabaseData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlFlexibleServerDatabaseData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerDatabaseData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MySqlFlexibleServerDatabaseData IPersistableModel<MySqlFlexibleServerDatabaseData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlFlexibleServerDatabaseData>(data, options);
        }

        string IPersistableModel<MySqlFlexibleServerDatabaseData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

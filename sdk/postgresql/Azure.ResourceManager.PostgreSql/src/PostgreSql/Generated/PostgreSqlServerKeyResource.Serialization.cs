// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PostgreSql
{
    public partial class PostgreSqlServerKeyResource : IJsonModel<PostgreSqlServerKeyData>
    {
        void IJsonModel<PostgreSqlServerKeyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        PostgreSqlServerKeyData IJsonModel<PostgreSqlServerKeyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PostgreSqlServerKeyData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<PostgreSqlServerKeyData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        PostgreSqlServerKeyData IPersistableModel<PostgreSqlServerKeyData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PostgreSqlServerKeyData>(data, options);
        }

        string IPersistableModel<PostgreSqlServerKeyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

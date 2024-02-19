// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql
{
    public partial class MySqlServerAdministratorResource : IJsonModel<MySqlServerAdministratorData>
    {
        void IJsonModel<MySqlServerAdministratorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MySqlServerAdministratorData IJsonModel<MySqlServerAdministratorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlServerAdministratorData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MySqlServerAdministratorData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MySqlServerAdministratorData IPersistableModel<MySqlServerAdministratorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlServerAdministratorData>(data, options);
        }

        string IPersistableModel<MySqlServerAdministratorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql
{
    public partial class MySqlQueryStatisticResource : IJsonModel<MySqlQueryStatisticData>
    {
        void IJsonModel<MySqlQueryStatisticData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MySqlQueryStatisticData IJsonModel<MySqlQueryStatisticData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlQueryStatisticData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MySqlQueryStatisticData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MySqlQueryStatisticData IPersistableModel<MySqlQueryStatisticData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlQueryStatisticData>(data, options);
        }

        string IPersistableModel<MySqlQueryStatisticData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlServerJobTargetGroupResource : IJsonModel<SqlServerJobTargetGroupData>
    {
        void IJsonModel<SqlServerJobTargetGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SqlServerJobTargetGroupData IJsonModel<SqlServerJobTargetGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SqlServerJobTargetGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SqlServerJobTargetGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SqlServerJobTargetGroupData IPersistableModel<SqlServerJobTargetGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SqlServerJobTargetGroupData>(data, options);
        }

        string IPersistableModel<SqlServerJobTargetGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

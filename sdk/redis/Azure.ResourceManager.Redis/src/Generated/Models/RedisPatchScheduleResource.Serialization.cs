// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisPatchScheduleResource : IJsonModel<RedisPatchScheduleData>
    {
        void IJsonModel<RedisPatchScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        RedisPatchScheduleData IJsonModel<RedisPatchScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RedisPatchScheduleData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<RedisPatchScheduleData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        RedisPatchScheduleData IPersistableModel<RedisPatchScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RedisPatchScheduleData>(data, options);
        }

        string IPersistableModel<RedisPatchScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

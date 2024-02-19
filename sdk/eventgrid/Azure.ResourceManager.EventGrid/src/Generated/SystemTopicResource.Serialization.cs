// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class SystemTopicResource : IJsonModel<SystemTopicData>
    {
        void IJsonModel<SystemTopicData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SystemTopicData IJsonModel<SystemTopicData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SystemTopicData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SystemTopicData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SystemTopicData IPersistableModel<SystemTopicData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SystemTopicData>(data, options);
        }

        string IPersistableModel<SystemTopicData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

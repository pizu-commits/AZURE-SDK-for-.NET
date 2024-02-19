// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ElasticSan
{
    public partial class ElasticSanVolumeGroupResource : IJsonModel<ElasticSanVolumeGroupData>
    {
        void IJsonModel<ElasticSanVolumeGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ElasticSanVolumeGroupData IJsonModel<ElasticSanVolumeGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ElasticSanVolumeGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ElasticSanVolumeGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ElasticSanVolumeGroupData IPersistableModel<ElasticSanVolumeGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ElasticSanVolumeGroupData>(data, options);
        }

        string IPersistableModel<ElasticSanVolumeGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ProbeResource : IJsonModel<ProbeData>
    {
        void IJsonModel<ProbeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ProbeData IJsonModel<ProbeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ProbeData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ProbeData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ProbeData IPersistableModel<ProbeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ProbeData>(data, options);
        }

        string IPersistableModel<ProbeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

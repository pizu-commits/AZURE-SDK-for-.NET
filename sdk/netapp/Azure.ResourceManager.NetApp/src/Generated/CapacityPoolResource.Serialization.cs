// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NetApp
{
    public partial class CapacityPoolResource : IJsonModel<CapacityPoolData>
    {
        void IJsonModel<CapacityPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        CapacityPoolData IJsonModel<CapacityPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CapacityPoolData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<CapacityPoolData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        CapacityPoolData IPersistableModel<CapacityPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CapacityPoolData>(data, options);
        }

        string IPersistableModel<CapacityPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

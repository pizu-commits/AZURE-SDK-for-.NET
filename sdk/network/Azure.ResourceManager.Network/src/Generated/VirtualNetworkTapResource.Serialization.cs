// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkTapResource : IJsonModel<VirtualNetworkTapData>
    {
        void IJsonModel<VirtualNetworkTapData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        VirtualNetworkTapData IJsonModel<VirtualNetworkTapData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualNetworkTapData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<VirtualNetworkTapData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        VirtualNetworkTapData IPersistableModel<VirtualNetworkTapData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualNetworkTapData>(data, options);
        }

        string IPersistableModel<VirtualNetworkTapData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

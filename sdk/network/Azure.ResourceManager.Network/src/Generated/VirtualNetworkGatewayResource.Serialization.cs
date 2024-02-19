// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkGatewayResource : IJsonModel<VirtualNetworkGatewayData>
    {
        void IJsonModel<VirtualNetworkGatewayData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        VirtualNetworkGatewayData IJsonModel<VirtualNetworkGatewayData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualNetworkGatewayData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<VirtualNetworkGatewayData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        VirtualNetworkGatewayData IPersistableModel<VirtualNetworkGatewayData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualNetworkGatewayData>(data, options);
        }

        string IPersistableModel<VirtualNetworkGatewayData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

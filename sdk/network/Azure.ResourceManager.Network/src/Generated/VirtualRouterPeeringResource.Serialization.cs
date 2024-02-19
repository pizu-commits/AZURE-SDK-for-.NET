// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualRouterPeeringResource : IJsonModel<VirtualRouterPeeringData>
    {
        void IJsonModel<VirtualRouterPeeringData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        VirtualRouterPeeringData IJsonModel<VirtualRouterPeeringData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualRouterPeeringData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<VirtualRouterPeeringData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        VirtualRouterPeeringData IPersistableModel<VirtualRouterPeeringData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<VirtualRouterPeeringData>(data, options);
        }

        string IPersistableModel<VirtualRouterPeeringData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

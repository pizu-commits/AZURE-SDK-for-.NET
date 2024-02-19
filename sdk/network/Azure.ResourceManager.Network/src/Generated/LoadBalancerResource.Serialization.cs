// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class LoadBalancerResource : IJsonModel<LoadBalancerData>
    {
        void IJsonModel<LoadBalancerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        LoadBalancerData IJsonModel<LoadBalancerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<LoadBalancerData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<LoadBalancerData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        LoadBalancerData IPersistableModel<LoadBalancerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<LoadBalancerData>(data, options);
        }

        string IPersistableModel<LoadBalancerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

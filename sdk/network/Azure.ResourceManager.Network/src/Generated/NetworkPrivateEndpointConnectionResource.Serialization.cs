// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkPrivateEndpointConnectionResource : IJsonModel<NetworkPrivateEndpointConnectionData>
    {
        void IJsonModel<NetworkPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        NetworkPrivateEndpointConnectionData IJsonModel<NetworkPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkPrivateEndpointConnectionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<NetworkPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        NetworkPrivateEndpointConnectionData IPersistableModel<NetworkPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkPrivateEndpointConnectionData>(data, options);
        }

        string IPersistableModel<NetworkPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql
{
    public partial class MySqlPrivateEndpointConnectionResource : IJsonModel<MySqlPrivateEndpointConnectionData>
    {
        void IJsonModel<MySqlPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MySqlPrivateEndpointConnectionData IJsonModel<MySqlPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlPrivateEndpointConnectionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MySqlPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MySqlPrivateEndpointConnectionData IPersistableModel<MySqlPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MySqlPrivateEndpointConnectionData>(data, options);
        }

        string IPersistableModel<MySqlPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Monitor
{
    public partial class MonitorPrivateEndpointConnectionResource : IJsonModel<MonitorPrivateEndpointConnectionData>
    {
        void IJsonModel<MonitorPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        MonitorPrivateEndpointConnectionData IJsonModel<MonitorPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MonitorPrivateEndpointConnectionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<MonitorPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        MonitorPrivateEndpointConnectionData IPersistableModel<MonitorPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<MonitorPrivateEndpointConnectionData>(data, options);
        }

        string IPersistableModel<MonitorPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkGroupStaticMemberResource : IJsonModel<NetworkGroupStaticMemberData>
    {
        void IJsonModel<NetworkGroupStaticMemberData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        NetworkGroupStaticMemberData IJsonModel<NetworkGroupStaticMemberData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkGroupStaticMemberData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<NetworkGroupStaticMemberData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        NetworkGroupStaticMemberData IPersistableModel<NetworkGroupStaticMemberData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<NetworkGroupStaticMemberData>(data, options);
        }

        string IPersistableModel<NetworkGroupStaticMemberData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

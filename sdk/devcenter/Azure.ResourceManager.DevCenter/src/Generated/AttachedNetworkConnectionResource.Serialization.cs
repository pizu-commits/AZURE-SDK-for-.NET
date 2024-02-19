// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevCenter
{
    public partial class AttachedNetworkConnectionResource : IJsonModel<AttachedNetworkConnectionData>
    {
        void IJsonModel<AttachedNetworkConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        AttachedNetworkConnectionData IJsonModel<AttachedNetworkConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AttachedNetworkConnectionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<AttachedNetworkConnectionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        AttachedNetworkConnectionData IPersistableModel<AttachedNetworkConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AttachedNetworkConnectionData>(data, options);
        }

        string IPersistableModel<AttachedNetworkConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

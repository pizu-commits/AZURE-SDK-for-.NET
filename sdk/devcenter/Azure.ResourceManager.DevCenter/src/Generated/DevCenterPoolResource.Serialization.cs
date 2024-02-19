// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevCenterPoolResource : IJsonModel<DevCenterPoolData>
    {
        void IJsonModel<DevCenterPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DevCenterPoolData IJsonModel<DevCenterPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevCenterPoolData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DevCenterPoolData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DevCenterPoolData IPersistableModel<DevCenterPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevCenterPoolData>(data, options);
        }

        string IPersistableModel<DevCenterPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

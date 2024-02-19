// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevBoxDefinitionResource : IJsonModel<DevBoxDefinitionData>
    {
        void IJsonModel<DevBoxDefinitionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DevBoxDefinitionData IJsonModel<DevBoxDefinitionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevBoxDefinitionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DevBoxDefinitionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DevBoxDefinitionData IPersistableModel<DevBoxDefinitionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevBoxDefinitionData>(data, options);
        }

        string IPersistableModel<DevBoxDefinitionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

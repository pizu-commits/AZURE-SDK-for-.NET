// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevCenter
{
    public partial class ImageVersionResource : IJsonModel<ImageVersionData>
    {
        void IJsonModel<ImageVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ImageVersionData IJsonModel<ImageVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ImageVersionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ImageVersionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ImageVersionData IPersistableModel<ImageVersionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ImageVersionData>(data, options);
        }

        string IPersistableModel<ImageVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

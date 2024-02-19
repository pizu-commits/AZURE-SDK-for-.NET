// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DigitalTwins
{
    public partial class DigitalTwinsPrivateLinkResource : IJsonModel<DigitalTwinsPrivateLinkResourceData>
    {
        void IJsonModel<DigitalTwinsPrivateLinkResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DigitalTwinsPrivateLinkResourceData IJsonModel<DigitalTwinsPrivateLinkResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DigitalTwinsPrivateLinkResourceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DigitalTwinsPrivateLinkResourceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DigitalTwinsPrivateLinkResourceData IPersistableModel<DigitalTwinsPrivateLinkResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DigitalTwinsPrivateLinkResourceData>(data, options);
        }

        string IPersistableModel<DigitalTwinsPrivateLinkResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

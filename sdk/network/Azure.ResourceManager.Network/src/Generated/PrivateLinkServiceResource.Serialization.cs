// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class PrivateLinkServiceResource : IJsonModel<PrivateLinkServiceData>
    {
        void IJsonModel<PrivateLinkServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        PrivateLinkServiceData IJsonModel<PrivateLinkServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PrivateLinkServiceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<PrivateLinkServiceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        PrivateLinkServiceData IPersistableModel<PrivateLinkServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<PrivateLinkServiceData>(data, options);
        }

        string IPersistableModel<PrivateLinkServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

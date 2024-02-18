// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sphere
{
    public partial class SphereCatalogResource : IJsonModel<SphereCatalogData>
    {
        void IJsonModel<SphereCatalogData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SphereCatalogData IJsonModel<SphereCatalogData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SphereCatalogData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SphereCatalogData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SphereCatalogData IPersistableModel<SphereCatalogData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SphereCatalogData>(data, options);
        }

        string IPersistableModel<SphereCatalogData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

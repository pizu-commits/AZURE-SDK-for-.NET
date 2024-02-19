// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Grafana
{
    public partial class GrafanaPrivateLinkResource : IJsonModel<GrafanaPrivateLinkResourceData>
    {
        void IJsonModel<GrafanaPrivateLinkResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        GrafanaPrivateLinkResourceData IJsonModel<GrafanaPrivateLinkResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<GrafanaPrivateLinkResourceData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<GrafanaPrivateLinkResourceData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        GrafanaPrivateLinkResourceData IPersistableModel<GrafanaPrivateLinkResourceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<GrafanaPrivateLinkResourceData>(data, options);
        }

        string IPersistableModel<GrafanaPrivateLinkResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

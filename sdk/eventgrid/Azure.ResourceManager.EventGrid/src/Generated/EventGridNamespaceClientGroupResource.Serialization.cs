// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class EventGridNamespaceClientGroupResource : IJsonModel<EventGridNamespaceClientGroupData>
    {
        void IJsonModel<EventGridNamespaceClientGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        EventGridNamespaceClientGroupData IJsonModel<EventGridNamespaceClientGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<EventGridNamespaceClientGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<EventGridNamespaceClientGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        EventGridNamespaceClientGroupData IPersistableModel<EventGridNamespaceClientGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<EventGridNamespaceClientGroupData>(data, options);
        }

        string IPersistableModel<EventGridNamespaceClientGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

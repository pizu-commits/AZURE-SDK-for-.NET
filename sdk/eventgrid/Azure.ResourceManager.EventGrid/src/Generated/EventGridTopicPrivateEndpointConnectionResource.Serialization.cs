// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class EventGridTopicPrivateEndpointConnectionResource : IJsonModel<EventGridPrivateEndpointConnectionData>
    {
        void IJsonModel<EventGridPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<EventGridPrivateEndpointConnectionData>)Data).Write(writer, options);

        EventGridPrivateEndpointConnectionData IJsonModel<EventGridPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<EventGridPrivateEndpointConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<EventGridPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        EventGridPrivateEndpointConnectionData IPersistableModel<EventGridPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<EventGridPrivateEndpointConnectionData>(data, options);

        string IPersistableModel<EventGridPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<EventGridPrivateEndpointConnectionData>)Data).GetFormatFromOptions(options);
    }
}

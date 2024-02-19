// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventHubs
{
    public partial class EventHubsConsumerGroupResource : IJsonModel<EventHubsConsumerGroupData>
    {
        void IJsonModel<EventHubsConsumerGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        EventHubsConsumerGroupData IJsonModel<EventHubsConsumerGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<EventHubsConsumerGroupData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<EventHubsConsumerGroupData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        EventHubsConsumerGroupData IPersistableModel<EventHubsConsumerGroupData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<EventHubsConsumerGroupData>(data, options);
        }

        string IPersistableModel<EventHubsConsumerGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

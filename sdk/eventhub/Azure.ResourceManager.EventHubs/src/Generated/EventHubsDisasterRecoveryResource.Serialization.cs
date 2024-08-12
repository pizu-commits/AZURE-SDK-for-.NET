// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventHubs
{
    public partial class EventHubsDisasterRecoveryResource : IJsonModel<EventHubsDisasterRecoveryData>
    {
        void IJsonModel<EventHubsDisasterRecoveryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<EventHubsDisasterRecoveryData>)Data).Write(writer, options);

        EventHubsDisasterRecoveryData IJsonModel<EventHubsDisasterRecoveryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<EventHubsDisasterRecoveryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<EventHubsDisasterRecoveryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        EventHubsDisasterRecoveryData IPersistableModel<EventHubsDisasterRecoveryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<EventHubsDisasterRecoveryData>(data, options);

        string IPersistableModel<EventHubsDisasterRecoveryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<EventHubsDisasterRecoveryData>)Data).GetFormatFromOptions(options);
    }
}

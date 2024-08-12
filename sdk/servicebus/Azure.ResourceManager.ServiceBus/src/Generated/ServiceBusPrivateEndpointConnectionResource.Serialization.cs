// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusPrivateEndpointConnectionResource : IJsonModel<ServiceBusPrivateEndpointConnectionData>
    {
        void IJsonModel<ServiceBusPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ServiceBusPrivateEndpointConnectionData>)Data).Write(writer, options);

        ServiceBusPrivateEndpointConnectionData IJsonModel<ServiceBusPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ServiceBusPrivateEndpointConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ServiceBusPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ServiceBusPrivateEndpointConnectionData IPersistableModel<ServiceBusPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ServiceBusPrivateEndpointConnectionData>(data, options);

        string IPersistableModel<ServiceBusPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ServiceBusPrivateEndpointConnectionData>)Data).GetFormatFromOptions(options);
    }
}

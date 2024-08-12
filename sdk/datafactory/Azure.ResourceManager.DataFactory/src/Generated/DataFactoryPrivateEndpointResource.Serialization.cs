// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataFactory
{
    public partial class DataFactoryPrivateEndpointResource : IJsonModel<DataFactoryPrivateEndpointData>
    {
        void IJsonModel<DataFactoryPrivateEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataFactoryPrivateEndpointData>)Data).Write(writer, options);

        DataFactoryPrivateEndpointData IJsonModel<DataFactoryPrivateEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataFactoryPrivateEndpointData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataFactoryPrivateEndpointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DataFactoryPrivateEndpointData IPersistableModel<DataFactoryPrivateEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataFactoryPrivateEndpointData>(data, options);

        string IPersistableModel<DataFactoryPrivateEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataFactoryPrivateEndpointData>)Data).GetFormatFromOptions(options);
    }
}

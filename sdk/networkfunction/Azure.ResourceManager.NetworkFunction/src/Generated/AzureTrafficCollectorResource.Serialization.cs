// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.NetworkFunction
{
    public partial class AzureTrafficCollectorResource : IJsonModel<AzureTrafficCollectorData>
    {
        void IJsonModel<AzureTrafficCollectorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        AzureTrafficCollectorData IJsonModel<AzureTrafficCollectorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AzureTrafficCollectorData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<AzureTrafficCollectorData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        AzureTrafficCollectorData IPersistableModel<AzureTrafficCollectorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AzureTrafficCollectorData>(data, options);
        }

        string IPersistableModel<AzureTrafficCollectorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

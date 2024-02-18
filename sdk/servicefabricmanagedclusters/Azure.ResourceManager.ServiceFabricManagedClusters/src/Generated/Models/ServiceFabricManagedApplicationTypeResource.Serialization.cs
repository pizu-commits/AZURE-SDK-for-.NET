// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    public partial class ServiceFabricManagedApplicationTypeResource : IJsonModel<ServiceFabricManagedApplicationTypeData>
    {
        void IJsonModel<ServiceFabricManagedApplicationTypeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ServiceFabricManagedApplicationTypeData IJsonModel<ServiceFabricManagedApplicationTypeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceFabricManagedApplicationTypeData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ServiceFabricManagedApplicationTypeData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ServiceFabricManagedApplicationTypeData IPersistableModel<ServiceFabricManagedApplicationTypeData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ServiceFabricManagedApplicationTypeData>(data, options);
        }

        string IPersistableModel<ServiceFabricManagedApplicationTypeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

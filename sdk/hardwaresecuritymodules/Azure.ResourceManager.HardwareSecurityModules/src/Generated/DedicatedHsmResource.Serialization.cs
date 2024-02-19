// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    public partial class DedicatedHsmResource : IJsonModel<DedicatedHsmData>
    {
        void IJsonModel<DedicatedHsmData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DedicatedHsmData IJsonModel<DedicatedHsmData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DedicatedHsmData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DedicatedHsmData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DedicatedHsmData IPersistableModel<DedicatedHsmData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DedicatedHsmData>(data, options);
        }

        string IPersistableModel<DedicatedHsmData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

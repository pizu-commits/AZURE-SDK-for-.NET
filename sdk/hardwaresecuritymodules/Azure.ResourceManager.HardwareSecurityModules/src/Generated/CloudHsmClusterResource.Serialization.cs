// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HardwareSecurityModules
{
    public partial class CloudHsmClusterResource : IJsonModel<CloudHsmClusterData>
    {
        void IJsonModel<CloudHsmClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        CloudHsmClusterData IJsonModel<CloudHsmClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CloudHsmClusterData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<CloudHsmClusterData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        CloudHsmClusterData IPersistableModel<CloudHsmClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<CloudHsmClusterData>(data, options);
        }

        string IPersistableModel<CloudHsmClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

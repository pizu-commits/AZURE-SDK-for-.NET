// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabSecretResource : IJsonModel<DevTestLabSecretData>
    {
        void IJsonModel<DevTestLabSecretData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DevTestLabSecretData IJsonModel<DevTestLabSecretData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevTestLabSecretData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DevTestLabSecretData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DevTestLabSecretData IPersistableModel<DevTestLabSecretData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevTestLabSecretData>(data, options);
        }

        string IPersistableModel<DevTestLabSecretData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabArmTemplateResource : IJsonModel<DevTestLabArmTemplateData>
    {
        void IJsonModel<DevTestLabArmTemplateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DevTestLabArmTemplateData IJsonModel<DevTestLabArmTemplateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevTestLabArmTemplateData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DevTestLabArmTemplateData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DevTestLabArmTemplateData IPersistableModel<DevTestLabArmTemplateData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevTestLabArmTemplateData>(data, options);
        }

        string IPersistableModel<DevTestLabArmTemplateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

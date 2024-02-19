// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabVmScheduleResource : IJsonModel<DevTestLabScheduleData>
    {
        void IJsonModel<DevTestLabScheduleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DevTestLabScheduleData IJsonModel<DevTestLabScheduleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevTestLabScheduleData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DevTestLabScheduleData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DevTestLabScheduleData IPersistableModel<DevTestLabScheduleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DevTestLabScheduleData>(data, options);
        }

        string IPersistableModel<DevTestLabScheduleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

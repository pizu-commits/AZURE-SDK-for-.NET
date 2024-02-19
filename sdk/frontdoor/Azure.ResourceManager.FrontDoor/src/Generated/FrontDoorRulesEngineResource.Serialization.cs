// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.FrontDoor
{
    public partial class FrontDoorRulesEngineResource : IJsonModel<FrontDoorRulesEngineData>
    {
        void IJsonModel<FrontDoorRulesEngineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        FrontDoorRulesEngineData IJsonModel<FrontDoorRulesEngineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FrontDoorRulesEngineData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<FrontDoorRulesEngineData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        FrontDoorRulesEngineData IPersistableModel<FrontDoorRulesEngineData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<FrontDoorRulesEngineData>(data, options);
        }

        string IPersistableModel<FrontDoorRulesEngineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Dynatrace
{
    public partial class DynatraceSingleSignOnResource : IJsonModel<DynatraceSingleSignOnData>
    {
        void IJsonModel<DynatraceSingleSignOnData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        DynatraceSingleSignOnData IJsonModel<DynatraceSingleSignOnData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DynatraceSingleSignOnData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<DynatraceSingleSignOnData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        DynatraceSingleSignOnData IPersistableModel<DynatraceSingleSignOnData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<DynatraceSingleSignOnData>(data, options);
        }

        string IPersistableModel<DynatraceSingleSignOnData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

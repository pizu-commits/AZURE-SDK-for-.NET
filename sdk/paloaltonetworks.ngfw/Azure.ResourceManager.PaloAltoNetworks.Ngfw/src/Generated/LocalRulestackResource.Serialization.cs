// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class LocalRulestackResource : IJsonModel<LocalRulestackData>
    {
        void IJsonModel<LocalRulestackData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        LocalRulestackData IJsonModel<LocalRulestackData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<LocalRulestackData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<LocalRulestackData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        LocalRulestackData IPersistableModel<LocalRulestackData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<LocalRulestackData>(data, options);
        }

        string IPersistableModel<LocalRulestackData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

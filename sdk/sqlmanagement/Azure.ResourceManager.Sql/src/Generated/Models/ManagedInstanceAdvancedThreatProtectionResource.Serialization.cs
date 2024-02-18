// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstanceAdvancedThreatProtectionResource : IJsonModel<ManagedInstanceAdvancedThreatProtectionData>
    {
        void IJsonModel<ManagedInstanceAdvancedThreatProtectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        ManagedInstanceAdvancedThreatProtectionData IJsonModel<ManagedInstanceAdvancedThreatProtectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedInstanceAdvancedThreatProtectionData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<ManagedInstanceAdvancedThreatProtectionData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        ManagedInstanceAdvancedThreatProtectionData IPersistableModel<ManagedInstanceAdvancedThreatProtectionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<ManagedInstanceAdvancedThreatProtectionData>(data, options);
        }

        string IPersistableModel<ManagedInstanceAdvancedThreatProtectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

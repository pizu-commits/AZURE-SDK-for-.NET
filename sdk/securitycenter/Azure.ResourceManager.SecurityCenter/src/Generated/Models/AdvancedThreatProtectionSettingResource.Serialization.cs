// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class AdvancedThreatProtectionSettingResource : IJsonModel<AdvancedThreatProtectionSettingData>
    {
        void IJsonModel<AdvancedThreatProtectionSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        AdvancedThreatProtectionSettingData IJsonModel<AdvancedThreatProtectionSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AdvancedThreatProtectionSettingData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<AdvancedThreatProtectionSettingData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        AdvancedThreatProtectionSettingData IPersistableModel<AdvancedThreatProtectionSettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<AdvancedThreatProtectionSettingData>(data, options);
        }

        string IPersistableModel<AdvancedThreatProtectionSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
